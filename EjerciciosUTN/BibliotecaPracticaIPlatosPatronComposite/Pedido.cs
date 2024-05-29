using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPracticaIPlatosPatronComposite
{
    public class Pedido
    {
        private List<IPlato> listaPlatoOBebidasParaDelivery;
        private int IDPedido;
        private bool seEntrego = false;
        private string SiEsParaLocalOParaDelivery;


    }
}
