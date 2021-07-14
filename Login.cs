using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MD_MODULOS.Conexion;
using MD_MODULOS.Modulos;


namespace MD_MODULOS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            int idusuario_esperado = CDusuario.loguear(textUsuario.Text, textPass.Text);

            if (idusuario_esperado != 0)
            {
                MessageBox.Show("Bienvenido", "Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                this.Hide();
                MD_MASTER mdi = new MD_MASTER(idusuario_esperado);
                mdi.Show();
            }
            else {

                MessageBox.Show("Usuario no encontrado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
