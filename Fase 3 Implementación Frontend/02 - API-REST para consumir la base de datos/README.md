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


**A continuación se muestra como se consumen las API en Angular 14**

Este endPoint es el que se consume y se establece en el archivo "Environment.ts", para lograr la comunicación entre el backend y el frontend Angular. 


![image](https://github.com/user-attachments/assets/3c9d8055-d09e-484c-867c-197c68e13ecc)



![image](https://github.com/user-attachments/assets/75605e9c-73bd-4224-b1ef-a1fcf38be905)


---

**Módulo Usuarios**

Utilizando el editor de código VS-Code vemos que se consume el Api de "Iniciar Sesión" como se aprecia en la imagen

![image](https://github.com/user-attachments/assets/627635bb-da13-4885-b16a-8bf2b32c9a54)

---

Se observa que se consumen las demás Apis-Rest que son: Guardar, Editar y eliminar, la aplicación se ejecuta en el puerto 4200 de localhost


![image](https://github.com/user-attachments/assets/ac46493a-cde8-4ca0-ace2-44a268e5b2ad)

---

Primero se debe ejecutar la aplicación en .Net-Core como se ve a continuación, ya que si no se ejecuta no consumura las APIS RESTfull en Angular.
Se muestra a contunuación .Net-Core y se ejecuta presionando la tecla "F5" o presionando el botón "Continuar" ubicado en la parte superior, donde esta subrayado en color rojo

![image](https://github.com/user-attachments/assets/032092e9-9493-4030-9511-559b56102aea)

Luego estando en el editor de código VS-Code se ejecuta la aplicación escribiendo el siguiente comando "ng serve --open" como se ve a continuación

![image](https://github.com/user-attachments/assets/48efcf60-ce37-42ab-8088-ec3d3504e589)


---


Y listo, vemos que la aplicación se ejecuta en el puerto 4200 como se aprecia en la imagen.

![image](https://github.com/user-attachments/assets/3c5fb3f0-7eb5-43cd-b711-82895747e633)


---


**Módulo Productos**

Consumo de Apis-Rest de Productos que son: Listar, Guardar, Editar y eliminar

<img width="1074" height="650" alt="image" src="https://github.com/user-attachments/assets/ca0e3fd5-00ce-46a9-869b-5c14a108044e" />

<img width="1185" height="177" alt="image" src="https://github.com/user-attachments/assets/2b70b106-9453-4df3-9671-40f645de4f30" />

Ejecución de la aplicación 

<img width="1280" height="550" alt="image" src="https://github.com/user-attachments/assets/8d1e1026-7852-4ff8-aa96-b1500a1e3bd1" />


---







