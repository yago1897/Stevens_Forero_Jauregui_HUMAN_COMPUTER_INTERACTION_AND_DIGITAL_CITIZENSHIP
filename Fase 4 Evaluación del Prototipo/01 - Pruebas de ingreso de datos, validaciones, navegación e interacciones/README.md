# Pruebas de ingreso de datos, validaciones, navegación e interacciones

---

**Introducción**

Las pruebas de ingreso de datos, validaciones, navegación e interacciones tienen como objetivo verificar que el Sistema de Venta Ecommerce funciona correctamente desde la perspectiva del usuario final. Estas pruebas garantizan que los formularios validen adecuadamente la información, que la navegación entre los distintos módulos sea fluida y que las interacciones generen las respuestas esperadas del sistema.

---

**1. Pruebas de ingreso de datos**

**Login**


- Validación de campos obligatorios y formato de contraseña

---

Como se aprecia en la imagen los campos validan su obligatoriedad

![image](https://github.com/user-attachments/assets/528c2e6d-4ee1-4684-b9a8-13ac1f68319b)


---

- Ingresar un correo en formato inválido (resultado esperado: mensaje de error).
  
En este caso también valida que el formato del correo electrónico sea el formato correcto como se ve en la imagen

![image](https://github.com/user-attachments/assets/cdccb09f-a332-40d9-aeb9-b97d2a4f5e7c)

---

Se ingresan las credenciales equivocadas y arroja el mensaje de alerta notificando indicando email/contraseña incorrectas


<img width="1218" height="530" alt="image" src="https://github.com/user-attachments/assets/d444ac06-b81a-4028-bf21-a4286ff2af71" />


---



Se ingresa el email y contraseña correctos para poder ingresar

![image](https://github.com/user-attachments/assets/1b8be49e-93e9-4225-8fa6-2b58f0be9219)


---


**Módulo Usuarios:**

---

- Las validaciones de los campos ocurren en el módulo Agregar Usuarios, no se activa el botón guardar hasta que no se llenen los campos por completo y los campos validan su obligatoriedad

![image](https://github.com/user-attachments/assets/23929bcf-3db0-47cd-ac8b-50fd0b93e404)


---



Productos:

Crear un producto con precio negativo (resultado esperado: error de validación).

Crear un producto con nombre y precio correctos (resultado esperado: registro exitoso).

Ventas:

Registrar una venta seleccionando producto y cantidad válidos (resultado esperado: compra registrada).

Intentar registrar una venta sin forma de pago (resultado esperado: error de validación).
