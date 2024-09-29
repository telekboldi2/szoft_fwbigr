namespace Szofteng
{
    partial class TermekKategoriaForm
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
            treeViewKategoriak = new TreeView();
            label1 = new Label();
            label2 = new Label();
            txtNev = new TextBox();
            txtLeiras = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // treeViewKategoriak
            // 
            treeViewKategoriak.Location = new Point(12, 12);
            treeViewKategoriak.Name = "treeViewKategoriak";
            treeViewKategoriak.Size = new Size(202, 290);
            treeViewKategoriak.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 43);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Név:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 155);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Leírás:";
            // 
            // txtNev
            // 
            txtNev.Location = new Point(264, 40);
            txtNev.Name = "txtNev";
            txtNev.Size = new Size(237, 23);
            txtNev.TabIndex = 3;
            // 
            // txtLeiras
            // 
            txtLeiras.Location = new Point(264, 152);
            txtLeiras.MaximumSize = new Size(400, 400);
            txtLeiras.MinimumSize = new Size(0, 150);
            txtLeiras.Name = "txtLeiras";
            txtLeiras.Size = new Size(237, 150);
            txtLeiras.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(12, 320);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 5;
            button1.Text = "Új testvér kat.";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(141, 320);
            button2.Name = "button2";
            button2.Size = new Size(119, 23);
            button2.TabIndex = 6;
            button2.Text = "Új gyermek kat.";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(393, 320);
            button3.Name = "button3";
            button3.Size = new Size(119, 23);
            button3.TabIndex = 8;
            button3.Text = "Törlés";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(264, 320);
            button4.Name = "button4";
            button4.Size = new Size(119, 23);
            button4.TabIndex = 7;
            button4.Text = "Mentés";
            button4.UseVisualStyleBackColor = true;
            // 
            // TermekKategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 396);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtLeiras);
            Controls.Add(txtNev);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(treeViewKategoriak);
            Name = "TermekKategoriaForm";
            Text = "TermekKategoriaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewKategoriak;
        private Label label1;
        private Label label2;
        private TextBox txtNev;
        private TextBox txtLeiras;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}