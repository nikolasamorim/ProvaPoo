
using _3C1NIKOLAS31.Code.DTO;
using _3C1NIKOLAS31.Code.DAL;
using System.Data;

namespace _3C1NIKOLAS31.Code.BLL
{
    internal class SGamesBLL
    {
        Banco bd = new Banco();
        string tabela = "savassigames";



        public void Inserir(SGamesDTO SGamesDTO)
        {

            string inserir = $"insert into {tabela} values('{ SGamesDTO.Id}','{ SGamesDTO.Produto}','{ SGamesDTO.Preco}')";
            bd.ExecutarComando(inserir);
        }


        public void Excluir(SGamesDTO SGamesDTO)
        {
            string excluir = $"delete from {tabela} where id = '{SGamesDTO.Id}';";
            bd.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela}; ";
            return bd.ExecutarConsulta(sql);
        }
        public void Editar(SGamesDTO SGamesDTO)
        {
            string alterar = $"update {tabela} set produto = '{SGamesDTO.Produto}', preco = '{SGamesDTO.Preco}' where id = '{SGamesDTO.Id}';";
            bd.ExecutarComando(alterar);
        }
    }
}
