
namespace pAula08
{
    partial class frmExercicio1
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.lblFrase = new System.Windows.Forms.Label();
            this.btnEspaços = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnParesLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtFrase.Location = new System.Drawing.Point(114, 12);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(287, 102);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.Location = new System.Drawing.Point(49, 12);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(50, 20);
            this.lblFrase.TabIndex = 1;
            this.lblFrase.Text = "Frase";
            // 
            // btnEspaços
            // 
            this.btnEspaços.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspaços.Location = new System.Drawing.Point(31, 164);
            this.btnEspaços.Name = "btnEspaços";
            this.btnEspaços.Size = new System.Drawing.Size(111, 46);
            this.btnEspaços.TabIndex = 2;
            this.btnEspaços.Text = "Espaços em Branco";
            this.btnEspaços.UseVisualStyleBackColor = true;
            this.btnEspaços.Click += new System.EventHandler(this.btnEspaços_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetraR.Location = new System.Drawing.Point(180, 164);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(111, 46);
            this.btnLetraR.TabIndex = 3;
            this.btnLetraR.Text = "Letra R";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetraR_Click);
            // 
            // btnParesLetras
            // 
            this.btnParesLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParesLetras.Location = new System.Drawing.Point(330, 164);
            this.btnParesLetras.Name = "btnParesLetras";
            this.btnParesLetras.Size = new System.Drawing.Size(111, 46);
            this.btnParesLetras.TabIndex = 4;
            this.btnParesLetras.Text = "Pares de Letras Iguais";
            this.btnParesLetras.UseVisualStyleBackColor = true;
            this.btnParesLetras.Click += new System.EventHandler(this.btnParesLetras_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 359);
            this.Controls.Add(this.btnParesLetras);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnEspaços);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.Button btnEspaços;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnParesLetras;
    }
}