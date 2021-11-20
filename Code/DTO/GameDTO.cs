using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1_PedroMartins_34.Code.DTO
{
    public class GameDTO
    {
        private int _id;
        private string _nome, _produtora;
        private float _preco;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Produtora { get => _produtora; set => _produtora = value; }
        public float Preco { get => _preco; set => _preco = value; }
    }
}
