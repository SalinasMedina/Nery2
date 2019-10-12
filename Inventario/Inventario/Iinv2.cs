using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Inventario
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "Iinv2" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface Iinv2
    {
        [OperationContract]
        void guardar(int a, string b, int c, int d, string e);
        [OperationContract]
        string [] buscar(int cla);
        [OperationContract]
        string convertir(string n);
        [OperationContract]
        string toText(double value);
    }
}
