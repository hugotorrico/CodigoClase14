using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase14
{
    public class ProveedorRopa : IProveedor
    {
        public string Direccion { get; set; }
        public void EnviarPedido(Pedido pedido)
        {
            Console.WriteLine("Enviar Pedido Proveedor Ropa");
            Console.WriteLine($"Nombre: {pedido.Nombre}");
            Console.WriteLine($"Costo:  {pedido.Costo}");
            Console.WriteLine($"Direccion:  {Direccion}");
        }
        public void RecibirPedido(Pedido pedido)
        {
            Console.WriteLine("Enviar Pedido Proveedor Ropa");
            Console.WriteLine($"Nombre: {pedido.Nombre}");
            Console.WriteLine($"Costo:  {pedido.Costo}");
            Console.WriteLine($"Direccion:  {Direccion}");
        }
    }
}
