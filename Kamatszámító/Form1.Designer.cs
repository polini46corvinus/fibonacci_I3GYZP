namespace Kamatszámító
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
            hitelOsszeg = new Label();
            kamatErtek = new Label();
            torlesztoOsszeg = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            hitelOsszegTextBox = new TextBox();
            kamatTextBox = new TextBox();
            torlesztoTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // hitelOsszeg
            // 
            hitelOsszeg.AutoSize = true;
            hitelOsszeg.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hitelOsszeg.Location = new Point(115, 60);
            hitelOsszeg.Name = "hitelOsszeg";
            hitelOsszeg.Size = new Size(67, 15);
            hitelOsszeg.TabIndex = 0;
            hitelOsszeg.Text = "Hitelösszeg";
            // 
            // kamatErtek
            // 
            kamatErtek.AutoSize = true;
            kamatErtek.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kamatErtek.Location = new Point(120, 98);
            kamatErtek.Name = "kamatErtek";
            kamatErtek.Size = new Size(62, 15);
            kamatErtek.TabIndex = 1;
            kamatErtek.Text = "Kamat (%)";
            // 
            // torlesztoOsszeg
            // 
            torlesztoOsszeg.AutoSize = true;
            torlesztoOsszeg.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            torlesztoOsszeg.Location = new Point(103, 137);
            torlesztoOsszeg.Name = "torlesztoOsszeg";
            torlesztoOsszeg.Size = new Size(79, 15);
            torlesztoOsszeg.TabIndex = 2;
            torlesztoOsszeg.Text = "Havi törlesztő";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 217);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(393, 203);
            dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(214, 174);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // hitelOsszegTextBox
            // 
            hitelOsszegTextBox.Location = new Point(189, 57);
            hitelOsszegTextBox.Name = "hitelOsszegTextBox";
            hitelOsszegTextBox.Size = new Size(100, 23);
            hitelOsszegTextBox.TabIndex = 5;
            hitelOsszegTextBox.Text = "1000000";
            // 
            // kamatTextBox
            // 
            kamatTextBox.Location = new Point(189, 95);
            kamatTextBox.Name = "kamatTextBox";
            kamatTextBox.Size = new Size(100, 23);
            kamatTextBox.TabIndex = 6;
            kamatTextBox.Text = "1";
            // 
            // torlesztoTextBox
            // 
            torlesztoTextBox.Location = new Point(189, 134);
            torlesztoTextBox.Name = "torlesztoTextBox";
            torlesztoTextBox.Size = new Size(100, 23);
            torlesztoTextBox.TabIndex = 7;
            torlesztoTextBox.Text = "20000";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(torlesztoTextBox);
            Controls.Add(kamatTextBox);
            Controls.Add(hitelOsszegTextBox);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(torlesztoOsszeg);
            Controls.Add(kamatErtek);
            Controls.Add(hitelOsszeg);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label hitelOsszeg;
        private Label kamatErtek;
        private Label torlesztoOsszeg;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox hitelOsszegTextBox;
        private TextBox kamatTextBox;
        private TextBox torlesztoTextBox;
    }
}
