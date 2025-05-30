namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();
        List<Produto> item = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(int.Parse(codigo.Text), (nome.Text), double.Parse(preco.Text), int.Parse(quantidade.Text));
            MessageBox.Show(produto.codigo + "\n" + produto.nome + "\n" + produto.preco + "\n" + produto.quant + "\n");
            produtos.Add(produto);



            clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clear()
        {
            codigo.Text = string.Empty;
            nome.Text = string.Empty;
            preco.Text = string.Empty;
            quantidade.Text = string.Empty;
            codigo.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string linha = "";

            foreach (var produto in produtos)
            {
                linha = linha + "Produto: " + produto.codigo +
                    "\tNome :   " + produto.nome +
                    "\tPreço   : " + produto.preco +
                    "\tQtde    : " + produto.quant + "\n";
            }



        }

        private void listprodutos_SelectedIndexChanged(object sender, EventArgs e)
        {





        }
    }
}


