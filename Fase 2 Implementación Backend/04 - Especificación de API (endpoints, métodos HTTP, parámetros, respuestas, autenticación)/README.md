# Especificación de API (endpoints, métodos HTTP, parámetros, respuestas, autenticación)

---

**Inroducción**

La Especificación de la API describe de manera estructurada los endpoints disponibles en el backend del Sistema de Venta Ecommerce, indicando los métodos HTTP, parámetros de entrada, respuestas esperadas y el mecanismo de autenticación utilizado. Esta documentación facilita la integración con el frontend desarrollado en Angular 15 y también asegura una comunicación clara entre el backend y frontend.


---

**Especificación de la API – Sistema de Venta eCommerce**

**Autenticación**
- **Tipo:** JWT (JSON Web Token).
- **Método:** Al iniciar sesión (/api/Acceso/Login) se genera un token.
- **Uso:** Se debe incluír en el encabezado de cada petición:
- **Authorization:** Bearer <token> - El token se genera para permitirle al usuario acceder a las demás apis como veremos más adelante en un ejemplo con el cliente Posman

---

**Módulo de Acceso (Login)**
**Endpoint:** /api/Acceso/Login
- **Método:** POST
- **Patametros:** LoginDTO

{

    "correo": "Admin@hotmail.com",
    
    "clave": "123"
  
}

**Respuesta (200 OK):**

{

    "isSuccess": true,
    
    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
  
}


---


**Módulo Usuario**
  
**Endpoint completo:** http://localhost:5364/api/Usuario/Lista 

- **Método:** **GET** /api/Usuario →  Lista todos los usuarios. 
- **Método:** **POST** /api/Usuario → Crear usuario. **Parametros:** → [FromBody], UsuarioDTO
- **Método:** **PUT**  /api/Usuario/{id} → Modificar usuario. **Parametros:** → [FromBody], UsuarioDTO
- **Método:** **DELETE** /api/Usuario/{id} → Eliminar usuario. **Parametros:** → int id

---


**Módulo Rol**
  
**Endpoint completo:** http://localhost:5364/api/Rol/Lista 

- **Método:** **GET** /api/Rol →  Lista todos los Roles.

---


**Módulo Producto**
  
**Endpoint completo:** http://localhost:5364/api/Producto/Lista 

- **Método:** **GET** /api/Producto →  Lista todos los productos. 
- **Método:** **POST** /api/Producto → Crear productos. **Parametros:** → [FromBody], ProductoDTO
- **Método:** **PUT**  /api/Producto/{id} → Modificar productos. **Parametros:** → [FromBody], ProductoDTO
- **Método:** **DELETE** /api/Producto/{id} → Eliminar productos. **Parametros:** → int id

---

**Módulo Categoria**
  
**Endpoint completo:** http://localhost:5364/api/Categoria/Lista 

- **Método:** **GET** /api/Categoria →  Lista todas las categorias

---


**Módulo Venta**
  
**Endpoint completo:** http://localhost:5364/api/Venta 
 
- **Método:** **POST** /api/Venta → Registrar venta. **Parametros:** → [FromBody], VentaDTO
- **Método:** **GET**  /api/Venta/Historial?fechaInicio=2025-01-01&fechaFin=2025-01-31 → Obtiene el historial de la venta buscado por filtros de fecha. **Parametros:** → (string buscarPor, string? numeroVenta, string? fechaInicio, string? fechaFin)

- **Método:** **GET** /api/Venta → Obtiene el reporte de la venta por filtros de fecha. **Parametros:** → (string? fechaInicio, string? fechaFin)

---


**Módulo Reporte**

**Endpoint completo:** http://localhost:5364/api/Reporte

- **Método:** **GET** /api/Reporte/Excel?fechaInicio=2025-01-01&fechaFin=2025-01-31 → Genera reporte en excel buscado por filtros de fecha. **Parametros:** → (string? fechaInicio, string? fechaFin)

---

**Módulo DashBoard**

**Endpoint completo:** http://localhost:5364/api/DashBoard

- **Método:** **GET** /api/DashBoard/Resumen → Datos estadísticos de ventas, ingresos totales, ventas totales, produtos totales

---


**Conclusión**

La API del Sistema de Venta Ecommerce está estructurada en módulos que exponen endpoints REST bajo HTTP. Se emplea autenticación JWT para garantizar la seguridad de las operaciones y cada controlador implementa operaciones CRUD o consultas específicas de negocio. Esto facilita la integración con el frontend desarrollado en Angular.

---


**Referencias**

- https://learn.microsoft.com/en-us/aspnet/core/web-api



