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

- **Método:** **GET** /api/Categoria →  Lista todos las categorias

---


**Módulo Venta**
  
**Endpoint completo:** http://localhost:5364/api/Venta 
 
- **Método:** **POST** /api/Venta → Registrar venta. **Parametros:** → [FromBody], VentaDTO
- **Método:** **GET**  /api/Venta → Obtiene el hostorial de la venta por filtros de fecha. **Parametros:** → (string buscarPor, string? numeroVenta, string? fechaInicio, string? fechaFin)

- **Método:** **GET** /api/Venta → Obtiene el reporte de la venta por filtros de fecha. **Parametros:** → (string? fechaInicio, string? fechaFin)





