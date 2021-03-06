using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
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
        public static bool IsCorrectUri(string uri) 
        {
            string pattern = @"https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)";

            return Regex.IsMatch(uri, pattern, RegexOptions.IgnoreCase);
        }
    }
}
