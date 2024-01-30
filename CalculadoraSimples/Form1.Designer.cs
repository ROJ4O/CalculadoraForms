namespace CalculadoraSimples
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtResultado = new TextBox();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnAdicao = new Button();
            btnIgual = new Button();
            btnVirgula = new Button();
            btnZero = new Button();
            btnClear = new Button();
            txtFormula = new TextBox();
            btnPorcentagem = new Button();
            btnVolta = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.Black;
            txtResultado.BorderStyle = BorderStyle.FixedSingle;
            txtResultado.Font = new Font("Segoe UI", 28F);
            txtResultado.ForeColor = Color.White;
            txtResultado.Location = new Point(0, 27);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(234, 57);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSete
            // 
            btnSete.BackColor = Color.White;
            btnSete.FlatAppearance.BorderSize = 0;
            btnSete.FlatStyle = FlatStyle.Flat;
            btnSete.Font = new Font("Cambria", 10F);
            btnSete.Location = new Point(0, 140);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(61, 55);
            btnSete.TabIndex = 1;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = false;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.BackColor = Color.White;
            btnOito.FlatAppearance.BorderSize = 0;
            btnOito.FlatStyle = FlatStyle.Flat;
            btnOito.Font = new Font("Cambria", 10F);
            btnOito.Location = new Point(62, 140);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(55, 55);
            btnOito.TabIndex = 2;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = false;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.BackColor = Color.White;
            btnNove.FlatAppearance.BorderSize = 0;
            btnNove.FlatStyle = FlatStyle.Flat;
            btnNove.Font = new Font("Cambria", 10F);
            btnNove.Location = new Point(118, 140);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(55, 55);
            btnNove.TabIndex = 3;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = false;
            btnNove.Click += btnNove_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.BackColor = Color.White;
            btnQuatro.FlatAppearance.BorderSize = 0;
            btnQuatro.FlatStyle = FlatStyle.Flat;
            btnQuatro.Font = new Font("Cambria", 10F);
            btnQuatro.Location = new Point(0, 196);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(61, 55);
            btnQuatro.TabIndex = 4;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = false;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = Color.White;
            btnCinco.FlatAppearance.BorderSize = 0;
            btnCinco.FlatStyle = FlatStyle.Flat;
            btnCinco.Font = new Font("Cambria", 10F);
            btnCinco.Location = new Point(62, 196);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(55, 55);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = Color.White;
            btnSeis.FlatAppearance.BorderSize = 0;
            btnSeis.FlatStyle = FlatStyle.Flat;
            btnSeis.Font = new Font("Cambria", 10F);
            btnSeis.Location = new Point(118, 196);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(55, 55);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnUm
            // 
            btnUm.BackColor = Color.White;
            btnUm.FlatAppearance.BorderSize = 0;
            btnUm.FlatStyle = FlatStyle.Flat;
            btnUm.Font = new Font("Cambria", 10F);
            btnUm.Location = new Point(0, 252);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(61, 55);
            btnUm.TabIndex = 7;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = false;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.BackColor = Color.White;
            btnDois.FlatAppearance.BorderSize = 0;
            btnDois.FlatStyle = FlatStyle.Flat;
            btnDois.Font = new Font("Cambria", 10F);
            btnDois.Location = new Point(62, 252);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(55, 55);
            btnDois.TabIndex = 8;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = false;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.BackColor = Color.White;
            btnTres.FlatAppearance.BorderSize = 0;
            btnTres.FlatStyle = FlatStyle.Flat;
            btnTres.Font = new Font("Cambria", 10F);
            btnTres.Location = new Point(118, 252);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(55, 55);
            btnTres.TabIndex = 9;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += btnTres_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.White;
            btnSubtracao.FlatAppearance.BorderSize = 0;
            btnSubtracao.FlatStyle = FlatStyle.Flat;
            btnSubtracao.Font = new Font("Cambria", 12F);
            btnSubtracao.Location = new Point(174, 252);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(59, 55);
            btnSubtracao.TabIndex = 12;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.White;
            btnMultiplicacao.FlatAppearance.BorderSize = 0;
            btnMultiplicacao.FlatStyle = FlatStyle.Flat;
            btnMultiplicacao.Font = new Font("Cambria", 12F);
            btnMultiplicacao.Location = new Point(174, 196);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(59, 55);
            btnMultiplicacao.TabIndex = 11;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.White;
            btnDivisao.FlatAppearance.BorderSize = 0;
            btnDivisao.FlatStyle = FlatStyle.Flat;
            btnDivisao.Font = new Font("Cambria", 12F);
            btnDivisao.Location = new Point(174, 140);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(59, 55);
            btnDivisao.TabIndex = 10;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.BackColor = Color.White;
            btnAdicao.FlatAppearance.BorderSize = 0;
            btnAdicao.FlatStyle = FlatStyle.Flat;
            btnAdicao.Font = new Font("Cambria", 12F);
            btnAdicao.Location = new Point(174, 308);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(59, 73);
            btnAdicao.TabIndex = 16;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = false;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.White;
            btnIgual.FlatAppearance.BorderSize = 0;
            btnIgual.FlatStyle = FlatStyle.Flat;
            btnIgual.Font = new Font("Cambria", 10F);
            btnIgual.Location = new Point(118, 308);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(55, 73);
            btnIgual.TabIndex = 15;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.White;
            btnVirgula.FlatAppearance.BorderSize = 0;
            btnVirgula.FlatStyle = FlatStyle.Flat;
            btnVirgula.Font = new Font("Cambria", 10F);
            btnVirgula.Location = new Point(0, 308);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(61, 73);
            btnVirgula.TabIndex = 13;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.White;
            btnZero.FlatAppearance.BorderSize = 0;
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Font = new Font("Cambria", 10F);
            btnZero.Location = new Point(62, 308);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(55, 73);
            btnZero.TabIndex = 17;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Cambria", 12F);
            btnClear.ForeColor = SystemColors.ControlText;
            btnClear.Location = new Point(0, 85);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 54);
            btnClear.TabIndex = 18;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtFormula
            // 
            txtFormula.BackColor = Color.Black;
            txtFormula.BorderStyle = BorderStyle.None;
            txtFormula.Enabled = false;
            txtFormula.Font = new Font("Segoe UI", 15F);
            txtFormula.ForeColor = Color.White;
            txtFormula.ImeMode = ImeMode.NoControl;
            txtFormula.Location = new Point(0, 0);
            txtFormula.Name = "txtFormula";
            txtFormula.ReadOnly = true;
            txtFormula.Size = new Size(234, 27);
            txtFormula.TabIndex = 0;
            txtFormula.TextAlign = HorizontalAlignment.Right;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.BackColor = Color.White;
            btnPorcentagem.FlatAppearance.BorderSize = 0;
            btnPorcentagem.FlatStyle = FlatStyle.Flat;
            btnPorcentagem.Font = new Font("Cambria", 12F);
            btnPorcentagem.ForeColor = SystemColors.ControlText;
            btnPorcentagem.Location = new Point(174, 85);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.Size = new Size(59, 54);
            btnPorcentagem.TabIndex = 20;
            btnPorcentagem.Text = "%";
            btnPorcentagem.UseVisualStyleBackColor = false;
            btnPorcentagem.Click += btnPorcentagem_Click;
            // 
            // btnVolta
            // 
            btnVolta.BackColor = Color.White;
            btnVolta.FlatAppearance.BorderSize = 0;
            btnVolta.FlatStyle = FlatStyle.Flat;
            btnVolta.Font = new Font("Cambria", 12F);
            btnVolta.ForeColor = SystemColors.ControlText;
            btnVolta.Location = new Point(118, 85);
            btnVolta.Name = "btnVolta";
            btnVolta.Size = new Size(55, 54);
            btnVolta.TabIndex = 21;
            btnVolta.Text = "←";
            btnVolta.UseVisualStyleBackColor = false;
            btnVolta.Click += btnVolta_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(19, 33);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 22;
            btnFechar.Text = "Fecha";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(234, 381);
            Controls.Add(btnVolta);
            Controls.Add(btnPorcentagem);
            Controls.Add(txtFormula);
            Controls.Add(btnClear);
            Controls.Add(btnZero);
            Controls.Add(btnAdicao);
            Controls.Add(btnIgual);
            Controls.Add(btnVirgula);
            Controls.Add(btnSubtracao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnDivisao);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(txtResultado);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnAdicao;
        private Button btnIgual;
        private Button btnVirgula;
        private Button btnZero;
        private Button btnClear;
        private TextBox txtFormula;
        private Button btnPorcentagem;
        private Button btnVolta;
        private Button btnFechar;
    }
}
