using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Software_Accounting.Source
{
    public static class UriOpener
    {
        public static void OpenUri(string uri) 
        {
            try 
            {
                ProcessStartInfo psInfo = new ProcessStartInfo
                {
                    FileName = uri,
                    UseShellExecute = true
                };
                Process.Start(psInfo);
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message);
                return;
            }

        }
    }
}
