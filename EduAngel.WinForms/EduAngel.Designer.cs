namespace EduAngel.WinForms
{
    partial class EduAngel
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
            gestãoToolStripMenuItem = new ToolStripMenuItem();
            tiposDeRedeMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestãoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1008, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestãoToolStripMenuItem
            // 
            gestãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tiposDeRedeMenuItem });
            gestãoToolStripMenuItem.Name = "gestãoToolStripMenuItem";
            gestãoToolStripMenuItem.Size = new Size(55, 20);
            gestãoToolStripMenuItem.Text = "&Gestão";
            // 
            // tiposDeRedeMenuItem
            // 
            tiposDeRedeMenuItem.Name = "tiposDeRedeMenuItem";
            tiposDeRedeMenuItem.Size = new Size(180, 22);
            tiposDeRedeMenuItem.Text = "&Tipo de rede";
            tiposDeRedeMenuItem.Click += tiposDeRedeMenuItem_Click;
            // 
            // EduAngel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(menuStrip1);
            ImeMode = ImeMode.On;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "EduAngel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestãoToolStripMenuItem;
        private ToolStripMenuItem tiposDeRedeMenuItem;
    }
}
