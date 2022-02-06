
namespace pTriangulo
{
    partial class pnlTriangulo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValordeA = new System.Windows.Forms.Label();
            this.lblValordeB = new System.Windows.Forms.Label();
            this.lblValordeC = new System.Windows.Forms.Label();
            this.txtValordeA = new System.Windows.Forms.TextBox();
            this.txtValordeB = new System.Windows.Forms.TextBox();
            this.txtValordeC = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValordeA
            // 
            this.lblValordeA.AutoSize = true;
            this.lblValordeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValordeA.Location = new System.Drawing.Point(142, 22);
            this.lblValordeA.Name = "lblValordeA";
            this.lblValordeA.Size = new System.Drawing.Size(99, 24);
            this.lblValordeA.TabIndex = 0;
            this.lblValordeA.Text = "Valor de A";
            // 
            // lblValordeB
            // 
            this.lblValordeB.AutoSize = true;
            this.lblValordeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValordeB.Location = new System.Drawing.Point(142, 75);
            this.lblValordeB.Name = "lblValordeB";
            this.lblValordeB.Size = new System.Drawing.Size(98, 24);
            this.lblValordeB.TabIndex = 1;
            this.lblValordeB.Text = "Valor de B";
            // 
            // lblValordeC
            // 
            this.lblValordeC.AutoSize = true;
            this.lblValordeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValordeC.Location = new System.Drawing.Point(142, 123);
            this.lblValordeC.Name = "lblValordeC";
            this.lblValordeC.Size = new System.Drawing.Size(99, 24);
            this.lblValordeC.TabIndex = 2;
            this.lblValordeC.Text = "Valor de C";
            // 
            // txtValordeA
            // 
            this.txtValordeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValordeA.Location = new System.Drawing.Point(265, 22);
            this.txtValordeA.Name = "txtValordeA";
            this.txtValordeA.Size = new System.Drawing.Size(100, 26);
            this.txtValordeA.TabIndex = 3;
            // 
            // txtValordeB
            // 
            this.txtValordeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValordeB.Location = new System.Drawing.Point(265, 73);
            this.txtValordeB.Name = "txtValordeB";
            this.txtValordeB.Size = new System.Drawing.Size(100, 26);
            this.txtValordeB.TabIndex = 4;
            // 
            // txtValordeC
            // 
            this.txtValordeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValordeC.Location = new System.Drawing.Point(265, 121);
            this.txtValordeC.Name = "txtValordeC";
            this.txtValordeC.Size = new System.Drawing.Size(100, 26);
            this.txtValordeC.TabIndex = 5;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(92, 171);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(108, 55);
            this.btnExecutar.TabIndex = 6;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(206, 171);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 55);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(320, 171);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(108, 55);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnlTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 282);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.txtValordeC);
            this.Controls.Add(this.txtValordeB);
            this.Controls.Add(this.txtValordeA);
            this.Controls.Add(this.lblValordeC);
            this.Controls.Add(this.lblValordeB);
            this.Controls.Add(this.lblValordeA);
            this.Name = "pnlTriangulo";
            this.Text = "Calculo de Triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValordeA;
        private System.Windows.Forms.Label lblValordeB;
        private System.Windows.Forms.Label lblValordeC;
        private System.Windows.Forms.TextBox txtValordeA;
        private System.Windows.Forms.TextBox txtValordeB;
        private System.Windows.Forms.TextBox txtValordeC;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}

