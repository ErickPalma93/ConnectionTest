namespace TesteConexao
{
    partial class PostRequestForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TextBox TextUrl;
        private Button buttonBuscar;
        private Button buttonLimpar;
        private RichTextBox ResponseBox;
        private Label label4;
        private RichTextBox RequestBodyBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem requisicaoGetMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            TextUrl = new TextBox();
            buttonBuscar = new Button();
            buttonLimpar = new Button();
            ResponseBox = new RichTextBox();
            label4 = new Label();
            RequestBodyBox = new RichTextBox();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            requisicaoGetMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 24);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Teste Avançado";
            // 
            // TextUrl
            // 
            TextUrl.BackColor = SystemColors.HighlightText;
            TextUrl.Location = new Point(117, 178);
            TextUrl.Name = "TextUrl";
            TextUrl.Size = new Size(647, 23);
            TextUrl.TabIndex = 5;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(328, 219);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(126, 23);
            buttonBuscar.TabIndex = 6;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(689, 219);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(75, 23);
            buttonLimpar.TabIndex = 7;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // ResponseBox
            // 
            ResponseBox.BackColor = SystemColors.Info;
            ResponseBox.Location = new Point(69, 270);
            ResponseBox.Name = "ResponseBox";
            ResponseBox.ReadOnly = true;
            ResponseBox.Size = new Size(695, 129);
            ResponseBox.TabIndex = 8;
            ResponseBox.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 242);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 9;
            label4.Text = "Resposta:";
            // 
            // RequestBodyBox
            // 
            RequestBodyBox.BackColor = SystemColors.HighlightText;
            RequestBodyBox.Location = new Point(69, 59);
            RequestBodyBox.Name = "RequestBodyBox";
            RequestBodyBox.Size = new Size(695, 101);
            RequestBodyBox.TabIndex = 10;
            RequestBodyBox.Text = "{\n    \"email\": \"\",\n    \"senha\": \"\"\n}";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 186);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 11;
            label2.Text = "URL:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { requisicaoGetMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // requisicaoGetMenuItem
            // 
            requisicaoGetMenuItem.ForeColor = SystemColors.HotTrack;
            requisicaoGetMenuItem.Name = "requisicaoGetMenuItem";
            requisicaoGetMenuItem.Size = new Size(94, 20);
            requisicaoGetMenuItem.Text = "Teste simples";
            requisicaoGetMenuItem.Click += postRequestMenuItem_Click;
            // 
            // PostRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(RequestBodyBox);
            Controls.Add(label4);
            Controls.Add(ResponseBox);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonBuscar);
            Controls.Add(TextUrl);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "PostRequestForm";
            Text = "Teste de Comunicação";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
    }
}
