using _3C1_PedroMartins_34.Code.DAL;
using _3C1_PedroMartins_34.Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1_PedroMartins_34.Code.BLL
{
    public class GameBLL
    {
        DatabaseAccess database = new DatabaseAccess();

        private readonly string table = "GAMES";

        public void Inserir(GameDTO gameDTO)
        {
            string insert = $"INSERT INTO {table} VALUES (null, '{gameDTO.Nome}', '{gameDTO.Produtora}', '{gameDTO.Preco}');";
            database.ExecutarComando(insert);
        }

        public void Alterar(GameDTO gameDTO)
        {
            string update = $@"UPDATE {table} SET       nome        = '{gameDTO.Nome}', 
                                                        produtora         = '{gameDTO.Produtora}', 
                                                        preco = '{gameDTO.Preco}', 
                                                WHERE   ID           = '{gameDTO.Id}';";
            database.ExecutarComando(update);
        }

        public void Excluir(int id)
        {
            string excluir = $"DELETE FROM {table} WHERE ID = '{id}';";
            database.ExecutarComando(excluir);
        }

        public DataTable Get()
        {
            string query = $"SELECT * FROM {table} ORDER BY nome;";
            return database.ExecutarConsulta(query);
        }
    }
}
