namespace WinFormsApp1
{
    partial class Form2
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
            spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            spreadsheetControl1.Location = new Point(178, 131);
            spreadsheetControl1.Name = "spreadsheetControl1";
            spreadsheetControl1.Size = new Size(600, 300);
            spreadsheetControl1.TabIndex = 0;
            spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(spreadsheetControl1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
    }
}