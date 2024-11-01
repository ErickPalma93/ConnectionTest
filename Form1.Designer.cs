namespace TesteConexao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem requisicaoPostMenuItem;

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
            label1 = new Label();
            TextUser = new TextBox();
            TextPass = new TextBox();
            TextUrl = new TextBox();
            buttonBuscar = new Button();
            buttonLimpar = new Button();
            ResponseBox = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            requisicaoPostMenuItem = new ToolStripMenuItem();
            radioButtonGet = new RadioButton();
            radioButtonPost = new RadioButton();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 33);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Teste simples";
            // 
            // TextUser
            // 
            TextUser.BackColor = SystemColors.ButtonHighlight;
            TextUser.Location = new Point(193, 60);
            TextUser.Name = "TextUser";
            TextUser.Size = new Size(333, 23);
            TextUser.TabIndex = 4;
            // 
            // TextPass
            // 
            TextPass.BackColor = SystemColors.HighlightText;
            TextPass.Location = new Point(193, 100);
            TextPass.Name = "TextPass";
            TextPass.Size = new Size(333, 23);
            TextPass.TabIndex = 5;
            // 
            // TextUrl
            // 
            TextUrl.BackColor = SystemColors.HighlightText;
            TextUrl.Location = new Point(193, 140);
            TextUrl.Name = "TextUrl";
            TextUrl.Size = new Size(558, 23);
            TextUrl.TabIndex = 6;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(328, 185);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(126, 23);
            buttonBuscar.TabIndex = 7;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(676, 185);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(75, 23);
            buttonLimpar.TabIndex = 8;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // ResponseBox
            // 
            ResponseBox.BackColor = SystemColors.Info;
            ResponseBox.Location = new Point(69, 259);
            ResponseBox.Name = "ResponseBox";
            ResponseBox.ReadOnly = true;
            ResponseBox.Size = new Size(682, 119);
            ResponseBox.TabIndex = 9;
            ResponseBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 60);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 10;
            label2.Text = "Email/Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 100);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 11;
            label3.Text = "Password/Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 140);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 12;
            label4.Text = "URL:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 241);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 13;
            label5.Text = "Resposta:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { requisicaoPostMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // requisicaoPostMenuItem
            // 
            requisicaoPostMenuItem.ForeColor = SystemColors.HotTrack;
            requisicaoPostMenuItem.Name = "requisicaoPostMenuItem";
            requisicaoPostMenuItem.Size = new Size(98, 20);
            requisicaoPostMenuItem.Text = "Teste Avançado";
            requisicaoPostMenuItem.Click += postRequestMenuItem_Click;
            // 
            // radioButtonGet
            // 
            radioButtonGet.AutoSize = true;
            radioButtonGet.Cursor = Cursors.Hand;
            radioButtonGet.Enabled = false;
            radioButtonGet.Location = new Point(85, 176);
            radioButtonGet.Name = "radioButtonGet";
            radioButtonGet.Size = new Size(45, 19);
            radioButtonGet.TabIndex = 14;
            radioButtonGet.Text = "GET";
            radioButtonGet.UseVisualStyleBackColor = true;
            radioButtonGet.Visible = false;
            // 
            // radioButtonPost
            // 
            radioButtonPost.AutoSize = true;
            radioButtonPost.Checked = true;
            radioButtonPost.Cursor = Cursors.Hand;
            radioButtonPost.Location = new Point(85, 201);
            radioButtonPost.Name = "radioButtonPost";
            radioButtonPost.Size = new Size(53, 19);
            radioButtonPost.TabIndex = 15;
            radioButtonPost.TabStop = true;
            radioButtonPost.Text = "POST";
            radioButtonPost.UseVisualStyleBackColor = true;
            radioButtonPost.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 397);
            Controls.Add(radioButtonPost);
            Controls.Add(radioButtonGet);
            Controls.Add(label5);
            Controls.Add(ResponseBox);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonBuscar);
            Controls.Add(TextUrl);
            Controls.Add(TextPass);
            Controls.Add(TextUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Teste de Comunicação";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TextUser;
        private TextBox TextPass;
        private TextBox TextUrl;
        private Button buttonBuscar;
        private Button buttonLimpar;
        private RichTextBox ResponseBox;
        private RadioButton radioButtonGet;
        private RadioButton radioButtonPost;
    }
}
