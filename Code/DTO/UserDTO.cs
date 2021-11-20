using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1_PedroMartins_34.Code.DTO
{
    public class UserDTO
    {
        private int _id;
        private string _nome, _email, _senha;

        public int Id { get => _id; set => _id = value; }

        public string Nome { get => _nome; set => _nome = value; }

        public string Email { get => _email; set => _email = value; }

        public string Senha { get => _senha; set => _senha = value; }
    }
}
