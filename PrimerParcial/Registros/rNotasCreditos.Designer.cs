namespace PrimerParcial.Registros
{
    partial class rNotasCreditos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NotaIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EstudianteIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ObservacionestextBox = new System.Windows.Forms.TextBox();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Consultarbutton = new System.Windows.Forms.Button();
            this.BuscarNotaIdbutton = new System.Windows.Forms.Button();
            this.BuscarEstudianteIdbutton = new System.Windows.Forms.Button();
            this.EstudianteNombretextBox = new System.Windows.Forms.TextBox();
            this.MontoAsignaturanumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PctBecanumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NotaIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoAsignaturanumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBecanumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "EstudianteId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto asignatura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Porciento Beca%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Monto";
            // 
            // NotaIdnumericUpDown
            // 
            this.NotaIdnumericUpDown.Location = new System.Drawing.Point(107, 24);
            this.NotaIdnumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NotaIdnumericUpDown.Name = "NotaIdnumericUpDown";
            this.NotaIdnumericUpDown.Size = new System.Drawing.Size(158, 20);
            this.NotaIdnumericUpDown.TabIndex = 7;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Location = new System.Drawing.Point(107, 62);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(224, 20);
            this.FechadateTimePicker.TabIndex = 8;
            // 
            // EstudianteIdnumericUpDown
            // 
            this.EstudianteIdnumericUpDown.Location = new System.Drawing.Point(107, 94);
            this.EstudianteIdnumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.EstudianteIdnumericUpDown.Name = "EstudianteIdnumericUpDown";
            this.EstudianteIdnumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.EstudianteIdnumericUpDown.TabIndex = 9;
            // 
            // ObservacionestextBox
            // 
            this.ObservacionestextBox.Location = new System.Drawing.Point(107, 233);
            this.ObservacionestextBox.Multiline = true;
            this.ObservacionestextBox.Name = "ObservacionestextBox";
            this.ObservacionestextBox.Size = new System.Drawing.Size(224, 43);
            this.ObservacionestextBox.TabIndex = 10;
            // 
            // MontotextBox
            // 
            this.MontotextBox.Location = new System.Drawing.Point(107, 195);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.ReadOnly = true;
            this.MontotextBox.Size = new System.Drawing.Size(224, 20);
            this.MontotextBox.TabIndex = 11;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(15, 292);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(59, 42);
            this.Nuevobutton.TabIndex = 14;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(107, 292);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(59, 42);
            this.Guardarbutton.TabIndex = 15;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(193, 292);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(59, 42);
            this.Eliminarbutton.TabIndex = 16;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.Location = new System.Drawing.Point(274, 292);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(59, 42);
            this.Consultarbutton.TabIndex = 17;
            this.Consultarbutton.Text = "Consultar";
            this.Consultarbutton.UseVisualStyleBackColor = true;
            this.Consultarbutton.Click += new System.EventHandler(this.Consultarbutton_Click);
            // 
            // BuscarNotaIdbutton
            // 
            this.BuscarNotaIdbutton.Location = new System.Drawing.Point(271, 24);
            this.BuscarNotaIdbutton.Name = "BuscarNotaIdbutton";
            this.BuscarNotaIdbutton.Size = new System.Drawing.Size(60, 23);
            this.BuscarNotaIdbutton.TabIndex = 18;
            this.BuscarNotaIdbutton.Text = "Buscar";
            this.BuscarNotaIdbutton.UseVisualStyleBackColor = true;
            this.BuscarNotaIdbutton.Click += new System.EventHandler(this.BuscarNotaIdbutton_Click);
            // 
            // BuscarEstudianteIdbutton
            // 
            this.BuscarEstudianteIdbutton.Location = new System.Drawing.Point(271, 94);
            this.BuscarEstudianteIdbutton.Name = "BuscarEstudianteIdbutton";
            this.BuscarEstudianteIdbutton.Size = new System.Drawing.Size(60, 20);
            this.BuscarEstudianteIdbutton.TabIndex = 19;
            this.BuscarEstudianteIdbutton.Text = "Buscar";
            this.BuscarEstudianteIdbutton.UseVisualStyleBackColor = true;
            this.BuscarEstudianteIdbutton.Click += new System.EventHandler(this.BuscarEstudianteIdbutton_Click);
            // 
            // EstudianteNombretextBox
            // 
            this.EstudianteNombretextBox.Location = new System.Drawing.Point(164, 93);
            this.EstudianteNombretextBox.Name = "EstudianteNombretextBox";
            this.EstudianteNombretextBox.Size = new System.Drawing.Size(101, 20);
            this.EstudianteNombretextBox.TabIndex = 20;
            // 
            // MontoAsignaturanumericUpDown
            // 
            this.MontoAsignaturanumericUpDown.Location = new System.Drawing.Point(107, 132);
            this.MontoAsignaturanumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MontoAsignaturanumericUpDown.Name = "MontoAsignaturanumericUpDown";
            this.MontoAsignaturanumericUpDown.Size = new System.Drawing.Size(224, 20);
            this.MontoAsignaturanumericUpDown.TabIndex = 21;
            this.MontoAsignaturanumericUpDown.ValueChanged += new System.EventHandler(this.MontoAsignaturanumericUpDown_ValueChanged);
            // 
            // PctBecanumericUpDown
            // 
            this.PctBecanumericUpDown.Location = new System.Drawing.Point(107, 162);
            this.PctBecanumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PctBecanumericUpDown.Name = "PctBecanumericUpDown";
            this.PctBecanumericUpDown.Size = new System.Drawing.Size(224, 20);
            this.PctBecanumericUpDown.TabIndex = 22;
            this.PctBecanumericUpDown.ValueChanged += new System.EventHandler(this.PctBecanumericUpDown_ValueChanged);
            // 
            // rNotasCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 346);
            this.Controls.Add(this.PctBecanumericUpDown);
            this.Controls.Add(this.MontoAsignaturanumericUpDown);
            this.Controls.Add(this.EstudianteNombretextBox);
            this.Controls.Add(this.BuscarEstudianteIdbutton);
            this.Controls.Add(this.BuscarNotaIdbutton);
            this.Controls.Add(this.Consultarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.MontotextBox);
            this.Controls.Add(this.ObservacionestextBox);
            this.Controls.Add(this.EstudianteIdnumericUpDown);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.NotaIdnumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rNotasCreditos";
            this.Text = "Registro de notas de creditos";
            ((System.ComponentModel.ISupportInitialize)(this.NotaIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoAsignaturanumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBecanumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NotaIdnumericUpDown;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.NumericUpDown EstudianteIdnumericUpDown;
        private System.Windows.Forms.TextBox ObservacionestextBox;
        private System.Windows.Forms.TextBox MontotextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Consultarbutton;
        private System.Windows.Forms.Button BuscarNotaIdbutton;
        private System.Windows.Forms.Button BuscarEstudianteIdbutton;
        private System.Windows.Forms.TextBox EstudianteNombretextBox;
        private System.Windows.Forms.NumericUpDown MontoAsignaturanumericUpDown;
        private System.Windows.Forms.NumericUpDown PctBecanumericUpDown;
    }
}