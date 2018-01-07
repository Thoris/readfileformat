using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Reader.Core.Configuration.Parameters
{
    public class ParameterPosition : BaseParameter
    {
        #region Constants

        public const string AttributeType = "position";

        public const string KeyInitialPosition = "initial";
        public const string KeySize = "size";

        #endregion

        #region Properties

        public int InitialPosition { get; set; }
        public int Size { get; set; }

        #endregion

        #region Constructors/Destructors

        public ParameterPosition()
        {

        }

        #endregion
    }
}
