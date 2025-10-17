namespace AccountingSystemWinForms
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            label1 = new Label();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            SuspendLayout();
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(52, 81);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(41, 20);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Login";
            kryptonLabel1.Click += kryptonLabel1_Click;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(52, 118);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(100, 23);
            kryptonTextBox1.TabIndex = 7;
            kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(7, 67, 130);
            label1.Location = new Point(52, 162);
            label1.Name = "label1";
            label1.Size = new Size(100, 42);
            label1.TabIndex = 8;
            label1.Text = "Log In";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Location = new Point(52, 240);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(194, 20);
            kryptonTextBox2.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            kryptonTextBox2.TabIndex = 9;
            kryptonTextBox2.Text = "Username";
            // 
            // kryptonTextBox3
            // 
            kryptonTextBox3.Location = new Point(52, 278);
            kryptonTextBox3.Name = "kryptonTextBox3";
            kryptonTextBox3.Size = new Size(194, 20);
            kryptonTextBox3.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            kryptonTextBox3.TabIndex = 10;
            kryptonTextBox3.Text = "Password";
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(kryptonTextBox3);
            Controls.Add(kryptonTextBox2);
            Controls.Add(label1);
            Controls.Add(kryptonTextBox1);
            Controls.Add(kryptonLabel1);
            Name = "LoginControl";
            Size = new Size(334, 463);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Label label1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
    }
}
