namespace RegistroLibros.UI.Consultas
{
    partial class ConsultaLibros
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
            this.Buscatbutton = new System.Windows.Forms.Button();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Hastalabel = new System.Windows.Forms.Label();
            this.Desdelabel = new System.Windows.Forms.Label();
            this.Rangolabel = new System.Windows.Forms.Label();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.Criteriolabel = new System.Windows.Forms.Label();
            this.Filtrolabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Buscatbutton
            // 
            this.Buscatbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscatbutton.Location = new System.Drawing.Point(620, 30);
            this.Buscatbutton.Name = "Buscatbutton";
            this.Buscatbutton.Size = new System.Drawing.Size(71, 58);
            this.Buscatbutton.TabIndex = 23;
            this.Buscatbutton.Text = "Buscar";
            this.Buscatbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscatbutton.UseVisualStyleBackColor = true;
            this.Buscatbutton.Click += new System.EventHandler(this.Buscatbutton_Click);
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(29, 109);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.Size = new System.Drawing.Size(660, 255);
            this.ConsultadataGridView.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HastadateTimePicker);
            this.panel1.Controls.Add(this.DesdedateTimePicker);
            this.panel1.Controls.Add(this.Hastalabel);
            this.panel1.Controls.Add(this.Desdelabel);
            this.panel1.Location = new System.Drawing.Point(190, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 41);
            this.panel1.TabIndex = 21;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(238, 12);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(148, 20);
            this.HastadateTimePicker.TabIndex = 3;
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(60, 11);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(131, 20);
            this.DesdedateTimePicker.TabIndex = 2;
            // 
            // Hastalabel
            // 
            this.Hastalabel.AutoSize = true;
            this.Hastalabel.Location = new System.Drawing.Point(197, 13);
            this.Hastalabel.Name = "Hastalabel";
            this.Hastalabel.Size = new System.Drawing.Size(35, 13);
            this.Hastalabel.TabIndex = 1;
            this.Hastalabel.Text = "Hasta";
            // 
            // Desdelabel
            // 
            this.Desdelabel.AutoSize = true;
            this.Desdelabel.Location = new System.Drawing.Point(16, 13);
            this.Desdelabel.Name = "Desdelabel";
            this.Desdelabel.Size = new System.Drawing.Size(38, 13);
            this.Desdelabel.TabIndex = 0;
            this.Desdelabel.Text = "Desde";
            // 
            // Rangolabel
            // 
            this.Rangolabel.AutoSize = true;
            this.Rangolabel.Location = new System.Drawing.Point(36, 79);
            this.Rangolabel.Name = "Rangolabel";
            this.Rangolabel.Size = new System.Drawing.Size(148, 13);
            this.Rangolabel.TabIndex = 20;
            this.Rangolabel.Text = "Filtrando por Rango de Fecha";
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimirbutton.Location = new System.Drawing.Point(29, 381);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(89, 48);
            this.Imprimirbutton.TabIndex = 19;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CriteriotextBox);
            this.groupBox1.Controls.Add(this.FiltrocomboBox);
            this.groupBox1.Controls.Add(this.Criteriolabel);
            this.groupBox1.Controls.Add(this.Filtrolabel);
            this.groupBox1.Location = new System.Drawing.Point(29, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 46);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(278, 17);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(292, 20);
            this.CriteriotextBox.TabIndex = 3;
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Location = new System.Drawing.Point(60, 14);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(155, 21);
            this.FiltrocomboBox.TabIndex = 2;
            this.FiltrocomboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrocomboBox_SelectedIndexChanged);
            // 
            // Criteriolabel
            // 
            this.Criteriolabel.AutoSize = true;
            this.Criteriolabel.Location = new System.Drawing.Point(233, 20);
            this.Criteriolabel.Name = "Criteriolabel";
            this.Criteriolabel.Size = new System.Drawing.Size(39, 13);
            this.Criteriolabel.TabIndex = 1;
            this.Criteriolabel.Text = "Criterio";
            // 
            // Filtrolabel
            // 
            this.Filtrolabel.AutoSize = true;
            this.Filtrolabel.Location = new System.Drawing.Point(7, 20);
            this.Filtrolabel.Name = "Filtrolabel";
            this.Filtrolabel.Size = new System.Drawing.Size(29, 13);
            this.Filtrolabel.TabIndex = 0;
            this.Filtrolabel.Text = "Filtro";
            // 
            // ConsultaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 438);
            this.Controls.Add(this.Buscatbutton);
            this.Controls.Add(this.ConsultadataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Rangolabel);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultaLibros";
            this.Text = "ConsultaLibros";
            this.Load += new System.EventHandler(this.ConsultaLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscatbutton;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label Hastalabel;
        private System.Windows.Forms.Label Desdelabel;
        private System.Windows.Forms.Label Rangolabel;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Label Criteriolabel;
        private System.Windows.Forms.Label Filtrolabel;
    }
}