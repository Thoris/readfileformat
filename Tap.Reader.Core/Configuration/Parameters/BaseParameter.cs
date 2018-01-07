using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Reader.Core.Configuration.Parameters
{
    public class BaseParameter
    {
        #region Constants

        public const string ListName = "parameters";
        public const string EntryName = "parameter";


        public const string KeyName = "name";
        public const string KeyValue = "value";
        public const string KeyType = "type";
        public const string KeyOrder = "order";


        #endregion

        #region Properties

        public string Name { get; set; }
        public object Value { get; set; }
        public string Type { get; set; }
        public int Order { get; set; }

        #endregion

        #region Constructors/Destructors

        public BaseParameter()
        {

        }

        #endregion
    }
}
