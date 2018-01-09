using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Reader.Core.Configuration.Parameters
{
    public class ExpectedValue
    {
        #region Constants

        public const string KeyExpectedValue = "expected";
        public const string KeyCharacter = "fullcharacter";
        public const string KeyListConstants = "constants";
        public const string KeyEntryConstant = "constant";

        #endregion

        #region Properties

        public string Character { get; set; }
        public IList<string> Constants { get; set; }

        #endregion

        #region Constructors/Destructors

        public ExpectedValue()
        {
            Constants = new List<string>();
        }

        #endregion

        #region Methods

        public bool IsReadToCheck()
        {
            if (!string.IsNullOrEmpty(Character))
                return true;

            if (Constants.Count > 0)
                return true;

            return false;
        }

        #endregion

    }
}
