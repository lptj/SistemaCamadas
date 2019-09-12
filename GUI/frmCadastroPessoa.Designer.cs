namespace GUI
{
    partial class frmCadastroPessoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNasc = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvPesquisar = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxEstCiv = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ckbRecEmail = new System.Windows.Forms.CheckBox();
            this.ckbRecSMS = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(95, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtNasc
            // 
            this.txtNasc.Location = new System.Drawing.Point(95, 64);
            this.txtNasc.Name = "txtNasc";
            this.txtNasc.Size = new System.Drawing.Size(100, 20);
            this.txtNasc.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(95, 240);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Buscar Nome:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(209, 273);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(95, 275);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisar.TabIndex = 7;
            // 
            // dgvPesquisar
            // 
            this.dgvPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisar.Location = new System.Drawing.Point(26, 303);
            this.dgvPesquisar.Name = "dgvPesquisar";
            this.dgvPesquisar.Size = new System.Drawing.Size(591, 150);
            this.dgvPesquisar.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(95, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 92);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sexo:";
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Checked = true;
            this.rbtnMasc.Location = new System.Drawing.Point(95, 123);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasc.TabIndex = 4;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "Masculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Location = new System.Drawing.Point(170, 123);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(67, 17);
            this.rbtnFem.TabIndex = 5;
            this.rbtnFem.Text = "Feminino";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Estado Civíl:";
            // 
            // cbxEstCiv
            // 
            this.cbxEstCiv.FormattingEnabled = true;
            this.cbxEstCiv.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Divorciado",
            "Viuvo",
            "Outros"});
            this.cbxEstCiv.Location = new System.Drawing.Point(95, 147);
            this.cbxEstCiv.Name = "cbxEstCiv";
            this.cbxEstCiv.Size = new System.Drawing.Size(100, 21);
            this.cbxEstCiv.TabIndex = 6;
            this.cbxEstCiv.Text = "Selecione";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tipo de Contato:";
            // 
            // ckbRecEmail
            // 
            this.ckbRecEmail.AutoSize = true;
            this.ckbRecEmail.Location = new System.Drawing.Point(95, 177);
            this.ckbRecEmail.Name = "ckbRecEmail";
            this.ckbRecEmail.Size = new System.Drawing.Size(95, 17);
            this.ckbRecEmail.TabIndex = 7;
            this.ckbRecEmail.Text = "Recebe E-mail";
            this.ckbRecEmail.UseVisualStyleBackColor = true;
            // 
            // ckbRecSMS
            // 
            this.ckbRecSMS.AutoSize = true;
            this.ckbRecSMS.Location = new System.Drawing.Point(95, 200);
            this.ckbRecSMS.Name = "ckbRecSMS";
            this.ckbRecSMS.Size = new System.Drawing.Size(90, 17);
            this.ckbRecSMS.TabIndex = 8;
            this.ckbRecSMS.Text = "Recebe SMS";
            this.ckbRecSMS.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(209, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(290, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(209, 34);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 23;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(290, 34);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 571);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.ckbRecSMS);
            this.Controls.Add(this.ckbRecEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxEstCiv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbtnFem);
            this.Controls.Add(this.rbtnMasc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtNasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroPessoa";
            this.Text = "4";
            this.Load += new System.EventHandler(this.frmCadastroPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNasc;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dgvPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxEstCiv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ckbRecEmail;
        private System.Windows.Forms.CheckBox ckbRecSMS;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
    }
}