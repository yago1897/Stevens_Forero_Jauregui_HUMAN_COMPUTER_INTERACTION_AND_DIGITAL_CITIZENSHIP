MODELO -ENTIDAD-RELACIÓN

El sistema cuenta con las siguientes entidades: Usuario, Rol, Menu, MenuRol, Producto, Categoria, Venta, DetalleVenta, NumeroDocumento

Relaciones entre entidades

- **Usuario – Rol (N:1)** 
  - Un usuario pertenece a un único rol.
  - Ejemplo: Administrador, Cliente, Vendedor.
  - Motivo: Controlar permisos y responsabilidades del sistema.

- **Rol – Menú (N:M)** 
  - Esta relación se hace a través de la tabla MenuRol.
  - Un rol puede tener acceso a varios menús, y un menú puede estar habilitado para varios roles.
  - Motivo: Permitir la administración de permisos y accesos en la interfaz del sistema.

- **Producto – Categoría (N:1)**
  - Cada producto pertenece a una categoría.
  - Motivo: Clasificación para facilitar la búsqueda y organización de los productos.

- **Venta – DetalleVenta (1:N)**
  - Una venta puede tener varios detalles de venta.
  - Motivo: Representar las distintas líneas de productos comprados en una transacción.

- **DetalleVenta – Producto (N:1)**
  - Cada detalle de venta está asociado a un único producto.
  - Motivo: Especificar qué producto se vendió en cada línea.
 
- **Venta – NumeroDocumento (N:1)**
  - Cada venta se asocia con un número de documento (factura, boleta, ticket).
  - Motivo: Garantizar numeración secuencial y trazabilidad de las transacciones.

