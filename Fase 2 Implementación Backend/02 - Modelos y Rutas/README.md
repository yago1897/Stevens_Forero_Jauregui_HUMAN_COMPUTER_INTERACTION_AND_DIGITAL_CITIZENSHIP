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

**Modelo:** Usuario.cs

<img width="856" height="490" alt="image" src="https://github.com/user-attachments/assets/ef5156db-73a4-4665-b1f7-b6bf06d802e1" />

---


**Modelo:** Rol.cs

<img width="601" height="314" alt="image" src="https://github.com/user-attachments/assets/b1b63ba7-5e94-49a7-aeda-cc7ecc7f5ba1" />

---

**Modelo:** Producto.cs

<img width="712" height="465" alt="image" src="https://github.com/user-attachments/assets/d40e11e4-fd59-42ec-ba0e-a1dda7bb2ddd" />

---


**Modelo:** Categoria.cs

<img width="638" height="319" alt="image" src="https://github.com/user-attachments/assets/57a2f1f0-7fcd-479c-a440-0cb662fff149" />

---


**Modelo:** Venta.cs

<img width="683" height="349" alt="image" src="https://github.com/user-attachments/assets/e0293a42-b131-41bf-92a6-37829e2a3e64" />

---


**Modelo:** DetalleVenta.cs

<img width="526" height="421" alt="image" src="https://github.com/user-attachments/assets/e99e3311-770e-4312-a0d8-b17b9c85233d" />

---







