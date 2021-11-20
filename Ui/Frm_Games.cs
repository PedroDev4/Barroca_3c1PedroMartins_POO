using _3C1_PedroMartins_34.Code.BLL;
using _3C1_PedroMartins_34.Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C1_PedroMartins_34.Ui
{
    public partial class Frm_Games : Form
    {
        GameBLL gameBLL = new GameBLL();
        GameDTO gameDTO = new GameDTO();

        public Frm_Games()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            GameDTO gameDTO = new GameDTO()
            {
                Id = int.Parse(txt_id.Text),
                Nome = txt_NomeGame.Text,
                Produtora = txt_produtora.Text,
                Preco = float.Parse(txt_preco.Text),
            };

            gameBLL.Inserir(gameDTO);
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            dtg_Games.DataSource = gameBLL.Get();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            GameDTO gameDTO = new GameDTO()
            {
                Id = int.Parse(txt_id.Text),
                Nome = txt_NomeGame.Text,
                Produtora = txt_produtora.Text,
                Preco = float.Parse(txt_preco.Text),
            };

            gameBLL.Alterar(gameDTO);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            gameBLL.Excluir(int.Parse(txt_id.Text));
        }
    }
}
