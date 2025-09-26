**Controladores**
---
**1. Introducción**

Los controladores del Sistema de Venta Ecommerce realizado en ASP.NET Core se encargan de recibir las peticiones HTTP, procesarlas y devolver una respuesta al cliente. Actúan como intermediarios entre la vista o el cliente (frontend) y la lógica de negocio (servicios/modelos). En el sistema de venta eCommerce, cada controlador gestiona un módulo específico de la aplicación, esto garantiza la correcta separación de responsabilidades.

---

**Controladores del sistema**

**2. Estilo Arquitectónico**

**Descripción:** El sistema sigue una arquitectura en capas (N-Layered Architecture), estructurado de la siguiente manera:

**1. AccesoController.cs**
  - Gestiona la autenticación y autorización de usuarios (login).

**2. CategoriaController.cs**
  - Permite administrar las categorías de productos (creación, edición y eliminación).

**3. DashBoardController.cs**
  - Controla la visualización del panel principal, mostrando indicadores de ventas y productos.

**4. ListaProductos.cs**
  - Expone los listados de productos disponibles para la venta.

**5. MenuController.cs**
  - Administra los menús de navegación de la aplicación.

**6. ProductoController.cs**
  - Gestiona la creación, modificación y eliminación de productos.

**7. RolController.cs**
  - Administra los roles de los usuarios y sus permisos.

**8. UsuarioController.cs**
  - Controla la gestión de usuarios (registro, edición, eliminación).

**9. VentaController.cs**
  - Se encarga de registrar ventas, formas de pago y asociar productos a las compras realizadas.

---


**Controladores del Sistema de Venta Ecommerce**

**1. AccesoController.cs**

<img width="1183" height="519" alt="image" src="https://github.com/user-attachments/assets/b59259dc-6fd4-4fd8-9fc4-ac2fec0728dd" />

<img width="1224" height="284" alt="image" src="https://github.com/user-attachments/assets/bec1adb7-6e13-425f-9c24-7cac9ddabb43" />

---

**2. CategoriaController.cs**

<img width="1213" height="609" alt="image" src="https://github.com/user-attachments/assets/213cf871-32a5-4f41-a320-cc0ec2a5f7f0" />

---

**3. DashBoardController.cs**

<img width="1115" height="654" alt="image" src="https://github.com/user-attachments/assets/d429ddb5-3363-44ac-9c0b-c5c9e1afd6e2" />

---

**4. ListaProductos**

<img width="1280" height="738" alt="image" src="https://github.com/user-attachments/assets/7fc42821-d886-41ce-8f1c-fe8c0621934a" />

---

**5. MenuController.cs**

<img width="1104" height="648" alt="image" src="https://github.com/user-attachments/assets/f67d7eac-4feb-4bdf-9f20-ff35af70fdb8" />

---

**6. ProductoController.cs**

<img width="1108" height="646" alt="image" src="https://github.com/user-attachments/assets/60982ef0-3f08-4213-ba2f-87517880ba6d" />

<img width="1234" height="328" alt="image" src="https://github.com/user-attachments/assets/8101abb4-e262-458a-ad6a-88afcf4e5f68" />

<img width="1238" height="590" alt="image" src="https://github.com/user-attachments/assets/2823514c-45be-447e-babb-815c5c4aec80" />

---

**7. RolController.cs**

<img width="1133" height="647" alt="image" src="https://github.com/user-attachments/assets/bd182bb2-d593-4f69-8e5e-f3bdce797fbf" />

---

**8. UsuarioController.cs**

<img width="1130" height="641" alt="image" src="https://github.com/user-attachments/assets/4041eee0-f55a-4f18-8ce6-752db6185f3a" />

<img width="1253" height="286" alt="image" src="https://github.com/user-attachments/assets/bedd0f4e-b98d-4400-a705-562dc3726516" />

<img width="1208" height="273" alt="image" src="https://github.com/user-attachments/assets/d34a9273-8cdc-49b8-b9a7-f9c1cb204b2b" />


<img width="1229" height="508" alt="image" src="https://github.com/user-attachments/assets/f60801b0-f21b-438c-968e-d2e6378bbbbf" />

---

**9. VentaController.cs**

<img width="1130" height="650" alt="image" src="https://github.com/user-attachments/assets/fc10d8bb-3715-4da2-b584-73122fe1a863" />

<img width="1122" height="649" alt="image" src="https://github.com/user-attachments/assets/a21a28d3-d689-4e58-aefa-7cb0b128ab7c" />

<img width="1227" height="642" alt="image" src="https://github.com/user-attachments/assets/5c011863-3e83-4286-b175-ac9f1bd0a4b4" />


---

**Conclusión**

La organización de los controladores permite mantener una arquitectura clara y escalable, donde cada módulo del sistema de ventas cuenta con un controlador independiente, esto facilita su mantenimiento, pruebas, escalabilidad y futuras ampliaciones.


---

**Referencias**

https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers













