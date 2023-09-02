using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DXWFSpreadSheet
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WindowsFormsSettings.TrackWindowsAppMode = DefaultBoolean.True;
            WindowsFormsSettings.TrackWindowsAccentColor = DefaultBoolean.True;
            Application.Run(new Form1());
        }

        public static void SpreadSheet()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WindowsFormsSettings.TrackWindowsAppMode = DefaultBoolean.True;
            WindowsFormsSettings.TrackWindowsAccentColor = DefaultBoolean.True;
            Application.Run(new Form1());
        }
    }
}
