namespace TOKENCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button3 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxCertInfo = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxCertInfo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 429);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(294, 383);
            button2.Name = "button2";
            button2.Size = new Size(135, 32);
            button2.TabIndex = 3;
            button2.Text = "Fechar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(6, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 92);
            panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Windows_Defender;
            pictureBox1.Location = new Point(177, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(274, 3);
            label3.Name = "label3";
            label3.Size = new Size(154, 47);
            label3.TabIndex = 7;
            label3.Text = "Não tem um certificado? Agende clicando no botão abaixo:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // button3
            // 
            button3.Location = new Point(325, 57);
            button3.Name = "button3";
            button3.Size = new Size(103, 32);
            button3.TabIndex = 6;
            button3.Text = "Agendar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 57);
            button1.Name = "button1";
            button1.Size = new Size(103, 32);
            button1.TabIndex = 1;
            button1.Text = "Selecionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(0, 3);
            label1.Name = "label1";
            label1.Size = new Size(154, 47);
            label1.TabIndex = 2;
            label1.Text = "Selecione o seu certificado digital clicando no botão abaixo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 128);
            label2.Name = "label2";
            label2.Size = new Size(291, 15);
            label2.TabIndex = 4;
            label2.Text = "As informações do certificado digital aparecerão aqui:\r\n";
            label2.Click += label2_Click;
            // 
            // textBoxCertInfo
            // 
            textBoxCertInfo.ForeColor = SystemColors.MenuHighlight;
            textBoxCertInfo.ImeMode = ImeMode.On;
            textBoxCertInfo.Location = new Point(12, 149);
            textBoxCertInfo.Multiline = true;
            textBoxCertInfo.Name = "textBoxCertInfo";
            textBoxCertInfo.ReadOnly = true;
            textBoxCertInfo.Size = new Size(417, 220);
            textBoxCertInfo.TabIndex = 3;
            textBoxCertInfo.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(441, 427);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Certificado Digital - Validação e Informação .:";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBoxCertInfo;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
