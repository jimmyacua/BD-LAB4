namespace Lab4_BD
{
    partial class AgregarEstudiante
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.IrAlistaEst = new MetroFramework.Controls.MetroLink();
            this.elimEst = new MetroFramework.Controls.MetroLink();
            this.circulo = new System.Windows.Forms.PictureBox();
            this.datos = new System.Windows.Forms.GroupBox();
            this.cedula = new MetroFramework.Controls.MetroLabel();
            this.idField = new MetroFramework.Controls.MetroTextBox();
            this.nombre = new MetroFramework.Controls.MetroLabel();
            this.apellido1 = new MetroFramework.Controls.MetroLabel();
            this.apellido2 = new MetroFramework.Controls.MetroLabel();
            this.fechaNac = new MetroFramework.Controls.MetroLabel();
            this.direccion = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.fecha = new MetroFramework.Controls.MetroDateTime();
            this.telef = new MetroFramework.Controls.MetroLabel();
            this.email = new MetroFramework.Controls.MetroLabel();
            this.genero = new MetroFramework.Controls.MetroLabel();
            this.fem = new MetroFramework.Controls.MetroRadioButton();
            this.masc = new MetroFramework.Controls.MetroRadioButton();
            this.otroSexo = new MetroFramework.Controls.MetroRadioButton();
            this.usuario = new MetroFramework.Controls.MetroLabel();
            this.pass = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox7 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.guardar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.circulo)).BeginInit();
            this.datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // IrAlistaEst
            // 
            this.IrAlistaEst.Location = new System.Drawing.Point(607, 31);
            this.IrAlistaEst.Name = "IrAlistaEst";
            this.IrAlistaEst.Size = new System.Drawing.Size(157, 13);
            this.IrAlistaEst.TabIndex = 0;
            this.IrAlistaEst.Text = "Ir a lista de estudiantes";
            this.IrAlistaEst.UseSelectable = true;
            this.IrAlistaEst.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // elimEst
            // 
            this.elimEst.Location = new System.Drawing.Point(637, 63);
            this.elimEst.Name = "elimEst";
            this.elimEst.Size = new System.Drawing.Size(112, 23);
            this.elimEst.TabIndex = 1;
            this.elimEst.Text = "Eliminar Estudiante";
            this.elimEst.UseSelectable = true;
            this.elimEst.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // circulo
            // 
            this.circulo.Image = global::Lab4_BD.Properties.Resources.circulo;
            this.circulo.Location = new System.Drawing.Point(309, 11);
            this.circulo.Name = "circulo";
            this.circulo.Size = new System.Drawing.Size(125, 117);
            this.circulo.TabIndex = 2;
            this.circulo.TabStop = false;
            // 
            // datos
            // 
            this.datos.Controls.Add(this.guardar);
            this.datos.Controls.Add(this.metroTextBox8);
            this.datos.Controls.Add(this.metroTextBox7);
            this.datos.Controls.Add(this.metroTextBox6);
            this.datos.Controls.Add(this.metroTextBox4);
            this.datos.Controls.Add(this.pass);
            this.datos.Controls.Add(this.usuario);
            this.datos.Controls.Add(this.otroSexo);
            this.datos.Controls.Add(this.masc);
            this.datos.Controls.Add(this.fem);
            this.datos.Controls.Add(this.genero);
            this.datos.Controls.Add(this.email);
            this.datos.Controls.Add(this.telef);
            this.datos.Controls.Add(this.fecha);
            this.datos.Controls.Add(this.metroTextBox5);
            this.datos.Controls.Add(this.metroTextBox3);
            this.datos.Controls.Add(this.metroTextBox2);
            this.datos.Controls.Add(this.metroTextBox1);
            this.datos.Controls.Add(this.direccion);
            this.datos.Controls.Add(this.fechaNac);
            this.datos.Controls.Add(this.apellido2);
            this.datos.Controls.Add(this.apellido1);
            this.datos.Controls.Add(this.nombre);
            this.datos.Controls.Add(this.idField);
            this.datos.Controls.Add(this.cedula);
            this.datos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datos.Location = new System.Drawing.Point(13, 142);
            this.datos.Name = "datos";
            this.datos.Size = new System.Drawing.Size(774, 297);
            this.datos.TabIndex = 3;
            this.datos.TabStop = false;
            this.datos.Text = "Datos del estudiante";
            this.datos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cedula
            // 
            this.cedula.AutoSize = true;
            this.cedula.Location = new System.Drawing.Point(33, 26);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(50, 19);
            this.cedula.TabIndex = 0;
            this.cedula.Text = "Cédula";
            // 
            // idField
            // 
            // 
            // 
            // 
            this.idField.CustomButton.Image = null;
            this.idField.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.idField.CustomButton.Name = "";
            this.idField.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idField.CustomButton.TabIndex = 1;
            this.idField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idField.CustomButton.UseSelectable = true;
            this.idField.CustomButton.Visible = false;
            this.idField.Lines = new string[0];
            this.idField.Location = new System.Drawing.Point(160, 26);
            this.idField.MaxLength = 32767;
            this.idField.Name = "idField";
            this.idField.PasswordChar = '\0';
            this.idField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idField.SelectedText = "";
            this.idField.SelectionLength = 0;
            this.idField.SelectionStart = 0;
            this.idField.ShortcutsEnabled = true;
            this.idField.Size = new System.Drawing.Size(155, 23);
            this.idField.TabIndex = 1;
            this.idField.UseSelectable = true;
            this.idField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(33, 71);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(59, 19);
            this.nombre.TabIndex = 2;
            this.nombre.Text = "Nombre";
            // 
            // apellido1
            // 
            this.apellido1.AutoSize = true;
            this.apellido1.Location = new System.Drawing.Point(33, 110);
            this.apellido1.Name = "apellido1";
            this.apellido1.Size = new System.Drawing.Size(102, 19);
            this.apellido1.TabIndex = 3;
            this.apellido1.Text = "Primer Apellido";
            // 
            // apellido2
            // 
            this.apellido2.AutoSize = true;
            this.apellido2.Location = new System.Drawing.Point(33, 144);
            this.apellido2.Name = "apellido2";
            this.apellido2.Size = new System.Drawing.Size(114, 19);
            this.apellido2.TabIndex = 4;
            this.apellido2.Text = "Segundo Apellido";
            this.apellido2.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // fechaNac
            // 
            this.fechaNac.AutoSize = true;
            this.fechaNac.Location = new System.Drawing.Point(33, 180);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(114, 19);
            this.fechaNac.TabIndex = 5;
            this.fechaNac.Text = "Fecha Nacimiento";
            this.fechaNac.Click += new System.EventHandler(this.metroLabel1_Click_1);
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.Location = new System.Drawing.Point(33, 221);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(63, 19);
            this.direccion.TabIndex = 6;
            this.direccion.Text = "Dirección";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(160, 67);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(155, 23);
            this.metroTextBox1.TabIndex = 7;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(160, 110);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(155, 23);
            this.metroTextBox2.TabIndex = 8;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(160, 144);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(155, 23);
            this.metroTextBox3.TabIndex = 9;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox5
            // 
            // 
            // 
            // 
            this.metroTextBox5.CustomButton.Image = null;
            this.metroTextBox5.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.metroTextBox5.CustomButton.Name = "";
            this.metroTextBox5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.CustomButton.TabIndex = 1;
            this.metroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.CustomButton.UseSelectable = true;
            this.metroTextBox5.CustomButton.Visible = false;
            this.metroTextBox5.Lines = new string[0];
            this.metroTextBox5.Location = new System.Drawing.Point(160, 217);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '\0';
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.SelectionLength = 0;
            this.metroTextBox5.SelectionStart = 0;
            this.metroTextBox5.ShortcutsEnabled = true;
            this.metroTextBox5.Size = new System.Drawing.Size(155, 23);
            this.metroTextBox5.TabIndex = 11;
            this.metroTextBox5.UseSelectable = true;
            this.metroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(160, 180);
            this.fecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(155, 29);
            this.fecha.TabIndex = 12;
            // 
            // telef
            // 
            this.telef.AutoSize = true;
            this.telef.Location = new System.Drawing.Point(425, 26);
            this.telef.Name = "telef";
            this.telef.Size = new System.Drawing.Size(58, 19);
            this.telef.TabIndex = 13;
            this.telef.Text = "Teléfono";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(425, 67);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(47, 19);
            this.email.TabIndex = 14;
            this.email.Text = "E-mail";
            // 
            // genero
            // 
            this.genero.AutoSize = true;
            this.genero.Location = new System.Drawing.Point(425, 110);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(52, 19);
            this.genero.TabIndex = 15;
            this.genero.Text = "Género";
            this.genero.Click += new System.EventHandler(this.metroLabel1_Click_2);
            // 
            // fem
            // 
            this.fem.AutoSize = true;
            this.fem.Location = new System.Drawing.Point(505, 117);
            this.fem.Name = "fem";
            this.fem.Size = new System.Drawing.Size(76, 15);
            this.fem.TabIndex = 16;
            this.fem.Text = "Femenino";
            this.fem.UseSelectable = true;
            // 
            // masc
            // 
            this.masc.AutoSize = true;
            this.masc.Location = new System.Drawing.Point(505, 138);
            this.masc.Name = "masc";
            this.masc.Size = new System.Drawing.Size(78, 15);
            this.masc.TabIndex = 17;
            this.masc.Text = "Masculino";
            this.masc.UseSelectable = true;
            // 
            // otroSexo
            // 
            this.otroSexo.AutoSize = true;
            this.otroSexo.Location = new System.Drawing.Point(505, 159);
            this.otroSexo.Name = "otroSexo";
            this.otroSexo.Size = new System.Drawing.Size(47, 15);
            this.otroSexo.TabIndex = 18;
            this.otroSexo.Text = "Otro";
            this.otroSexo.UseSelectable = true;
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(425, 180);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(53, 19);
            this.usuario.TabIndex = 19;
            this.usuario.Text = "Usuario";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(425, 221);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(75, 19);
            this.pass.TabIndex = 15;
            this.pass.Text = "Contraseña";
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(505, 176);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(155, 23);
            this.metroTextBox4.TabIndex = 20;
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox6
            // 
            // 
            // 
            // 
            this.metroTextBox6.CustomButton.Image = null;
            this.metroTextBox6.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.metroTextBox6.CustomButton.Name = "";
            this.metroTextBox6.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox6.CustomButton.TabIndex = 1;
            this.metroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox6.CustomButton.UseSelectable = true;
            this.metroTextBox6.CustomButton.Visible = false;
            this.metroTextBox6.Lines = new string[0];
            this.metroTextBox6.Location = new System.Drawing.Point(505, 217);
            this.metroTextBox6.MaxLength = 32767;
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.PasswordChar = '*';
            this.metroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox6.SelectedText = "";
            this.metroTextBox6.SelectionLength = 0;
            this.metroTextBox6.SelectionStart = 0;
            this.metroTextBox6.ShortcutsEnabled = true;
            this.metroTextBox6.Size = new System.Drawing.Size(155, 23);
            this.metroTextBox6.TabIndex = 21;
            this.metroTextBox6.UseSelectable = true;
            this.metroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox7
            // 
            // 
            // 
            // 
            this.metroTextBox7.CustomButton.Image = null;
            this.metroTextBox7.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.metroTextBox7.CustomButton.Name = "";
            this.metroTextBox7.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox7.CustomButton.TabIndex = 1;
            this.metroTextBox7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox7.CustomButton.UseSelectable = true;
            this.metroTextBox7.CustomButton.Visible = false;
            this.metroTextBox7.Lines = new string[0];
            this.metroTextBox7.Location = new System.Drawing.Point(505, 67);
            this.metroTextBox7.MaxLength = 32767;
            this.metroTextBox7.Name = "metroTextBox7";
            this.metroTextBox7.PasswordChar = '\0';
            this.metroTextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox7.SelectedText = "";
            this.metroTextBox7.SelectionLength = 0;
            this.metroTextBox7.SelectionStart = 0;
            this.metroTextBox7.ShortcutsEnabled = true;
            this.metroTextBox7.Size = new System.Drawing.Size(155, 23);
            this.metroTextBox7.TabIndex = 22;
            this.metroTextBox7.UseSelectable = true;
            this.metroTextBox7.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox7.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox8
            // 
            // 
            // 
            // 
            this.metroTextBox8.CustomButton.Image = null;
            this.metroTextBox8.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.metroTextBox8.CustomButton.Name = "";
            this.metroTextBox8.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox8.CustomButton.TabIndex = 1;
            this.metroTextBox8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox8.CustomButton.UseSelectable = true;
            this.metroTextBox8.CustomButton.Visible = false;
            this.metroTextBox8.Lines = new string[0];
            this.metroTextBox8.Location = new System.Drawing.Point(505, 22);
            this.metroTextBox8.MaxLength = 32767;
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.PasswordChar = '\0';
            this.metroTextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox8.SelectedText = "";
            this.metroTextBox8.SelectionLength = 0;
            this.metroTextBox8.SelectionStart = 0;
            this.metroTextBox8.ShortcutsEnabled = true;
            this.metroTextBox8.Size = new System.Drawing.Size(155, 23);
            this.metroTextBox8.TabIndex = 23;
            this.metroTextBox8.UseSelectable = true;
            this.metroTextBox8.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox8.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(313, 262);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(108, 23);
            this.guardar.TabIndex = 24;
            this.guardar.Text = "Guardar";
            this.guardar.UseSelectable = true;
            // 
            // AgregarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.circulo);
            this.Controls.Add(this.elimEst);
            this.Controls.Add(this.IrAlistaEst);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "AgregarEstudiante";
            this.Text = "Agregar Estudiante";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circulo)).EndInit();
            this.datos.ResumeLayout(false);
            this.datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink IrAlistaEst;
        private MetroFramework.Controls.MetroLink elimEst;
        private System.Windows.Forms.PictureBox circulo;
        private System.Windows.Forms.GroupBox datos;
        private MetroFramework.Controls.MetroLabel apellido2;
        private MetroFramework.Controls.MetroLabel apellido1;
        private MetroFramework.Controls.MetroLabel nombre;
        private MetroFramework.Controls.MetroTextBox idField;
        private MetroFramework.Controls.MetroLabel cedula;
        private MetroFramework.Controls.MetroLabel fechaNac;
        private MetroFramework.Controls.MetroDateTime fecha;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel direccion;
        private MetroFramework.Controls.MetroLabel genero;
        private MetroFramework.Controls.MetroLabel email;
        private MetroFramework.Controls.MetroLabel telef;
        private MetroFramework.Controls.MetroRadioButton otroSexo;
        private MetroFramework.Controls.MetroRadioButton masc;
        private MetroFramework.Controls.MetroRadioButton fem;
        private MetroFramework.Controls.MetroButton guardar;
        private MetroFramework.Controls.MetroTextBox metroTextBox8;
        private MetroFramework.Controls.MetroTextBox metroTextBox7;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroLabel pass;
        private MetroFramework.Controls.MetroLabel usuario;
    }
}

