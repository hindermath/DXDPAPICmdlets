using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DXWFApplication1
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
            Application.Run(new Form1());
        }
        [STAThread]
        public static void DxApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WindowsFormsSettings.TrackWindowsAppMode = DefaultBoolean.True;
            WindowsFormsSettings.TrackWindowsAccentColor = DefaultBoolean.True;
            Form1 form1 = new Form1() {ShowIcon = false, IconOptions = {ShowIcon = false}};
            Application.Run(form1);
        }
    }
}
