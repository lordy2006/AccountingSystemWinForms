namespace AccountingSystemWinForms
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
            panel1 = new Panel();
            btnLogin = new Button();
            lblTitle = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(725, 227);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 202);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(566, 549);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(239, 44);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "button1";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Showcard Gothic", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(397, 342);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(235, 60);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "klhkaw";
            lblTitle.Click += label1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1055, 279);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(100, 96);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(566, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(872, 519);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(383, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 10);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Picture2;
            pictureBox1.Location = new Point(447, 213);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Location = new Point(213, 233);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(100, 100);
            kryptonPanel1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 752);
            Controls.Add(kryptonPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(lblTitle);
            Controls.Add(btnLogin);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private Label lblTitle;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}
