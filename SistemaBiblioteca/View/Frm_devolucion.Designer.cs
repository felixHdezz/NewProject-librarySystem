namespace SistemaBiblioteca.View
{
    partial class Frm_devolucion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_devol = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cant_pre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_tip_pre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_fe_pres = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_grupo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_grado = new System.Windows.Forms.TextBox();
            this.txt_nom_alum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clv_matri = new System.Windows.Forms.Button();
            this.txt_matri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_real_devol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devol)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_devol
            // 
            this.dgv_devol.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_devol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_devol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_devol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_devol.Location = new System.Drawing.Point(12, 171);
            this.dgv_devol.Name = "dgv_devol";
            this.dgv_devol.RowHeadersVisible = false;
            this.dgv_devol.Size = new System.Drawing.Size(880, 241);
            this.dgv_devol.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Clave";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre del libro";
            this.Column2.Name = "Column2";
            this.Column2.Width = 350;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Clasificacion";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_cant_pre);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_tip_pre);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_fe_pres);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_grupo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_grado);
            this.groupBox1.Controls.Add(this.txt_nom_alum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_clv_matri);
            this.groupBox1.Controls.Add(this.txt_matri);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de prestamo";
            // 
            // txt_cant_pre
            // 
            this.txt_cant_pre.Location = new System.Drawing.Point(719, 116);
            this.txt_cant_pre.Name = "txt_cant_pre";
            this.txt_cant_pre.Size = new System.Drawing.Size(150, 21);
            this.txt_cant_pre.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(654, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "Cantidad:";
            // 
            // txt_tip_pre
            // 
            this.txt_tip_pre.Location = new System.Drawing.Point(448, 116);
            this.txt_tip_pre.Name = "txt_tip_pre";
            this.txt_tip_pre.Size = new System.Drawing.Size(195, 21);
            this.txt_tip_pre.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(353, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "Tipo prestamo:";
            // 
            // txt_fe_pres
            // 
            this.txt_fe_pres.Location = new System.Drawing.Point(141, 116);
            this.txt_fe_pres.Name = "txt_fe_pres";
            this.txt_fe_pres.Size = new System.Drawing.Size(195, 21);
            this.txt_fe_pres.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Fecha de prestamo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Detalle de prestamo";
            // 
            // txt_grupo
            // 
            this.txt_grupo.Location = new System.Drawing.Point(704, 56);
            this.txt_grupo.Name = "txt_grupo";
            this.txt_grupo.Size = new System.Drawing.Size(150, 21);
            this.txt_grupo.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Grupo:";
            // 
            // txt_grado
            // 
            this.txt_grado.Location = new System.Drawing.Point(498, 56);
            this.txt_grado.Name = "txt_grado";
            this.txt_grado.Size = new System.Drawing.Size(150, 21);
            this.txt_grado.TabIndex = 20;
            // 
            // txt_nom_alum
            // 
            this.txt_nom_alum.Location = new System.Drawing.Point(89, 56);
            this.txt_nom_alum.Name = "txt_nom_alum";
            this.txt_nom_alum.Size = new System.Drawing.Size(353, 21);
            this.txt_nom_alum.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Grado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nombre:";
            // 
            // btn_clv_matri
            // 
            this.btn_clv_matri.BackgroundImage = global::SistemaBiblioteca.Properties.Resources.Busqueda;
            this.btn_clv_matri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_clv_matri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clv_matri.Location = new System.Drawing.Point(290, 20);
            this.btn_clv_matri.Name = "btn_clv_matri";
            this.btn_clv_matri.Size = new System.Drawing.Size(113, 36);
            this.btn_clv_matri.TabIndex = 7;
            this.btn_clv_matri.Text = "Buscar";
            this.btn_clv_matri.UseVisualStyleBackColor = true;
            // 
            // txt_matri
            // 
            this.txt_matri.Location = new System.Drawing.Point(89, 29);
            this.txt_matri.Name = "txt_matri";
            this.txt_matri.Size = new System.Drawing.Size(150, 21);
            this.txt_matri.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula:";
            // 
            // btn_real_devol
            // 
            this.btn_real_devol.BackgroundImage = global::SistemaBiblioteca.Properties.Resources.accepted_48;
            this.btn_real_devol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_real_devol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_real_devol.Location = new System.Drawing.Point(771, 418);
            this.btn_real_devol.Name = "btn_real_devol";
            this.btn_real_devol.Size = new System.Drawing.Size(121, 36);
            this.btn_real_devol.TabIndex = 7;
            this.btn_real_devol.Text = "Devolver";
            this.btn_real_devol.UseVisualStyleBackColor = true;
            // 
            // Frm_devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaBiblioteca.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 461);
            this.Controls.Add(this.btn_real_devol);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_devol);
            this.DoubleBuffered = true;
            this.Name = "Frm_devolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones de libros";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devol)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_clv_matri;
        public System.Windows.Forms.TextBox txt_grupo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_grado;
        public System.Windows.Forms.TextBox txt_nom_alum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_cant_pre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_real_devol;
        public System.Windows.Forms.TextBox txt_matri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        public System.Windows.Forms.DataGridView dgv_devol;
        public System.Windows.Forms.TextBox txt_tip_pre;
        public System.Windows.Forms.TextBox txt_fe_pres;
    }
}