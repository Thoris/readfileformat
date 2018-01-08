using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Reader.Core.Reading.Results
{
    public class LineValue
    {
        #region Properties

        public IList<ParameterValue> Parameters { get; set; }
        public string Line { get; set; }
        public int LineNumber { get; set; }
        public string Name { get; set; }            

        #endregion

        #region Constructors/Destructors

        public LineValue()
        {
            Parameters = new List<ParameterValue>();
        }

        #endregion
    }
}
