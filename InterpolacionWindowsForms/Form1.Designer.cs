namespace InterpolacionWindowsForms
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
            this.btnInterpolar = new System.Windows.Forms.Button();
            this.tbPuntos = new System.Windows.Forms.TextBox();
            this.tbValorInterpolar = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInterpolar
            // 
            this.btnInterpolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterpolar.Location = new System.Drawing.Point(652, 171);
            this.btnInterpolar.Name = "btnInterpolar";
            this.btnInterpolar.Size = new System.Drawing.Size(136, 70);
            this.btnInterpolar.TabIndex = 0;
            this.btnInterpolar.Text = "INTERPOLAR";
            this.btnInterpolar.UseVisualStyleBackColor = true;
            this.btnInterpolar.Click += new System.EventHandler(this.btnInterpolar_Click);
            // 
            // tbPuntos
            // 
            this.tbPuntos.Location = new System.Drawing.Point(527, 144);
            this.tbPuntos.Name = "tbPuntos";
            this.tbPuntos.Size = new System.Drawing.Size(100, 22);
            this.tbPuntos.TabIndex = 1;
            // 
            // tbValorInterpolar
            // 
            this.tbValorInterpolar.Location = new System.Drawing.Point(527, 199);
            this.tbValorInterpolar.Name = "tbValorInterpolar";
            this.tbValorInterpolar.Size = new System.Drawing.Size(100, 22);
            this.tbValorInterpolar.TabIndex = 2;
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(527, 257);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(100, 22);
            this.tbResultado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresa dos Puntos separados por ( , )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingresa Valor a Interpolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "ISCO /7A / INTERPOLACIÓN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbValorInterpolar);
            this.Controls.Add(this.tbPuntos);
            this.Controls.Add(this.btnInterpolar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInterpolar;
        private System.Windows.Forms.TextBox tbPuntos;
        private System.Windows.Forms.TextBox tbValorInterpolar;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

