namespace EduAngel.WinForms.Redes
{
    partial class TiposRedes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiposRedes));
            toolStrip1 = new ToolStrip();
            novoBotao = new ToolStripButton();
            salvarBotao = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            containePainel = new Panel();
            nome = new TextBox();
            tipoDeRede = new Label();
            id = new TextBox();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            containePainel.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { novoBotao, salvarBotao, toolStripSeparator1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(438, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // novoBotao
            // 
            novoBotao.DisplayStyle = ToolStripItemDisplayStyle.Image;
            novoBotao.Image = (Image)resources.GetObject("novoBotao.Image");
            novoBotao.ImageTransparentColor = Color.Magenta;
            novoBotao.Name = "novoBotao";
            novoBotao.Size = new Size(23, 22);
            novoBotao.Text = "toolStripButton1";
            novoBotao.Click += novoBotao_Click;
            // 
            // salvarBotao
            // 
            salvarBotao.DisplayStyle = ToolStripItemDisplayStyle.Image;
            salvarBotao.Image = (Image)resources.GetObject("salvarBotao.Image");
            salvarBotao.ImageTransparentColor = Color.Magenta;
            salvarBotao.Name = "salvarBotao";
            salvarBotao.Size = new Size(23, 22);
            salvarBotao.Text = "toolStripButton2";
            salvarBotao.Click += salvarBotao_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // containePainel
            // 
            containePainel.BorderStyle = BorderStyle.FixedSingle;
            containePainel.Controls.Add(nome);
            containePainel.Controls.Add(tipoDeRede);
            containePainel.Controls.Add(id);
            containePainel.Controls.Add(label1);
            containePainel.Location = new Point(12, 28);
            containePainel.Name = "containePainel";
            containePainel.Size = new Size(414, 90);
            containePainel.TabIndex = 1;
            // 
            // nome
            // 
            nome.Location = new Point(100, 40);
            nome.Name = "nome";
            nome.Size = new Size(288, 23);
            nome.TabIndex = 3;
            // 
            // tipoDeRede
            // 
            tipoDeRede.AutoSize = true;
            tipoDeRede.Location = new Point(15, 43);
            tipoDeRede.Name = "tipoDeRede";
            tipoDeRede.Size = new Size(75, 15);
            tipoDeRede.TabIndex = 2;
            tipoDeRede.Text = "Tipo de Rede";
            // 
            // id
            // 
            id.Location = new Point(100, 10);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // TiposRedes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 134);
            Controls.Add(containePainel);
            Controls.Add(toolStrip1);
            KeyPreview = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "TiposRedes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TiposRedes";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            containePainel.ResumeLayout(false);
            containePainel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton novoBotao;
        private ToolStripButton salvarBotao;
        private ToolStripSeparator toolStripSeparator1;
        private Panel containePainel;
        private TextBox nome;
        private Label tipoDeRede;
        private TextBox id;
        private Label label1;
    }
}