using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase14
{
    public class ProveedorElectronica : IProveedor
    {
        public string PaginaWeb { get; set; }
        public void EnviarPedido(Pedido pedido)
        {
            Console.WriteLine("Enviar Pedido Proveedor Electrónica");
            Console.WriteLine($"Nombre: {pedido.Nombre}");
            Console.WriteLine($"Costo:  {pedido.Costo}");
            Console.WriteLine($"PaginaWeb:  {PaginaWeb}");

        }

        public void RecibirPedido(Pedido pedido)
        {
            Console.WriteLine("Recibir Pedido Proveedor Electrónica");
            Console.WriteLine($"Nombre: {pedido.Nombre}");
            Console.WriteLine($"Costo:  {pedido.Costo}");
            Console.WriteLine($"PaginaWeb:  {PaginaWeb}");
        }
    }
}
