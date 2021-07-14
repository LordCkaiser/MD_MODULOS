using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MD_MODULOS.Conexion;
using MD_MODULOS.Modulos;

namespace MD_MODULOS
{
    public partial class MD_MASTER : Form
    {
        private int idusuario;
        public MD_MASTER(int idusuario_esperado=0)
        {
            InitializeComponent();

            idusuario = idusuario_esperado;
        }

        private void MD_MASTER_Load(object sender, EventArgs e)
        {
            //LISTA MENU//
            List<Modulos.Menu> permisos_esperados = CDusuario.Obtener_Permisos(idusuario);
            MenuStrip Mimenu = new MenuStrip();

            foreach (Modulos.Menu objMenu in permisos_esperados)
            {
                ToolStripMenuItem Menupadre = new ToolStripMenuItem(objMenu.nombre);
                Menupadre.TextImageRelation = TextImageRelation.ImageAboveText;

                string rutaimagen = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../") + objMenu.icono);
                Menupadre.Image = new Bitmap(rutaimagen);
                Menupadre.ImageScaling = ToolStripItemImageScaling.None;
                Mimenu.Items.Add(Menupadre);

                //LISTA SUBMENU//

                foreach (Submenu objsubmenu in objMenu.ListaSubmenu) {

                 ToolStripMenuItem Menuhijo = new ToolStripMenuItem(objsubmenu.nombre,null,llamar_formulariosSubmenu,objsubmenu.nombre_formulario);
                 Menupadre.DropDownItems.Add(Menuhijo);
                }
                }
            this.MainMenuStrip = Mimenu;
            Controls.Add(Mimenu);
            }

        //METODO LLAMAR AL FORMULARIO DEL SUBMENU//
        private void llamar_formulariosSubmenu(object sender, System.EventArgs e) {

            ToolStripMenuItem seleccmenu = (ToolStripMenuItem)sender;

            Assembly asm = Assembly.GetEntryAssembly();
            Type elemento = asm.GetType(asm.GetName().Name + "."+seleccmenu.Name);

            if (elemento == null)
            {
                MessageBox.Show("Formulario no Encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                Form frmcreado = (Form)Activator.CreateInstance(elemento);
                int encontrado = this.MdiChildren.Where(x => x.Name == frmcreado.Name).ToList().Count();

                if (encontrado != 0) {

                ((Form)(this.MdiChildren.Where(x => x.Name == frmcreado.Name).FirstOrDefault())).WindowState = FormWindowState.Normal;
                    ((Form)(this.MdiChildren.Where(x => x.Name == frmcreado.Name).FirstOrDefault())).Activate();


                }
                else
                {
                    frmcreado.MdiParent = this;
                    frmcreado.Show();
                }
                }
            }
        }
}
