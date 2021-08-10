
namespace Livraria
{
    partial class frmatendente
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblfunc = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.dgvfunc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioativo = new System.Windows.Forms.RadioButton();
            this.radioinativo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblfunc
            // 
            this.lblfunc.AutoSize = true;
            this.lblfunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfunc.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblfunc.Location = new System.Drawing.Point(290, 25);
            this.lblfunc.Name = "lblfunc";
            this.lblfunc.Size = new System.Drawing.Size(225, 42);
            this.lblfunc.TabIndex = 0;
            this.lblfunc.Text = "Funcionario";
            this.lblfunc.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbl1.Location = new System.Drawing.Point(119, 96);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(76, 24);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Codigo:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcodigo.Location = new System.Drawing.Point(201, 96);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(0, 24);
            this.lblcodigo.TabIndex = 2;
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbllogin.Location = new System.Drawing.Point(119, 183);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(62, 24);
            this.lbllogin.TabIndex = 3;
            this.lbllogin.Text = "Login:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblnome.Location = new System.Drawing.Point(119, 138);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(67, 24);
            this.lblnome.TabIndex = 5;
            this.lblnome.Text = "Nome:";
            this.lblnome.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(205, 135);
            this.txtnome.MaxLength = 60;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(386, 29);
            this.txtnome.TabIndex = 6;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged_1);
            // 
            // txtlogin
            // 
            this.txtlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.Location = new System.Drawing.Point(205, 178);
            this.txtlogin.MaxLength = 20;
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(181, 29);
            this.txtlogin.TabIndex = 7;
            this.txtlogin.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblsenha.Location = new System.Drawing.Point(119, 223);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(70, 24);
            this.lblsenha.TabIndex = 8;
            this.lblsenha.Text = "Senha:";
            // 
            // txtsenha
            // 
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(205, 220);
            this.txtsenha.MaxLength = 8;
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(181, 29);
            this.txtsenha.TabIndex = 9;
            // 
            // dgvfunc
            // 
            this.dgvfunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfunc.Location = new System.Drawing.Point(123, 361);
            this.dgvfunc.MultiSelect = false;
            this.dgvfunc.Name = "dgvfunc";
            this.dgvfunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfunc.Size = new System.Drawing.Size(468, 165);
            this.dgvfunc.TabIndex = 10;
            this.dgvfunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfunc_CellContentClick);
            this.dgvfunc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvfunc_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbusca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(121, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 67);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa por Funcionario";
            // 
            // txtbusca
            // 
            this.txtbusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusca.Location = new System.Drawing.Point(6, 25);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(437, 29);
            this.txtbusca.TabIndex = 12;
            this.txtbusca.TextChanged += new System.EventHandler(this.txtbusca_TextChanged);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnnovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnovo.Location = new System.Drawing.Point(664, 357);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(79, 29);
            this.btnnovo.TabIndex = 12;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btngravar
            // 
            this.btngravar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btngravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngravar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btngravar.Location = new System.Drawing.Point(664, 392);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(79, 29);
            this.btngravar.TabIndex = 13;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = false;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnalterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnalterar.Location = new System.Drawing.Point(664, 427);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(79, 29);
            this.btnalterar.TabIndex = 14;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = false;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexcluir.Location = new System.Drawing.Point(664, 462);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(79, 29);
            this.btnexcluir.TabIndex = 15;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncancelar.Location = new System.Drawing.Point(664, 497);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(79, 29);
            this.btncancelar.TabIndex = 16;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(471, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Status:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // radioativo
            // 
            this.radioativo.AutoSize = true;
            this.radioativo.Checked = true;
            this.radioativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioativo.ForeColor = System.Drawing.Color.Blue;
            this.radioativo.Location = new System.Drawing.Point(475, 210);
            this.radioativo.Name = "radioativo";
            this.radioativo.Size = new System.Drawing.Size(63, 22);
            this.radioativo.TabIndex = 18;
            this.radioativo.TabStop = true;
            this.radioativo.Text = "Ativo";
            this.radioativo.UseVisualStyleBackColor = true;
            this.radioativo.CheckedChanged += new System.EventHandler(this.radioativo_CheckedChanged);
            // 
            // radioinativo
            // 
            this.radioinativo.AutoSize = true;
            this.radioinativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioinativo.ForeColor = System.Drawing.Color.DarkRed;
            this.radioinativo.Location = new System.Drawing.Point(475, 232);
            this.radioinativo.Name = "radioinativo";
            this.radioinativo.Size = new System.Drawing.Size(75, 22);
            this.radioinativo.TabIndex = 19;
            this.radioinativo.TabStop = true;
            this.radioinativo.Text = "Inativo";
            this.radioinativo.UseVisualStyleBackColor = true;
            // 
            // frmatendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.radioinativo);
            this.Controls.Add(this.radioativo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvfunc);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblfunc);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "frmatendente";
            this.Size = new System.Drawing.Size(782, 614);
            this.Load += new System.EventHandler(this.frmatendente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfunc;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.DataGridView dgvfunc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbusca;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioativo;
        private System.Windows.Forms.RadioButton radioinativo;
    }
}
