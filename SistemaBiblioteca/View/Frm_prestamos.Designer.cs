namespace SistemaBiblioteca.View
{
    partial class Frm_prestamos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_bus_list_li = new System.Windows.Forms.Button();
            this.rdb_exter = new System.Windows.Forms.RadioButton();
            this.rdb_inter = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_clas_li = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nom_li = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_clv_li = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_book = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_real_prest = new System.Windows.Forms.Button();
            this.txt_grado = new System.Windows.Forms.TextBox();
            this.txt_nom_alum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_matri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_grupo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 255);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Clave";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Libro";
            this.Column2.Name = "Column2";
            this.Column2.Width = 340;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Clasificacion";
            this.Column3.Name = "Column3";
            this.Column3.Width = 190;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "";
            this.Column7.Name = "Column7";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_bus_list_li);
            this.groupBox1.Controls.Add(this.rdb_exter);
            this.groupBox1.Controls.Add(this.rdb_inter);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_cant);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_clas_li);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nom_li);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_clv_li);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1126, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Prestamo";
            // 
            // btn_bus_list_li
            // 
            this.btn_bus_list_li.BackgroundImage = global::SistemaBiblioteca.Properties.Resources.Busqueda;
            this.btn_bus_list_li.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_bus_list_li.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bus_list_li.ForeColor = System.Drawing.Color.Black;
            this.btn_bus_list_li.Location = new System.Drawing.Point(346, 20);
            this.btn_bus_list_li.Name = "btn_bus_list_li";
            this.btn_bus_list_li.Size = new System.Drawing.Size(100, 36);
            this.btn_bus_list_li.TabIndex = 27;
            this.btn_bus_list_li.Text = "Lista libros";
            this.btn_bus_list_li.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_bus_list_li.UseVisualStyleBackColor = true;
            this.btn_bus_list_li.Click += new System.EventHandler(this.btn_bus_list_li_Click);
            // 
            // rdb_exter
            // 
            this.rdb_exter.AutoSize = true;
            this.rdb_exter.Location = new System.Drawing.Point(201, 90);
            this.rdb_exter.Name = "rdb_exter";
            this.rdb_exter.Size = new System.Drawing.Size(67, 19);
            this.rdb_exter.TabIndex = 25;
            this.rdb_exter.TabStop = true;
            this.rdb_exter.Text = "Externo";
            this.rdb_exter.UseVisualStyleBackColor = true;
            // 
            // rdb_inter
            // 
            this.rdb_inter.AutoSize = true;
            this.rdb_inter.Location = new System.Drawing.Point(124, 90);
            this.rdb_inter.Name = "rdb_inter";
            this.rdb_inter.Size = new System.Drawing.Size(63, 19);
            this.rdb_inter.TabIndex = 24;
            this.rdb_inter.TabStop = true;
            this.rdb_inter.Text = "Interno";
            this.rdb_inter.UseVisualStyleBackColor = true;
            this.rdb_inter.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tipo prestamo:";
            // 
            // txt_cant
            // 
            this.txt_cant.Location = new System.Drawing.Point(782, 119);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(234, 21);
            this.txt_cant.TabIndex = 22;
            this.txt_cant.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(717, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Cantidad:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(460, 118);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(234, 21);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fecha devolucion:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha prestamo:";
            // 
            // txt_clas_li
            // 
            this.txt_clas_li.Location = new System.Drawing.Point(542, 59);
            this.txt_clas_li.Name = "txt_clas_li";
            this.txt_clas_li.Size = new System.Drawing.Size(234, 21);
            this.txt_clas_li.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Clasificacion:";
            // 
            // txt_nom_li
            // 
            this.txt_nom_li.Location = new System.Drawing.Point(124, 59);
            this.txt_nom_li.Name = "txt_nom_li";
            this.txt_nom_li.Size = new System.Drawing.Size(315, 21);
            this.txt_nom_li.TabIndex = 8;
            this.txt_nom_li.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre Libro:";
            // 
            // txt_clv_li
            // 
            this.txt_clv_li.Location = new System.Drawing.Point(124, 30);
            this.txt_clv_li.Name = "txt_clv_li";
            this.txt_clv_li.Size = new System.Drawing.Size(200, 21);
            this.txt_clv_li.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave del libro:";
            // 
            // btn_add_book
            // 
            this.btn_add_book.BackgroundImage = global::SistemaBiblioteca.Properties.Resources.add_48;
            this.btn_add_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_add_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_book.ForeColor = System.Drawing.Color.Black;
            this.btn_add_book.Location = new System.Drawing.Point(1020, 38);
            this.btn_add_book.Name = "btn_add_book";
            this.btn_add_book.Size = new System.Drawing.Size(100, 36);
            this.btn_add_book.TabIndex = 6;
            this.btn_add_book.Text = "Agregar";
            this.btn_add_book.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SistemaBiblioteca.Properties.Resources.cancel_48;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1017, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quitar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_real_prest);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1126, 281);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btn_real_prest
            // 
            this.btn_real_prest.BackgroundImage = global::SistemaBiblioteca.Properties.Resources.accepted_48;
            this.btn_real_prest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_real_prest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_real_prest.Location = new System.Drawing.Point(1017, 62);
            this.btn_real_prest.Name = "btn_real_prest";
            this.btn_real_prest.Size = new System.Drawing.Size(100, 36);
            this.btn_real_prest.TabIndex = 6;
            this.btn_real_prest.Text = "Prestar";
            this.btn_real_prest.UseVisualStyleBackColor = true;
            // 
            // txt_grado
            // 
            this.txt_grado.Location = new System.Drawing.Point(493, 46);
            this.txt_grado.Name = "txt_grado";
            this.txt_grado.Size = new System.Drawing.Size(234, 21);
            this.txt_grado.TabIndex = 32;
            // 
            // txt_nom_alum
            // 
            this.txt_nom_alum.Location = new System.Drawing.Point(115, 46);
            this.txt_nom_alum.Name = "txt_nom_alum";
            this.txt_nom_alum.Size = new System.Drawing.Size(316, 21);
            this.txt_nom_alum.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Grado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nombre:";
            // 
            // txt_matri
            // 
            this.txt_matri.Location = new System.Drawing.Point(115, 19);
            this.txt_matri.Name = "txt_matri";
            this.txt_matri.Size = new System.Drawing.Size(201, 21);
            this.txt_matri.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Matricula:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_grupo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_grado);
            this.groupBox3.Controls.Add(this.btn_add_book);
            this.groupBox3.Controls.Add(this.txt_matri);
            this.groupBox3.Controls.Add(this.txt_nom_alum);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1126, 85);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del alumno";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(733, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "Grupo:";
            // 
            // txt_grupo
            // 
            this.txt_grupo.Location = new System.Drawing.Point(783, 46);
            this.txt_grupo.Name = "txt_grupo";
            this.txt_grupo.Size = new System.Drawing.Size(234, 21);
            this.txt_grupo.TabIndex = 33;
            // 
            // Frm_prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaBiblioteca.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1154, 548);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Frm_prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamo de libros";
            this.Load += new System.EventHandler(this.Frm_prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txt_clas_li;
        public System.Windows.Forms.TextBox txt_nom_li;
        public System.Windows.Forms.TextBox txt_clv_li;
        public System.Windows.Forms.TextBox txt_cant;
        public System.Windows.Forms.Button btn_add_book;
        public System.Windows.Forms.RadioButton rdb_exter;
        public System.Windows.Forms.RadioButton rdb_inter;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btn_bus_list_li;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        public System.Windows.Forms.Button btn_real_prest;
        public System.Windows.Forms.TextBox txt_grado;
        public System.Windows.Forms.TextBox txt_nom_alum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_matri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_grupo;

    }
}