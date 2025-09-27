# Conexión de Base de Datos
---


**Introducción**

La conexión de la aplicación al motor de base de datos es para garantizar la persistencia de los datos. En este caso, se utiliza SQL Server 2019 como gestor de base de datos y Entity Framework Core como ORM, lo que permite trabajar con objetos en lugar de escribir directamente sentencias SQL.

En el proyecto SistemaVenta.API (ASP.NET Core con C#), la conexión a la base de datos se realiza principalmente mediante Entity Framework Core (EF Core), que actúa como un ORM (Object Relational Mapper) para mapear los modelos a tablas SQL Server.

---



**Configuración de la conexión**

**1. Archivo appsettings.json**

En este archivo se define la cadena de conexión hacia SQL Server: donde está el nombre del servidor, el nombre de la base de datos como se aprecia en la imagen. 

<img width="1129" height="653" alt="image" src="https://github.com/user-attachments/assets/94e0f58c-b458-485b-afd4-8efa2283f5f3" />

---


**2. Clase ApplicationDbContext (DbContext)**

Esta clase actúa como puente entre los modelos y la base de datos:las tablas de base de datos se convierten a entidades clase en C#, es decir, crea las entidades a partir de la base de datos.

<img width="1126" height="654" alt="image" src="https://github.com/user-attachments/assets/9f7c5bde-a457-40e3-b70b-63064fc0dbae" />

No solo se mapean las tables de base de datos a entidades en C#, también sus propiedades como se aprecia en las siguientes imágenes

**Categoria**

<img width="1222" height="292" alt="image" src="https://github.com/user-attachments/assets/46a7af14-f620-48f2-9cfc-f02416ba3496" />

---

**DetalleVenta**

<img width="1232" height="332" alt="image" src="https://github.com/user-attachments/assets/b9e0ed28-dfa5-4c81-aad3-cb5cf080138a" />

---
**Menu**

<img width="1239" height="284" alt="image" src="https://github.com/user-attachments/assets/cc1fa504-51ae-477f-bd1e-7e701d2cce97" />

---

**MenuRol**

<img width="1224" height="263" alt="image" src="https://github.com/user-attachments/assets/0d661f58-f0b9-49f6-a6a6-f5713592652f" />

---

**NumeroDocumento**

<img width="1225" height="200" alt="image" src="https://github.com/user-attachments/assets/a41c633c-4ca3-4529-9e4b-501a5bc7e6e3" />

---

**Producto**

<img width="1225" height="396" alt="image" src="https://github.com/user-attachments/assets/1a796ca4-54e5-481a-a647-6d45af59e14b" />

---

**Rol**

<img width="1226" height="234" alt="image" src="https://github.com/user-attachments/assets/01ad2803-f994-4ffb-ab91-8d149767bc2d" />

---

**Usuario**

<img width="1224" height="455" alt="image" src="https://github.com/user-attachments/assets/4cafd48e-8fc9-47ab-9fc1-5cee0fe2104d" />

---

**Venta**

<img width="1227" height="341" alt="image" src="https://github.com/user-attachments/assets/d3a6e65a-8145-4592-b753-a4f8c549736c" />


---

**Registro en la clase Dependencia.cs**

En esta clase se registra el DbContext y se vincula a la cadena de conexión como se aprecia en la imagen: 

<img width="1149" height="642" alt="image" src="https://github.com/user-attachments/assets/21d57bef-42da-4af7-a49d-16abd87b6757" />


---


**Conclusión**

La conexión de base de datos en el sistema de ventas Ecommerce se logra mediante Entity Framework Core y SQL Server, asegurando la persistencia y gestión eficiente de los datos a través de un contexto centralizado (DbventaContext). Esto permite que los controladores trabajen directamente con objetos sin necesidad de SQL explícito.


---


**Referencias**

- https://learn.microsoft.com/en-us/ef/core/get-started/











