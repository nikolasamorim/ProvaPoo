using System;
using System.Windows.Forms;
using _3C1NIKOLAS31.Code.BLL;
using _3C1NIKOLAS31.Code.DTO;
namespace _3C1NIKOLAS31.Ui
{
    public partial class SavassiGames : Form
    {
         SGamesBLL SGamesbll = new SGamesBLL();
         SGamesDTO SGamesdto = new SGamesDTO();
        public SavassiGames()
        {
            InitializeComponent();
            dgtlista.DataSource = SGamesbll.Listar();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            SGamesdto.Id = txtid.Text;
            SGamesdto.Produto = txtproduto.Text;
            SGamesdto.Preco = txtpreco.Text;

            SGamesbll.Inserir(SGamesdto);
            dgtlista.DataSource = SGamesbll.Listar();
            MessageBox.Show("Cadastrado!", "Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            SGamesdto.Id = txtid.Text;
            SGamesbll.Excluir(SGamesdto);
            dgtlista.DataSource = SGamesbll.Listar();
            MessageBox.Show("Excluido!", "Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            SGamesdto.Id = txtid.Text;
            SGamesdto.Produto = txtproduto.Text;
            SGamesdto.Preco = txtpreco.Text;


            SGamesbll.Editar(SGamesdto);


            MessageBox.Show("Alterado com sucesso!", "Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgtlista.DataSource = SGamesbll.Listar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void SavassiGames_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
