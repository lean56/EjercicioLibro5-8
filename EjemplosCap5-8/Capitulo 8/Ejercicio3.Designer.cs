namespace EjemplosCap5_8.Capitulo_8
{
    partial class Ejercicio3
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
            this.Fechabutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Fechabutton
            // 
            this.Fechabutton.Location = new System.Drawing.Point(85, 118);
            this.Fechabutton.Name = "Fechabutton";
            this.Fechabutton.Size = new System.Drawing.Size(95, 23);
            this.Fechabutton.TabIndex = 0;
            this.Fechabutton.Text = "Generar Fecha";
            this.Fechabutton.UseVisualStyleBackColor = true;
            this.Fechabutton.Click += new System.EventHandler(this.Fechabutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "La Fecha es:";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Location = new System.Drawing.Point(95, 73);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(0, 13);
            this.fecha.TabIndex = 2;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 194);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fechabutton);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Fechabutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fecha;
    }
}