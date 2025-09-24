# Diseño Conceptual - Sistema Venta Ecommerce

A continuación se especifica **El diseño o estructura conceptual de la aplicación**, los roles de usuario y los módulos principales del sistema. El objetivo es representar de manera clara como está organizado la interfaz y las funciones antes de pasar al diseño detallado.

---

 Roles de usuario

- **Administrador**
  - Accede a todos los módulos del sistema.
  - Gestiona usuarios, productos.
  - Puede generar ventas y exportar reportes.

- **Empleado**
  - Accede únicamente a:
    - Venta
    - Historial de Ventas
    - Reportes
  - No tiene permisos para administrar usuarios ni productos.

---

##Módulos principales

- **Dashboard**
  - Resumen general de información del sistema como reportes en gráficos de ventas, total de ingresos, total de ventas y total de productos.

- **Usuarios** *Rol - Administrador*
  - Registro de nuevos usuarios.
  - Edición de datos de usuario.
  - Eliminación de usuarios.

- **Productos** *Rol - Administrador*
  - Registro de productos.
  - Actualización de precios.
  - Control de inventario.

- **Venta** - *Rol - Administrador*
  - Registro de ventas en tiempo real.
  - Cálculo automático de totales.

- **Historial de Ventas** - *Rol - Administrador*
  - Consulta de ventas pasadas.
  - Búsqueda y filtrado por fecha.

- **Reportes** - *Rol - Administrador*
  - Generación de reportes de ventas.
  - Exportación en formato Excel.

---

- **Venta** - *Rol Empleado*
  - Registro de ventas en tiempo real.
  - Cálculo automático de totales.

- **Historial de Ventas** - *Rol - Empleado*
  - Consulta de ventas pasadas.
  - Búsqueda y filtrado por fecha.

- **Reportes** - *Rol - Empleado*
  - Generación de reportes de ventas.
  - Exportación en formato Excel.
    
---

##Estructura de navegación

```plaintext
[Sistema Venta Ecommerce]
   |
   ├── Dashboard
   ├── Usuarios (solo administrador)
   ├── Productos (solo administrador)
   ├── Venta
   ├── Historial de Ventas
   └── Reportes
