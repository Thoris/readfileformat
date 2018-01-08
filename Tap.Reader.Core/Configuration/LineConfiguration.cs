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
        public const string KeyName = "name";

        #endregion

        #region Properties

        public IList<Conditions.Condition> Conditions { get; set; }
        public IList<Parameters.BaseParameter> Parameters { get; set; }
        public bool IsHeader { get; set; }
        public bool IsFooter { get; set; }
        public int LineOffset { get; set; }
        public string Name { get; set; }

        #endregion

        #region Constructors/Destructors

        public LineConfiguration()
        {
            Parameters = new List<Parameters.BaseParameter>();
            Conditions = new List<Conditions.Condition>();
        }

        #endregion
    }
}
