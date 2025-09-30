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

**Módulo Usuarios**

<img width="1276" height="551" alt="image" src="https://github.com/user-attachments/assets/4271922b-a330-481b-a674-de6dc7ffc796" />

---

**Agregar un Usuario**

<img width="1280" height="600" alt="image" src="https://github.com/user-attachments/assets/0eefa06a-96a0-4816-9e3a-ce7b31c91163" />

---

**Editar usuario** - se presiona en el ícono del lápiz como se aprecia en la imagen

<img width="1220" height="600" alt="image" src="https://github.com/user-attachments/assets/1d1011c9-5410-4bbb-b739-40cbdc7d9a80" />

---

**Eliminar un usuario** - se presiona en el ícono del recicalje como se aprecia en la imagen

<img width="1189" height="562" alt="image" src="https://github.com/user-attachments/assets/f5c9455c-d72e-4f40-a7b6-4d7d789790df" />

---

**Módulo Productos**

<img width="1280" height="592" alt="image" src="https://github.com/user-attachments/assets/c331291b-74cf-497b-9ecd-0754e6f590a9" />

---

**Crear un producto** 

<img width="1220" height="575" alt="image" src="https://github.com/user-attachments/assets/f97caee0-7431-4cbb-b809-24a14e7630d7" />

---

**Editar un producto** - se presiona en el ícono del lápiz

<img width="1280" height="614" alt="image" src="https://github.com/user-attachments/assets/1a389593-9267-43fe-8977-efdfb2c798cf" />

---

**Eliminar un producto**

<img width="753" height="354" alt="image" src="https://github.com/user-attachments/assets/f743cb78-3829-4ba7-8884-c35b898891cc" />

---

**Módulo ventas** - se busca el productom se elije la cantidad y se agrega al botón del carrito, se refleja el valor total y por último se registra la venta, hay un ícono de reciclaje por si se desea eliminar el producto para cambiar por otro como se aprecia en la imagen con las flechas señaladas en color rojo

<img width="1232" height="492" alt="image" src="https://github.com/user-attachments/assets/11e14295-fdd2-4a1c-808a-96262f1ade74" />

---

<img width="1278" height="547" alt="image" src="https://github.com/user-attachments/assets/1dffdf9a-ae00-43d4-8b20-106ca252058f" />

---

**Módulo "Historial de ventas":**

En el filtro de búsquedas por fecha se coloca la fecha del día de compra y se presiona en el botón "Buscar", luego se presiona en el ícono del ojo, que es el detalle de la venta y se refleja el detalle de la compra como se aprecia en la imagen

<img width="1242" height="538" alt="image" src="https://github.com/user-attachments/assets/c891fdc3-62bd-43f7-909d-dc8ba29d1d31" />

---

**Módulo "Reportes"**

En el filtro de búsquedas por fecha se coloca la fecha del día de compra y se presiona en el botón "Buscar", luego se habilita el botón de "Exportar a excel" para su descarga y visualización como se ve en las imágenes

<img width="1228" height="537" alt="image" src="https://github.com/user-attachments/assets/94bf6e4c-1b49-4465-b881-bccb0b36e457" />

<img width="1280" height="380" alt="image" src="https://github.com/user-attachments/assets/55925e66-d284-4725-a7a4-0411bcf97fa2" />

---


**2. Pruebas de validaciones**


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
- Validación del campo **Stock** La cantidad no puede ser menor a 1 como se aprecia en las 2 imágenes.

---

<img width="1278" height="632" alt="image" src="https://github.com/user-attachments/assets/0ce7c583-388b-4b4c-8795-51ff4c0025a7" />

---

<img width="1214" height="613" alt="image" src="https://github.com/user-attachments/assets/b7bac538-712a-4227-8c87-984671dd9918" />


---

**Módulo Ventas:**
---
- Validación de campos obligarorios.
- No se activa el botón **Agregar al carrito** hasta que no se llenen los campos por completo.
- Validación del campo **Buscar producto** que sólo permite ingresar letras y no números.


---

<img width="1280" height="465" alt="image" src="https://github.com/user-attachments/assets/de13d29e-c910-4c29-8dcc-c35183041e1f" />

---

**Módulo Historial Ventas:**
---

- Validación de campos obligarorios donde indica que se deben ingresar ambas fechas.
- Validación de los campo **Fecha Inicio** y **Fecha Fin** que sólo permite ingresar números y no letras.

---

<img width="1237" height="407" alt="image" src="https://github.com/user-attachments/assets/00dcc6ca-5770-4b55-8f94-f427cf2bab86" />


---

**Módulo Reportes**
---

- Validación de campos obligarorios donde indica que se deben ingresar ambas fechas.
- Validación de los campo **Fecha Inicio** y **Fecha Fin** que sólo permite ingresar números y no letras.

---

<img width="1278" height="440" alt="image" src="https://github.com/user-attachments/assets/fe746629-aa02-4616-9a4f-069b13052227" />


---


**3. Pruebas de navegación**

- Desde el Login ingresar al Dashboard correctamente tras ingreso de credenciales.

- Navegar entre los módulos (Usuarios → Productos → Ventas → Historial → Reportes) sin errores de carga.

- Usar botones de regreso o menús laterales para retornar al módulo anterior.

---


**4. Pruebas de interacciones**

- Botones de guardar, editar, eliminar responden de forma inmediata.

- En Historial de ventas, el filtro por fechas devuelve los registros correspondientes.

- En Reportes, al aplicar filtro y exportar, se genera correctamente el archivo Excel.

- Pruebas de accesibilidad: navegación con teclado (tab, enter) y compatibilidad con lectores de pantalla.


---


**Conclusión**

Las pruebas realizadas al Sistema Venta Ecommerce de ingreso de datos, validaciones, navegación e interacciones son fundamentales para garantizar que el sistema funcione de manera segura, coherente y usable. Con su aplicación se asegura que el usuario pueda realizar sus tareas sin inconvenientes y que el sistema responda de forma confiable a diferentes escenarios.


---









