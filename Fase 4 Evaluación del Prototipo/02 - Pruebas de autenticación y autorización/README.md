# Pruebas de autenticación y autorización
---

**Introducción**

En esta etapa se verifican y realizan pruebas de inicio de sesión (autenticación) y el control de accesos a los distintos módulos del sistema (autorización), con el fin de que solo los usuarios con credenciales válidas puedan ingresar y que sus permisos se ajusten al rol asignado (administrador o empleado) en el Sistema Venta Ecommerce.

---


**1. Objetivos de la prueba**

Validar que el sistema permite el acceso únicamente a usuarios registrados con credenciales correctas.

Verificar que usuarios no autenticados no puedan acceder directamente a las funcionalidades del sistema (URLs protegidas).

Confirmar que la asignación de roles (Administrador, Empleado) restringe o habilita las funcionalidades adecuadas.

Comprobar que el sistema usa JWT (JSON Web Token) de manera correcta en las solicitudes a la API.


---


**2. Prueba práctica con el cliente Posman**

---


Se debe instalar las librerías de JWT como se ve en la imagen
![image](https://github.com/user-attachments/assets/6f7c3a16-2e48-43a7-89e9-76d24ee23b28)


---


Luego se crea una clase llamada"Utilidades" donde se crea un método de encriptación llamado "encriptarSHA256", esto con el fin de al registrar un usuario encripte la contraseña por motivos de seguridad

---
![image](https://github.com/user-attachments/assets/bff4651f-516a-4915-8ecd-5bfdaff844ac)

---

Se crea otro método llamado "generarJWT" que genera el token con el propósito de que cuando se loguee al iniciar sesión el usuario con las credenciales le genere un token y así tenga permitido la autorización de ingresar a las demás apis de Listar, editar, eliminar, consultar productos o pedidos
![image](https://github.com/user-attachments/assets/254eab5f-f34b-4d1c-9127-1cc3474ab8da)

---

En el controlador llamado "Acceso" se crea la acción de "Registrarse" como se ve en la imagen

---

![image](https://github.com/user-attachments/assets/6171c535-563a-4c45-af34-dddabf050e62)

---

Se crea la acción de "Login" con el propósito de que al iniciar sesión con las credenciales correctas le genere el token y le permita al usuario tener la autorización de acceder a las demas apis de Listar, editar, eliminar, consultar productos o pedidos

---

![image](https://github.com/user-attachments/assets/f75a16aa-f88f-4461-b0ff-c5adb49f8235)

---

Este es el controlador de Productos el cual como se ve en la imagen se coloca la palabra "Authorize" con el fin de que solo pueden acceder a esta api quien este autorizado por un token

---

![image](https://github.com/user-attachments/assets/afa486c0-6f34-4e24-8aa9-4d5a49de4d75)

---

Al realizar la prueba con la herramienta "Swagger" y "Postman" e intentar acceder a la api de Productos me arroja un mensaje de 401 que no estoy autorizado como se muestra en las imágenes

---

![image](https://github.com/user-attachments/assets/daf1e815-a691-41dc-94b4-0644bc8cbf51)
![image](https://github.com/user-attachments/assets/f0bf5884-efec-40de-ac4b-6bc132dd03f0)

---

Se procede a realizar la siguiente prueba de registrar un usuario para crearle credenciales y encriptar su contraseña 
Como se observa en la imagen la contraseña es "123456"

---

![image](https://github.com/user-attachments/assets/4e467c9d-88e6-44a5-bf9a-bb6263d4c60d)

---

Y se observa que la contraseña quedo encriptada en base de datos como se aprecia en la imagen

---

![image](https://github.com/user-attachments/assets/4690aa20-2dd5-4b8c-88a4-c5ffe4adef00)

---

Si intentamos de acceder con una contraseña diferente no arroja el token que se espera que arroje y toma el valor de "false" como se aprecia en la imagen

---

![image](https://github.com/user-attachments/assets/700e1767-3854-4b33-91ff-ea39cd188f54)

---

Si por el contrario ingresamos las credenciales correctas con la contraseña correcta, genera el token como se ve en la imagen y como se esperaba

---

![image](https://github.com/user-attachments/assets/26808a8a-e9fb-4217-b02e-42f3cab18a3f)

---

Y con el token generado ya podriamos ingresar a la api de "Productos" como se ve en la imagen, el token se ingresa en el campo señalado con una flecha en color rojo

---

![image](https://github.com/user-attachments/assets/2b361c66-32b3-42c5-81c1-9a342b32cd0c)


---

**Conclusión**

Las pruebas de autenticación y autorización para el Sistema Venta Ecommerce aseguran que el sistema sea seguro y confiable, esto evita accesos indebidos y garantizan que los usuarios solo puedan operar dentro de los permisos definidos por su rol. Esto refuerza la integridad de los datos y la correcta aplicación de las reglas de negocio.

---

**Referencias**

- https://learn.microsoft.com/en-us/aspnet/core/web-api
