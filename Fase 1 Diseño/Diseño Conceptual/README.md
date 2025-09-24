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

```

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
    **```**

Inicialmente se observa la vista del login donde de acuerdo al perfil o rol del usuario puede acceder con sus credenciales

<img width="1265" height="556" alt="image" src="https://github.com/user-attachments/assets/79f0baff-8ee2-49ed-9db8-8c5230813d7e" />

Una vez ingresando con las credenciales con rol "Administrador" accede a la siguiente pantalla donde por ser administrador tiene acceso a todos los módulos de la app como se aprecia en la siguiente imagen:

<img width="1277" height="452" alt="image" src="https://github.com/user-attachments/assets/02a58835-babd-4e99-8586-d0af7647eb07" />

Módulo de "DashBoard"
<img width="1280" height="601" alt="image" src="https://github.com/user-attachments/assets/b1bec094-6750-4a2b-8ac3-0d19fae5dffd" />

Módulo Usuarios
<img width="1276" height="551" alt="image" src="https://github.com/user-attachments/assets/4271922b-a330-481b-a674-de6dc7ffc796" />

Agregar un Usuario
<img width="1280" height="600" alt="image" src="https://github.com/user-attachments/assets/0eefa06a-96a0-4816-9e3a-ce7b31c91163" />

Editar usuario - se presiona en el ícono del lápiz como se aprecia en la imagen
<img width="1220" height="600" alt="image" src="https://github.com/user-attachments/assets/1d1011c9-5410-4bbb-b739-40cbdc7d9a80" />

Eliminar un usuario - se presiona en el ícono del recicalje como se aprecia en la imagen
<img width="1189" height="562" alt="image" src="https://github.com/user-attachments/assets/f5c9455c-d72e-4f40-a7b6-4d7d789790df" />

Módulo Productos

<img width="1280" height="592" alt="image" src="https://github.com/user-attachments/assets/c331291b-74cf-497b-9ecd-0754e6f590a9" />

Crear un producto 
<img width="1220" height="575" alt="image" src="https://github.com/user-attachments/assets/f97caee0-7431-4cbb-b809-24a14e7630d7" />

Editar un producto - se presiona en el ícono del lápiz

<img width="1280" height="614" alt="image" src="https://github.com/user-attachments/assets/1a389593-9267-43fe-8977-efdfb2c798cf" />

Eliminar un producto

<img width="753" height="354" alt="image" src="https://github.com/user-attachments/assets/f743cb78-3829-4ba7-8884-c35b898891cc" />


















 






