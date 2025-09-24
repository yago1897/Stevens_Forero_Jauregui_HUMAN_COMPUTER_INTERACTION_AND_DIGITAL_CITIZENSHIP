# Diseño Conceptual - Sistema Venta Ecommerce

A continuación se especifica **El diseño o estructura conceptual de la aplicación**, la pantalla de login y credenciales, los roles de usuario y los módulos principales del sistema. El objetivo es representar de manera clara como está organizado la interfaz y las funciones antes de pasar al diseño detallado.

---
Inicialmente se observa la vista del login donde de acuerdo al perfil del usuario puede acceder con sus credenciales.



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
   ├── Dashboard (solo administrador)
   ├── Usuarios (solo administrador)
   ├── Productos (solo administrador)
   ├── Venta     (Administrador y empleado)
   ├── Historial de Ventas (Administrador y empleado)
   └── Reportes            (Administrador y empleado)

---

# Principios de diseño centrado en el usuario (HCI) aplicados #
- **Usabilidad - Consistencia visual**
  - Todos los módulos utilizan la misma barra lateral de navegación.
  - Los iconos, botones y colores se mantienen uniformes en cada pantalla.
  - La visibilidad del estado del sistema es eficiente al usarlo
  - La ejecución de las taréas en cada una de las operaciones CRUD cumple con las métricas de usabilidad


- **Accesibilidad**
  - Contraste de colores verificado con WAVE siguiendo los estándares de WCAG 2.1.
  - Contraste y legibilidad y uso de tipografía legible en botones con etiquetas claras.
  - Texto alternativo en imágenes e íconos
  - Navegación por teclado con teclas Tab y Enter 

- **Ergonomía**
  - La interfaz muestra solo la información necesaria (ej. el empleado solo ve los módulos de venta, historial y reportes y el administrador ve tódos los módulos), evitando sobrecarga de opciones.
  - Los términos y flujos usados (ej. “Venta”, “Historial Ventas”, “Productos” etc.) tienen un lenguaje fácil de entender facilitando la comprensión.
  - El menú lateral izquierdo, filtros y botones mantienen una estructura fija en cada pantalla, y esto reduce el esfuerzo visual.

<img width="808" height="372" alt="image" src="https://github.com/user-attachments/assets/497795ff-552c-4b0a-b62d-dfc1c3146af4" />






 






