using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new fMain());


                bool result;
                var mutex = new System.Threading.Mutex(true, "UniqueAppId", out result);


                if (!result)
                {
                    MessageBox.Show("Another instance is already running !", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                Application.Run(new fMain());
                GC.KeepAlive(mutex);                // mutex shouldn't be released - important line
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


                Environment.Exit(0);
            }
        }
    }
}
