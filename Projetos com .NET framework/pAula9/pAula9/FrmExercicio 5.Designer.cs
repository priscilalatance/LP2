
namespace pAula9
{
    partial class FrmExercicio_5
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
            this.btnMedias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMedias
            // 
            this.btnMedias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedias.Location = new System.Drawing.Point(243, 111);
            this.btnMedias.Name = "btnMedias";
            this.btnMedias.Size = new System.Drawing.Size(221, 84);
            this.btnMedias.TabIndex = 0;
            this.btnMedias.Text = "Calculo de Médias";
            this.btnMedias.UseVisualStyleBackColor = true;
            this.btnMedias.Click += new System.EventHandler(this.btnMedias_Click);
            // 
            // FrmExecicio_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMedias);
            this.Name = "FrmExecicio_5";
            this.Text = "FrmExecicio_5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedias;
    }
}