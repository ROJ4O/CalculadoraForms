using System.Security.Policy;
using System.Threading;
using System;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        decimal calculo;
        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        bool resultado = false;
        public Form1()
        {
            this.KeyPreview = true;

            this.KeyDown += (sender, e) => TrataAtalhos(e);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResultado.Text))
            {
                txtResultado.Text += "0,";
                txtFormula.Text += "0,";
            }

            else if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
                txtFormula.Text += ",";
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
            txtFormula.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
            txtFormula.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
            txtFormula.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
            txtFormula.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
            txtFormula.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
            txtFormula.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
            txtFormula.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
            txtFormula.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
            txtFormula.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
            txtFormula.Text += "9";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = Convert.ToDecimal(txtResultado.Text);

                txtFormula.Text += " + ";
                txtResultado.Text = "";

                adicao = true;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
            }
            catch (Exception)
            {

            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            resultado = true;
            txtFormula.Text += " = ";

            //Calculo de Adição
            if (adicao == true)
            {
                try
                {
                    txtResultado.Text = Convert.ToString(Convert.ToDecimal(txtResultado.Text) + calculo);
                    txtFormula.Text += txtResultado.Text;
                }
                catch (Exception) { }
            }
            //Calculo de Subtração
            if (subtracao == true)
            {
                txtResultado.Text = Convert.ToString(calculo - Convert.ToDecimal(txtResultado.Text));
                txtFormula.Text += txtResultado.Text;
            }
            //Calculo de multiplicação
            if (multiplicacao == true)
            {
                txtResultado.Text = Convert.ToString(Convert.ToDecimal(txtResultado.Text) * calculo);
                txtFormula.Text += txtResultado.Text;
            }
            //Calculo de Divisão
            if (divisao == true)
            {
                txtResultado.Text = Convert.ToString(calculo / Convert.ToDecimal(txtResultado.Text));
                txtFormula.Text += txtResultado.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtFormula.Text = "";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            try
            {


                calculo = Convert.ToDecimal(txtResultado.Text);

                txtFormula.Text += " - ";
                txtResultado.Text = "";

                adicao = false;
                subtracao = true;
                multiplicacao = false;
                divisao = false;
            }
            catch (Exception)
            {

            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            try
            {


                calculo = Convert.ToDecimal(txtResultado.Text);

                txtFormula.Text += " x ";
                txtResultado.Text = "";

                adicao = false;
                subtracao = false;
                multiplicacao = true;
                divisao = false;
            }
            catch (Exception)
            {

            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            try
            {


                calculo = Convert.ToDecimal(txtResultado.Text);

                txtFormula.Text += " / ";
                txtResultado.Text = "";

                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = true;
            }
            catch (Exception)
            {

            }
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            try
            {
                string Apagar = txtResultado.Text;

                Apagar = Apagar.Remove(Apagar.Length - 1);

                txtResultado.Text = Apagar;
                txtFormula.Text = Apagar;
            }
            catch (Exception)
            {

            }
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            if (subtracao == true)
            {
                double valorPorcentagem = Convert.ToDouble(calculo);
                double pecentual = Convert.ToDouble(txtResultado.Text) / 100;

                txtResultado.Text = Convert.ToString(valorPorcentagem - (pecentual * valorPorcentagem));

                txtFormula.Text += "% = ";
                txtFormula.Text += txtResultado.Text;
            }
            else if (adicao == true)
            {
                try
                {
                    double valorPorcentagem = Convert.ToDouble(calculo);
                    double pecentual = Convert.ToDouble(txtResultado.Text) / 100;

                    txtResultado.Text = Convert.ToString(valorPorcentagem + (pecentual * valorPorcentagem));

                    txtFormula.Text += "% = ";
                    txtFormula.Text += txtResultado.Text;
                }
                catch (Exception) { }
            }
        }
        private void TrataAtalhos(KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    btnZero.PerformClick();
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    btnUm.PerformClick();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    btnDois.PerformClick();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    btnTres.PerformClick();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    btnQuatro.PerformClick();
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    if (e.Shift)
                    {
                        btnPorcentagem.PerformClick();
                    }
                    else
                    {
                        btnCinco.PerformClick();
                    }
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    btnSeis.PerformClick();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    btnSete.PerformClick();
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    btnOito.PerformClick();
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    btnNove.PerformClick();
                    break;
                case Keys.Oemcomma:
                case Keys.Decimal:
                    btnVirgula.PerformClick();
                    break;
                case Keys.Add:
                    btnAdicao.PerformClick();
                    break;
                case Keys.Subtract:
                    btnSubtracao.PerformClick();
                    break;
                case Keys.Multiply:
                    btnMultiplicacao.PerformClick();
                    break;
                case Keys.Divide:
                    btnDivisao.PerformClick();
                    break;
                case Keys.Delete:
                    btnClear.PerformClick();
                    break;
                case Keys.Oemplus:
                case Keys.Enter:
                    btnIgual.PerformClick();
                    break;
                case Keys.Back:
                    btnVolta.PerformClick();
                    break;
                case Keys.Escape:
                    btnFechar.PerformClick();
                    break;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
