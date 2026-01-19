ESCRITO CON CHATGPT:

📦 API Base – Proyecto de Aprendizaje

Este repositorio tiene como objetivo servir como una base de API para realizar cambios posteriores y aprender sobre distintas tecnologías sin la necesidad de crear todo desde cero cada vez.

La idea principal es contar con un proyecto reutilizable que permita experimentar, probar conceptos y validar ideas de forma práctica.

🤖 Uso de IA

La IA se utilizará exclusivamente para:

Aplicar estilos a textos

Consultar conceptos teóricos

 G
❌ No se usará IA para escribir código, ya que el objetivo es mantener el proceso de aprendizaje activo y consciente.

¿Qué sentido tiene aprender si el código lo escribe otro?

⏳ Constancia del Proyecto

Es posible que no exista una constancia estricta en el desarrollo de este u otros proyectos debido a responsabilidades laborales.
Aun así, el repositorio funcionará como un espacio de experimentación continua al que se podrá volver cuando sea necesario.

🚀 Próximos Pasos

Una de las primeras tecnologías a incorporar será Redis.

Algunas ideas iniciales:

Estudiar los conceptos fundamentales de Redis

Evaluar cómo integrarlo dentro de este proyecto

Generar una gran cantidad de registros (posiblemente con ayuda de IA) para:

Simular un GetAll más pesado

Analizar mejoras de rendimiento

Implementar, si es necesario, un retraso artificial en las requests para:

Entender mejor el impacto del caché

Justificar el uso de Redis en escenarios reales

Estas son dudas y puntos a tener en cuenta al momento de decidir cómo y cuándo usar Redis dentro del proyecto.

📚 Librerías utilizadas

**Carter**

Biblioteca utilizada para estructurar la API sobre ASP.NET Core Minimal APIs mediante un enfoque modular.
Permite definir y agrupar endpoints relacionados dentro de módulos independientes, separando la configuración de rutas del Program.cs y evitando su crecimiento excesivo.

Este enfoque mejora la organización del ruteo, la legibilidad del código y la mantenibilidad del proyecto a medida que aumenta la cantidad de endpoints.
Además, se integra de forma nativa con el sistema de Inyección de Dependencias de ASP.NET Core, lo que facilita la construcción de endpoints más desacoplados y orientados a pruebas.

