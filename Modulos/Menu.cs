using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD_MODULOS.Modulos
{
  public  class Menu
    {

        public string nombre { get; set; }
        public string icono { get; set; }

        public List<Submenu> ListaSubmenu { get; set; }
    }
}
