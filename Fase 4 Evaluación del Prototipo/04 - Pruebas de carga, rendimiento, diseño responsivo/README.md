# Pruebas de carga, rendimiento, diseño responsivo

---

**Introducción**

Las pruebas de rendimiento y de diseño responsivo son esenciales para garantizar que una aplicación web no solo funcione correctamente.
Las pruebas de rendimiento lo que hace es medir la capacidad del sistema en cuanto a tiempos de respuesta, estabilidad y consumo de los recursos, simulando múltiples usuarios concurrentes mediante herramientas como Apache JMeter. Por su parte, las pruebas de diseño responsivo validan que la interfaz se adapte correctamente a diferentes resoluciones (móvil, tableta y escritorio). Esto optimiza la experiencia del usuario y asegurar que la aplicación Sistema Venta Ecommerce esté lista para un entorno real de uso.

---

**1. Pruebas de rendimiento**

---

- Las pruebas se realiza mediante la herramienta **Apache JMeter** mide tiempos de respuesta simulando múltiples usuarios concurrentes.
  
- Se realiza el flujo y paso a paso de la prueba con 100 usuarios concurrentes como se ve a continuación en las imágenes.

<img width="1013" height="603" alt="image" src="https://github.com/user-attachments/assets/e02e1082-e1b7-4fdb-bc4c-a5cb55062a8b" />

---

<img width="1003" height="605" alt="image" src="https://github.com/user-attachments/assets/883093d0-9f0d-4695-935f-ffa2bee3e53d" />


---

<img width="996" height="615" alt="image" src="https://github.com/user-attachments/assets/39963917-1e0d-47b6-a199-b29ad4d7890d" />

---

- Se valida el tiempo de respuesta del **inicio de sesión** ingresando las credenciales como **Administrador**, con 100 usuarios concurrentes al mismo tiempo. Se configura el servidor, la ruta, el puerto y el http como POST como se aprecia en la imagen

---

<img width="1000" height="603" alt="image" src="https://github.com/user-attachments/assets/45e82d6e-f214-42a2-9911-d3998fccaa77" />


---

<img width="1000" height="601" alt="image" src="https://github.com/user-attachments/assets/8381ce1c-4f1c-4d0d-9b05-591805bda652" />

---

<img width="1001" height="603" alt="image" src="https://github.com/user-attachments/assets/620490c4-af4c-4305-88d5-33f803167714" />

---

- Al ejecutar la prueba se evidencia que se ejecuta exitosamente con 100 usuarios concurrentes el tiempo de respuesta del inicio de sesión es tan sólo de 2 segundos como se aprecia en las imagenes.

---

<img width="1005" height="601" alt="image" src="https://github.com/user-attachments/assets/c69fb042-1fee-4859-9fb7-e85f27526136" />

---

<img width="999" height="603" alt="image" src="https://github.com/user-attachments/assets/a638ada7-8fc3-4097-9503-5a924c2b7612" />

---

- La siguiente prueba es en el **Módulo usuarios** con 100 usuarios concurrentes y con un tiempo de respuesta de 2 segundos como se evidencia en las imágenes 

---

<img width="1003" height="605" alt="image" src="https://github.com/user-attachments/assets/e34ac1b1-79df-47cb-b656-100131c19a3d" />

---

<img width="1010" height="598" alt="image" src="https://github.com/user-attachments/assets/9b551043-e22b-43c4-9766-23b92032f0ce" />

---

<img width="1002" height="603" alt="image" src="https://github.com/user-attachments/assets/7f94f20e-4192-48c2-a2e5-0a2daeab8051" />

---

- La siguiente prueba es en el **Módulo productos** con 200 usuarios concurrentes y con un tiempo de respuesta de 3 segundos como se evidencia en las imágenes

---

<img width="1002" height="607" alt="image" src="https://github.com/user-attachments/assets/68afc0c6-a5cd-4124-9fba-2db51cf42b54" />

---

<img width="996" height="593" alt="image" src="https://github.com/user-attachments/assets/962d1eac-117e-49ec-81d7-a65cdc564031" />

---

<img width="991" height="603" alt="image" src="https://github.com/user-attachments/assets/426b8ea1-25a3-413a-bf43-c5217dd59fc9" />

---


**2. Pruebas de diseño responsive**

---


  - El uso de Angular Material asegura componentes adaptables a cualquier dispositivo y con estilos. modernos.
  - Uso de componente flexibles como por ejemplo **mat-sidenav** sirve para adaptarse dinamicamente según el tamaño de pantalla, como se ve a continuación

<img width="1206" height="651" alt="image" src="https://github.com/user-attachments/assets/2c43879f-bcc1-4262-ab88-be6bff3c39d1" />


---


**Pruebas en múltiples dispositivos**

  - Se realizan pruebas con las herramientas de inspección de navegadores (modo responsive).

---


**A continuación se realizan las siguientes pruebas**

---

- Se minimiza y ajusta el ancho de la ventana del navegador lo más posible y se evidencia que sigue manteniendo su uniformidad

<img width="514" height="533" alt="image" src="https://github.com/user-attachments/assets/d24b6654-6121-4107-96c4-0a3656efc5a3" />

---

- Con la herramienta DevTools como se ve en la siguiente imagen se puede configurar y simular pantallas de distintos dispositivos (iPhone, iPad, Galaxy, etc.). 

<img width="1280" height="714" alt="image" src="https://github.com/user-attachments/assets/efc1dbea-5666-45a8-9cf0-11b08b223e6a" />

---

<img width="1131" height="651" alt="image" src="https://github.com/user-attachments/assets/a5ea6f5d-5a0c-484f-a700-c246bcc3e4bb" />

---

**Conclusión**

La realización de pruebas de rendimiento en el Sistema Venta Ecommerce permitió comprobar que la aplicación mantiene tiempos de respuesta adecuados incluso bajo carga, esto garantiza la disponibilidad y estabilidad del sistema. Asimismo, las pruebas de diseño responsivo demostraron que la interfaz conserva su correcta visualización y navegabilidad en diferentes dispositivos y esto incrementa la satisfacción del usuario final.


**Referencias**

- Apache Software Foundation - https://jmeter.apache.org/
- https://material.angular.io/
- https://www.w3.org/TR/css3-mediaqueries/












