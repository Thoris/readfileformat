using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Reader.Core.Configuration
{
    public class FileConfiguration
    {
        #region Constants

        public const string EntryName = "configuration";

        #endregion

        #region Properties

        public IList<LineConfiguration> Lines { get; set; }

        #endregion

        #region Constructors/Destructors

        public FileConfiguration()
        {
            Lines = new List<LineConfiguration>();
        }

        #endregion
    }
}
