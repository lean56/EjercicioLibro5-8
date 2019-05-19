namespace EjemplosCap5_8.Capitulo_5
{
    partial class Ejercicio4
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
            this.NEnterotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FactorialtextBox = new System.Windows.Forms.TextBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un Numero Entero";
            // 
            // NEnterotextBox
            // 
            this.NEnterotextBox.Location = new System.Drawing.Point(149, 32);
            this.NEnterotextBox.Name = "NEnterotextBox";
            this.NEnterotextBox.Size = new System.Drawing.Size(52, 20);
            this.NEnterotextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "El Factorial Es";
            // 
            // FactorialtextBox
            // 
            this.FactorialtextBox.Location = new System.Drawing.Point(149, 73);
            this.FactorialtextBox.Name = "FactorialtextBox";
            this.FactorialtextBox.Size = new System.Drawing.Size(52, 20);
            this.FactorialtextBox.TabIndex = 4;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(68, 122);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton.TabIndex = 6;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 157);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.FactorialtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NEnterotextBox);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NEnterotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FactorialtextBox;
        private System.Windows.Forms.Button Calcularbutton;
    }
}