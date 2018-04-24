using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Util
    {
        public static void openHtml(String fileName)
        {
            string commandText = @"G:\inst3.2\Momot\laba1\Момот_лаба3_справка\"+fileName;
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
    }
}
