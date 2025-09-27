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


**Módulo Usuarios**

**Endpoint completo:** http://localhost:5364/api/Usuario/Lista 
- **Método:** **GET** /api/Usuario →  Lista todos los usuarios.
- **Método:** **POST** /api/Usuario → Crear usuario.
- **Método:** **PUT**  /api/Usuario/{id} → Modificar usuario.
- **Método:** **DELETE** /api/Usuario/{id} → Eliminar usuario.



