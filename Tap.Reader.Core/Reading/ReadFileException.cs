using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Reader.Core.Reading
{
    public class ReadFileException : Exception
    {
        #region Properties

        public string FileName { get; internal set; }

        #endregion

        #region Constructors/Destructors

        public ReadFileException(string fileName, string message)
            : base (message)
        {
            FileName = fileName;

        }

        #endregion
    }
}
