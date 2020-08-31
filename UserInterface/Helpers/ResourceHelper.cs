using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.UserInterface.Helpers
{
    public class ResourceHelper
    {
        public const string closeButtonName = "close.png";

        public static string ResourceFilePath = Path.Combine(Path.GetFullPath(@"..\..\"), "Resources");

    }
}
