using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Reader.Core.Reading.Results
{
    public class FileValue
    {
        #region Properties

        public string FileName { get; set; }
        public IList<LineValue> Headers { get; set; }
        public IList<LineValue> Records { get; set; }
        public IList<LineValue> Footers { get; set; }

        #endregion

        #region Constructors/Destructors

        public FileValue()
        {
            Headers = new List<LineValue>();
            Records = new List<LineValue>();
            Footers = new List<LineValue>();
        }

        #endregion
    }
}
