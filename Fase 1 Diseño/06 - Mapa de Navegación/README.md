# Mapa de Navegación
---

**1. Introducción**

El Mapa de Navegación del Sistema de Venta Ecommerce representa el flujo de interacción del usuario a través de las diferentes pantallas y módulos disponibles. Su propósito es visualizar de manera estructurada cómo se accede desde el inicio de sesión (Login) hacia las distintas funcionalidades del sistema, esto garantiza que la interfaz sea intuitiva y accesible con los objetivos de la aplicación.

---

**2. Módulos y flujo de navegación**

**1. Login**
  - Punto de entrada al sistema.
  - Si las credenciales son correctas → entra al sistema, pasa al Dashboard.


**2. Dashboard Principal**
  - Pantalla inicial después del login.
  - Desde aquí se accede a todos los módulos principales.

  
**3. Usuarios**
  - Lista de usuarios.
  - Funcionalidades: Crear, Editar, Eliminar.


**4. Productos**
  - Lista de productos.
  - Funcionalidades: Crear, Editar, Eliminar.


**5. Ventas**
  - Buscar producto.
  - Seleccionar cantidad.
  - Elegir forma de pago (tarjeta o efectivo).
  - Registrar compra.


**6. Historial de Ventas**
  - Filtro por fechas.
  - Mostrar compras realizadas.


**7. Reportes**
  - Filtro por fechas.
  - Generar reporte en Excel.


---


# Representación en Navegabilidad (PlantUML)

**3. Descripción:** Diagrama de estado de navegabilidad.



<img width="627" height="383" alt="image" src="https://github.com/user-attachments/assets/43f02689-ac4b-4e73-8144-903b862d5e68" />

---

**Descripción:** Diagrama de estado de la avegabilidad + flujo funcional detallado por módulo.


<img width="607" height="553" alt="image" src="https://github.com/user-attachments/assets/d3ecef6a-2c4b-4dda-9288-882d1f36f192" />


---


**4. Conclusión:**

El diagrama de navegabilidad permite identificar la secuencia lógica de interacción del usuario dentro del sistema, asegurando claridad en el acceso a cada módulo (DashBoard, Usuarios, Productos, Ventas, Historial de Ventas y Reportes). Esto facilita tanto la experiencia de uso como la posterior implementación y mantenimiento del sistema, al contar con una guía visual que refleja el flujo completo de navegación.


**5. Referencias:**

- Ingeniería de Software: Un enfoque práctico. 8.ª edición. McGraw-Hill.
- https://plantuml.com/es/
