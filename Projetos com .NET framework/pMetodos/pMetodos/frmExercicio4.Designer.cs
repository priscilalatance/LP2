
namespace pMetodos
{
    partial class frmExercicio4
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
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.btnLetras = new System.Windows.Forms.Button();
            this.btnCaracter = new System.Windows.Forms.Button();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(168, 32);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(378, 96);
            this.rtbTexto.TabIndex = 0;
            this.rtbTexto.Text = "";
            // 
            // btnLetras
            // 
            this.btnLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetras.Location = new System.Drawing.Point(493, 226);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(125, 53);
            this.btnLetras.TabIndex = 13;
            this.btnLetras.Text = "Caracter Alfabético";
            this.btnLetras.UseVisualStyleBackColor = true;
            this.btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // btnCaracter
            // 
            this.btnCaracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaracter.Location = new System.Drawing.Point(288, 226);
            this.btnCaracter.Name = "btnCaracter";
            this.btnCaracter.Size = new System.Drawing.Size(166, 53);
            this.btnCaracter.TabIndex = 12;
            this.btnCaracter.Text = "Primeiro Caracter em Branco";
            this.btnCaracter.UseVisualStyleBackColor = true;
            this.btnCaracter.Click += new System.EventHandler(this.btnCaracter_Click);
            // 
            // btnNumeros
            // 
            this.btnNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumeros.Location = new System.Drawing.Point(121, 226);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(125, 53);
            this.btnNumeros.TabIndex = 11;
            this.btnNumeros.Text = "Verifica se é número";
            this.btnNumeros.UseVisualStyleBackColor = true;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.btnCaracter);
            this.Controls.Add(this.btnNumeros);
            this.Controls.Add(this.rtbTexto);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.Button btnLetras;
        private System.Windows.Forms.Button btnCaracter;
        private System.Windows.Forms.Button btnNumeros;
    }
}