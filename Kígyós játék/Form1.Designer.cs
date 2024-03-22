namespace Kígyós_játék
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lepesszamLabel = new Label();
            hosszLabel = new Label();
            szintLabel = new Label();
            kajagenerátorTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // lepesszamLabel
            // 
            lepesszamLabel.AutoSize = true;
            lepesszamLabel.BackColor = Color.Transparent;
            lepesszamLabel.Location = new Point(21, 20);
            lepesszamLabel.Name = "lepesszamLabel";
            lepesszamLabel.Size = new Size(64, 15);
            lepesszamLabel.TabIndex = 0;
            lepesszamLabel.Text = "Lépésszám";
            // 
            // hosszLabel
            // 
            hosszLabel.AutoSize = true;
            hosszLabel.BackColor = Color.Transparent;
            hosszLabel.Location = new Point(21, 44);
            hosszLabel.Name = "hosszLabel";
            hosszLabel.Size = new Size(38, 15);
            hosszLabel.TabIndex = 1;
            hosszLabel.Text = "Hossz";
            // 
            // szintLabel
            // 
            szintLabel.AutoSize = true;
            szintLabel.BackColor = Color.Transparent;
            szintLabel.Location = new Point(21, 69);
            szintLabel.Name = "szintLabel";
            szintLabel.Size = new Size(32, 15);
            szintLabel.TabIndex = 2;
            szintLabel.Text = "Szint";
            // 
            // kajagenerátorTimer
            // 
            kajagenerátorTimer.Enabled = true;
            kajagenerátorTimer.Interval = 1400;
            kajagenerátorTimer.Tick += kajagenerátorTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(szintLabel);
            Controls.Add(hosszLabel);
            Controls.Add(lepesszamLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += lefele;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lepesszamLabel;
        private Label hosszLabel;
        private Label szintLabel;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer kajagenerátorTimer;
    }
}