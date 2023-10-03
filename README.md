# PruebaSD
Realizar una aplicación web en Angular que permita consultar una tabla en una base
de datos y visualizar el resultado de la consulta en pantalla.


NOTA: 
- Cuando se clone con git el proyecto se debe ejecutar los siguientes pasos:
- en el proyecto de biblioca de clases "PruebaSD.Data", modificar en el metodo "OnConfiguring" la cadena de conexión  del servidor de BD donde se ejecuta
  Server=DESKTOP-7SMJ1SR\\SQLEXPRESS; DataBase=PruebaSD;Integrated Security=True;TrustServerCertificate=True

1. Se debe ejecutar el archivo (.sql) de script pendiente por ejecuar:
   
3. SE EJECUTA EL SIGUIENTE COMANDO PARA GENERAR TODO EL MODELO DE DATOS EN LA BD (SQL SERVER)

   
  ```bash
  Update-Database 
  ```

 o se puede ejecutar este comando. Cualquiera de los datos.

   ```bash
  dotnet ef database update
  ```

3. LUEGO, SE EJECUTA EL DATA SEER CON LOS DATOS QUE SE INSERTARAN EN LA TABLA "Usuario"

   
  ```bash
   dotnet run seedData
  ```
