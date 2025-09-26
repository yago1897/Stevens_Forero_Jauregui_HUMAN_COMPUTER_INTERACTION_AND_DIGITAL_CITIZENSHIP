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
