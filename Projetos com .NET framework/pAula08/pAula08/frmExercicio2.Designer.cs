
namespace pAula08
{
    partial class frmExercicio2
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
            this.lblNumeroN = new System.Windows.Forms.Label();
            this.txtNumeroN = new System.Windows.Forms.TextBox();
            this.btnNumeroH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroN
            // 
            this.lblNumeroN.AutoSize = true;
            this.lblNumeroN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroN.Location = new System.Drawing.Point(56, 54);
            this.lblNumeroN.Name = "lblNumeroN";
            this.lblNumeroN.Size = new System.Drawing.Size(138, 20);
            this.lblNumeroN.TabIndex = 2;
            this.lblNumeroN.Text = "Digite o Número N";
            // 
            // txtNumeroN
            // 
            this.txtNumeroN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroN.Location = new System.Drawing.Point(200, 48);
            this.txtNumeroN.Name = "txtNumeroN";
            this.txtNumeroN.Size = new System.Drawing.Size(167, 26);
            this.txtNumeroN.TabIndex = 3;
            // 
            // btnNumeroH
            // 
            this.btnNumeroH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumeroH.Location = new System.Drawing.Point(174, 193);
            this.btnNumeroH.Name = "btnNumeroH";
            this.btnNumeroH.Size = new System.Drawing.Size(148, 46);
            this.btnNumeroH.TabIndex = 4;
            this.btnNumeroH.Text = "Gerar Número H";
            this.btnNumeroH.UseVisualStyleBackColor = true;
            this.btnNumeroH.Click += new System.EventHandler(this.btnNumeroH_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 324);
            this.Controls.Add(this.btnNumeroH);
            this.Controls.Add(this.txtNumeroN);
            this.Controls.Add(this.lblNumeroN);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroN;
        private System.Windows.Forms.TextBox txtNumeroN;
        private System.Windows.Forms.Button btnNumeroH;
    }
}