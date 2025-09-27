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

**Ahora veremos un ejemplo práctico de autenticación por medio de JWT(Jason-Web-Token) en .Net-Core y con el cliente Posman + encriptación de la contraseña**
---

Se debe instalar las librerías de JWT como se ve en la imagen
![image](https://github.com/user-attachments/assets/6f7c3a16-2e48-43a7-89e9-76d24ee23b28)


Luego se crea una clase llamada"Utilidades" donde se crea un método de encriptación llamado "encriptarSHA256", esto con el fin de al registrar un usuario encripte la contraseña por motivos de seguridad
![image](https://github.com/user-attachments/assets/bff4651f-516a-4915-8ecd-5bfdaff844ac)

Se crea otro método llamado "generarJWT" que genera el token con el propósito de que cuando se loguee al iniciar sesión el usuario con las credenciales le genere un token y así tenga permitido la autorización de ingresar a las demás apis de Listar, editar, eliminar, consultar productos o pedidos
![image](https://github.com/user-attachments/assets/254eab5f-f34b-4d1c-9127-1cc3474ab8da)

En el controlador llamado "Acceso" se crea la acción de "Registrarse" como se ve en la imagen

![image](https://github.com/user-attachments/assets/6171c535-563a-4c45-af34-dddabf050e62)

Se crea la acción de "Login" con el propósito de que al iniciar sesión con las credenciales correctas le genere el token y le permita al usuario tener la autorización de acceder a las demas apis de Listar, editar, eliminar, consultar productos o pedidos
![image](https://github.com/user-attachments/assets/f75a16aa-f88f-4461-b0ff-c5adb49f8235)

Este es el controlador de Productos el cual como se ve en la imagen se coloca la palabra "Authorize" con el fin de que solo pueden acceder a esta api quien este autorizado por un token

![image](https://github.com/user-attachments/assets/afa486c0-6f34-4e24-8aa9-4d5a49de4d75)

Al realizar la prueba con la herramienta "Swagger" y "Postman" e intentar acceder a la api de Productos me arroja un mensaje de 401 que no estoy autorizado como se muestra en las imágenes

![image](https://github.com/user-attachments/assets/daf1e815-a691-41dc-94b4-0644bc8cbf51)
![image](https://github.com/user-attachments/assets/f0bf5884-efec-40de-ac4b-6bc132dd03f0)

Se procede a realizar la siguiente prueba de registrar un usuario para crearle credenciales y encriptar su contraseña 
Como se observa en la imagen la contraseña es "123456"

![image](https://github.com/user-attachments/assets/4e467c9d-88e6-44a5-bf9a-bb6263d4c60d)

Y se observa que la contraseña quedo encriptada en base de datos como se aprecia en la imagen

![image](https://github.com/user-attachments/assets/4690aa20-2dd5-4b8c-88a4-c5ffe4adef00)

Si intentamos de acceder con una contraseña diferente no arroja el token que se espera que arroje y toma el valor de "false" como se aprecia en la imagen

![image](https://github.com/user-attachments/assets/700e1767-3854-4b33-91ff-ea39cd188f54)

Si por el contrario ingresamos las credenciales correctas con la contraseña correcta, genera el token como se ve en la imagen y como se esperaba

![image](https://github.com/user-attachments/assets/26808a8a-e9fb-4217-b02e-42f3cab18a3f)

Y con el token generado ya podriamos ingresar a la api de "Productos" como se ve en la imagen, el token se ingresa en el campo señalado con una flecha en color rojo

![image](https://github.com/user-attachments/assets/2b361c66-32b3-42c5-81c1-9a342b32cd0c)




**Conclusión**

La API del Sistema de Venta Ecommerce está estructurada en módulos que exponen endpoints REST bajo HTTP. Se emplea autenticación JWT para garantizar la seguridad de las operaciones y cada controlador implementa operaciones CRUD o consultas específicas de negocio. Esto facilita la integración con el frontend desarrollado en Angular.

---


**Referencias**

- https://learn.microsoft.com/en-us/aspnet/core/web-api



