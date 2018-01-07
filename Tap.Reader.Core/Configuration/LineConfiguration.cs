using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Reader.Core.Configuration
{
    public class LineConfiguration
    {

        #region Constants

        public const string ListName = "lines";
        public const string EntryName = "line";
        public const string TypeHeader = "isHeader";
        public const string TypeFooter = "isFooter";
        public const string TypeOffSet = "offset";


        #endregion

        #region Properties

        public IList<Parameters.BaseParameter> Parameters { get; set; }
        public bool IsHeader { get; set; }
        public bool IsFooter { get; set; }
        public int LineOffset { get; set; }

        #endregion

        #region Constructors/Destructors

        public LineConfiguration()
        {
            Parameters = new List<Parameters.BaseParameter>();
        }

        #endregion
    }
}
