namespace listasCirculares
{
    partial class Form1
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
            this.BASE = new System.Windows.Forms.TextBox();
            this.MINUTOS = new System.Windows.Forms.TextBox();
            this.ReporteBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AGREGAR = new System.Windows.Forms.Button();
            this.REPORTE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.agregarINICIO = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.eliminarUltimo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.seleccionBase = new System.Windows.Forms.TextBox();
            this.baseDespues = new System.Windows.Forms.Label();
            this.horaInicio = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.horaFin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BASE
            // 
            this.BASE.Location = new System.Drawing.Point(84, 60);
            this.BASE.Name = "BASE";
            this.BASE.Size = new System.Drawing.Size(100, 20);
            this.BASE.TabIndex = 0;
            // 
            // MINUTOS
            // 
            this.MINUTOS.Location = new System.Drawing.Point(210, 60);
            this.MINUTOS.Name = "MINUTOS";
            this.MINUTOS.Size = new System.Drawing.Size(100, 20);
            this.MINUTOS.TabIndex = 1;
            // 
            // ReporteBox
            // 
            this.ReporteBox.Location = new System.Drawing.Point(84, 200);
            this.ReporteBox.Multiline = true;
            this.ReporteBox.Name = "ReporteBox";
            this.ReporteBox.Size = new System.Drawing.Size(487, 92);
            this.ReporteBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BASE ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MINUTOS";
            // 
            // AGREGAR
            // 
            this.AGREGAR.Location = new System.Drawing.Point(316, 56);
            this.AGREGAR.Name = "AGREGAR";
            this.AGREGAR.Size = new System.Drawing.Size(104, 24);
            this.AGREGAR.TabIndex = 5;
            this.AGREGAR.Text = "AGREGAR BASE";
            this.AGREGAR.UseVisualStyleBackColor = true;
            this.AGREGAR.Click += new System.EventHandler(this.AGREGAR_Click);
            // 
            // REPORTE
            // 
            this.REPORTE.Location = new System.Drawing.Point(251, 319);
            this.REPORTE.Name = "REPORTE";
            this.REPORTE.Size = new System.Drawing.Size(136, 24);
            this.REPORTE.TabIndex = 6;
            this.REPORTE.Text = "REPORTE RUTAS";
            this.REPORTE.UseVisualStyleBackColor = true;
            this.REPORTE.Click += new System.EventHandler(this.REPORTE_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "BUSCAR BASE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // agregarINICIO
            // 
            this.agregarINICIO.Location = new System.Drawing.Point(316, 86);
            this.agregarINICIO.Name = "agregarINICIO";
            this.agregarINICIO.Size = new System.Drawing.Size(104, 24);
            this.agregarINICIO.TabIndex = 8;
            this.agregarINICIO.Text = "AGREGAR INICIO";
            this.agregarINICIO.UseVisualStyleBackColor = true;
            this.agregarINICIO.Click += new System.EventHandler(this.agregarINICIO_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "ELIMINAR (BASE)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // eliminarUltimo
            // 
            this.eliminarUltimo.Location = new System.Drawing.Point(455, 86);
            this.eliminarUltimo.Name = "eliminarUltimo";
            this.eliminarUltimo.Size = new System.Drawing.Size(116, 24);
            this.eliminarUltimo.TabIndex = 10;
            this.eliminarUltimo.Text = "ELIMINAR ULTIMO";
            this.eliminarUltimo.UseVisualStyleBackColor = true;
            this.eliminarUltimo.Click += new System.EventHandler(this.eliminarUltimo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(316, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 24);
            this.button3.TabIndex = 11;
            this.button3.Text = "INSERTAR DESPUES";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // seleccionBase
            // 
            this.seleccionBase.Location = new System.Drawing.Point(471, 174);
            this.seleccionBase.Name = "seleccionBase";
            this.seleccionBase.Size = new System.Drawing.Size(100, 20);
            this.seleccionBase.TabIndex = 12;
            // 
            // baseDespues
            // 
            this.baseDespues.AutoSize = true;
            this.baseDespues.Location = new System.Drawing.Point(468, 151);
            this.baseDespues.Name = "baseDespues";
            this.baseDespues.Size = new System.Drawing.Size(105, 13);
            this.baseDespues.TabIndex = 13;
            this.baseDespues.Text = "SELECCIONA BASE";
            // 
            // horaInicio
            // 
            this.horaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaInicio.Location = new System.Drawing.Point(28, 323);
            this.horaInicio.Name = "horaInicio";
            this.horaInicio.ShowUpDown = true;
            this.horaInicio.Size = new System.Drawing.Size(200, 20);
            this.horaInicio.TabIndex = 14;
            this.horaInicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(457, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 24);
            this.button4.TabIndex = 15;
            this.button4.Text = "ELIMINAR INICIO";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(251, 358);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 24);
            this.button5.TabIndex = 16;
            this.button5.Text = "RECORRIDO RUTAS";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // horaFin
            // 
            this.horaFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaFin.Location = new System.Drawing.Point(28, 362);
            this.horaFin.Name = "horaFin";
            this.horaFin.ShowUpDown = true;
            this.horaFin.Size = new System.Drawing.Size(200, 20);
            this.horaFin.TabIndex = 17;
            this.horaFin.ValueChanged += new System.EventHandler(this.horaFin_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 474);
            this.Controls.Add(this.horaFin);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.horaInicio);
            this.Controls.Add(this.baseDespues);
            this.Controls.Add(this.seleccionBase);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.eliminarUltimo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.agregarINICIO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.REPORTE);
            this.Controls.Add(this.AGREGAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReporteBox);
            this.Controls.Add(this.MINUTOS);
            this.Controls.Add(this.BASE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BASE;
        private System.Windows.Forms.TextBox MINUTOS;
        private System.Windows.Forms.TextBox ReporteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AGREGAR;
        private System.Windows.Forms.Button REPORTE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button agregarINICIO;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button eliminarUltimo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox seleccionBase;
        private System.Windows.Forms.Label baseDespues;
        private System.Windows.Forms.DateTimePicker horaInicio;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker horaFin;
    }
}

