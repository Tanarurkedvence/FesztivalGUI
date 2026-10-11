namespace FesztivalGUI
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nev = new DataGridViewTextBoxColumn();
            Varos = new DataGridViewTextBoxColumn();
            megye = new DataGridViewTextBoxColumn();
            Alapitas = new DataGridViewTextBoxColumn();
            Latogato = new DataGridViewTextBoxColumn();
            Jegyar = new DataGridViewTextBoxColumn();
            ev = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(282, 21);
            label1.TabIndex = 0;
            label1.Text = "Szűrés fesztivál vagy város alapján: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(360, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(282, 352);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(71, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(430, 352);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 23);
            textBox3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 352);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 4;
            label2.Text = "kijelölt alapítás:";
            // 
            // button1
            // 
            button1.Location = new Point(579, 340);
            button1.Name = "button1";
            button1.Size = new Size(189, 44);
            button1.TabIndex = 5;
            button1.Text = "módosítási javaslat";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(266, 312);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 6;
            label3.Text = "látogató (ezer fő)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(430, 312);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 7;
            label4.Text = "jegyár (Ft)";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nev, Varos, megye, Alapitas, Latogato, Jegyar });
            dataGridView1.Location = new Point(12, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(787, 211);
            dataGridView1.TabIndex = 8;
            // 
            // Id
            // 
            Id.HeaderText = "#";
            Id.Name = "Id";
            // 
            // Nev
            // 
            Nev.HeaderText = "fesztivál";
            Nev.Name = "Nev";
            // 
            // Varos
            // 
            Varos.HeaderText = "város";
            Varos.Name = "Varos";
            // 
            // megye
            // 
            megye.HeaderText = "Megye";
            megye.Name = "megye";
            // 
            // Alapitas
            // 
            Alapitas.HeaderText = "alapítás";
            Alapitas.Name = "Alapitas";
            // 
            // Latogato
            // 
            Latogato.HeaderText = "látogató";
            Latogato.Name = "Latogato";
            // 
            // Jegyar
            // 
            Jegyar.HeaderText = "jegyár";
            Jegyar.Name = "Jegyar";
            // 
            // ev
            // 
            ev.AutoSize = true;
            ev.Location = new Point(188, 355);
            ev.Name = "ev";
            ev.Size = new Size(0, 15);
            ev.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ev);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Magyar fesztiválok ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nev;
        private DataGridViewTextBoxColumn Varos;
        private DataGridViewTextBoxColumn megye;
        private DataGridViewTextBoxColumn Alapitas;
        private DataGridViewTextBoxColumn Latogato;
        private DataGridViewTextBoxColumn Jegyar;
        private Label ev;
    }
}
