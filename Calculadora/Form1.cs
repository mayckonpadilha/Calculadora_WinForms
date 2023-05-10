namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao


        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            textCalcular.Text += "1";
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            textCalcular.Text += "2";
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            textCalcular.Text += "3";
        }

        private void btn_quatro_Click(object sender, EventArgs e)
        {
            textCalcular.Text += "4";
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            textCalcular.Text += "5";
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            textCalcular.Text += "6";
        }

        private void btn_sete_Click(object sender, EventArgs e)
        {
            textCalcular.Text += "7";
        }

        private void btn_oito_Click(object sender, EventArgs e)
        {
            textCalcular.Text += "8";
        }

        private void btn_nove_Click(object sender, EventArgs e)
        {
            textCalcular.Text += "9";
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            textCalcular.Text += "0";
        }

        private void btn_ponto_Click(object sender, EventArgs e)
        {
            textCalcular.Text += ".";
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            textCalcular.Text += ",";
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
        }

        private void btn_Multiplicar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {

        }
    }
}