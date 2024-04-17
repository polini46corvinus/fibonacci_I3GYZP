namespace Hajós__minta_zh_
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
            mentesButton = new Button();
            dataGridView1 = new DataGridView();
            kerdesOsztalyBindingSource = new BindingSource(components);
            torlesButton = new Button();
            hozzaadasButton = new Button();
            szamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kerdesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kepDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            helyesValaszDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kerdesOsztalyBindingSource).BeginInit();
            SuspendLayout();
            // 
            // mentesButton
            // 
            mentesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            mentesButton.Location = new Point(789, 423);
            mentesButton.Name = "mentesButton";
            mentesButton.Size = new Size(75, 23);
            mentesButton.TabIndex = 0;
            mentesButton.Text = "&Mentés";
            mentesButton.UseVisualStyleBackColor = true;
            mentesButton.Click += mentesButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { szamDataGridViewTextBoxColumn, kerdesDataGridViewTextBoxColumn, v1DataGridViewTextBoxColumn, v2DataGridViewTextBoxColumn, v3DataGridViewTextBoxColumn, kepDataGridViewTextBoxColumn, helyesValaszDataGridViewTextBoxColumn });
            dataGridView1.DataSource = kerdesOsztalyBindingSource;
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(760, 389);
            dataGridView1.TabIndex = 2;
            // 
            // kerdesOsztalyBindingSource
            // 
            kerdesOsztalyBindingSource.DataSource = typeof(KerdesOsztaly);
            // 
            // torlesButton
            // 
            torlesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            torlesButton.Location = new Point(789, 352);
            torlesButton.Name = "torlesButton";
            torlesButton.Size = new Size(75, 23);
            torlesButton.TabIndex = 3;
            torlesButton.Text = "&Törlés";
            torlesButton.UseVisualStyleBackColor = true;
            torlesButton.Click += torlesButton_Click;
            // 
            // hozzaadasButton
            // 
            hozzaadasButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            hozzaadasButton.Location = new Point(789, 323);
            hozzaadasButton.Name = "hozzaadasButton";
            hozzaadasButton.Size = new Size(75, 23);
            hozzaadasButton.TabIndex = 4;
            hozzaadasButton.Text = "&Hozzáadás";
            hozzaadasButton.UseVisualStyleBackColor = true;
            hozzaadasButton.Click += hozzaadasButton_Click;
            // 
            // szamDataGridViewTextBoxColumn
            // 
            szamDataGridViewTextBoxColumn.DataPropertyName = "Szam";
            szamDataGridViewTextBoxColumn.HeaderText = "Szam";
            szamDataGridViewTextBoxColumn.Name = "szamDataGridViewTextBoxColumn";
            szamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kerdesDataGridViewTextBoxColumn
            // 
            kerdesDataGridViewTextBoxColumn.DataPropertyName = "Kerdes";
            kerdesDataGridViewTextBoxColumn.HeaderText = "Kerdes";
            kerdesDataGridViewTextBoxColumn.Name = "kerdesDataGridViewTextBoxColumn";
            kerdesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // v1DataGridViewTextBoxColumn
            // 
            v1DataGridViewTextBoxColumn.DataPropertyName = "V1";
            v1DataGridViewTextBoxColumn.HeaderText = "V1";
            v1DataGridViewTextBoxColumn.Name = "v1DataGridViewTextBoxColumn";
            v1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // v2DataGridViewTextBoxColumn
            // 
            v2DataGridViewTextBoxColumn.DataPropertyName = "V2";
            v2DataGridViewTextBoxColumn.HeaderText = "V2";
            v2DataGridViewTextBoxColumn.Name = "v2DataGridViewTextBoxColumn";
            v2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // v3DataGridViewTextBoxColumn
            // 
            v3DataGridViewTextBoxColumn.DataPropertyName = "V3";
            v3DataGridViewTextBoxColumn.HeaderText = "V3";
            v3DataGridViewTextBoxColumn.Name = "v3DataGridViewTextBoxColumn";
            v3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kepDataGridViewTextBoxColumn
            // 
            kepDataGridViewTextBoxColumn.DataPropertyName = "Kep";
            kepDataGridViewTextBoxColumn.HeaderText = "Kep";
            kepDataGridViewTextBoxColumn.Name = "kepDataGridViewTextBoxColumn";
            kepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // helyesValaszDataGridViewTextBoxColumn
            // 
            helyesValaszDataGridViewTextBoxColumn.DataPropertyName = "HelyesValasz";
            helyesValaszDataGridViewTextBoxColumn.HeaderText = "HelyesValasz";
            helyesValaszDataGridViewTextBoxColumn.Name = "helyesValaszDataGridViewTextBoxColumn";
            helyesValaszDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 461);
            Controls.Add(hozzaadasButton);
            Controls.Add(torlesButton);
            Controls.Add(dataGridView1);
            Controls.Add(mentesButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kerdesOsztalyBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button mentesButton;
        private DataGridView dataGridView1;
        private BindingSource kerdesOsztalyBindingSource;
        private Button torlesButton;
        private Button hozzaadasButton;
        private DataGridViewTextBoxColumn szamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kerdesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kepDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn helyesValaszDataGridViewTextBoxColumn;
    }
}
