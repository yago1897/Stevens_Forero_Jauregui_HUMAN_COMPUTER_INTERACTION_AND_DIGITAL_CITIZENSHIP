# Modelos y rutas

**Introducción**

Los modelos representan las entidades de negocio del sistema de ventas Ecommerce, mientras que las rutas definen los endpoints de acceso a dichas entidades a través de la API. Esta separación permite organizar la lógica de datos y facilitar la interacción entre cliente y servidor.

---



**Modelos principales**

- **Usuario:** representa los datos de los usuarios (nombre, correo, contraseña, rol, etc.).
- **Rol:** define los permisos de los usuarios.
- **Producto:** contiene la información de los productos (nombre, categoría, stock, precio, etc.).
- **Categoría:** agrupa productos en categorías.
- **Venta:** almacena las transacciones realizadas, con fecha, forma de pago, total, etc.
- **DetalleVenta:** registra los productos asociados a cada venta (cantidad, precio unitario, subtotal).

---

**Ejemplo del modelo:** Usuario.cs





