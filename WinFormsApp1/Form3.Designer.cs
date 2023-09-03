namespace WinFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            menuStrip1 = new MenuStrip();
            dateiToolStripMenuItem = new ToolStripMenuItem();
            neuToolStripMenuItem = new ToolStripMenuItem();
            öffnenToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            speichernToolStripMenuItem = new ToolStripMenuItem();
            speichernunterToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            druckenToolStripMenuItem = new ToolStripMenuItem();
            seitenansichtToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            beendenToolStripMenuItem = new ToolStripMenuItem();
            bearbeitenToolStripMenuItem = new ToolStripMenuItem();
            rückgängigToolStripMenuItem = new ToolStripMenuItem();
            wiederholenToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            ausschneidenToolStripMenuItem = new ToolStripMenuItem();
            kopierenToolStripMenuItem = new ToolStripMenuItem();
            einfügenToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            allesauswählenToolStripMenuItem = new ToolStripMenuItem();
            extrasToolStripMenuItem = new ToolStripMenuItem();
            anpassenToolStripMenuItem = new ToolStripMenuItem();
            optionenToolStripMenuItem = new ToolStripMenuItem();
            hilfeToolStripMenuItem = new ToolStripMenuItem();
            inhaltToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            suchenToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            infoToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            spreadsheetControl1.Location = new Point(53, 60);
            spreadsheetControl1.Name = "spreadsheetControl1";
            spreadsheetControl1.Size = new Size(600, 300);
            spreadsheetControl1.TabIndex = 1;
            spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dateiToolStripMenuItem, bearbeitenToolStripMenuItem, extrasToolStripMenuItem, hilfeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            dateiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { neuToolStripMenuItem, öffnenToolStripMenuItem, toolStripSeparator, speichernToolStripMenuItem, speichernunterToolStripMenuItem, toolStripSeparator1, druckenToolStripMenuItem, seitenansichtToolStripMenuItem, toolStripSeparator2, beendenToolStripMenuItem });
            dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            dateiToolStripMenuItem.Size = new Size(69, 29);
            dateiToolStripMenuItem.Text = "&Datei";
            // 
            // neuToolStripMenuItem
            // 
            neuToolStripMenuItem.Image = (Image)resources.GetObject("neuToolStripMenuItem.Image");
            neuToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            neuToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            neuToolStripMenuItem.Size = new Size(257, 34);
            neuToolStripMenuItem.Text = "&Neu";
            // 
            // öffnenToolStripMenuItem
            // 
            öffnenToolStripMenuItem.Image = (Image)resources.GetObject("öffnenToolStripMenuItem.Image");
            öffnenToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            öffnenToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            öffnenToolStripMenuItem.Size = new Size(257, 34);
            öffnenToolStripMenuItem.Text = "Ö&ffnen";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(254, 6);
            // 
            // speichernToolStripMenuItem
            // 
            speichernToolStripMenuItem.Image = (Image)resources.GetObject("speichernToolStripMenuItem.Image");
            speichernToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            speichernToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            speichernToolStripMenuItem.Size = new Size(257, 34);
            speichernToolStripMenuItem.Text = "&Speichern";
            // 
            // speichernunterToolStripMenuItem
            // 
            speichernunterToolStripMenuItem.Name = "speichernunterToolStripMenuItem";
            speichernunterToolStripMenuItem.Size = new Size(257, 34);
            speichernunterToolStripMenuItem.Text = "Speichern &unter";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(254, 6);
            // 
            // druckenToolStripMenuItem
            // 
            druckenToolStripMenuItem.Image = (Image)resources.GetObject("druckenToolStripMenuItem.Image");
            druckenToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            druckenToolStripMenuItem.Name = "druckenToolStripMenuItem";
            druckenToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            druckenToolStripMenuItem.Size = new Size(257, 34);
            druckenToolStripMenuItem.Text = "&Drucken";
            // 
            // seitenansichtToolStripMenuItem
            // 
            seitenansichtToolStripMenuItem.Image = (Image)resources.GetObject("seitenansichtToolStripMenuItem.Image");
            seitenansichtToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            seitenansichtToolStripMenuItem.Name = "seitenansichtToolStripMenuItem";
            seitenansichtToolStripMenuItem.Size = new Size(257, 34);
            seitenansichtToolStripMenuItem.Text = "&Seitenansicht";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(254, 6);
            // 
            // beendenToolStripMenuItem
            // 
            beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            beendenToolStripMenuItem.Size = new Size(257, 34);
            beendenToolStripMenuItem.Text = "&Beenden";
            // 
            // bearbeitenToolStripMenuItem
            // 
            bearbeitenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rückgängigToolStripMenuItem, wiederholenToolStripMenuItem, toolStripSeparator3, ausschneidenToolStripMenuItem, kopierenToolStripMenuItem, einfügenToolStripMenuItem, toolStripSeparator4, allesauswählenToolStripMenuItem });
            bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            bearbeitenToolStripMenuItem.Size = new Size(111, 29);
            bearbeitenToolStripMenuItem.Text = "&Bearbeiten";
            // 
            // rückgängigToolStripMenuItem
            // 
            rückgängigToolStripMenuItem.Name = "rückgängigToolStripMenuItem";
            rückgängigToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            rückgängigToolStripMenuItem.Size = new Size(290, 34);
            rückgängigToolStripMenuItem.Text = "&Rückgängig";
            // 
            // wiederholenToolStripMenuItem
            // 
            wiederholenToolStripMenuItem.Name = "wiederholenToolStripMenuItem";
            wiederholenToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            wiederholenToolStripMenuItem.Size = new Size(290, 34);
            wiederholenToolStripMenuItem.Text = "&Wiederholen";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(287, 6);
            // 
            // ausschneidenToolStripMenuItem
            // 
            ausschneidenToolStripMenuItem.Image = (Image)resources.GetObject("ausschneidenToolStripMenuItem.Image");
            ausschneidenToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            ausschneidenToolStripMenuItem.Name = "ausschneidenToolStripMenuItem";
            ausschneidenToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            ausschneidenToolStripMenuItem.Size = new Size(290, 34);
            ausschneidenToolStripMenuItem.Text = "Aussc&hneiden";
            // 
            // kopierenToolStripMenuItem
            // 
            kopierenToolStripMenuItem.Image = (Image)resources.GetObject("kopierenToolStripMenuItem.Image");
            kopierenToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            kopierenToolStripMenuItem.Name = "kopierenToolStripMenuItem";
            kopierenToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            kopierenToolStripMenuItem.Size = new Size(290, 34);
            kopierenToolStripMenuItem.Text = "&Kopieren";
            // 
            // einfügenToolStripMenuItem
            // 
            einfügenToolStripMenuItem.Image = (Image)resources.GetObject("einfügenToolStripMenuItem.Image");
            einfügenToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            einfügenToolStripMenuItem.Name = "einfügenToolStripMenuItem";
            einfügenToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            einfügenToolStripMenuItem.Size = new Size(290, 34);
            einfügenToolStripMenuItem.Text = "&Einfügen";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(287, 6);
            // 
            // allesauswählenToolStripMenuItem
            // 
            allesauswählenToolStripMenuItem.Name = "allesauswählenToolStripMenuItem";
            allesauswählenToolStripMenuItem.Size = new Size(290, 34);
            allesauswählenToolStripMenuItem.Text = "&Alles auswählen";
            // 
            // extrasToolStripMenuItem
            // 
            extrasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { anpassenToolStripMenuItem, optionenToolStripMenuItem });
            extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            extrasToolStripMenuItem.Size = new Size(74, 29);
            extrasToolStripMenuItem.Text = "E&xtras";
            // 
            // anpassenToolStripMenuItem
            // 
            anpassenToolStripMenuItem.Name = "anpassenToolStripMenuItem";
            anpassenToolStripMenuItem.Size = new Size(191, 34);
            anpassenToolStripMenuItem.Text = "&Anpassen";
            // 
            // optionenToolStripMenuItem
            // 
            optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            optionenToolStripMenuItem.Size = new Size(191, 34);
            optionenToolStripMenuItem.Text = "&Optionen";
            // 
            // hilfeToolStripMenuItem
            // 
            hilfeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inhaltToolStripMenuItem, indexToolStripMenuItem, suchenToolStripMenuItem, toolStripSeparator5, infoToolStripMenuItem });
            hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            hilfeToolStripMenuItem.Size = new Size(64, 29);
            hilfeToolStripMenuItem.Text = "&Hilfe";
            // 
            // inhaltToolStripMenuItem
            // 
            inhaltToolStripMenuItem.Name = "inhaltToolStripMenuItem";
            inhaltToolStripMenuItem.Size = new Size(171, 34);
            inhaltToolStripMenuItem.Text = "&Inhalt";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size(171, 34);
            indexToolStripMenuItem.Text = "&Index";
            // 
            // suchenToolStripMenuItem
            // 
            suchenToolStripMenuItem.Name = "suchenToolStripMenuItem";
            suchenToolStripMenuItem.Size = new Size(171, 34);
            suchenToolStripMenuItem.Text = "&Suchen";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(168, 6);
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(171, 34);
            infoToolStripMenuItem.Text = "Inf&o...";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(spreadsheetControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            Text = "Form3";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem neuToolStripMenuItem;
        private ToolStripMenuItem öffnenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem speichernToolStripMenuItem;
        private ToolStripMenuItem speichernunterToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem druckenToolStripMenuItem;
        private ToolStripMenuItem seitenansichtToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem beendenToolStripMenuItem;
        private ToolStripMenuItem bearbeitenToolStripMenuItem;
        private ToolStripMenuItem rückgängigToolStripMenuItem;
        private ToolStripMenuItem wiederholenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem ausschneidenToolStripMenuItem;
        private ToolStripMenuItem kopierenToolStripMenuItem;
        private ToolStripMenuItem einfügenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem allesauswählenToolStripMenuItem;
        private ToolStripMenuItem extrasToolStripMenuItem;
        private ToolStripMenuItem anpassenToolStripMenuItem;
        private ToolStripMenuItem optionenToolStripMenuItem;
        private ToolStripMenuItem hilfeToolStripMenuItem;
        private ToolStripMenuItem inhaltToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem suchenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem infoToolStripMenuItem;
    }
}