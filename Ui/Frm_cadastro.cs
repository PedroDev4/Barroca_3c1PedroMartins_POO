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
    public partial class Frm_cadastro : Form
    {
        public Frm_cadastro()
        {
            InitializeComponent();
        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            UserBLL userBLL = new UserBLL();
            UserDTO userDto = new UserDTO
            {
                Nome = txt_Nome.Text,
                Email = txt_Email.Text,
                Senha = txt_Senha.Text,
                Id = int.Parse(txt_id.Text)
            };

            userBLL.Insert(userDto);

            Frm_Games frm_Games = new Frm_Games();

            frm_Games.Show();
        }
    }
}
