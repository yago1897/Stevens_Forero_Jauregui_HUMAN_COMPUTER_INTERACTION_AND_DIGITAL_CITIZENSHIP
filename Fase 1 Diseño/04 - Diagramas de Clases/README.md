# Diagrama de clases

**1. Introducción**

El Diagrama de Clases del Sistema de Venta Ecommerce representa la estructura estática del sistema, mostrando las entidades principales, sus atributos, métodos y las relaciones entre ellas. Este modelo proporciona una visión detallada de cómo se organiza la lógica interna del software, sirviendo como base para la implementación orientada a objetos en C#.

El diagrama de clases representa la estructura del sistema, mostrando las
clases, sus atributos, métodos y las relaciones entre ellas.

---
# Descripción y Responsabilidad de las Clases


**1. Usuario**

**Descripción:** Representa a los empleados que interactúan con el sistema. Contiene la información básica de autenticación y estado.

**Responsabilidades:**
  - Autenticarse en el sistema mediante correo y clave.
  - Registrar nuevos usuarios.
  - Actualizar su perfil y datos personales.
  - Asociarse con un Rol que define sus permisos.

---
 
**2. Rol**

**Descripción:** Define los distintos perfiles de acceso y permisos para acceder al sistema.

**Responsabilidades:**
  - Identificar el tipo de rol (Administrador, Empleado).
  - Asociar los menús y opciones que cada rol puede acceder.
  - Mantener la trazabilidad de creación a través de fechaRegistro.

---

**3. Menú**

**Descripción:** Contiene las opciones de navegación que el sistema muestra para que el usuario navegue.

**Responsabilidades:**
  - Representar cada opción del menú (nombre, icono, url).
  - Asociar a roles mediante la clase MenuRol.
  - Mostrar los accesos permitidos al usuario según su rol.

---

**4. MenuRol**

**Descripción:** Es una clase puente que relaciona los menús con los roles.

**Responsabilidades:**
  - Establecer qué menús puede ver y usar cada rol.
  - Facilitar el control de accesos de forma dinámica.


---


**5. Producto**

**Descripción:** Representa los bienes que se registran, y que se venden y administran dentro del sistema.

**Responsabilidades:**
  - Mantener información sobre nombre, stock, precio, categoría y estado.
  - Permitir el registro y actualización de productos.
  - Descontar stock automáticamente al realizar una venta.

---


**6. Categoría**

**Descripción:** Agrupa los productos en grupos o categorías para una mejor organización.

**Responsabilidades:**
  - Mantener el listado de categorías activas.
  - Permitir la asociación de productos a una categoría.
  - Administrar su estado (activo/inactivo).

---


**7. Venta**

**Descripción:** Representa la transacción comercial realizada en el sistema.

**Responsabilidades:**
  - Almacenar información del número de documento, tipo de pago, total y fecha.
  - Estar asociada a un usuario (empleado que realizó la venta).
  - Registrar la venta y calcular el monto total.
  - Relacionarse con múltiples DetalleVenta.

---


**8. DetalleVenta**

**Descripción:** Representa cada línea de la venta, indicando los productos vendidos, cantidades y precios.

**Responsabilidades:**
  - Especificar producto, cantidad, precio y subtotal.
  - Calcular el subtotal correspondiente.
  - Asociarse a una Venta y un Producto.

---


**9. NumeroDocumento**

**Descripción:** Lleva el control de numeración de documentos de venta.

**Responsabilidades:**
  - Generar secuencias de números únicos para las ventas, similar a un campo identity.
  - Mantener el último número emitido y la fecha de registro.

---


**10. SistemaPago**

**Descripción:** Clase externa que representa la interacción con plataformas de pago.

**Responsabilidades:**
  - Procesar pagos electrónicos según el monto de la venta.
  - Confirmar la transacción con el sistema de pago externo.
  - Retornar el estado (aprobado/rechazado).

---

**2. Diagrama de clases del Sistema de Venta Ecommerce**


<img width="754" height="426" alt="image" src="https://github.com/user-attachments/assets/d7a712f3-3a0f-436f-9fc1-9ea214f68fd8" />

---

**3. Conclusión**

El diagrama de clases facilita la comprensión del diseño del sistema al describir de forma clara las entidades, sus responsabilidades y las interacciones entre ellas. Además, asegura la coherencia en el desarrollo, también promueve la reutilización de código y garantiza que la implementación cumpla con los requisitos funcionales y de negocio establecidos.

---

**4. Referencias**
  - El Lenguaje Unificado de Modelado: Manual de referencia. Addison-Wesley.
  - https://plantuml.com/es/






  
  


  
