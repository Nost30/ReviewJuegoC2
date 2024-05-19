using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReviewsJuegos
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.ComboBoxJuego = new System.Windows.Forms.ComboBox();
            this.TxtJuego = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnRefrescar = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.BtnAgregarPlata = new System.Windows.Forms.Button();
            this.BtnAgDesarrolladora = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(48, 165);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 25;
            this.DataGridView1.Size = new System.Drawing.Size(467, 184);
            this.DataGridView1.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(48, 395);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(440, 122);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // ComboBoxJuego
            // 
            this.ComboBoxJuego.FormattingEnabled = true;
            this.ComboBoxJuego.Location = new System.Drawing.Point(238, 122);
            this.ComboBoxJuego.Name = "ComboBoxJuego";
            this.ComboBoxJuego.Size = new System.Drawing.Size(187, 23);
            this.ComboBoxJuego.TabIndex = 5;
            this.ComboBoxJuego.SelectedIndexChanged += new System.EventHandler(this.ComboBoxJuego_SelectedIndexChanged);
            // 
            // TxtJuego
            // 
            this.TxtJuego.Location = new System.Drawing.Point(112, 122);
            this.TxtJuego.Name = "TxtJuego";
            this.TxtJuego.Size = new System.Drawing.Size(110, 23);
            this.TxtJuego.TabIndex = 6;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(48, 367);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(154, 15);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "¿Deseas agregar otro juego?";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(48, 27);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(187, 67);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 8;
            this.PictureBox1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(432, 367);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(83, 15);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Eliminar juego";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(440, 395);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 10;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.btnEliminarJuego_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(48, 122);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(41, 23);
            this.TxtId.TabIndex = 11;
            this.TxtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(48, 439);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(151, 15);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "¿Desea actualizar los datos?";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(48, 457);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 13;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.Location = new System.Drawing.Point(440, 45);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.BtnRefrescar.TabIndex = 14;
            this.BtnRefrescar.Text = "Refrescar";
            this.BtnRefrescar.UseVisualStyleBackColor = true;
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(595, 165);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 44);
            this.Button1.TabIndex = 15;
            this.Button1.Text = "Agregar genero";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnAgregarPlata
            // 
            this.BtnAgregarPlata.Location = new System.Drawing.Point(595, 215);
            this.BtnAgregarPlata.Name = "BtnAgregarPlata";
            this.BtnAgregarPlata.Size = new System.Drawing.Size(75, 40);
            this.BtnAgregarPlata.TabIndex = 16;
            this.BtnAgregarPlata.Text = "Agregar plataforma";
            this.BtnAgregarPlata.UseVisualStyleBackColor = true;
            this.BtnAgregarPlata.Click += new System.EventHandler(this.BtnAgregarPlata_Click);
            // 
            // BtnAgDesarrolladora
            // 
            this.BtnAgDesarrolladora.Location = new System.Drawing.Point(579, 261);
            this.BtnAgDesarrolladora.Name = "BtnAgDesarrolladora";
            this.BtnAgDesarrolladora.Size = new System.Drawing.Size(91, 60);
            this.BtnAgDesarrolladora.TabIndex = 17;
            this.BtnAgDesarrolladora.Text = "Agregar Desarrolladora";
            this.BtnAgDesarrolladora.UseVisualStyleBackColor = true;
            this.BtnAgDesarrolladora.Click += new System.EventHandler(this.BtnAgDesarrolladora_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(691, 516);
            this.Controls.Add(this.BtnAgDesarrolladora);
            this.Controls.Add(this.BtnAgregarPlata);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.BtnRefrescar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtJuego);
            this.Controls.Add(this.ComboBoxJuego);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal DataGridView DataGridView1;
        internal Button BtnAgregar;
        internal Button BtnBuscar;
        internal ComboBox ComboBoxJuego;
        internal TextBox TxtJuego;
        internal Label Label1;
        internal PictureBox PictureBox1;
        internal Label Label2;
        internal Button BtnEliminar;
        internal TextBox TxtId;
        internal Label Label3;
        internal Button BtnActualizar;
        internal Button BtnRefrescar;
        internal Button Button1;
        internal Button BtnAgregarPlata;
        internal Button BtnAgDesarrolladora;
    }
}