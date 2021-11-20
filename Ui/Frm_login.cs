using _3C1_PedroMartins_34.Code.BLL;
using _3C1_PedroMartins_34.Code.DTO;
using _3C1_PedroMartins_34.Ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C1_PedroMartins_34
{
    public partial class Frm_login : Form
    {

        public Frm_login()
        {
            InitializeComponent();
        }

        private void btn_TelaCadastro_Click(object sender, EventArgs e)
        {
            Frm_cadastro frm_cadastro = new Frm_cadastro();
            frm_cadastro.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            UserBLL userBLL = new UserBLL();

            string email = txt_email.Text;
            string senha = txt_Senha.Text;

            var isValid = userBLL.VerificarCredenciais(email, senha);

            if (isValid) {
                Frm_Games frm_Games = new Frm_Games();
                frm_Games.Show();
            }

            MessageBox.Show("Email ou senha Invalidos. Por favor tente novamente");
        }
    }
}
