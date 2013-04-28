using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SkypeSpammerer_xE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool isMain = true;
            System.Drawing.Size sF = new System.Drawing.Size(0, 0);
            try
            {
                if ((args.Length >= 2) && (args.Length < 4))
                {
                    int s1 = 0, s2 = 0;
                    if (int.TryParse(args[0], out s1) && (int.TryParse(args[1], out s2)))
                    {
                        sF = new System.Drawing.Size(s1, s2);
                    }
                    if (args.Length == 3) if (args[2] != "1") isMain = false;
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(sF, isMain));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured, this one to be exact: \n" + ex.Message.TrimEnd('.') + " (" + ex.GetHashCode() + ")\nMaybe you wanna recheck that\n\n1. Skype is running\n2. This application is allowed to access Skype\n3. You're not too fat to use this application.", "FAIL");
                Application.Exit();
            }
        }
    }
}
