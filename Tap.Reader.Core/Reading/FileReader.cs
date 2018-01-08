using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tap.Reader.Core.Reading.Results;

namespace Tap.Reader.Core.Reading
{
    public class FileReader
    {
        #region Constructors/Destructors

        public FileReader()
        {

        }

        #endregion

        #region Methods

        public Results.FileValue Execute(string fileName, Configuration.FileConfiguration config)
        {
            if (!System.IO.File.Exists(fileName))
                throw new ReadFileException(fileName, "There is no file: " + fileName);

            StreamReader reader = new StreamReader(fileName);

            string content = reader.ReadToEnd();

            reader.Close();

            string[] lines = content.Split(new char[] { '\n' });

            Results.FileValue res = new Results.FileValue();

            res.FileName = fileName;

            res.Headers = ReadHeaders(lines, config);
            res.Footers = ReadFooter(lines, config);
            res.Records = ReadRecords(lines, config);

            return res;

        }

        private IList<LineValue> ReadHeaders(string [] lines, Configuration.FileConfiguration config)
        {
            IList<LineValue> list = new List<LineValue>();

            #region Reading Configuration

            IList<Configuration.LineConfiguration> linesConfig = new List<Configuration.LineConfiguration>();

            for (int c = 0; c < config.Lines.Count; c++ )
            {
                if (config.Lines[c].IsHeader)
                {
                    linesConfig.Add(config.Lines[c]);
                }
            }
            
            #endregion
            
            
            for (int i = 0; i < linesConfig.Count; i++)
            {
                string headerLine = lines[linesConfig[i].LineOffset];

                list.Add(ReadLine(linesConfig[i].LineOffset + 1, linesConfig[i].Name, headerLine, linesConfig[i].Parameters));
            }


            return list;
        }

        private IList<LineValue> ReadFooter(string[] lines, Configuration.FileConfiguration config)
        {
            IList<LineValue> list = new List<LineValue>();

            #region Reading Configuration

            IList<Configuration.LineConfiguration> linesConfig = new List<Configuration.LineConfiguration>();

            for (int c = 0; c < config.Lines.Count; c++)
            {
                if (config.Lines[c].IsFooter)
                {
                    linesConfig.Add(config.Lines[c]);
                }
            }

            #endregion

            for (int i = 0; i < linesConfig.Count; i++)
            {
                string headerLine = lines[lines.Length - 1 - linesConfig[i].LineOffset];

                list.Add(ReadLine(lines.Length - linesConfig[i].LineOffset, linesConfig[i].Name, headerLine, linesConfig[i].Parameters));
            }


            return list;
        }
        private IList<LineValue> ReadRecords(string[] lines, Configuration.FileConfiguration config)
        {
            IList<LineValue> list = new List<LineValue>();

            int offSetHeader = 0;
            int offSetFooter = 0;

            #region Reading Configuration

            for (int c = 0; c < config.Lines.Count; c++)
            {
                if (config.Lines[c].IsFooter)
                {
                    int offset = config.Lines[c].LineOffset + 1;
                    if (offSetFooter < offset)
                        offSetFooter = offset;
                }
            }
 
            for (int c = 0; c < config.Lines.Count; c++)
            {
                if (config.Lines[c].IsHeader)
                {
                    int offset = config.Lines[c].LineOffset + 1;
                    if (offSetHeader < offset)
                        offSetHeader = offset;
                }
            }


            IList<Configuration.LineConfiguration> linesConfig = new List<Configuration.LineConfiguration>();

            for (int c = 0; c < config.Lines.Count; c++)
            {
                if (!config.Lines[c].IsFooter && !config.Lines[c].IsHeader)
                {
                    linesConfig.Add(config.Lines[c]);
                }
            }

            #endregion

            for (int c = offSetHeader; c < lines.Length - offSetFooter - 1; c++)
            {
                int indexConfig = GetIndexConfigCondition(lines[c], linesConfig);

                if (indexConfig == -1)
                    continue;

                list.Add(ReadLine(c + 1, linesConfig[indexConfig].Name, lines[c], linesConfig[indexConfig].Parameters));
            }


            return list;
        }


        private bool IsValidCondition (string line, Configuration.LineConfiguration lineConfig)
        {            
            for (int c=0; c < lineConfig.Conditions.Count; c++)
            {
                if (!IsValidCondition(line, lineConfig.Conditions[c]))
                    return false;
            }

            return true;
        }
        private bool IsValidCondition(string line, Configuration.Conditions.Condition condition)
        {
            string value = line.Substring(condition.Start - 1, condition.Size);

            for (int c=0; c < condition.Values.Count; c++)
            {
                if (string.Compare(value, condition.Values[c], true) == 0)
                    return true;
            }

            return false;
        }

        private int GetIndexConfigCondition(string line, IList<Configuration.LineConfiguration> linesConfig)
        {
            for (int c=0; c < linesConfig.Count; c++)
            {
                if (IsValidCondition(line, linesConfig[c]))
                    return c;
            }

            return -1;
        }

        private LineValue ReadLine(int lineNumber, string name, string line, IList<Configuration.Parameters.BaseParameter> parameters)
        {
            LineValue res = new LineValue();
            res.LineNumber = lineNumber;
            res.Line = line;
            res.Name = name;

            for (int c = 0; c < parameters.Count; c++ )
            {
                res.Parameters.Add(ReadParameter(line, parameters[c]));
            }

            return res;
        }
        private ParameterValue ReadParameter(string line,  Configuration.Parameters.BaseParameter parameter)
        {
            ParameterValue res = new ParameterValue();
            res.Type = parameter.Type;
            res.Name = parameter.Name;

            #region By Divisor
            if (parameter.GetType() == typeof(Core.Configuration.Parameters.ParameterDivisor))
            {
                Core.Configuration.Parameters.ParameterDivisor config = (Core.Configuration.Parameters.ParameterDivisor)parameter;
                res.ReadType = Core.Configuration.Parameters.ParameterPosition.AttributeType;

                res.Position = config.Position;
                res.Divisor = config.Divisor;
                res.Size = 0;

                string[] values = line.Split(new string [] {res.Divisor}, StringSplitOptions.None);

                if (res.Position <= values.Length)
                {
                    res.ReadValue = values[res.Position - 1];
                }

                return res;
            }
            #endregion

            #region By Position
            else if (parameter.GetType() == typeof(Core.Configuration.Parameters.ParameterPosition))
            {             
                Core.Configuration.Parameters.ParameterPosition config = (Core.Configuration.Parameters.ParameterPosition)parameter;
                res.ReadType = Core.Configuration.Parameters.ParameterPosition.AttributeType;

                res.Position = config.InitialPosition;
                res.Divisor = null;
                res.Size = config.Size;
                
                res.ReadValue = line.Substring(config.InitialPosition - 1, config.Size);



                return res;
            }
            #endregion

            return null;
        }

        #endregion
    }
}
