
namespace pAula9
{
    partial class FrmExercicio_2
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
            this.btnMercadorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMercadorias
            // 
            this.btnMercadorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMercadorias.Location = new System.Drawing.Point(253, 131);
            this.btnMercadorias.Name = "btnMercadorias";
            this.btnMercadorias.Size = new System.Drawing.Size(188, 84);
            this.btnMercadorias.TabIndex = 0;
            this.btnMercadorias.Text = "Mercadorias";
            this.btnMercadorias.UseVisualStyleBackColor = true;
            this.btnMercadorias.Click += new System.EventHandler(this.btnMercadorias_Click);
            // 
            // FrmExercicio_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMercadorias);
            this.Name = "FrmExercicio_2";
            this.Text = "FrmExercicio_2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMercadorias;
    }
}