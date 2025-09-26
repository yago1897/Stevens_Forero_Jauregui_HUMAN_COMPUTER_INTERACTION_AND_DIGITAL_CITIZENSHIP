# Arquitectura de Software
La arquitectura de software describe la estructura general del sistema, los componentes principales que lo conforman, sus relaciones y las decisiones técnicas que permiten su implementación. No detalla cada línea de código ni cada pantalla, sino que proporciona una visión global que guía el desarrollo, mantenimiento y evolución del sistema.

---

# Arquitectura del sistema

La arquitectura de software del Sistema de Venta Ecommerce se ha diseñado siguiendo el patrón N-Capas, con el objetivo de garantizar mantenibilidad, escalabilidad, reutilización de componentes y separación clara de responsabilidades.
Se ha implementado bajo los principios SOLID y utilizando tecnologías modernas que aseguran rendimiento, seguridad y facilidad de integración.

---

**2. Estilo Arquitectónico**

**Descripción:** El sistema sigue una arquitectura en capas (N-Layered Architecture), estructurado de la siguiente manera:

**1. Capa de Presentación (Cliente Web):**
  - Desarrollada en Angular 15.
  - Entorno de desarrollo: Visual Studio Code.
  - Consume los servicios expuestos por la API REST.
  - Interfaz intuitiva, accesible y adaptada a web.

---

**2. Capa de Servicios / API REST:**
  - Implementada en ASP.NET Core 7 (C#).
  - Entorno de desarrollo: Visual Studio 2022.
  - Define controladores que exponen endpoints REST..
  - Incluye mecanismos de seguridad JWT (JSON Web Token) para autenticación y autorización.

---

**3. Capa de Negocio (BLL – Business Logic Layer):**
  - Contiene la lógica de negocio del sistema.
  - Encapsula las reglas, validaciones y flujos de compra/venta.
  - Se comunica con los controladores y la capa de datos.
  

---


**4. Capa de Datos (DAL – Data Access Layer)**
  - Implementada con el ORM Entity Framework Core.
  - Gestiona el acceso a la base de datos SQL Server.
  - Aplica el patrón Repositorio para desacoplar consultas e inserciones, actualizaciones y eliminaciones.

---


**5. Capa de Transferencia de Datos (DTOs – Data Transfer Objects)**
  - Permite estructurar los datos enviados/recibidos entre la API y la aplicación cliente.
  - Reduce la sobreexposición de las entidades del modelo de dominio.
  - Aplica seguridad al no exponer las propiedades de la entidad.

---

**6. Capa de Persistencia (Model)**
  - Contiene la información de las entidades Usuarios, Roles, Menú, MenuRol, Productos, Ventas etc.
  - Maneja la lógica de los datos y el estado de la aplicación.
  - Interactúa con la base de datos y procesa la información antes de mostrarsela al usuario.

---

**7. Capa de Inversión de Control (IOC – Dependency Injection)**
  - Gestiona el registro de interfaces y sus implementaciones.
  - Permite inyectar dependencias en los controladores y servicios.
  - Mejora el desacoplamiento entre las capas y facilita la prueba unitaria y la escalabilidad.
  - Ejemplo: services.AddScoped<IUsuarioService, UsuarioService>();.

---


**3. Seguridad**

**Descripción:** El sistema incorpora JWT (JSON Web Tokens) como mecanismo principal de autenticación.
  - Los usuarios se autentican contra la API REST.
  - La API genera un token firmado que incluye permisos y roles.
  - El token se adjunta en cada petición al servidor.
  - Garantiza confidencialidad, integridad y control de acceso en toda la aplicación.

---

**4. Entornos de Desarrollo**

**Descripción:** El proyecto se divide en dos entornos de desarrollo claramente diferenciados:
  - Frontend (Angular 15): desarrollado en Visual Studio Code, lo que facilita la modularidad, integración el backend de Visual Studio 2022.
  - Backend (ASP.NET Core 7, C#): desarrollado en Visual Studio 2022, aprovechando sus herramientas avanzadas de depuración, integración con SQL Server y soporte para arquitecturas en capas.

---

**5. Diagrama de Componentes que describe la arquitectura del sistema**

<img width="649" height="623" alt="image" src="https://github.com/user-attachments/assets/535bdc43-0bc6-4d8b-a35e-eeb4dd84f593" />

---

**6. Conclusión**

La arquitectura propuesta asegura que el sistema sea modular, extensible, seguro y escalable u con la inclusión de Inyección de dependencias la arquitectura se vuelve mas eficiente, desacoplada, flexible y escalable.
La separación de entornos entre Visual Studio Code (Frontend) y Visual Studio 2022 (Backend) refuerza las buenas prácticas de desarrollo moderno, y esto permite equipos más ágiles, mejor integración y escalabilidad futura.

    

  


