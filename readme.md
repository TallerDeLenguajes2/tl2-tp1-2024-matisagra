## RESPUESTAS
CADETERIA - CADETE POR AGREGACION
CADETE - PEDIDO POR AGREGACION
PEDIDOS - CLIENTE POR COMPOSICION

Cadetería
AsignarPedido(Cadete cadete, Pedidos pedido): Asigna un pedido a un cadete.
ReasignarPedido(Cadete anterior, Cadete nuevo, Pedidos pedido): Reasigna un pedido de un cadete a otro.
AgregarCadete(Cadete cadete): Añade un nuevo cadete a la cadetería.
EliminarCadete(Cadete cadete): Elimina un cadete de la cadetería.
EliminarPedido(Pedidos pedido): Elimina un pedido y el cliente asociado.
GenerarInforme(): Genera un informe sobre la actividad de la cadetería.

Cadete
EntregarPedido(Pedidos pedido): Marca un pedido como entregado.
ListarPedidos(): Muestra los pedidos asignados al cadete.
AgregarPedido(Pedidos pedido): Añade un pedido a la lista de pedidos del cadete.
EliminarPedido(Pedidos pedido): Elimina un pedido de la lista de pedidos del cadete.
CalcularJornal(): Calcula el jornal a cobrar por el cadete.
CambiarEstadoPedido: este método encuentra un pedido específico en una lista por su número y cambia su estado si el pedido existe

-Atributos: Todos privados para mantener los detalles internos a salvo y controlar cómo se accede a ellos. 
-Métodos: Todos públicos para permitir que otras partes del código interactúen con la clase y usen sus funcionalidades.
