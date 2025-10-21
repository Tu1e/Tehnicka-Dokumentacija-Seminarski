using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projekat
{
    internal static class Program
    {
        public static Color GlobalThemeColor = Color.Empty;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmServerMain());
        }
    }
}
