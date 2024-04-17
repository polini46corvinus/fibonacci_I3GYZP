namespace Hajós__minta_zh_
{
    partial class BeviteliForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            szamTextBox = new TextBox();
            bindingSource1 = new BindingSource(components);
            kerdesTextBox = new TextBox();
            label2 = new Label();
            v1TextBox = new TextBox();
            label3 = new Label();
            v2TextBox = new TextBox();
            label4 = new Label();
            v3TextBox = new TextBox();
            label5 = new Label();
            okButton = new Button();
            cancelButton = new Button();
            kepTextBox = new TextBox();
            label6 = new Label();
            helyesValaszTextBox = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 28);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 0;
            label1.Text = "Szam [szám] KÖTELEZŐ";
            // 
            // szamTextBox
            // 
            szamTextBox.Location = new Point(30, 46);
            szamTextBox.Name = "szamTextBox";
            szamTextBox.Size = new Size(375, 23);
            szamTextBox.TabIndex = 1;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(KerdesOsztaly);
            // 
            // kerdesTextBox
            // 
            kerdesTextBox.Location = new Point(30, 101);
            kerdesTextBox.Name = "kerdesTextBox";
            kerdesTextBox.Size = new Size(375, 23);
            kerdesTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 83);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Kerdes";
            // 
            // v1TextBox
            // 
            v1TextBox.Location = new Point(30, 156);
            v1TextBox.Name = "v1TextBox";
            v1TextBox.Size = new Size(375, 23);
            v1TextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 138);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 4;
            label3.Text = "V1";
            // 
            // v2TextBox
            // 
            v2TextBox.Location = new Point(30, 212);
            v2TextBox.Name = "v2TextBox";
            v2TextBox.Size = new Size(375, 23);
            v2TextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 194);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 6;
            label4.Text = "V2";
            // 
            // v3TextBox
            // 
            v3TextBox.Location = new Point(30, 266);
            v3TextBox.Name = "v3TextBox";
            v3TextBox.Size = new Size(375, 23);
            v3TextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 248);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 8;
            label5.Text = "V3";
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(330, 423);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 15;
            okButton.Text = "&OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(249, 423);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 14;
            cancelButton.Text = "&Mégse";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // kepTextBox
            // 
            kepTextBox.Location = new Point(30, 316);
            kepTextBox.Name = "kepTextBox";
            kepTextBox.Size = new Size(375, 23);
            kepTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 298);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 10;
            label6.Text = "Kep";
            // 
            // helyesValaszTextBox
            // 
            helyesValaszTextBox.Location = new Point(30, 371);
            helyesValaszTextBox.Name = "helyesValaszTextBox";
            helyesValaszTextBox.Size = new Size(375, 23);
            helyesValaszTextBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 353);
            label7.Name = "label7";
            label7.Size = new Size(168, 15);
            label7.TabIndex = 12;
            label7.Text = "HelyesValasz [szám] KÖTELEZŐ";
            // 
            // BeviteliForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 468);
            Controls.Add(helyesValaszTextBox);
            Controls.Add(label7);
            Controls.Add(kepTextBox);
            Controls.Add(label6);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(v3TextBox);
            Controls.Add(label5);
            Controls.Add(v2TextBox);
            Controls.Add(label4);
            Controls.Add(v1TextBox);
            Controls.Add(label3);
            Controls.Add(kerdesTextBox);
            Controls.Add(label2);
            Controls.Add(szamTextBox);
            Controls.Add(label1);
            Name = "BeviteliForm";
            Text = "BeviteliForm";
            Load += BeviteliForm_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox szamTextBox;
        private TextBox kerdesTextBox;
        private Label label2;
        private TextBox v1TextBox;
        private Label label3;
        private TextBox v2TextBox;
        private Label label4;
        private TextBox v3TextBox;
        private Label label5;
        private Button okButton;
        private Button cancelButton;
        private TextBox kepTextBox;
        private Label label6;
        private TextBox helyesValaszTextBox;
        private Label label7;
        private BindingSource bindingSource1;
    }
}