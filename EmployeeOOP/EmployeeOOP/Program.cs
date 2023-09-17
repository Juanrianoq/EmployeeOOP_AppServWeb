using EmployeeOOP.Classes;
try
{
      Console.WriteLine("OOP APLICATION");
      Console.WriteLine("---------------");

      // Variables.
      int day, month, year;
      string firstName, lastName;
      decimal salary;

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

      // Asignación de valores a las variables.
      Console.Write("Ingresar nombre completo: ");
      firstName = Console.ReadLine();

      Console.Write("Ingresar apellidos: ");
      lastName = Console.ReadLine();

      Console.Write("Ingresar salario devengado: ");
      salary = Decimal.Parse(Console.ReadLine());

      SalaryEmployee objSalEmployee = new SalaryEmployee()
      {
            Id = 1057782302,
            FirstName = firstName,
            LastName = lastName,
            BirthDate = objDate,
            HiringDate = objDate,
            IsActive = true,
            Salary = salary,
      };

      Console.WriteLine(objSalEmployee);
}
catch (Exception ex)
{
      Console.WriteLine(ex.Message);
}


