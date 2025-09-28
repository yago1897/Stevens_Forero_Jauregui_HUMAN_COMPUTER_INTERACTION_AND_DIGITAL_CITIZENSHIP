# API-REST para consumir la base de datos
---

**Introducción**

El consumo de una API-REST en el frontend permite que la aplicación en Angular se comunique con el backend desarrollado en ASP.NET Core. A través de peticiones HTTP, los formularios y vistas previamente diseñados pueden acceder a la base de datos de SQL Server mediante los servicios expuestos por el backend.


---



La manera de su implementación fue por medio de API RESTful que se mostrarán a continuación.

Estas API RESTful fueron realizadas en .Net-Core para luego ser consumidas por Angular 14, a continuación se muestran las API RESTful en .Net-Core

![image](https://github.com/user-attachments/assets/209065f2-4a28-4959-a67a-8fc96fa9de55)

![image](https://github.com/user-attachments/assets/749b3a92-754d-4651-a0e8-1bc7d93e1b3e)

![image](https://github.com/user-attachments/assets/6743266c-e8ac-44b9-a32a-a2d1e9a211b5)

---

A continuación se muestra parte del código de las Apis en .Net-Core, en este caso las API RESTful de Usuarios para Iniciar Sesion, Crear, Editar, y eliminar usuarios


![image](https://github.com/user-attachments/assets/66ac3493-2e81-436d-a7e2-c9b01bd9a0ea)

![image](https://github.com/user-attachments/assets/1b86164c-deb6-404e-aa85-1edbf5d04f40)

![image](https://github.com/user-attachments/assets/16451e6c-63ae-4a55-921c-c51c453ee01f)

![image](https://github.com/user-attachments/assets/b5d5f37f-f795-4890-aca9-d96ec2acf46e)

![image](https://github.com/user-attachments/assets/b113220e-687b-4bb0-80bf-3d9bdf1cbff7)

![image](https://github.com/user-attachments/assets/6c80f091-61c5-4d66-bc8a-d00dea664494)


---

Primero se debe ejecutar la aplicación en .Net-Core como se ve en la siguiente imagen, ya que si no se ejecuta no consumira las APIS RESTfull en Angular.
Se ejecuta presionando la tecla "F5" o presionando el botón "Continuar" ubicado en la parte superior, donde esta subrayado en color rojo

![image](https://github.com/user-attachments/assets/032092e9-9493-4030-9511-559b56102aea)


---


**A continuación se muestra como se consumen las API en Angular 14**

Para efectos de práctica se utiliza el editor de código VS-Code.
Este endPoint es el que se consume y se establece en el archivo "Environment.ts", para lograr la comunicación entre el backend y el frontend Angular. 


![image](https://github.com/user-attachments/assets/3c9d8055-d09e-484c-867c-197c68e13ecc)



![image](https://github.com/user-attachments/assets/75605e9c-73bd-4224-b1ef-a1fcf38be905)


---

**Módulo Usuarios**

Se observa que se consume el Api de "Iniciar Sesión" como se aprecia en la imagen

![image](https://github.com/user-attachments/assets/627635bb-da13-4885-b16a-8bf2b32c9a54)

---

Se observa que se consumen las demás Apis-Rest, las cuales son: Guardar, Editar y eliminar, la aplicación se ejecuta en el puerto 4200 de localhost


![image](https://github.com/user-attachments/assets/ac46493a-cde8-4ca0-ace2-44a268e5b2ad)

---


Con el editor de código VS-Code se ejecuta la aplicación escribiendo el siguiente comando "ng serve --open" como se ve a continuación

![image](https://github.com/user-attachments/assets/48efcf60-ce37-42ab-8088-ec3d3504e589)


---


Y se observa que la aplicación se ejecuta en el puerto 4200 como se aprecia en la imagen.

<img width="1278" height="583" alt="image" src="https://github.com/user-attachments/assets/b25161f5-c638-4e37-a674-984c41585703" />


---

Consumo de Apis-Rest de **Roles** que lista los roles de los usuarios

---

<img width="1138" height="653" alt="image" src="https://github.com/user-attachments/assets/ad2f4927-8e52-4b77-be5e-c1654afd96f1" />


---

Asi se visualiza al desplegar la lista de Roles en el módulo **Usuarios**

---

<img width="1221" height="628" alt="image" src="https://github.com/user-attachments/assets/075cf4c6-fed0-4961-93a3-fb3f89705435" />


---


**Módulo Productos**

Consumo de Apis-Rest de Productos: Listar, Guardar, Editar y eliminar

<img width="1074" height="650" alt="image" src="https://github.com/user-attachments/assets/ca0e3fd5-00ce-46a9-869b-5c14a108044e" />

<img width="1185" height="177" alt="image" src="https://github.com/user-attachments/assets/2b70b106-9453-4df3-9671-40f645de4f30" />

---

Y se observa que la aplicación se ejecuta en el puerto 4200, con el comando "ng serve --open" como se aprecia en la imagen.


<img width="850" height="143" alt="image" src="https://github.com/user-attachments/assets/0fecce24-b933-4a80-aec4-d32ddfa46484" />



Asi se visualiza el módulo **Productos**



![image](https://github.com/user-attachments/assets/3c5fb3f0-7eb5-43cd-b711-82895747e633)


---

Consumo de Apis-Rest de **Categorías** que lista las categorías de los productos

---

<img width="1124" height="650" alt="image" src="https://github.com/user-attachments/assets/dfdb5b2e-a9bf-4a4a-b45b-0f5167079156" />

---

Asi se visualiza al desplegar la lista de categorías en el módulo **Productos**

---

<img width="1230" height="635" alt="image" src="https://github.com/user-attachments/assets/b05541fb-a8ac-482e-9859-571b6c0e9156" />




---


**Módulos Venta - Historial Ventas y Reportes**

Consumo de Apis-Rest de Venta, los cuales son: Registrar, Historial, y Reporte para las vistas **Venta**, **Historial Ventas** y **Reportes**.

**Módulo Venta**


<img width="1134" height="648" alt="image" src="https://github.com/user-attachments/assets/e720a022-64d5-4043-b635-007c5267ab63" />

---

De igual forma se observa que la aplicación se ejecuta en el puerto 4200, con el comando "ng serve --open" como se aprecia en la imagen.


<img width="850" height="143" alt="image" src="https://github.com/user-attachments/assets/0fecce24-b933-4a80-aec4-d32ddfa46484" />

---

Así se visualiza la vista del módulo **Venta**

<img width="1279" height="552" alt="image" src="https://github.com/user-attachments/assets/a5438cac-2803-4e1f-9373-7c18110943ee" />

---
 
Así se visualiza la vista del módulo **Historial Ventas**

<img width="1280" height="598" alt="image" src="https://github.com/user-attachments/assets/a4fea9eb-54f4-4a10-bb71-b7bbc3d45e75" />

---

Así se visualiza la vista del módulo  **Reportes**

<img width="1280" height="483" alt="image" src="https://github.com/user-attachments/assets/5cf97479-ba43-4d2e-8409-1b895e2786bd" />



---


**Conclusión**

El consumo de la API-REST del Sistema Venta Ecommerce desde Angular permite la integración total del frontend con el backend, y esto garantiza las operaciones CRUD seguras y eficientes. Gracias a la autenticación JWT, se asegura la protección de los recursos y el acceso a la información.


**Referencias**

- https://angular.io/guide/http
- https://learn.microsoft.com/aspnet/core/security/authentication/jwt
- https://material.angular.dev/









