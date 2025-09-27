# Modelos y rutas

**1. Introducción**

Los modelos representan las entidades de negocio del sistema de ventas Ecommerce, mientras que las rutas definen los endpoints de acceso a dichas entidades a través de la API. Esta separación permite organizar la lógica de datos y facilitar la interacción entre cliente y servidor.

---



**2. Modelos principales**

En ASP.NET Core, y más específicamente en el Sistema de Ventas Ecommerce, los modelos representan las entidades del dominio de la aplicación, es decir, los objetos con los que se trabaja en la base de datos y en la lógica de negocio.

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


**3. Rutas**

En ASP.NET Core, las rutas definen el camino por el cual el cliente (frontend - Angular o Postman) accede a un recurso del backend.
Básicamente, cada Controlador expone endpoints accesibles mediante URLs, y las rutas se especifican con atributos como [Route], [HttpGet], [HttpPost], etc.


**Rutas en:** UsuarioController.cs

<img width="519" height="519" alt="image" src="https://github.com/user-attachments/assets/60664be0-a096-4964-9b40-8f20566520d1" />

<img width="690" height="326" alt="image" src="https://github.com/user-attachments/assets/1b5a0198-2673-4e65-9c4d-81e8f43664ca" />

<img width="531" height="324" alt="image" src="https://github.com/user-attachments/assets/caecc04a-04cd-417b-b79f-4dae83462415" />

---

**Rutas en:** RolController.cs

<img width="639" height="560" alt="image" src="https://github.com/user-attachments/assets/f132f29f-2695-45a2-9842-702b61b8a23a" />


---


**Rutas en:** ProductoController.cs

<img width="536" height="558" alt="image" src="https://github.com/user-attachments/assets/f92cbeb0-e423-43d3-ae4c-e94dbc41606e" />

<img width="652" height="349" alt="image" src="https://github.com/user-attachments/assets/8b1970bb-80a9-4972-b6cf-09100320b673" />

<img width="562" height="548" alt="image" src="https://github.com/user-attachments/assets/2cb3c175-60ad-469a-acc3-a761c55d92bd" />


---


**Rutas en:** CategoríaController.cs

<img width="639" height="567" alt="image" src="https://github.com/user-attachments/assets/a24f0588-889e-44ab-96c1-3d6299303edf" />


---


**Rutas en:** VentaController.cs


<img width="578" height="583" alt="image" src="https://github.com/user-attachments/assets/e0d1c5e4-4ea6-4ded-a4fb-ca4226d673c2" />

<img width="823" height="346" alt="image" src="https://github.com/user-attachments/assets/0e00a6fb-2c7f-4b8f-a61b-f031c788ec42" />

<img width="618" height="311" alt="image" src="https://github.com/user-attachments/assets/f7f52126-9e5d-4c8f-9071-c8754c89c798" />


---


**Rutas en:** MenuController.cs

<img width="493" height="539" alt="image" src="https://github.com/user-attachments/assets/0ff3c6c8-3cef-49b9-b4aa-37a7630bf369" />


---


**Rutas en:** DashBoardController.cs

<img width="554" height="580" alt="image" src="https://github.com/user-attachments/assets/8d99f114-9a76-4959-bf72-e9f273c4ed1a" />

Con estas rutas quedan cubiertas todas las rutas de todos los módulos
---


**4. Conclusión**

La combinación de modelos y rutas garantiza una arquitectura limpia en el backend: los modelos gestionan la representación de datos y las rutas permiten exponerlos a través de la API para su consumo por el cliente que puede ser Postman o frontend que se use, en este caso en Angular 15.

---


**5. Referencias**

 - https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/routing


































