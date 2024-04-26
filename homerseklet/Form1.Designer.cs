namespace homerseklet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            adatokRögzítéseToolStripMenuItem = new ToolStripMenuItem();
            statisztikaToolStripMenuItem = new ToolStripMenuItem();
            kilépésToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adatokRögzítéseToolStripMenuItem, statisztikaToolStripMenuItem, kilépésToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(288, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // adatokRögzítéseToolStripMenuItem
            // 
            adatokRögzítéseToolStripMenuItem.Name = "adatokRögzítéseToolStripMenuItem";
            adatokRögzítéseToolStripMenuItem.Size = new Size(107, 20);
            adatokRögzítéseToolStripMenuItem.Text = "Adatok rögzítése";
            adatokRögzítéseToolStripMenuItem.Click += adatokRögzítéseToolStripMenuItem_Click;
            // 
            // statisztikaToolStripMenuItem
            // 
            statisztikaToolStripMenuItem.Name = "statisztikaToolStripMenuItem";
            statisztikaToolStripMenuItem.Size = new Size(71, 20);
            statisztikaToolStripMenuItem.Text = "Statisztika";
            statisztikaToolStripMenuItem.Click += statisztikaToolStripMenuItem_Click;
            // 
            // kilépésToolStripMenuItem
            // 
            kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            kilépésToolStripMenuItem.Size = new Size(56, 20);
            kilépésToolStripMenuItem.Text = "Kilépés";
            kilépésToolStripMenuItem.Click += kilépésToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 44);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Főmenü";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adatokRögzítéseToolStripMenuItem;
        private ToolStripMenuItem statisztikaToolStripMenuItem;
        private ToolStripMenuItem kilépésToolStripMenuItem;
    }
}
