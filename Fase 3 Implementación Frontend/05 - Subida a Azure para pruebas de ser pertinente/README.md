# Despliegue en plataforma Azure para pruebas

---

**Introducción**

El despliegue del Sistema Venta Ecommerce en la plataforma de Azure permite alojar la aplicación en la nube de Microsoft, garantizando disponibilidad, escalabilidad y acceso remoto para los usuarios. A través de Azure App Service y servicios relacionados, se publica tanto el backend (API REST) como el frontend, conectados a la base de datos.


---


Se ingresa al portal de Azure
![image](https://github.com/user-attachments/assets/a30e4a66-3224-4aad-b167-7dfaaac41586)


---

Se crea la suscripción en azure para realizar el despliegue

![image](https://github.com/user-attachments/assets/f72ac6f3-55df-41ef-a145-65b74588e7f2)

---

Luego de crear la suscripción se debe crear el "Grupo de Recursos"

![image](https://github.com/user-attachments/assets/e5c4647a-b8bc-4c22-b1eb-5d8943206dc7)

---

Luego de crear el grupo de recursos se crea la appWeb donde estará alojado el código

![image](https://github.com/user-attachments/assets/addf4b7a-2847-4280-95c9-dd9e0c7d603b)

---

Y se configura los datos para crear la aplcicación como se aprecia en la imagen

![image](https://github.com/user-attachments/assets/c6753dc0-a9ac-4acb-8cd8-c10672a0f4b1)
![image](https://github.com/user-attachments/assets/a366ae99-66fa-465d-9b19-45d9a2ba9601)
![image](https://github.com/user-attachments/assets/75692b5e-b260-403a-ae13-065d0d28e23c)

---

Y vemos que se creo el recurso exitosamente, es decir la app para alojar el código

![image](https://github.com/user-attachments/assets/3990a82b-49da-4b94-85c3-ff55729d70ab)


---

El siguiente paso es crear la base de datos SQL AZURE para alojar la base de datos creada en sql server como se ve en la imagen

![image](https://github.com/user-attachments/assets/d704686f-6d2a-41f4-af46-e74d9b58e7e0)

---

Luego en la plataforma visual Studio de .Net se publica la aplicación como se ve en la imagen

![image](https://github.com/user-attachments/assets/6c332275-aeb0-4f5f-8cb7-f48340216240)

---

Al escoger la opción de publicar automaticamente visual studio reconoce la appWeb creada en Azure con el nombre del grupo de recursos como se observa em la imagen

![image](https://github.com/user-attachments/assets/66fe147f-3f6b-4338-889d-4abe648b3e78)


---

Se crea el perfil de publicación como se esperaba

![image](https://github.com/user-attachments/assets/9894003b-e658-48c7-89f1-e80eaabf6ab6)

---

![image](https://github.com/user-attachments/assets/4446f42c-5d6f-45da-b37a-775a0dbb1a0f)


---

Y se presiona el botón de publicar como se ve en la imagen

![image](https://github.com/user-attachments/assets/5c207626-d4dd-4a5c-acd2-306709c1bd77)

---

Y vemos que la publicación fue exitosa como se aprecia en la imagen

Y se observa la URL es el dominio predeterminada de Azure donde se aloja la aplicación Web Api, que en este caso es el BACKEND 

![image](https://github.com/user-attachments/assets/7465a311-fb3b-4a5d-b7e1-957c0ef71401)

---

Se observa que es la misma url del dominio donde se encuentra el BACKEND

![image](https://github.com/user-attachments/assets/6d6fb60c-f6d7-47ac-ab00-4aa77eafec6c)

---

Ahora crearemos otro Hosting en Azure para alojar el FRONTEND, es decir la aplicación en Angular

tal como se realizó con el anterior, se crea una appWeb como se ve en la imagen para alojar la aplicación de Angular

![image](https://github.com/user-attachments/assets/12c693eb-299a-48f9-a44a-79250bc74a05)

---

Esta aplicación recibe el nombre de AngularBiu como se ve en la imagen

![image](https://github.com/user-attachments/assets/d48e883b-32d6-486f-83b8-6e7b925010fc)

---

Y se observa que se crea el alojamiento como se ve en la imagen, para alojar la eplicación de Angular 14

![image](https://github.com/user-attachments/assets/5f57d4ae-1688-4116-bc1b-d7c6f49d6e49)


---

Si presionamos el enlace de la url señalada em color rojo como se ve en la imagen

![image](https://github.com/user-attachments/assets/64b40f3e-b126-432c-b30d-89ac44ded81a)

---

Vemos que nos lleva a una página donde aún no hay nada, eso es porque ya esta creado el alojamiento pero la aplicación no hay contenido ya que la aplicación no ha sido publicada

![image](https://github.com/user-attachments/assets/2c606e66-49f3-45f1-b30e-39cd88a94c51)

---

La aplicación angular es realizada en VisualCode como se ve en la imagen y para el despliegue de la app se escoje la appWeb donde se alojará como se ve en la imagen

![image](https://github.com/user-attachments/assets/85cdcbe5-ad0f-4863-940d-40ba7147ec26)

---

Como se observa en la imagen se elije la opción "Deploy to WebApp"

![image](https://github.com/user-attachments/assets/419f5f78-5ffc-4b00-8e45-b2cbbed084d2)

---

Y vemos que se publica exitosamente como se esperaba, se puede ver la URL del dominio predeterminado creado por Azure donde está alojada la aplicación de Angular

![image](https://github.com/user-attachments/assets/281afdd3-23bc-4ef5-b30c-b554cdef667b)
![image](https://github.com/user-attachments/assets/171773d8-72d7-4066-a4a5-ceac9aa76990)

---

Este es el módulo de usuarios, como se puede observar , el despliegue del Front de Angular fue exitosamente publicado al igual que el Backend publicado anteriormente

![image](https://github.com/user-attachments/assets/1379f720-c8c7-4835-867a-c41d2a0651be)

---

Módulo productos

![image](https://github.com/user-attachments/assets/a8c4466d-0c19-4fe5-a018-e5dfa888d0df)

---

Módulo ventas

![image](https://github.com/user-attachments/assets/4f29e8bb-ca76-4b98-96ae-ab621a3bee0e)

---

Historial de Ventas

![image](https://github.com/user-attachments/assets/b88c6d53-5256-4d2a-b901-250ff2e75a71)

---

Módulo reportes

![image](https://github.com/user-attachments/assets/41b3a71e-17da-42f3-bdc7-ec3a8e15e2d3)

---

Esto sería todo por el lado del despliegue a Azure

Para concluír se cumple con el objetivo de publicar las 2 aplicaciones, la de Backend y la del lado Front en Azure, se muestra el paso a paso desde la creación de la suscipción, la creación del grupo de recursos y la creación de las appWeb donde se alojan las aplicaciones. Para finalizar se eliminarán todos los recuros ya que Azure cobra por uso ya que no estoy usando una cuenta gratuita. Cuando se crea por primera vez la cuenta Azure obsequia 200 dolares por 30 días para uso de cualquier recurso, sin embargo ya esos 200 dólares se agotaron en el uso de otras aplicaciones que habia subido meses antes, lo cual me llevo a utilizar la versión paga para efectos de esta prueba. Es por eso que ya habiendo documentado esta prueba se eliminarán todos los recuros.

---

**Conclusión**

El despliegue del Sistema Venta Ecommerce en Azure proporciona una infraestructura robusta para el sistema, garantizando alta disponibilidad, escalabilidad bajo demanda y seguridad en el acceso. Además, centraliza los servicios de frontend, backend y base de datos en un mismo ecosistema de nube.


**Referencias**

- https://learn.microsoft.com/azure



