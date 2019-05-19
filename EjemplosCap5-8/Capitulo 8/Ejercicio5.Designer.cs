namespace EjemplosCap5_8.Capitulo_8
{
    partial class Ejercicio5
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
            this.Cadena1textBox = new System.Windows.Forms.TextBox();
            this.Cadena2textBox = new System.Windows.Forms.TextBox();
            this.ComparaciontextBox = new System.Windows.Forms.TextBox();
            this.Compararbutton = new System.Windows.Forms.Button();
            this.Comparacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadena 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cadena 2";
            // 
            // Cadena1textBox
            // 
            this.Cadena1textBox.Location = new System.Drawing.Point(88, 29);
            this.Cadena1textBox.Name = "Cadena1textBox";
            this.Cadena1textBox.Size = new System.Drawing.Size(100, 20);
            this.Cadena1textBox.TabIndex = 2;
            // 
            // Cadena2textBox
            // 
            this.Cadena2textBox.Location = new System.Drawing.Point(88, 69);
            this.Cadena2textBox.Name = "Cadena2textBox";
            this.Cadena2textBox.Size = new System.Drawing.Size(100, 20);
            this.Cadena2textBox.TabIndex = 3;
            // 
            // ComparaciontextBox
            // 
            this.ComparaciontextBox.Location = new System.Drawing.Point(88, 113);
            this.ComparaciontextBox.Name = "ComparaciontextBox";
            this.ComparaciontextBox.Size = new System.Drawing.Size(100, 20);
            this.ComparaciontextBox.TabIndex = 4;
            // 
            // Compararbutton
            // 
            this.Compararbutton.Location = new System.Drawing.Point(88, 162);
            this.Compararbutton.Name = "Compararbutton";
            this.Compararbutton.Size = new System.Drawing.Size(75, 23);
            this.Compararbutton.TabIndex = 5;
            this.Compararbutton.Text = "Comparar";
            this.Compararbutton.UseVisualStyleBackColor = true;
            this.Compararbutton.Click += new System.EventHandler(this.Compararbutton_Click);
            // 
            // Comparacion
            // 
            this.Comparacion.AutoSize = true;
            this.Comparacion.Location = new System.Drawing.Point(15, 120);
            this.Comparacion.Name = "Comparacion";
            this.Comparacion.Size = new System.Drawing.Size(69, 13);
            this.Comparacion.TabIndex = 6;
            this.Comparacion.Text = "Comparacion";
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 223);
            this.Controls.Add(this.Comparacion);
            this.Controls.Add(this.Compararbutton);
            this.Controls.Add(this.ComparaciontextBox);
            this.Controls.Add(this.Cadena2textBox);
            this.Controls.Add(this.Cadena1textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cadena1textBox;
        private System.Windows.Forms.TextBox Cadena2textBox;
        private System.Windows.Forms.TextBox ComparaciontextBox;
        private System.Windows.Forms.Button Compararbutton;
        private System.Windows.Forms.Label Comparacion;
    }
}