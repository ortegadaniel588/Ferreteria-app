using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class index : System.Web.UI.Page
        
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            asignarMensaje();
        }

        public void asignarMensaje() {
            Car objCar = new Car();
            string msj = objCar.Stop();
            lbuno.Text = msj;
        }
        
    }
}