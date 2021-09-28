using R5Ficha.MVC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R5Ficha
{
    public partial class FrmLogin : MaterialSkin.Controls.MaterialForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            MVC.Util.itensUtil.configuraCores(this);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Hide();
            new MVC.View.FrmPrincipal().Show();            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new MVC.View.FrmConexao().ShowDialog();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
