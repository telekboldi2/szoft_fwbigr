namespace Szofteng
{
    partial class UgyfelForm
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
            ugyfelBindingSource = new BindingSource(components);
            rendelesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lakcimDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lakcimIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonszamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ugyfelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            Update = new Button();
            Save = new Button();
            Delete = new Button();
            New = new Button();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // rendelesDataGridViewTextBoxColumn
            // 
            rendelesDataGridViewTextBoxColumn.DataPropertyName = "Rendeles";
            rendelesDataGridViewTextBoxColumn.HeaderText = "Rendeles";
            rendelesDataGridViewTextBoxColumn.Name = "rendelesDataGridViewTextBoxColumn";
            // 
            // lakcimDataGridViewTextBoxColumn
            // 
            lakcimDataGridViewTextBoxColumn.DataPropertyName = "Lakcim";
            lakcimDataGridViewTextBoxColumn.HeaderText = "Lakcim";
            lakcimDataGridViewTextBoxColumn.Name = "lakcimDataGridViewTextBoxColumn";
            // 
            // lakcimIdDataGridViewTextBoxColumn
            // 
            lakcimIdDataGridViewTextBoxColumn.DataPropertyName = "LakcimId";
            lakcimIdDataGridViewTextBoxColumn.HeaderText = "LakcimId";
            lakcimIdDataGridViewTextBoxColumn.Name = "lakcimIdDataGridViewTextBoxColumn";
            // 
            // telefonszamDataGridViewTextBoxColumn
            // 
            telefonszamDataGridViewTextBoxColumn.DataPropertyName = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.HeaderText = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.Name = "telefonszamDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // ugyfelIdDataGridViewTextBoxColumn
            // 
            ugyfelIdDataGridViewTextBoxColumn.DataPropertyName = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.HeaderText = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.Name = "ugyfelIdDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ugyfelIdDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telefonszamDataGridViewTextBoxColumn, lakcimIdDataGridViewTextBoxColumn, lakcimDataGridViewTextBoxColumn, rendelesDataGridViewTextBoxColumn });
            dataGridView1.DataSource = ugyfelBindingSource;
            dataGridView1.Location = new Point(28, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(760, 321);
            dataGridView1.TabIndex = 0;
            // 
            // Update
            // 
            Update.Location = new Point(559, 374);
            Update.Name = "Update";
            Update.Size = new Size(138, 23);
            Update.TabIndex = 8;
            Update.Text = "Frissítés";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Save
            // 
            Save.Location = new Point(415, 374);
            Save.Name = "Save";
            Save.Size = new Size(138, 23);
            Save.TabIndex = 7;
            Save.Text = "Mentés";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(256, 374);
            Delete.Name = "Delete";
            Delete.Size = new Size(138, 23);
            Delete.TabIndex = 6;
            Delete.Text = "Törlés";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // New
            // 
            New.Location = new Point(112, 374);
            New.Name = "New";
            New.Size = new Size(138, 23);
            New.TabIndex = 5;
            New.Text = "Új (minta)";
            New.UseVisualStyleBackColor = true;
            New.Click += New_Click;
            // 
            // UgyfelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Update);
            Controls.Add(Save);
            Controls.Add(Delete);
            Controls.Add(New);
            Controls.Add(dataGridView1);
            Name = "UgyfelForm";
            Text = "UgyfelForm";
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource ugyfelBindingSource;
        private DataGridViewTextBoxColumn rendelesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lakcimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lakcimIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonszamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ugyfelIdDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private Button Update;
        private Button Save;
        private Button Delete;
        private Button New;
    }
}