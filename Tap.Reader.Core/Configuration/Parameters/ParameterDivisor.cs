using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Reader.Core.Configuration.Parameters
{
    public class ParameterDivisor : BaseParameter
    {
        #region Constants

        public const string AttributeType = "divisor";

        public const string KeyDivisor = "divisor";
        public const string KeyPosition = "position";
        
        #endregion

        #region Properties

        public string Divisor { get; set; }
        public int Position { get; set; }

        #endregion

        #region Constructors/Destructors

        public ParameterDivisor()
        {

        }

        #endregion
    }
}
