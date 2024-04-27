using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase14
{
    public class GestorPedidos
    {
        private readonly IProveedor _proveedor;

        public GestorPedidos( IProveedor proveedor)
        {
            _proveedor = proveedor;
        }

        public void EnviarTipoProducto(Pedido pedido)
        {
            _proveedor.EnviarPedido(pedido);
        }
        public void RecibirTipoProducto(Pedido pedido)
        {
            _proveedor.RecibirPedido(pedido);
        }

        
    }
}
