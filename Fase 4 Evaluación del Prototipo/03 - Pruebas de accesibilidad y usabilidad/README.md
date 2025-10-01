# Pruebas de accesibilidad y usabilidad
---

**Introducción**

Al realizar las pruebas de usabilidad en el Sistema Venta Ecommerce se busca medir la facilidad de uso así como la comprensión y el aprendizaje del sistema. Con las pruebas de accesibilidad en el Sistema Venta Ecommerce se eliminar obstáculos que impiden el acceso a personas que tengan discapacidades (ejemplo: lectores de pantalla, contraste adecuado, navegación por teclado). Las pruebas de ergonomía busca la comodidad y eficiencia en la interacción entre el usuario y el Sistema Venta Ecommerce


---


**Pruebas realizadas**

---

**Objetivo:** Verificar que la aplicación sea fácil de usar y que los usuarios puedan realizar sus tareas sin confusión.

---

**1. Pruebas de usabilidad:**

---

- **Facilidad de navegación:** Se verificó que los usuarios puedan desplazarse entre todos los módulos (Dashboard, Usuarios, Productos, Ventas, Historial de Ventas y Reportes) sin dificultad.
- **Consistencia visual:** Los formularios, botones y menús mantienen un estilo uniforme,esto facilita el aprendizaje y la recordación de acciones.
- **Tiempo de respuesta:** El sistema responde rápidamente al consumo de APIs, evitando retrasos que son perceptibles.
- **Claridad en formularios:** Los campos están claramente etiquetados, y se validan entradas como correos electrónicos o números en ventas, validaciones de campos etc.

---

<img width="1273" height="604" alt="image" src="https://github.com/user-attachments/assets/cd636b49-6777-412e-b1c8-d33f08103377" />

---

<img width="1280" height="647" alt="image" src="https://github.com/user-attachments/assets/21990b6a-4d32-4f57-be11-13a6c6fbcca2" />

---

<img width="1276" height="592" alt="image" src="https://github.com/user-attachments/assets/2e8d2cd2-844c-4377-9fa9-f6b6633ba2f7" />

---

<img width="1280" height="719" alt="image" src="https://github.com/user-attachments/assets/996ed680-46b1-4a4e-b459-47c0c2e3f5a0" />

---

<img width="1280" height="557" alt="image" src="https://github.com/user-attachments/assets/9632b180-f262-4914-820d-f8bccbab0ceb" />

---

<img width="1280" height="609" alt="image" src="https://github.com/user-attachments/assets/12e29593-a1d7-4e78-8086-971df4cc8072" />

---

<img width="1279" height="507" alt="image" src="https://github.com/user-attachments/assets/4aaedce9-ac6c-418c-a4cb-c0e8ecaf2387" />

---

**Facilidad de aprendizaje:** El usuario al navegar en el sistema puede aprender rápidamente, realizar las tareas sin ayuda ya que la interfaz es clara y consistente.

**Consistencia:** El usuario puede navegar en el sistema sin problema ya que los formularios siguen el mismo diseño (colores, tipografía, validaciones, etc.).

**Eficiencia:** El usuario puede realizar una venta completa, consultar historial y generar reportes en pocos clics y sin errores y el tiempo de respuesta que tarda de navegar de módulo en módulo es ágil, rápido y fluído.


---

**1. Pruebas de accesibilidad:**

---

**Objetivo:** Asegurar que el sistema pueda ser usado también por personas con alguna discapacidad o limitación.

---

- **Compatibilidad con lectores de pantalla:** Se comprobó que los elementos HTML (etiquetas aria-label, alt, title) permitan interpretar correctamente los componentes visuales.
- **Contraste de colores:** Los textos son legibles frente a sus fondos, de acuerdo con las pautas WCAG 2.1.
- **Navegación con teclado:** Se verificó que los menús y formularios puedan ser recorridos usando solo el teclado (tabulación y Enter).
- **Responsive design:** Se validó que la interfaz se adapta a diferentes resoluciones de pantalla (desktop, tablet, móvil).
- **Textos alternativos en imágenes:** Se verífico que cada imagen tiene su texto descriptivo (alt).

---

**Login:** Se evidencia 0 errores, 0 errores en el contraste del colores y cumplen con los atributos **Aria** que mejoran la accesibilidad.

---

<img width="1133" height="648" alt="image" src="https://github.com/user-attachments/assets/fbd1f191-a4f6-4dfc-983f-23754e5fca67" />

---

**Módulo DashBoard:** Se evidencia 0 errores, 0 errores en el contraste del colores y cumplen con los atributos **Aria** que mejoran la accesibilidad.

---

<img width="1280" height="731" alt="image" src="https://github.com/user-attachments/assets/1fda873d-f09f-4943-88c1-a336e7d381ac" />

---

**Módulo Usuarios** Se evidencia 0 errores, 0 errores en el contraste del colores y cumplen con los atributos **Aria** que mejoran la accesibilidad.

---

