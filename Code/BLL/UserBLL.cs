using _3C1_PedroMartins_34.Code.DAL;
using _3C1_PedroMartins_34.Code.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1_PedroMartins_34.Code.BLL
{
    public class UserBLL
    {
        DatabaseAccess database = new DatabaseAccess();

        private readonly string table = "USUARIO";

        public void Insert(UserDTO userDto) {

            string insert = $"INSERT INTO {table} VALUES(null,'{userDto.Nome}','{userDto.Email}',{userDto.Senha})";
            database.ExecutarComando(insert);
        }

        public bool VerificarCredenciais(string email, string senha) {

            string query = $"SELECT * FROM {table} WHERE EMAIL = {email} AND SENHA = {senha}";
            var result = database.ExecutarConsulta(query);

            if (result.Rows.Count > 0)
                return true;

            return false; 
        }
    }
}
