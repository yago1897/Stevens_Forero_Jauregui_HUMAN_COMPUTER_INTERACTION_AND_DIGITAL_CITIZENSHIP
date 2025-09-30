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

**Las validaciones de los campos ocurren en el módulo Agregar Usuarios y Editar usuarios**

- Validación de campos obligarorios.
- No se activa el botón guardar hasta que no se llenen los campos por completo.
- Otras validaciones como el campo **Nombre completo** sólo deja ingresar letras y no números.

---

![image](https://github.com/user-attachments/assets/23929bcf-3db0-47cd-ac8b-50fd0b93e404)


---



**Módulo Productos:**

---

**Las validaciones de los campos ocurren en el módulo Agregar Productos y Editar Productos**

- Validación de campos obligarorios.
- No se activa el botón guardar hasta que no se llenen los campos por completo.
- Validación del campo **Nombre** que sólo permite ingresar letras y no números.
- Validación del campo **Stock** que sólo permite ingresar números y no letras.
- Validación del campo **Precio** que sólo permite ingresar números y no letras.
- Validación del campo **Stock** La cantidad no puede ser menor a 1.

---

<img width="1278" height="632" alt="image" src="https://github.com/user-attachments/assets/0ce7c583-388b-4b4c-8795-51ff4c0025a7" />

---

<img width="1280" height="465" alt="image" src="https://github.com/user-attachments/assets/de13d29e-c910-4c29-8dcc-c35183041e1f" />

---

**Módulo Ventas:**
---
- Validación de campos obligarorios.
- No se activa el botón **Agregar al carrito** hasta que no se llenen los campos por completo.
- Validación del campo **Buscar producto** que sólo permite ingresar letras y no números.




---


---

<img width="1214" height="613" alt="image" src="https://github.com/user-attachments/assets/b7bac538-712a-4227-8c87-984671dd9918" />

---



