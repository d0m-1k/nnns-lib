using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace nnn
{
    internal class nnn_sevice
    {
        public bool startProcess(string applicationPath, string arguments = "", bool createWindow = true)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = applicationPath,
                    Arguments = arguments,
                    UseShellExecute = false,
                    CreateNoWindow = !createWindow
                };

                using (Process process = Process.Start(startInfo)) { process.WaitForExit(); }
                return true;
            }
            catch (Exception ex) { return false; }
        }
    }
}