<img width="1280" height="728" alt="image" src="https://github.com/user-attachments/assets/287fa075-3bd3-4dc8-bbe4-baa728e83ca0" />

---

**Agregar Usuarios:** En la ventana de **Agregar Usuario** evidencia 0 errores, 0 errores en el contraste del colores y cumplen con los atributos **Aria** que mejoran la accesibilidad.

---

<img width="1279" height="622" alt="image" src="https://github.com/user-attachments/assets/bd1412e1-549f-48a8-9e71-812617239de6" />

---

**Editar Usuarios:** En la ventana de **Editar Usuario** evidencia 0 errores, 0 errores en el contraste del colores y cumplen con los atributos **Aria** que mejoran la accesibilidad.

---


<img width="1280" height="651" alt="image" src="https://github.com/user-attachments/assets/fc5ad387-b117-4f77-86f2-1cb02d27460e" />

---

Los íconos e imagenes cuentan con texto alternativo como se aprecia en la imagen, que es el resultado esperado.

---

<img width="1231" height="590" alt="image" src="https://github.com/user-attachments/assets/735b71e5-b135-4885-80c3-4610b506632b" />

---
El ícono de eliminar también cuenta con su texto alternativo como se aprecia en la imagen, que es el resultado esperado.

---

<img width="1228" height="534" alt="image" src="https://github.com/user-attachments/assets/d5f610e3-2a5e-4d47-94b7-09f1127029b8" />

---

**Eliminar Usuarios:** En la ventana emergente de **Eliminar Usuario** evidencia 0 errores, 0 errores en el contraste del colores y cumplen con los atributos **Aria** que mejoran la accesibilidad.

---

<img width="1143" height="646" alt="image" src="https://github.com/user-attachments/assets/952ef5d0-3ac4-487a-98a7-f1ac3aa112c8" />

---

**Módulo Venta:** En la vista **Venta** se evidencia 0 errores, 0 errores en el contraste del colores y cumplen con los atributos **Aria** que mejoran la accesibilidad y cuenta con texto alternativo como se aprecia en las imágenes 2 siguientes imágenes.


---

<img width="1231" height="531" alt="image" src="https://github.com/user-attachments/assets/4e5ec7d0-2692-4ea7-9847-1445776307a2" />

---

<img width="1280" height="717" alt="image" src="https://github.com/user-attachments/assets/e341760d-c628-48c6-993f-f28eb3090980" />

---

**Módulo Historial ventas:** De igual manera en la vista se evidencia 0 errores, 0 errores en el contraste del colores y cumplen con los atributos **Aria** que mejoran la accesibilidad como se aprecia en las 2 siguientes imágenes.

---

<img width="1280" height="565" alt="image" src="https://github.com/user-attachments/assets/5bba42a0-a966-4298-901b-6c9f5cde481a" />

---

<img width="1280" height="731" alt="image" src="https://github.com/user-attachments/assets/7b7962d5-1c5a-4dc8-bef6-1f9c46f09566" />

---

**Módulo reportes:** El último módulo de reportes también se evidencia 0 errores, 0 errores en el contraste del colores y cumplen con los atributos **Aria** que mejoran la accesibilidad como se aprecia en las 2 siguientes imágenes.

---

<img width="1278" height="528" alt="image" src="https://github.com/user-attachments/assets/9186da51-8e43-478a-9da1-9583c2702d03" />

---

<img width="1280" height="731" alt="image" src="https://github.com/user-attachments/assets/6f304b1f-7d1c-4312-ba1a-5f7d0a908b45" />

---

**Pruebas de Ergonomía:**

---

**Objetivo:** Validar que la interacción con el sistema sea cómoda, rápida y no provoque cansancio innecesario.

---

- **Distribución de elementos:** Se reviso que los botones principales están en lugares visibles y de fácil acceso.
  
- **Minimizar la carga cognitiva:** Se Comprobó que no hay exceso de información en una sola pantalla.

- **Mensajes:** Se comprobó que los mensajes de error, alertas, y mensajes exitosos son fáciles de entender para el usuario.

---

**Resultado final esperado:** La aplicación Sistema Venta Ecommerce resulta cómoda de usar, sin forzar la vista ni generar confusión en la interacción. 

---


**Conclusión**

La incorporación de pruebas de accesibilidad, usabilidad y ergonomía para el Sistema Venta Ecommerce asegura que no solo sea funcional, sino también inclusivo, intuitivo y cómodo de utilizar. Estas pruebas permitieron identificar mejoras en la experiencia de usuario, fomentando un diseño más universal y eliminando impedimentos tecnológicos. De esta forma, se garantiza que el software pueda ser utilizado por un público más amplio, contribuyendo a su calidad, aceptación y éxito.


**Referencias**

- Sitio del  Dr. Nielsen  “https://www.nngroup.com/people/jakob-nielsen/.”
- Sitio web oficial de lineamientos de WCAG 2.1  “https://www.w3.org/TR/WCAG21/”






























