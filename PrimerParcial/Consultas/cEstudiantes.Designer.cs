namespace PrimerParcial.Consultas
{
    partial class cEstudiantes
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
            this.EstudinatesdataGridView = new System.Windows.Forms.DataGridView();
            this.DatoscomboBox = new System.Windows.Forms.ComboBox();
            this.FiltrartextBox = new System.Windows.Forms.TextBox();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EstudinatesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EstudinatesdataGridView
            // 
            this.EstudinatesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudinatesdataGridView.Location = new System.Drawing.Point(12, 82);
            this.EstudinatesdataGridView.Name = "EstudinatesdataGridView";
            this.EstudinatesdataGridView.Size = new System.Drawing.Size(357, 135);
            this.EstudinatesdataGridView.TabIndex = 0;
            // 
            // DatoscomboBox
            // 
            this.DatoscomboBox.FormattingEnabled = true;
            this.DatoscomboBox.Items.AddRange(new object[] {
            "EstudianteId",
            "Nombre",
            "Edad",
            "Carrera"});
            this.DatoscomboBox.Location = new System.Drawing.Point(13, 55);
            this.DatoscomboBox.Name = "DatoscomboBox";
            this.DatoscomboBox.Size = new System.Drawing.Size(121, 21);
            this.DatoscomboBox.TabIndex = 1;
            // 
            // FiltrartextBox
            // 
            this.FiltrartextBox.Location = new System.Drawing.Point(183, 55);
            this.FiltrartextBox.Name = "FiltrartextBox";
            this.FiltrartextBox.Size = new System.Drawing.Size(100, 20);
            this.FiltrartextBox.TabIndex = 2;
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Location = new System.Drawing.Point(294, 53);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 23);
            this.Imprimirbutton.TabIndex = 3;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtrar por";
            // 
            // cEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 259);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.FiltrartextBox);
            this.Controls.Add(this.DatoscomboBox);
            this.Controls.Add(this.EstudinatesdataGridView);
            this.Name = "cEstudiantes";
            this.Text = "cEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.EstudinatesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EstudinatesdataGridView;
        private System.Windows.Forms.ComboBox DatoscomboBox;
        private System.Windows.Forms.TextBox FiltrartextBox;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}