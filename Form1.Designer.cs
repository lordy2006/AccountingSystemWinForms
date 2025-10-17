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
            btnName = new Button();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // btnName
            // 
            btnName.Location = new Point(397, 149);
            btnName.Name = "btnName";
            btnName.Size = new Size(255, 220);
            btnName.TabIndex = 0;
            btnName.Text = "1";
            btnName.UseVisualStyleBackColor = true;
            btnName.Click += btnName_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(699, 264);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(212, 39);
            kryptonButton1.StateCommon.Border.Color1 = Color.Black;
            kryptonButton1.StateCommon.Border.Color2 = Color.Black;
            kryptonButton1.StateCommon.Border.Rounding = 20F;
            kryptonButton1.TabIndex = 1;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 483);
            Controls.Add(kryptonButton1);
            Controls.Add(btnName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StateCommon.Border.Rounding = 20F;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnName;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}
