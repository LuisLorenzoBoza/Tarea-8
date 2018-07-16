namespace RegistroLibros.UI.Registros
{
    partial class RegistroLibros
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
            this.components = new System.ComponentModel.Container();
            this.TipocomboBox = new System.Windows.Forms.ComboBox();
            this.Tipolabel = new System.Windows.Forms.Label();
            this.SiglastextBox = new System.Windows.Forms.TextBox();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LibroIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.Siglaslabel = new System.Windows.Forms.Label();
            this.LibroIDlabel = new System.Windows.Forms.Label();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LibroIDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TipocomboBox
            // 
            this.TipocomboBox.FormattingEnabled = true;
            this.TipocomboBox.Location = new System.Drawing.Point(88, 215);
            this.TipocomboBox.Name = "TipocomboBox";
            this.TipocomboBox.Size = new System.Drawing.Size(259, 21);
            this.TipocomboBox.TabIndex = 52;
            // 
            // Tipolabel
            // 
            this.Tipolabel.AutoSize = true;
            this.Tipolabel.Location = new System.Drawing.Point(12, 218);
            this.Tipolabel.Name = "Tipolabel";
            this.Tipolabel.Size = new System.Drawing.Size(28, 13);
            this.Tipolabel.TabIndex = 51;
            this.Tipolabel.Text = "Tipo";
            // 
            // SiglastextBox
            // 
            this.SiglastextBox.Location = new System.Drawing.Point(88, 162);
            this.SiglastextBox.Name = "SiglastextBox";
            this.SiglastextBox.Size = new System.Drawing.Size(259, 20);
            this.SiglastextBox.TabIndex = 50;
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(9, 63);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(37, 13);
            this.Fechalabel.TabIndex = 49;
            this.Fechalabel.Text = "Fecha";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(88, 63);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.FechadateTimePicker.TabIndex = 48;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(88, 99);
            this.DescripciontextBox.Multiline = true;
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(259, 43);
            this.DescripciontextBox.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 47;
            // 
            // LibroIDnumericUpDown
            // 
            this.LibroIDnumericUpDown.Location = new System.Drawing.Point(88, 30);
            this.LibroIDnumericUpDown.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.LibroIDnumericUpDown.Name = "LibroIDnumericUpDown";
            this.LibroIDnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.LibroIDnumericUpDown.TabIndex = 38;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Eliminarbutton.ForeColor = System.Drawing.Color.Yellow;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(396, 194);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(83, 42);
            this.Eliminarbutton.TabIndex = 42;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = false;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackColor = System.Drawing.Color.Green;
            this.Guardarbutton.ForeColor = System.Drawing.Color.Yellow;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(396, 100);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(83, 42);
            this.Guardarbutton.TabIndex = 41;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = false;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Nuevobutton.ForeColor = System.Drawing.Color.Yellow;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(396, 21);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(83, 36);
            this.Nuevobutton.TabIndex = 40;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = false;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.Color.Green;
            this.Buscarbutton.ForeColor = System.Drawing.Color.Yellow;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(272, 21);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 36);
            this.Buscarbutton.TabIndex = 43;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = false;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Location = new System.Drawing.Point(9, 111);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(63, 13);
            this.Descripcionlabel.TabIndex = 45;
            this.Descripcionlabel.Text = "Descripcion";
            // 
            // Siglaslabel
            // 
            this.Siglaslabel.AutoSize = true;
            this.Siglaslabel.Location = new System.Drawing.Point(9, 165);
            this.Siglaslabel.Name = "Siglaslabel";
            this.Siglaslabel.Size = new System.Drawing.Size(35, 13);
            this.Siglaslabel.TabIndex = 46;
            this.Siglaslabel.Text = "Siglas";
            // 
            // LibroIDlabel
            // 
            this.LibroIDlabel.AutoSize = true;
            this.LibroIDlabel.Location = new System.Drawing.Point(9, 30);
            this.LibroIDlabel.Name = "LibroIDlabel";
            this.LibroIDlabel.Size = new System.Drawing.Size(44, 13);
            this.LibroIDlabel.TabIndex = 44;
            this.LibroIDlabel.Text = "Libro ID";
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // RegistroLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(515, 269);
            this.Controls.Add(this.TipocomboBox);
            this.Controls.Add(this.Tipolabel);
            this.Controls.Add(this.SiglastextBox);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LibroIDnumericUpDown);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.Siglaslabel);
            this.Controls.Add(this.LibroIDlabel);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "RegistroLibros";
            this.Text = "RegistroLibros";
            this.Load += new System.EventHandler(this.RegistroLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LibroIDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TipocomboBox;
        private System.Windows.Forms.Label Tipolabel;
        private System.Windows.Forms.TextBox SiglastextBox;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown LibroIDnumericUpDown;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.Label Siglaslabel;
        private System.Windows.Forms.Label LibroIDlabel;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
    }
}