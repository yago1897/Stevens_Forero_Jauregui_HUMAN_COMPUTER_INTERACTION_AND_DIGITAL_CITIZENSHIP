# Diseño Conceptual - Sistema Venta Ecommerce

A continuación se describe la **El diseño o estructura conceptual de la aplicación**, los roles de usuario y los módulos principales del sistema. El objetivo es representar de manera clara la organización de la interfaz y las funciones antes de pasar al diseño detallado.

---

 Roles de usuario

- **Administrador**
  - Accede a todos los módulos del sistema.
  - Gestiona usuarios, productos e inventario.
  - Puede generar y exportar reportes.

- **Empleado**
  - Accede únicamente a:
    - Venta
    - Historial de Ventas
    - Reportes
  - No tiene permisos para administrar usuarios ni productos.

---

## 📂 Módulos principales

- **Dashboard**
  - Resumen general de información del sistema.

- **Usuarios** *(solo administrador)*
  - Registro de nuevos usuarios.
  - Edición de datos de usuario.
  - Eliminación de usuarios.

- **Productos** *(solo administrador)*
  - Registro de productos.
  - Actualización de precios.
  - Control de inventario.

- **Venta**
  - Registro de ventas en tiempo real.
  - Cálculo automático de totales.

- **Historial de Ventas**
  - Consulta de ventas pasadas.
  - Búsqueda y filtrado por fecha.

- **Reportes**
  - Generación de reportes de ventas.
  - Exportación en formato Excel.

---

## 🗺️ Estructura de navegación

```plaintext
[Sistema Venta Ecommerce]
   |
   ├── Dashboard
   ├── Usuarios (solo administrador)
   ├── Productos (solo administrador)
   ├── Venta
   ├── Historial de Ventas
   └── Reportes
