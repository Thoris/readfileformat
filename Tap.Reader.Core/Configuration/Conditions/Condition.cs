using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Reader.Core.Configuration.Conditions
{
    public class Condition
    {
        #region Constants

        public const string ListName = "conditions";
        public const string EntryName = "condition";
        public const string ListValues = "values";
        public const string EntryValue = "value";

        public const string KeySize = "size";
        public const string KeyStart = "start";
        
        #endregion

        #region Properties

        public int Start { get; set; }
        public int Size { get; set; }
        public IList<string> Values { get; set; }

        #endregion

        #region Constructors/Destructors

        public Condition()
        {
            Values = new List<string>();
        }

        #endregion
    }
}
