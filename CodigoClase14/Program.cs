// See https://aka.ms/new-console-template for more information
using CodigoClase14;

///Mis Proveedores
ProveedorRopa gamarra = new ProveedorRopa
{
    Direccion = "La Victoria"
};
ProveedorElectronica coolbox = new ProveedorElectronica
{
    PaginaWeb = "www.coolboxperu.com"
};

//Las empresas de los envíos
GestorPedidos gestorGamarra = new GestorPedidos(gamarra);
GestorPedidos gestorCoolbox = new GestorPedidos(coolbox);

//Mis pedidos
Pedido laptop = new Pedido
{
    Id = 1,
    Nombre = "Laptop",
    Costo = 2000
};
Pedido laptopEnvio = new Pedido
{
    Id = 3,
    Costo = 4000,
    Nombre = "Laptop"
};
Pedido ropa = new Pedido
{
    Id = 2,
    Nombre = "Casaca",
    Costo = 20
};
Pedido ropaEnvio = new Pedido
{
    Id = 4,
    Nombre = "Casaca",
    Costo = 50
};

//Electrónica Coolbox
gestorCoolbox.EnviarTipoProducto(laptopEnvio);
gestorCoolbox.RecibirTipoProducto(laptop);
Console.WriteLine("==========================================");

//Tienda Gamarra
gestorGamarra.EnviarTipoProducto(ropaEnvio);
gestorGamarra.EnviarTipoProducto(ropa);

Console.Read();