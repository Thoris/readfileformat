using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Reader.Core.Reading.Results
{
    public class ParameterValue
    {
        #region Properties

        public string ReadValue { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        public int Position { get; set; }
        public string Divisor { get; set; }
        public string ReadType { get; set; }
        public int Size { get; set; }


        public object Value { get; set; }
        public int ValueLenght
        {
            get
            {
                if (ReadValue == null)
                    return 0;
                else
                    return ReadValue.Length;
            }
        }
        #endregion

        #region Constructors/Destructors

        public ParameterValue()
        {

        }

        #endregion
    }
}
