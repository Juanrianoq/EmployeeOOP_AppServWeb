using EmployeeOOP.Classes;
try
{
      Console.WriteLine("OOP APLICATION");
      Console.WriteLine("---------------");

      // Variables.
      int day, month, year;

      Console.Write("Ingresar el dia: ");
      day = Convert.ToInt32(Console.ReadLine());

      Console.Write("Ingresar el mes: ");
      month = Convert.ToInt32(Console.ReadLine());

      Console.Write("Ingresar el año: ");
      year = Convert.ToInt32(Console.ReadLine());

      // Inicializacion de la clase "Date".
      Date objDate = new Date(day, month, year);
      Console.WriteLine("\n");
      Console.WriteLine(objDate.ToString());
}
catch (Exception ex)
{
      Console.WriteLine(ex.Message);
}


