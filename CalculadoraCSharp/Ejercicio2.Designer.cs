namespace CalculadoraCSharp
{
    partial class Ejercicio2
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
            this.btnFrase1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFrase2 = new System.Windows.Forms.Button();
            this.btnFrase3 = new System.Windows.Forms.Button();
            this.btnFrase4 = new System.Windows.Forms.Button();
            this.btnFrase5 = new System.Windows.Forms.Button();
            this.btnUnir = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFrase1
            // 
            this.btnFrase1.Location = new System.Drawing.Point(25, 73);
            this.btnFrase1.Name = "btnFrase1";
            this.btnFrase1.Size = new System.Drawing.Size(75, 23);
            this.btnFrase1.TabIndex = 0;
            this.btnFrase1.Text = "Frase 1";
            this.btnFrase1.UseVisualStyleBackColor = true;
            this.btnFrase1.Click += new System.EventHandler(this.btnFrase1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 23);
            this.textBox1.TabIndex = 1;
            // 
            // btnFrase2
            // 
            this.btnFrase2.Enabled = false;
            this.btnFrase2.Location = new System.Drawing.Point(120, 73);
            this.btnFrase2.Name = "btnFrase2";
            this.btnFrase2.Size = new System.Drawing.Size(75, 23);
            this.btnFrase2.TabIndex = 2;
            this.btnFrase2.Text = "Frase 2";
            this.btnFrase2.UseVisualStyleBackColor = true;
            this.btnFrase2.Click += new System.EventHandler(this.btnFrase2_Click);
            // 
            // btnFrase3
            // 
            this.btnFrase3.Enabled = false;
            this.btnFrase3.Location = new System.Drawing.Point(214, 73);
            this.btnFrase3.Name = "btnFrase3";
            this.btnFrase3.Size = new System.Drawing.Size(75, 23);
            this.btnFrase3.TabIndex = 3;
            this.btnFrase3.Text = "Frase 3";
            this.btnFrase3.UseVisualStyleBackColor = true;
            this.btnFrase3.Click += new System.EventHandler(this.btnFrase3_Click);
            // 
            // btnFrase4
            // 
            this.btnFrase4.Enabled = false;
            this.btnFrase4.Location = new System.Drawing.Point(25, 115);
            this.btnFrase4.Name = "btnFrase4";
            this.btnFrase4.Size = new System.Drawing.Size(75, 23);
            this.btnFrase4.TabIndex = 4;
            this.btnFrase4.Text = "Frase 4";
            this.btnFrase4.UseVisualStyleBackColor = true;
            this.btnFrase4.Click += new System.EventHandler(this.btnFrase4_Click);
            // 
            // btnFrase5
            // 
            this.btnFrase5.Enabled = false;
            this.btnFrase5.Location = new System.Drawing.Point(120, 115);
            this.btnFrase5.Name = "btnFrase5";
            this.btnFrase5.Size = new System.Drawing.Size(75, 23);
            this.btnFrase5.TabIndex = 5;
            this.btnFrase5.Text = "Frase 5";
            this.btnFrase5.UseVisualStyleBackColor = true;
            this.btnFrase5.Click += new System.EventHandler(this.btnFrase5_Click);
            // 
            // btnUnir
            // 
            this.btnUnir.Enabled = false;
            this.btnUnir.Location = new System.Drawing.Point(214, 115);
            this.btnUnir.Name = "btnUnir";
            this.btnUnir.Size = new System.Drawing.Size(75, 23);
            this.btnUnir.TabIndex = 6;
            this.btnUnir.Text = "Unir";
            this.btnUnir.UseVisualStyleBackColor = true;
            this.btnUnir.Click += new System.EventHandler(this.btnUnir_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(75, 173);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(161, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Limpiar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btn_Limpiar);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(75, 214);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(161, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Salir";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btn_Salir);
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 249);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnUnir);
            this.Controls.Add(this.btnFrase5);
            this.Controls.Add(this.btnFrase4);
            this.Controls.Add(this.btnFrase3);
            this.Controls.Add(this.btnFrase2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFrase1);
            this.Name = "Ejercicio2";
            this.Text = "Frases";
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnFrase1;
        private TextBox textBox1;
        private Button btnFrase2;
        private Button btnFrase3;
        private Button btnFrase4;
        private Button btnFrase5;
        private Button btnUnir;
        private Button button7;
        private Button button8;
    }
}