namespace _05Polimorfismo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1Parameter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn2Parameter = new System.Windows.Forms.Button();
            this.btn3Parameter = new System.Windows.Forms.Button();
            this.btn4Parameter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1Parameter
            // 
            this.btn1Parameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Parameter.Location = new System.Drawing.Point(307, 23);
            this.btn1Parameter.Name = "btn1Parameter";
            this.btn1Parameter.Size = new System.Drawing.Size(119, 39);
            this.btn1Parameter.TabIndex = 0;
            this.btn1Parameter.Text = "1Parameter";
            this.btn1Parameter.UseVisualStyleBackColor = true;
            this.btn1Parameter.Click += new System.EventHandler(this.btn1Parameter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(32, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 328);
            this.textBox1.TabIndex = 1;
            // 
            // btn2Parameter
            // 
            this.btn2Parameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Parameter.Location = new System.Drawing.Point(307, 81);
            this.btn2Parameter.Name = "btn2Parameter";
            this.btn2Parameter.Size = new System.Drawing.Size(119, 39);
            this.btn2Parameter.TabIndex = 2;
            this.btn2Parameter.Text = "2Parameter";
            this.btn2Parameter.UseVisualStyleBackColor = true;
            this.btn2Parameter.Click += new System.EventHandler(this.btn2Parameter_Click);
            // 
            // btn3Parameter
            // 
            this.btn3Parameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Parameter.Location = new System.Drawing.Point(307, 143);
            this.btn3Parameter.Name = "btn3Parameter";
            this.btn3Parameter.Size = new System.Drawing.Size(119, 39);
            this.btn3Parameter.TabIndex = 3;
            this.btn3Parameter.Text = "3Parameter";
            this.btn3Parameter.UseVisualStyleBackColor = true;
            this.btn3Parameter.Click += new System.EventHandler(this.btn3Parameter_Click);
            // 
            // btn4Parameter
            // 
            this.btn4Parameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Parameter.Location = new System.Drawing.Point(307, 204);
            this.btn4Parameter.Name = "btn4Parameter";
            this.btn4Parameter.Size = new System.Drawing.Size(119, 39);
            this.btn4Parameter.TabIndex = 4;
            this.btn4Parameter.Text = "4Parameter";
            this.btn4Parameter.UseVisualStyleBackColor = true;
            this.btn4Parameter.Click += new System.EventHandler(this.btn4Parameter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 386);
            this.Controls.Add(this.btn4Parameter);
            this.Controls.Add(this.btn3Parameter);
            this.Controls.Add(this.btn2Parameter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn1Parameter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1Parameter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn2Parameter;
        private System.Windows.Forms.Button btn3Parameter;
        private System.Windows.Forms.Button btn4Parameter;
    }
}

