namespace PrimerParcial.Consultas
{
    partial class cNotasCreditos
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
            this.NotasdataGridView = new System.Windows.Forms.DataGridView();
            this.DatoNotacomboBox = new System.Windows.Forms.ComboBox();
            this.ImprimirNotatextBox = new System.Windows.Forms.TextBox();
            this.ImprimirNotabutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NotasdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NotasdataGridView
            // 
            this.NotasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotasdataGridView.Location = new System.Drawing.Point(12, 90);
            this.NotasdataGridView.Name = "NotasdataGridView";
            this.NotasdataGridView.Size = new System.Drawing.Size(410, 136);
            this.NotasdataGridView.TabIndex = 0;
            // 
            // DatoNotacomboBox
            // 
            this.DatoNotacomboBox.FormattingEnabled = true;
            this.DatoNotacomboBox.Items.AddRange(new object[] {
            "NotaId",
            "Fecha",
            "EstudianteId",
            "Observaciones",
            "MontoAsignatura",
            "PctBeca",
            "Monto"});
            this.DatoNotacomboBox.Location = new System.Drawing.Point(12, 63);
            this.DatoNotacomboBox.Name = "DatoNotacomboBox";
            this.DatoNotacomboBox.Size = new System.Drawing.Size(121, 21);
            this.DatoNotacomboBox.TabIndex = 1;
            // 
            // ImprimirNotatextBox
            // 
            this.ImprimirNotatextBox.Location = new System.Drawing.Point(238, 64);
            this.ImprimirNotatextBox.Name = "ImprimirNotatextBox";
            this.ImprimirNotatextBox.Size = new System.Drawing.Size(100, 20);
            this.ImprimirNotatextBox.TabIndex = 2;
            // 
            // ImprimirNotabutton
            // 
            this.ImprimirNotabutton.Location = new System.Drawing.Point(347, 63);
            this.ImprimirNotabutton.Name = "ImprimirNotabutton";
            this.ImprimirNotabutton.Size = new System.Drawing.Size(75, 23);
            this.ImprimirNotabutton.TabIndex = 3;
            this.ImprimirNotabutton.Text = "button1";
            this.ImprimirNotabutton.UseVisualStyleBackColor = true;
            this.ImprimirNotabutton.Click += new System.EventHandler(this.ImprimirNotabutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtrar";
            // 
            // cNotasCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 244);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImprimirNotabutton);
            this.Controls.Add(this.ImprimirNotatextBox);
            this.Controls.Add(this.DatoNotacomboBox);
            this.Controls.Add(this.NotasdataGridView);
            this.Name = "cNotasCreditos";
            this.Text = "cNotasCreditos";
            ((System.ComponentModel.ISupportInitialize)(this.NotasdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NotasdataGridView;
        private System.Windows.Forms.ComboBox DatoNotacomboBox;
        private System.Windows.Forms.TextBox ImprimirNotatextBox;
        private System.Windows.Forms.Button ImprimirNotabutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}