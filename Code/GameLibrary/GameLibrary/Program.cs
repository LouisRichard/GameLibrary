using System;
using System.Windows.Forms;

namespace GameLibrary
{
    /// <summary>
    /// Main entry point of the program.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Second main entry point of the program.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginRegister());
        }
    }
}
