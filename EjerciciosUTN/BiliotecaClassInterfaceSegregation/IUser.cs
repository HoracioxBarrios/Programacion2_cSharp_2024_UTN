using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiliotecaClassInterfaceSegregation
{
    public interface IUser
    {
        void AddUser();
        void DeleteUser();
        void UpdateUser();
        void GetUser();
    }
}
/*Este es un ejemplo de lo que NO combiene hacer ya que:
 LA IDEA ES QUE UNA CLASS NO TENGA QUE USAR OBLIGADAMENTE UNA INTERFACE CON UN METODO 
QUE NO NECESITA.

 * Combiene tener interfaces mas especificas o mas chicas con menos metodos.
 */