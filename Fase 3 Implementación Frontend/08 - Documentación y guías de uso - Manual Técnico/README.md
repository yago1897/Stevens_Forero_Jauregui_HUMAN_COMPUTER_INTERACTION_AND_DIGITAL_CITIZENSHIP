# Manual Técnico del Sistema de Venta Ecommerce

---

**Índice**

**1. Introducción**

**2. Requisitos del Sistema**
- 2.1. Hardware
- 2.2. Software

**3. Arquitectura del Sistema**

**4. Base de Datos**

**5. Instalación y Configuración**
- 4.1. Backend
- 4.2. Frontend

**6. API REST**
- 6.1. Autenticación
- 6.2. Endpoints principales

**7. Seguridad**

**8. Despliegue en Azure**

**9. Mantenimiento**

**10. Conclusión**

**11. Referencias**


---

1. Introducción

Este manual técnico tiene como objetivo proporcionar la información necesaria para la instalación, configuración, despliegue y mantenimiento del Sistema de Venta Ecommerce.
Está dirigido a desarrolladores, administradores de sistemas y personal de soporte técnico, garantizando que el sistema pueda mantenerse y evolucionar de manera ordenada y eficiente.

---


**2. Requisitos del Sistema**

**2.1. Hardware**

- Procesador: Intel i5 o superior

- Memoria RAM: mínimo 8 GB

- Almacenamiento: 500 GB disponibles

- Conexión a Internet estable

---

**2.2. Software**

**Backend:**

- Visual Studio 2022

- .NET 7 (ASP.NET Core)

- Entity Framework Core

- SQL Server 2018 o 2019

---

**Frontend:**

- Visual Studio Code

- Angular v14 o 15

- Node.js v18+

- Angular Material

---

**Control de versiones:** Git + GitHub

**Plataforma de despliegue:** Azure App Service + Azure SQL Database


---

**3. Arquitectura del Sistema**

- El sistema sigue una arquitectura en capas (N-Capas) que facilita la escalabilidad y el mantenimiento.

- Capa de Presentación (Frontend): Angular v14, consumo de API REST.

- Capa de API/Servicios: ASP.NET Core Web API con JWT para autenticación.

- Capa de Negocio: Implementación de la lógica empresarial y principios SOLID.

- Capa de repositorio: Implementación del patrón de diseño repositorio.

- Capa de Datos: Entity Framework Core con SQL Server.

- Capa IoC (Inversión de Control): SistemaVenta.IOC, para registrar interfaces y dependencias.

---

<img width="798" height="640" alt="image" src="https://github.com/user-attachments/assets/995a7302-f461-4c56-95bd-a6c33cd6a470" />


---


**4. Base de Datos**

**Motor:** SQL Server 2019

- Modelo relacional incluye las tablas: Usuario, Rol, Producto, Categoría, Venta, DetalleVenta, NumeroDocumento, Menu, MenuRol.

- Relaciones gestionadas con Entity Framework Core.

---

<img width="970" height="467" alt="image" src="https://github.com/user-attachments/assets/70966e5a-c6e7-4d49-a5f6-10449e6e5acb" />

---


**5.1. Configuración del Backend**

- Abrir la solución en Visual Studio 2022.

- crear las capas ya mencionadas y configurar el archivo appsettings.json con los parámetros de la base de datos SQL Server.

- Ejecutar el enfoque Database First con **Scaffolding**:

---

<img width="1227" height="485" alt="image" src="https://github.com/user-attachments/assets/ae3791a2-1ef1-4d64-98dc-ed25b241c650" />

---

**6. API REST**

**6.1. Autenticación**

- Método: JWT (JSON Web Token)

- Endpoint: /api/Acceso/login

- Método: POST

- Parámetros: email, clave

- Respuesta: { token: "xxxx.yyyy.zzzz" }

**6.2. Endpoints principales**

**Usuarios**

- GET /api/usuarios → Listar usuarios

- POST /api/usuarios → Crear usuario

- PUT /api/usuarios/{id} → Actualizar usuario

- DELETE /api/usuarios/{id} → Eliminar usuario

**Productos**

- GET /api/productos → Listar productos

- POST /api/productos → Crear producto

- PUT /api/productos/{id} → Actualizar producto

- DELETE /api/productos/{id} → Eliminar producto

**Ventas**

- POST /api/ventas → Registrar venta

- GET /api/ventas/historial?fechaInicio=...&fechaFin=... → Filtrar historial

**Reportes**

- GET /api/reportes/excel → Generar reporte en Excel


---


**8. Seguridad**

- Autenticación y autorización con JWT.

- **Roles:** Administrador (gestión completa) y Empleado (ventas, historial, reportes).

- Buenas prácticas aplicadas: principios SOLID, DTOs, inyección de dependencias.


---


**7. Despliegue en Azure**

- Crear un recurso App Service en Azure.

- Configurar la base de datos en Azure SQL Database.

- Publicar el backend desde Visual Studio 2022 hacia Azure App Service.

- Publicar el frontend (Angular) en Azure Static Web Apps.

- Configurar variables de entorno (cadenas de conexión, JWT secret).


---


**9. Mantenimiento**

- Uso de GitHub para control de versiones.

- Aplicación de migraciones EF Core para actualizar la base de datos.

- Ejecución de pruebas unitarias.


---


**10. Conclusión**

Este manual técnico asegura que cualquier miembro del equipo de desarrollo o soporte pueda instalar, configurar, desplegar y mantener el sistema de manera eficiente.

---


**11. Referencias**
- https://learn.microsoft.com/aspnet/core
- https://learn.microsoft.com/ef/core
- https://material.angular.dev/
- https://learn.microsoft.com/azure/app-service







