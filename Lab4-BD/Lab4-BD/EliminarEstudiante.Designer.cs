namespace Lab4_BD
{
    partial class EliminarEstudiante
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
            this.agregarEst = new MetroFramework.Controls.MetroLink();
            this.listaEst = new MetroFramework.Controls.MetroLink();
            this.iconBorrar = new System.Windows.Forms.PictureBox();
            this.nombre = new MetroFramework.Controls.MetroLabel();
            this.nombres = new MetroFramework.Controls.MetroComboBox();
            this.eliminar = new MetroFramework.Controls.MetroButton();
            this.listEst = new System.Windows.Forms.DataGridView();
            this.estudiantes = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.iconBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listEst)).BeginInit();
            this.SuspendLayout();
            // 
            // agregarEst
            // 
            this.agregarEst.Location = new System.Drawing.Point(591, 64);
            this.agregarEst.Name = "agregarEst";
            this.agregarEst.Size = new System.Drawing.Size(169, 23);
            this.agregarEst.TabIndex = 0;
            this.agregarEst.Text = "Ir a agregar estudiante";
            this.agregarEst.UseSelectable = true;
            this.agregarEst.Click += new System.EventHandler(this.agregarEst_Click);
            // 
            // listaEst
            // 
            this.listaEst.Location = new System.Drawing.Point(591, 93);
            this.listaEst.Name = "listaEst";
            this.listaEst.Size = new System.Drawing.Size(169, 23);
            this.listaEst.TabIndex = 1;
            this.listaEst.Text = "Ir a lista de estudiantes";
            this.listaEst.UseSelectable = true;
            this.listaEst.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // iconBorrar
            // 
            this.iconBorrar.Image = global::Lab4_BD.Properties.Resources.borrar;
            this.iconBorrar.Location = new System.Drawing.Point(334, 50);
            this.iconBorrar.Name = "iconBorrar";
            this.iconBorrar.Size = new System.Drawing.Size(103, 99);
            this.iconBorrar.TabIndex = 2;
            this.iconBorrar.TabStop = false;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(24, 176);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(59, 19);
            this.nombre.TabIndex = 3;
            this.nombre.Text = "Nombre";
            // 
            // nombres
            // 
            this.nombres.FormattingEnabled = true;
            this.nombres.ItemHeight = 23;
            this.nombres.Location = new System.Drawing.Point(89, 176);
            this.nombres.Name = "nombres";
            this.nombres.Size = new System.Drawing.Size(121, 29);
            this.nombres.TabIndex = 4;
            this.nombres.UseSelectable = true;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(591, 182);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 5;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseSelectable = true;
            // 
            // listEst
            // 
            this.listEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listEst.Location = new System.Drawing.Point(24, 253);
            this.listEst.Name = "listEst";
            this.listEst.Size = new System.Drawing.Size(736, 186);
            this.listEst.TabIndex = 6;
            this.listEst.SelectionChanged += new System.EventHandler(this.listEst_SelectionChanged);
            // 
            // estudiantes
            // 
            this.estudiantes.AutoSize = true;
            this.estudiantes.Location = new System.Drawing.Point(24, 231);
            this.estudiantes.Name = "estudiantes";
            this.estudiantes.Size = new System.Drawing.Size(76, 19);
            this.estudiantes.TabIndex = 7;
            this.estudiantes.Text = "Estudiantes:";
            // 
            // EliminarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.estudiantes);
            this.Controls.Add(this.listEst);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.nombres);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.iconBorrar);
            this.Controls.Add(this.listaEst);
            this.Controls.Add(this.agregarEst);
            this.Name = "EliminarEstudiante";
            this.Text = "Eliminar Estudiante";
            this.Load += new System.EventHandler(this.EliminarEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listEst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink agregarEst;
        private MetroFramework.Controls.MetroLink listaEst;
        private System.Windows.Forms.PictureBox iconBorrar;
        private MetroFramework.Controls.MetroLabel nombre;
        private MetroFramework.Controls.MetroComboBox nombres;
        private MetroFramework.Controls.MetroButton eliminar;
        private System.Windows.Forms.DataGridView listEst;
        private MetroFramework.Controls.MetroLabel estudiantes;
    }
}