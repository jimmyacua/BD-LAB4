namespace Lab4_BD
{
    partial class ListaEstudiante
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
            this.elimEst = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nombre = new MetroFramework.Controls.MetroLabel();
            this.filtro = new MetroFramework.Controls.MetroLabel();
            this.nombres = new MetroFramework.Controls.MetroComboBox();
            this.filtros = new MetroFramework.Controls.MetroTextBox();
            this.buscar = new MetroFramework.Controls.MetroButton();
            this.listEst = new MetroFramework.Controls.MetroLabel();
            this.listEstu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listEstu)).BeginInit();
            this.SuspendLayout();
            // 
            // agregarEst
            // 
            this.agregarEst.Location = new System.Drawing.Point(622, 63);
            this.agregarEst.Name = "agregarEst";
            this.agregarEst.Size = new System.Drawing.Size(142, 23);
            this.agregarEst.TabIndex = 0;
            this.agregarEst.Text = "Ir a agregar estudiantes";
            this.agregarEst.UseSelectable = true;
            this.agregarEst.Click += new System.EventHandler(this.agregarEst_Click);
            // 
            // elimEst
            // 
            this.elimEst.Location = new System.Drawing.Point(622, 92);
            this.elimEst.Name = "elimEst";
            this.elimEst.Size = new System.Drawing.Size(142, 23);
            this.elimEst.TabIndex = 1;
            this.elimEst.Text = "Ir a eliminar estudiantes";
            this.elimEst.UseSelectable = true;
            this.elimEst.Click += new System.EventHandler(this.elimEst_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab4_BD.Properties.Resources.buscar;
            this.pictureBox1.Location = new System.Drawing.Point(352, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 107);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(37, 167);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(59, 19);
            this.nombre.TabIndex = 3;
            this.nombre.Text = "Nombre";
            // 
            // filtro
            // 
            this.filtro.AutoSize = true;
            this.filtro.Location = new System.Drawing.Point(375, 167);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(88, 19);
            this.filtro.TabIndex = 4;
            this.filtro.Text = "Filtro General";
            this.filtro.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // nombres
            // 
            this.nombres.FormattingEnabled = true;
            this.nombres.ItemHeight = 23;
            this.nombres.Location = new System.Drawing.Point(102, 167);
            this.nombres.Name = "nombres";
            this.nombres.Size = new System.Drawing.Size(229, 29);
            this.nombres.TabIndex = 5;
            this.nombres.UseSelectable = true;
            this.nombres.SelectedIndexChanged += new System.EventHandler(this.nombres_SelectedIndexChanged);
            // 
            // filtros
            // 
            // 
            // 
            // 
            this.filtros.CustomButton.Image = null;
            this.filtros.CustomButton.Location = new System.Drawing.Point(271, 1);
            this.filtros.CustomButton.Name = "";
            this.filtros.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.filtros.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.filtros.CustomButton.TabIndex = 1;
            this.filtros.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.filtros.CustomButton.UseSelectable = true;
            this.filtros.CustomButton.Visible = false;
            this.filtros.Lines = new string[0];
            this.filtros.Location = new System.Drawing.Point(471, 173);
            this.filtros.MaxLength = 32767;
            this.filtros.Name = "filtros";
            this.filtros.PasswordChar = '\0';
            this.filtros.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.filtros.SelectedText = "";
            this.filtros.SelectionLength = 0;
            this.filtros.SelectionStart = 0;
            this.filtros.ShortcutsEnabled = true;
            this.filtros.Size = new System.Drawing.Size(293, 23);
            this.filtros.TabIndex = 6;
            this.filtros.UseSelectable = true;
            this.filtros.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.filtros.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(364, 217);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 7;
            this.buscar.Text = "Buscar";
            this.buscar.UseSelectable = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // listEst
            // 
            this.listEst.AutoSize = true;
            this.listEst.Location = new System.Drawing.Point(37, 244);
            this.listEst.Name = "listEst";
            this.listEst.Size = new System.Drawing.Size(76, 19);
            this.listEst.TabIndex = 8;
            this.listEst.Text = "Estudiantes:";
            // 
            // listEstu
            // 
            this.listEstu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listEstu.Location = new System.Drawing.Point(23, 266);
            this.listEstu.Name = "listEstu";
            this.listEstu.Size = new System.Drawing.Size(754, 161);
            this.listEstu.TabIndex = 9;
            // 
            // ListaEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listEstu);
            this.Controls.Add(this.listEst);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.filtros);
            this.Controls.Add(this.nombres);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.elimEst);
            this.Controls.Add(this.agregarEst);
            this.Name = "ListaEstudiante";
            this.Text = "Lista Estudiantes";
            this.Load += new System.EventHandler(this.ListaEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listEstu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink agregarEst;
        private MetroFramework.Controls.MetroLink elimEst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel nombre;
        private MetroFramework.Controls.MetroLabel filtro;
        private MetroFramework.Controls.MetroComboBox nombres;
        private MetroFramework.Controls.MetroTextBox filtros;
        private MetroFramework.Controls.MetroButton buscar;
        private MetroFramework.Controls.MetroLabel listEst;
        private System.Windows.Forms.DataGridView listEstu;
    }
}