# Airline DB

## Requisitos para levantar el proyecto

1. **Tener MySQL corriendo localmente**
   - Asegúrate de que el servicio de MySQL esté iniciado en tu máquina local.

2. **Ejecutar el script de la base de datos**
   - Ejecuta el script SQL provisto en el repositorio para crear la base de datos y las tablas necesarias.

3. **Configurar usuario y contraseña de la base de datos**
   - Debes conocer el usuario y la contraseña de tu instancia local de MySQL. Estos datos serán necesarios para la conexión desde la aplicación.

4. **Instalar las dependencias de MySQL para el proyecto**
   - Abre una terminal en la raíz del proyecto y ejecuta el siguiente comando para restaurar las dependencias:
     ```
     dotnet restore
     ```
   - Esto instalará todas las dependencias necesarias, incluyendo el conector de MySQL para .NET.

5. **Establecer la variable de entorno de conexión**
   - Debe estar configurada la variable de entorno en tu sistema para la conexión a la base de datos. Por ejemplo:
     ```
     EAFIT_DB_CONNECTION=server=127.0.0.1;uid=root;pwd=toor;database=airline_db
     ```
   - Ajusta los valores según tu configuración local de MySQL (usuario, contraseña, nombre de la base de datos, etc.).

---
