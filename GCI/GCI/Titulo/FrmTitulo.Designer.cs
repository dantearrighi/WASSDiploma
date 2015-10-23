namespace GCI
{
    partial class FrmTitulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTitulo));
            this.tabs_titulos = new System.Windows.Forms.TabControl();
            this.tab_datos = new System.Windows.Forms.TabPage();
            this.cmb_universidad = new System.Windows.Forms.ComboBox();
            this.txt_aprobacioncie = new System.Windows.Forms.TextBox();
            this.lb_aprobacioncie = new System.Windows.Forms.Label();
            this.txt_terminovalidez = new System.Windows.Forms.TextBox();
            this.lb_termino = new System.Windows.Forms.Label();
            this.cmb_nivel = new System.Windows.Forms.ComboBox();
            this.cmb_modalidad = new System.Windows.Forms.ComboBox();
            this.cmb_jurisdiccion = new System.Windows.Forms.ComboBox();
            this.lb_nivel = new System.Windows.Forms.Label();
            this.lb_modalidad = new System.Windows.Forms.Label();
            this.lb_jurisdiccion = new System.Windows.Forms.Label();
            this.txt_coneau = new System.Windows.Forms.TextBox();
            this.lb_coneau = new System.Windows.Forms.Label();
            this.cmb_especialidades = new System.Windows.Forms.ComboBox();
            this.txt_leyaprobacion = new System.Windows.Forms.TextBox();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.lb_especialidad = new System.Windows.Forms.Label();
            this.lb_universidad = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lb_ley = new System.Windows.Forms.Label();
            this.tab_planes = new System.Windows.Forms.TabPage();
            this.grp_acciones = new System.Windows.Forms.GroupBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.lb_planes = new System.Windows.Forms.Label();
            this.dgv_planes = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.tabs_titulos.SuspendLayout();
            this.tab_datos.SuspendLayout();
            this.tab_planes.SuspendLayout();
            this.grp_acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_planes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs_titulos
            // 
            this.tabs_titulos.Controls.Add(this.tab_datos);
            this.tabs_titulos.Controls.Add(this.tab_planes);
            this.tabs_titulos.Location = new System.Drawing.Point(13, 13);
            this.tabs_titulos.Name = "tabs_titulos";
            this.tabs_titulos.SelectedIndex = 0;
            this.tabs_titulos.Size = new System.Drawing.Size(542, 311);
            this.tabs_titulos.TabIndex = 0;
            // 
            // tab_datos
            // 
            this.tab_datos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tab_datos.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.tab_datos.Controls.Add(this.cmb_universidad);
            this.tab_datos.Controls.Add(this.txt_aprobacioncie);
            this.tab_datos.Controls.Add(this.lb_aprobacioncie);
            this.tab_datos.Controls.Add(this.txt_terminovalidez);
            this.tab_datos.Controls.Add(this.lb_termino);
            this.tab_datos.Controls.Add(this.cmb_nivel);
            this.tab_datos.Controls.Add(this.cmb_modalidad);
            this.tab_datos.Controls.Add(this.cmb_jurisdiccion);
            this.tab_datos.Controls.Add(this.lb_nivel);
            this.tab_datos.Controls.Add(this.lb_modalidad);
            this.tab_datos.Controls.Add(this.lb_jurisdiccion);
            this.tab_datos.Controls.Add(this.txt_coneau);
            this.tab_datos.Controls.Add(this.lb_coneau);
            this.tab_datos.Controls.Add(this.cmb_especialidades);
            this.tab_datos.Controls.Add(this.txt_leyaprobacion);
            this.tab_datos.Controls.Add(this.txt_titulo);
            this.tab_datos.Controls.Add(this.lb_especialidad);
            this.tab_datos.Controls.Add(this.lb_universidad);
            this.tab_datos.Controls.Add(this.lb_titulo);
            this.tab_datos.Controls.Add(this.lb_ley);
            this.tab_datos.Location = new System.Drawing.Point(4, 22);
            this.tab_datos.Name = "tab_datos";
            this.tab_datos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_datos.Size = new System.Drawing.Size(534, 285);
            this.tab_datos.TabIndex = 0;
            this.tab_datos.Text = "Datos";
            // 
            // cmb_universidad
            // 
            this.cmb_universidad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_universidad.FormattingEnabled = true;
            this.cmb_universidad.Location = new System.Drawing.Point(203, 13);
            this.cmb_universidad.Name = "cmb_universidad";
            this.cmb_universidad.Size = new System.Drawing.Size(315, 21);
            this.cmb_universidad.TabIndex = 41;
            // 
            // txt_aprobacioncie
            // 
            this.txt_aprobacioncie.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_aprobacioncie.Location = new System.Drawing.Point(203, 225);
            this.txt_aprobacioncie.Name = "txt_aprobacioncie";
            this.txt_aprobacioncie.Size = new System.Drawing.Size(315, 20);
            this.txt_aprobacioncie.TabIndex = 39;
            // 
            // lb_aprobacioncie
            // 
            this.lb_aprobacioncie.BackColor = System.Drawing.Color.Transparent;
            this.lb_aprobacioncie.Image = global::GCI.Properties.Resources.checkbox_checked_icon_16;
            this.lb_aprobacioncie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_aprobacioncie.Location = new System.Drawing.Point(11, 217);
            this.lb_aprobacioncie.Name = "lb_aprobacioncie";
            this.lb_aprobacioncie.Size = new System.Drawing.Size(170, 35);
            this.lb_aprobacioncie.TabIndex = 38;
            this.lb_aprobacioncie.Text = "Aprobado por el CIE en:";
            this.lb_aprobacioncie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_terminovalidez
            // 
            this.txt_terminovalidez.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_terminovalidez.Location = new System.Drawing.Point(203, 199);
            this.txt_terminovalidez.Name = "txt_terminovalidez";
            this.txt_terminovalidez.Size = new System.Drawing.Size(315, 20);
            this.txt_terminovalidez.TabIndex = 37;
            // 
            // lb_termino
            // 
            this.lb_termino.BackColor = System.Drawing.Color.Transparent;
            this.lb_termino.Image = ((System.Drawing.Image)(resources.GetObject("lb_termino.Image")));
            this.lb_termino.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_termino.Location = new System.Drawing.Point(11, 191);
            this.lb_termino.Name = "lb_termino";
            this.lb_termino.Size = new System.Drawing.Size(170, 35);
            this.lb_termino.TabIndex = 36;
            this.lb_termino.Text = "Término de la validez:";
            this.lb_termino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_nivel
            // 
            this.cmb_nivel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_nivel.FormattingEnabled = true;
            this.cmb_nivel.Location = new System.Drawing.Point(203, 172);
            this.cmb_nivel.Name = "cmb_nivel";
            this.cmb_nivel.Size = new System.Drawing.Size(315, 21);
            this.cmb_nivel.TabIndex = 35;
            // 
            // cmb_modalidad
            // 
            this.cmb_modalidad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_modalidad.FormattingEnabled = true;
            this.cmb_modalidad.Location = new System.Drawing.Point(203, 145);
            this.cmb_modalidad.Name = "cmb_modalidad";
            this.cmb_modalidad.Size = new System.Drawing.Size(315, 21);
            this.cmb_modalidad.TabIndex = 34;
            // 
            // cmb_jurisdiccion
            // 
            this.cmb_jurisdiccion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_jurisdiccion.FormattingEnabled = true;
            this.cmb_jurisdiccion.Location = new System.Drawing.Point(203, 118);
            this.cmb_jurisdiccion.Name = "cmb_jurisdiccion";
            this.cmb_jurisdiccion.Size = new System.Drawing.Size(315, 21);
            this.cmb_jurisdiccion.TabIndex = 33;
            // 
            // lb_nivel
            // 
            this.lb_nivel.BackColor = System.Drawing.Color.Transparent;
            this.lb_nivel.Image = ((System.Drawing.Image)(resources.GetObject("lb_nivel.Image")));
            this.lb_nivel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nivel.Location = new System.Drawing.Point(11, 164);
            this.lb_nivel.Name = "lb_nivel";
            this.lb_nivel.Size = new System.Drawing.Size(170, 35);
            this.lb_nivel.TabIndex = 32;
            this.lb_nivel.Text = "Nivel:";
            this.lb_nivel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_modalidad
            // 
            this.lb_modalidad.BackColor = System.Drawing.Color.Transparent;
            this.lb_modalidad.Image = ((System.Drawing.Image)(resources.GetObject("lb_modalidad.Image")));
            this.lb_modalidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_modalidad.Location = new System.Drawing.Point(11, 137);
            this.lb_modalidad.Name = "lb_modalidad";
            this.lb_modalidad.Size = new System.Drawing.Size(170, 35);
            this.lb_modalidad.TabIndex = 31;
            this.lb_modalidad.Text = "Modalidad:";
            this.lb_modalidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_jurisdiccion
            // 
            this.lb_jurisdiccion.BackColor = System.Drawing.Color.Transparent;
            this.lb_jurisdiccion.Image = ((System.Drawing.Image)(resources.GetObject("lb_jurisdiccion.Image")));
            this.lb_jurisdiccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_jurisdiccion.Location = new System.Drawing.Point(11, 110);
            this.lb_jurisdiccion.Name = "lb_jurisdiccion";
            this.lb_jurisdiccion.Size = new System.Drawing.Size(170, 35);
            this.lb_jurisdiccion.TabIndex = 29;
            this.lb_jurisdiccion.Text = "Jurisdicción:";
            this.lb_jurisdiccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_coneau
            // 
            this.txt_coneau.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_coneau.Location = new System.Drawing.Point(203, 92);
            this.txt_coneau.Name = "txt_coneau";
            this.txt_coneau.Size = new System.Drawing.Size(315, 20);
            this.txt_coneau.TabIndex = 28;
            // 
            // lb_coneau
            // 
            this.lb_coneau.BackColor = System.Drawing.Color.Transparent;
            this.lb_coneau.Image = ((System.Drawing.Image)(resources.GetObject("lb_coneau.Image")));
            this.lb_coneau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_coneau.Location = new System.Drawing.Point(11, 84);
            this.lb_coneau.Name = "lb_coneau";
            this.lb_coneau.Size = new System.Drawing.Size(170, 35);
            this.lb_coneau.TabIndex = 27;
            this.lb_coneau.Text = "Resolución de CONEAU:";
            this.lb_coneau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_especialidades
            // 
            this.cmb_especialidades.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_especialidades.FormattingEnabled = true;
            this.cmb_especialidades.Location = new System.Drawing.Point(203, 251);
            this.cmb_especialidades.Name = "cmb_especialidades";
            this.cmb_especialidades.Size = new System.Drawing.Size(315, 21);
            this.cmb_especialidades.TabIndex = 26;
            // 
            // txt_leyaprobacion
            // 
            this.txt_leyaprobacion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_leyaprobacion.Location = new System.Drawing.Point(203, 66);
            this.txt_leyaprobacion.Name = "txt_leyaprobacion";
            this.txt_leyaprobacion.Size = new System.Drawing.Size(315, 20);
            this.txt_leyaprobacion.TabIndex = 23;
            // 
            // txt_titulo
            // 
            this.txt_titulo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_titulo.Location = new System.Drawing.Point(203, 40);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(315, 20);
            this.txt_titulo.TabIndex = 22;
            // 
            // lb_especialidad
            // 
            this.lb_especialidad.BackColor = System.Drawing.Color.Transparent;
            this.lb_especialidad.Image = global::GCI.Properties.Resources.box_icon_16;
            this.lb_especialidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_especialidad.Location = new System.Drawing.Point(11, 243);
            this.lb_especialidad.Name = "lb_especialidad";
            this.lb_especialidad.Size = new System.Drawing.Size(170, 35);
            this.lb_especialidad.TabIndex = 20;
            this.lb_especialidad.Text = "Especialidad:";
            this.lb_especialidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_universidad
            // 
            this.lb_universidad.BackColor = System.Drawing.Color.Transparent;
            this.lb_universidad.Image = global::GCI.Properties.Resources.book_icon_16;
            this.lb_universidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_universidad.Location = new System.Drawing.Point(11, 5);
            this.lb_universidad.Name = "lb_universidad";
            this.lb_universidad.Size = new System.Drawing.Size(170, 35);
            this.lb_universidad.TabIndex = 15;
            this.lb_universidad.Text = "Universidad:";
            this.lb_universidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_titulo
            // 
            this.lb_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo.Image = ((System.Drawing.Image)(resources.GetObject("lb_titulo.Image")));
            this.lb_titulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_titulo.Location = new System.Drawing.Point(11, 32);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(170, 35);
            this.lb_titulo.TabIndex = 12;
            this.lb_titulo.Text = "Descripción:";
            this.lb_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_ley
            // 
            this.lb_ley.BackColor = System.Drawing.Color.Transparent;
            this.lb_ley.Image = ((System.Drawing.Image)(resources.GetObject("lb_ley.Image")));
            this.lb_ley.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_ley.Location = new System.Drawing.Point(11, 58);
            this.lb_ley.Name = "lb_ley";
            this.lb_ley.Size = new System.Drawing.Size(170, 35);
            this.lb_ley.TabIndex = 13;
            this.lb_ley.Text = "Ley de aprobación del título";
            this.lb_ley.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tab_planes
            // 
            this.tab_planes.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.tab_planes.Controls.Add(this.grp_acciones);
            this.tab_planes.Controls.Add(this.lb_planes);
            this.tab_planes.Controls.Add(this.dgv_planes);
            this.tab_planes.Location = new System.Drawing.Point(4, 22);
            this.tab_planes.Name = "tab_planes";
            this.tab_planes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_planes.Size = new System.Drawing.Size(534, 285);
            this.tab_planes.TabIndex = 1;
            this.tab_planes.Text = "Planes";
            this.tab_planes.UseVisualStyleBackColor = true;
            // 
            // grp_acciones
            // 
            this.grp_acciones.Controls.Add(this.btn_eliminar);
            this.grp_acciones.Controls.Add(this.btn_agregar);
            this.grp_acciones.Controls.Add(this.btn_modificar);
            this.grp_acciones.Location = new System.Drawing.Point(6, 221);
            this.grp_acciones.Name = "grp_acciones";
            this.grp_acciones.Size = new System.Drawing.Size(502, 58);
            this.grp_acciones.TabIndex = 15;
            this.grp_acciones.TabStop = false;
            this.grp_acciones.Text = "Acciones";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Image = global::GCI.Properties.Resources.doc_delete_icon_16;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(165, 13);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 35);
            this.btn_eliminar.TabIndex = 14;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Image = global::GCI.Properties.Resources.doc_new_icon_16;
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(3, 13);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 35);
            this.btn_agregar.TabIndex = 13;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Image = global::GCI.Properties.Resources.doc_edit_icon_16;
            this.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar.Location = new System.Drawing.Point(84, 13);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 35);
            this.btn_modificar.TabIndex = 12;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // lb_planes
            // 
            this.lb_planes.Image = global::GCI.Properties.Resources.book_icon_16;
            this.lb_planes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_planes.Location = new System.Drawing.Point(6, 0);
            this.lb_planes.Name = "lb_planes";
            this.lb_planes.Size = new System.Drawing.Size(502, 35);
            this.lb_planes.TabIndex = 14;
            this.lb_planes.Text = "Planes del título:";
            this.lb_planes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_planes
            // 
            this.dgv_planes.AllowUserToAddRows = false;
            this.dgv_planes.AllowUserToDeleteRows = false;
            this.dgv_planes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_planes.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_planes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_planes.Location = new System.Drawing.Point(6, 35);
            this.dgv_planes.Name = "dgv_planes";
            this.dgv_planes.ReadOnly = true;
            this.dgv_planes.Size = new System.Drawing.Size(502, 180);
            this.dgv_planes.TabIndex = 13;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::GCI.Properties.Resources.cancel_icon_16;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(476, 330);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::GCI.Properties.Resources.save_icon_16;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(395, 330);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 35);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // FrmTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GCI.Properties.Resources.Fondo_Final;
            this.ClientSize = new System.Drawing.Size(569, 377);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.tabs_titulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTitulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Título";
            this.Load += new System.EventHandler(this.FrmTitulo_Load);
            this.tabs_titulos.ResumeLayout(false);
            this.tab_datos.ResumeLayout(false);
            this.tab_datos.PerformLayout();
            this.tab_planes.ResumeLayout(false);
            this.grp_acciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_planes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs_titulos;
        private System.Windows.Forms.TabPage tab_datos;
        private System.Windows.Forms.ComboBox cmb_especialidades;
        private System.Windows.Forms.TextBox txt_leyaprobacion;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.Label lb_especialidad;
        private System.Windows.Forms.Label lb_universidad;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Label lb_ley;
        private System.Windows.Forms.TextBox txt_aprobacioncie;
        private System.Windows.Forms.Label lb_aprobacioncie;
        private System.Windows.Forms.TextBox txt_terminovalidez;
        private System.Windows.Forms.Label lb_termino;
        private System.Windows.Forms.ComboBox cmb_nivel;
        private System.Windows.Forms.ComboBox cmb_modalidad;
        private System.Windows.Forms.ComboBox cmb_jurisdiccion;
        private System.Windows.Forms.Label lb_nivel;
        private System.Windows.Forms.Label lb_modalidad;
        private System.Windows.Forms.Label lb_jurisdiccion;
        private System.Windows.Forms.TextBox txt_coneau;
        private System.Windows.Forms.Label lb_coneau;
        private System.Windows.Forms.ComboBox cmb_universidad;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TabPage tab_planes;
        private System.Windows.Forms.GroupBox grp_acciones;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label lb_planes;
        private System.Windows.Forms.DataGridView dgv_planes;
        private System.Windows.Forms.Button btn_eliminar;
    }
}