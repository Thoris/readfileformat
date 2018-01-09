using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tap.Reader.Core.Configuration
{
    public class ConfigurationReader
    {
        #region Constructors/Destructors

        public ConfigurationReader()
        {

        }

        #endregion

        #region Methods

        public FileConfiguration Load(string configurationFile)
        {
            if (!System.IO.File.Exists(configurationFile))
                throw new ConfigFileException(configurationFile, "File not found");

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(configurationFile);

            XmlNodeList configuration = xmlDoc.GetElementsByTagName(FileConfiguration.EntryName);

            return ReadConfiguration(configurationFile, configuration);

        }
        private FileConfiguration ReadConfiguration(string configurationFile, XmlNodeList configuration)
        {
            FileConfiguration config = new FileConfiguration();

            if (configuration == null || configuration.Count == 0)
                throw new ConfigFileException(configurationFile, "There is not " + FileConfiguration.EntryName + " entry.");
             
            XmlElement xmlConfig = (XmlElement)configuration[0];   
            
            XmlNodeList lineList = xmlConfig.GetElementsByTagName(LineConfiguration.ListName);
            if (lineList != null && lineList.Count > 0)
            {
                XmlNodeList xmlLine = ((XmlElement)lineList[0]).GetElementsByTagName(LineConfiguration.EntryName);

                for (int c = 0; c < xmlLine.Count; c++)
                {
                    config.Lines.Add(ReadLineConfiguration(configurationFile, xmlLine[c]));
                }
            }

            return config;
        }
        private LineConfiguration ReadLineConfiguration(string configurationFile, XmlNode node)
        {
            LineConfiguration line = new LineConfiguration();

            XmlElement xmlConfig = (XmlElement)node;


            for (int x = 0; x < xmlConfig.Attributes.Count; x++)
            {
                string value = xmlConfig.Attributes[x].Value;
                if (string.Compare(xmlConfig.Attributes[x].Name, LineConfiguration.TypeHeader, true) == 0)
                {
                    line.IsHeader = bool.Parse(value);
                }
                else if (string.Compare(xmlConfig.Attributes[x].Name, LineConfiguration.TypeFooter, true) == 0)
                {
                    line.IsFooter = bool.Parse(value);
                }
                else if (string.Compare(xmlConfig.Attributes[x].Name, LineConfiguration.TypeOffSet, true) == 0)
                {
                    line.LineOffset = int.Parse(value);
                }
                else if (string.Compare(xmlConfig.Attributes[x].Name, LineConfiguration.KeyName, true) == 0)
                {
                    line.Name = value;
                }
            }


            XmlNodeList conditionsXml = xmlConfig.GetElementsByTagName(Conditions.Condition.ListName);
            if (conditionsXml != null && conditionsXml.Count > 0)
            {
                for (int c = 0; c < conditionsXml.Count; c++)
                {
                    XmlElement parametersXml = (XmlElement)conditionsXml[c];

                    XmlNodeList xmlParameter = parametersXml.GetElementsByTagName(Conditions.Condition.EntryName);

                    if (xmlParameter != null && xmlParameter.Count > 0)
                    {
                        for (int i = 0; i < xmlParameter.Count; i++)
                        {
                            line.Conditions.Add (ReadConditionConfiguration(configurationFile, xmlParameter[i]));                            
                        }
                    }
                }
            }





            XmlNodeList linesXml = xmlConfig.GetElementsByTagName(Parameters.BaseParameter.ListName);
            if (linesXml != null && linesXml.Count > 0)
            {
                for (int c = 0; c < linesXml.Count; c++)
                {
                    XmlElement parametersXml = (XmlElement)linesXml[c];

                    XmlNodeList xmlParameter = parametersXml.GetElementsByTagName(Parameters.BaseParameter.EntryName);

                    if (xmlParameter != null && xmlParameter.Count > 0)
                    {
                        for (int i = 0 ; i  < xmlParameter.Count; i++)
                        {
                            line.Parameters.Add(ReadParameterConfiguration(configurationFile, xmlParameter[i]));
                        }
                    }
                }
            }

            return line;
        }
        private Parameters.BaseParameter ReadParameterConfiguration(string configurationFile, XmlNode node)
        {
            Parameters.BaseParameter parameter = null;

            XmlElement xmlConfig = (XmlElement)node;

            for (int c = 0; c < node.Attributes.Count; c++ )
            {
                if (string.Compare ( node.Attributes[c].Name, "type", true) == 0)
                {
                    string value = node.Attributes[c].Value;

                    if (string.Compare(value, Parameters.ParameterDivisor.AttributeType, true) == 0)
                    {
                        return ReadParameterDivisorConfiguration(configurationFile, node);
                    }
                    else if (string.Compare(value, Parameters.ParameterPosition.AttributeType, true) == 0)
                    {
                        return ReadParameterPositionConfiguration(configurationFile, node);
                    }
                     
                }
            }

            return parameter;
        }
        private void ReadBaseParameters(string configurationFile, XmlNode node, Parameters.BaseParameter parameter)
        {
            XmlElement element = (XmlElement)node;

            XmlNodeList xmlName = element.GetElementsByTagName(Parameters.BaseParameter.KeyName);
            if (xmlName != null && xmlName.Count > 0)
            {
                parameter.Name = xmlName[0].InnerText;
            }
            XmlNodeList xmlValue = element.GetElementsByTagName(Parameters.BaseParameter.KeyValue);
            if (xmlValue != null && xmlValue.Count > 0)
            {
                parameter.Value = xmlValue[0].InnerText;
            }
            XmlNodeList xmlType = element.GetElementsByTagName(Parameters.BaseParameter.KeyType);
            if (xmlType != null && xmlType.Count > 0)
            {
                parameter.Type = xmlType[0].InnerText;
            }
            XmlNodeList xmlOrder = element.GetElementsByTagName(Parameters.BaseParameter.KeyOrder);
            if (xmlOrder != null && xmlOrder.Count > 0)
            {
                parameter.Order = int.Parse (xmlOrder[0].InnerText);
            }



            XmlNodeList xmlExpected = element.GetElementsByTagName(Parameters.ExpectedValue.KeyExpectedValue);
            if (xmlExpected != null && xmlExpected.Count > 0)
            {
                parameter.ExpectedValue = ReadExpectedValue(configurationFile, xmlExpected[0]);
            }
        }
        private Parameters.ParameterDivisor ReadParameterDivisorConfiguration(string configurationFile, XmlNode node)
        {
            Parameters.ParameterDivisor parameter = new Parameters.ParameterDivisor();
            XmlElement element = (XmlElement)node;


            ReadBaseParameters(configurationFile, node, parameter);
           
            XmlNodeList xmlDivisor = element.GetElementsByTagName(Parameters.ParameterDivisor.KeyDivisor);
            if (xmlDivisor != null && xmlDivisor.Count > 0)
            {
                parameter.Divisor = xmlDivisor[0].InnerText;
            }
            XmlNodeList xmlPosition = element.GetElementsByTagName(Parameters.ParameterDivisor.KeyPosition);
            if (xmlPosition != null && xmlPosition.Count > 0)
            {
                parameter.Position = int.Parse ( xmlPosition[0].InnerText );
            }



            return parameter;
        }
        private Parameters.ParameterPosition ReadParameterPositionConfiguration(string configurationFile, XmlNode node)
        {
            Parameters.ParameterPosition parameter = new Parameters.ParameterPosition();
            XmlElement element = (XmlElement)node;

            ReadBaseParameters(configurationFile, node, parameter);

            XmlNodeList xmlPosition = element.GetElementsByTagName(Parameters.ParameterPosition.KeyInitialPosition);
            if (xmlPosition != null && xmlPosition.Count > 0)
            {
                parameter.InitialPosition = int.Parse (xmlPosition[0].InnerText);
            }
            XmlNodeList xmlSize = element.GetElementsByTagName(Parameters.ParameterPosition.KeySize);
            if (xmlSize != null && xmlSize.Count > 0)
            {
                parameter.Size = int.Parse(xmlSize[0].InnerText);
            }


            return parameter;
        }
        private Conditions.Condition ReadConditionConfiguration(string configurationFile, XmlNode node)
        {
            Conditions.Condition condition = new Conditions.Condition();

            XmlElement element = (XmlElement)node;

            XmlNodeList xmlSize = element.GetElementsByTagName(Conditions.Condition.KeySize);
            if (xmlSize != null && xmlSize.Count > 0)
            {
                condition.Size = int.Parse (xmlSize[0].InnerText);
            }
            XmlNodeList xmlStart = element.GetElementsByTagName(Conditions.Condition.KeyStart);
            if (xmlStart != null && xmlStart.Count > 0)
            {
                condition.Start = int.Parse (xmlStart[0].InnerText);
            }
            XmlNodeList xmlValues = element.GetElementsByTagName(Conditions.Condition.ListValues);
            if (xmlValues != null && xmlValues.Count > 0)
            {
                XmlElement elementValues = (XmlElement)xmlValues[0];

                XmlNodeList xmlData = elementValues.GetElementsByTagName(Conditions.Condition.EntryValue);

                if (xmlData != null && xmlData.Count > 0)
                {
                    for (int c=0; c < xmlData.Count; c++)
                    {
                        condition.Values.Add(xmlData[c].InnerText);
                    }
                }
            }

            return condition;
        }
        private Parameters.ExpectedValue ReadExpectedValue(string configurationFile, XmlNode node)
        {
            Parameters.ExpectedValue res = new Parameters.ExpectedValue();

            XmlElement element = (XmlElement)node;

            XmlNodeList xmlCharacter = element.GetElementsByTagName(Parameters.ExpectedValue.KeyCharacter);
            if (xmlCharacter != null && xmlCharacter.Count > 0)
            {
                res.Character = xmlCharacter[0].InnerText;
            }
            XmlNodeList xmlValues = element.GetElementsByTagName(Parameters.ExpectedValue.KeyListConstants);
            if (xmlValues != null && xmlValues.Count > 0)
            {
                XmlElement elementValues = (XmlElement)xmlValues[0];

                XmlNodeList xmlData = elementValues.GetElementsByTagName(Parameters.ExpectedValue.KeyEntryConstant);

                if (xmlData != null && xmlData.Count > 0)
                {
                    for (int c = 0; c < xmlData.Count; c++)
                    {
                        res.Constants.Add(xmlData[c].InnerText);
                    }
                }
            }

            return res;
        }


        #endregion
    }
}
