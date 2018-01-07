using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Reader.Core.Configuration
{
    public class ConfigFileException : Exception
    {
        #region Properties

        public string FileName { get; internal set; }
       

        #endregion

        #region Constructors/Destructors

        public ConfigFileException(string fileName, string message)
            : base (message)
        {
            FileName = fileName;
        }


        #endregion
    }
}
