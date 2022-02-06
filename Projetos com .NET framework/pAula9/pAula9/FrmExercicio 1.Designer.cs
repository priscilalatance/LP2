
namespace pAula9
{
    partial class FrmExercicio_1
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
            this.btnNumeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNumeros
            // 
            this.btnNumeros.Location = new System.Drawing.Point(242, 118);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(175, 89);
            this.btnNumeros.TabIndex = 0;
            this.btnNumeros.Text = "Gerar números";
            this.btnNumeros.UseVisualStyleBackColor = true;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // FrmExercicio_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNumeros);
            this.Name = "FrmExercicio_1";
            this.Text = "FrmExercicio_1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNumeros;
    }
}