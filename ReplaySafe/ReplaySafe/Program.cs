using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReplaySafe
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Configuration.LoadConfiguration())
            {
                Configuration c = new Configuration();
                c.Show();
            }
            else
            {
                StartSafer();
            }

            Application.Run();
        }

        public static void StartSafer()
        {
            new Saver(Configuration.OsuPath, Configuration.BackupPath);
        }
    }
}
