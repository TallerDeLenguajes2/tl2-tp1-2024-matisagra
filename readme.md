# Cadetería

Este proyecto implementa un sistema de gestión para un servicio de cadetería, donde se pueden asignar pedidos a cadetes, gestionar la entrega de pedidos, y generar informes sobre las actividades de la cadetería. La aplicación está estructurada en torno a las siguientes clases principales: **Cadetería**, **Cadete**, **Pedidos**, y **Cliente**.

## Clases y Métodos

### Cadetería

La clase **Cadetería** maneja la administración general de los cadetes y los pedidos. Los métodos disponibles en esta clase son:

- **AsignarPedido(Cadete cadete, Pedidos pedido)**: Asigna un pedido a un cadete.
- **ReasignarPedido(Cadete anterior, Cadete nuevo, Pedidos pedido)**: Reasigna un pedido de un cadete a otro.
- **AgregarCadete(Cadete cadete)**: Añade un nuevo cadete a la cadetería.
- **EliminarCadete(Cadete cadete)**: Elimina un cadete de la cadetería.
- **EliminarPedido(Pedidos pedido)**: Elimina un pedido y el cliente asociado.
- **GenerarInforme()**: Genera un informe sobre la actividad de la cadetería.

### Cadete

La clase **Cadete** representa a los cadetes que realizan las entregas. Los métodos disponibles en esta clase son:

- **EntregarPedido(Pedidos pedido)**: Marca un pedido como entregado.
- **ListarPedidos()**: Muestra los pedidos asignados al cadete.
- **AgregarPedido(Pedidos pedido)**: Añade un pedido a la lista de pedidos del cadete.
- **EliminarPedido(Pedidos pedido)**: Elimina un pedido de la lista de pedidos del cadete.
- **CalcularJornal()**: Calcula el jornal a cobrar por el cadete.
- **CambiarEstadoPedido()**: Encuentra un pedido específico en la lista del cadete por su número y cambia su estado si el pedido existe.


- **Atributos**: Todos los atributos de las clases son privados para mantener los detalles internos protegidos y controlar cómo se accede a ellos.
- **Métodos**: Todos los métodos son públicos, permitiendo que otras partes del código interactúen con las clases y utilicen sus funcionalidades.

