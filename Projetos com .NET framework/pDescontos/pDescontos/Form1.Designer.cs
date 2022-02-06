
namespace pDescontos
{
    partial class pnlDesconto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlDesconto));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblNumeroFilhos = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskbxSalario = new System.Windows.Forms.MaskedTextBox();
            this.cbxNumeroFilhos = new System.Windows.Forms.ComboBox();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.rbntM = new System.Windows.Forms.RadioButton();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.btnVerificarDescontos = new System.Windows.Forms.Button();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.txtAliquotaIRPF = new System.Windows.Forms.TextBox();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.txtDescontoIRPF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(60, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(137, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Funcionário";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(60, 43);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(85, 16);
            this.lblSalarioBruto.TabIndex = 1;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // lblNumeroFilhos
            // 
            this.lblNumeroFilhos.AutoSize = true;
            this.lblNumeroFilhos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblNumeroFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFilhos.Location = new System.Drawing.Point(60, 75);
            this.lblNumeroFilhos.Name = "lblNumeroFilhos";
            this.lblNumeroFilhos.Size = new System.Drawing.Size(109, 16);
            this.lblNumeroFilhos.TabIndex = 2;
            this.lblNumeroFilhos.Text = "Numero de filhos";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(203, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(217, 22);
            this.txtNome.TabIndex = 3;
            // 
            // mskbxSalario
            // 
            this.mskbxSalario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mskbxSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalario.Location = new System.Drawing.Point(203, 43);
            this.mskbxSalario.Mask = "99990.00";
            this.mskbxSalario.Name = "mskbxSalario";
            this.mskbxSalario.Size = new System.Drawing.Size(217, 22);
            this.mskbxSalario.TabIndex = 4;
            // 
            // cbxNumeroFilhos
            // 
            this.cbxNumeroFilhos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbxNumeroFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNumeroFilhos.FormattingEnabled = true;
            this.cbxNumeroFilhos.Items.AddRange(new object[] {
            "0",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxNumeroFilhos.Location = new System.Drawing.Point(203, 75);
            this.cbxNumeroFilhos.Name = "cbxNumeroFilhos";
            this.cbxNumeroFilhos.Size = new System.Drawing.Size(217, 24);
            this.cbxNumeroFilhos.TabIndex = 5;
            // 
            // rbtnF
            // 
            this.rbtnF.AutoSize = true;
            this.rbtnF.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rbtnF.Checked = true;
            this.rbtnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnF.Location = new System.Drawing.Point(622, 43);
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.Size = new System.Drawing.Size(34, 20);
            this.rbtnF.TabIndex = 6;
            this.rbtnF.TabStop = true;
            this.rbtnF.Text = "F";
            this.rbtnF.UseVisualStyleBackColor = false;
            // 
            // rbntM
            // 
            this.rbntM.AutoSize = true;
            this.rbntM.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rbntM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbntM.Location = new System.Drawing.Point(619, 69);
            this.rbntM.Name = "rbntM";
            this.rbntM.Size = new System.Drawing.Size(37, 20);
            this.rbntM.TabIndex = 7;
            this.rbntM.Text = "M";
            this.rbntM.UseVisualStyleBackColor = false;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ckbxCasado.Checked = true;
            this.ckbxCasado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxCasado.Location = new System.Drawing.Point(583, 111);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(75, 20);
            this.ckbxCasado.TabIndex = 8;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = false;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(619, 20);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 16);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo";
            // 
            // btnVerificarDescontos
            // 
            this.btnVerificarDescontos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVerificarDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarDescontos.Location = new System.Drawing.Point(203, 125);
            this.btnVerificarDescontos.Name = "btnVerificarDescontos";
            this.btnVerificarDescontos.Size = new System.Drawing.Size(217, 30);
            this.btnVerificarDescontos.TabIndex = 10;
            this.btnVerificarDescontos.Text = "Verificar Desconto";
            this.btnVerificarDescontos.UseVisualStyleBackColor = false;
            this.btnVerificarDescontos.Click += new System.EventHandler(this.btnVerificarDescontos_Click);
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.Location = new System.Drawing.Point(60, 168);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(49, 16);
            this.lblDados.TabIndex = 11;
            this.lblDados.Text = "Dados";
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINSS.Location = new System.Drawing.Point(60, 230);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(91, 16);
            this.lblINSS.TabIndex = 12;
            this.lblINSS.Text = "Alíquota INSS";
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblDescontoINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoINSS.Location = new System.Drawing.Point(440, 230);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(100, 16);
            this.lblDescontoINSS.TabIndex = 13;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRPF.Location = new System.Drawing.Point(60, 263);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(90, 16);
            this.lblIRPF.TabIndex = 14;
            this.lblIRPF.Text = "Alíquota IRPF";
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblDescontoIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoIRPF.Location = new System.Drawing.Point(440, 263);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(99, 16);
            this.lblDescontoIRPF.TabIndex = 15;
            this.lblDescontoIRPF.Text = "Desconto IRPF";
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblSalarioFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFamilia.Location = new System.Drawing.Point(55, 297);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(98, 16);
            this.lblSalarioFamilia.TabIndex = 16;
            this.lblSalarioFamilia.Text = "Salário Família";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(53, 331);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(98, 16);
            this.lblSalarioLiquido.TabIndex = 17;
            this.lblSalarioLiquido.Text = "Salário Liquido";
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAliquotaINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAliquotaINSS.Location = new System.Drawing.Point(157, 227);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.ReadOnly = true;
            this.txtAliquotaINSS.Size = new System.Drawing.Size(217, 22);
            this.txtAliquotaINSS.TabIndex = 18;
            // 
            // txtAliquotaIRPF
            // 
            this.txtAliquotaIRPF.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAliquotaIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAliquotaIRPF.Location = new System.Drawing.Point(157, 255);
            this.txtAliquotaIRPF.Name = "txtAliquotaIRPF";
            this.txtAliquotaIRPF.ReadOnly = true;
            this.txtAliquotaIRPF.Size = new System.Drawing.Size(217, 22);
            this.txtAliquotaIRPF.TabIndex = 19;
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSalarioFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioFamilia.Location = new System.Drawing.Point(157, 291);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.ReadOnly = true;
            this.txtSalarioFamilia.Size = new System.Drawing.Size(217, 22);
            this.txtSalarioFamilia.TabIndex = 20;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioLiquido.Location = new System.Drawing.Point(157, 325);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.ReadOnly = true;
            this.txtSalarioLiquido.Size = new System.Drawing.Size(217, 22);
            this.txtSalarioLiquido.TabIndex = 21;
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDescontoINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoINSS.Location = new System.Drawing.Point(546, 227);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.ReadOnly = true;
            this.txtDescontoINSS.Size = new System.Drawing.Size(130, 22);
            this.txtDescontoINSS.TabIndex = 22;
            // 
            // txtDescontoIRPF
            // 
            this.txtDescontoIRPF.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDescontoIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoIRPF.Location = new System.Drawing.Point(545, 260);
            this.txtDescontoIRPF.Name = "txtDescontoIRPF";
            this.txtDescontoIRPF.ReadOnly = true;
            this.txtDescontoIRPF.Size = new System.Drawing.Size(131, 22);
            this.txtDescontoIRPF.TabIndex = 23;
            // 
            // pnlDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(783, 362);
            this.Controls.Add(this.txtDescontoIRPF);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtSalarioFamilia);
            this.Controls.Add(this.txtAliquotaIRPF);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblDescontoIRPF);
            this.Controls.Add(this.lblIRPF);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.btnVerificarDescontos);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.ckbxCasado);
            this.Controls.Add(this.rbntM);
            this.Controls.Add(this.rbtnF);
            this.Controls.Add(this.cbxNumeroFilhos);
            this.Controls.Add(this.mskbxSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNumeroFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNome);
            this.Name = "pnlDesconto";
            this.Text = "Cálculo de Descontos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblNumeroFilhos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskbxSalario;
        private System.Windows.Forms.ComboBox cbxNumeroFilhos;
        private System.Windows.Forms.RadioButton rbtnF;
        private System.Windows.Forms.RadioButton rbntM;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Button btnVerificarDescontos;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.TextBox txtAliquotaIRPF;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.TextBox txtDescontoIRPF;
    }
}

