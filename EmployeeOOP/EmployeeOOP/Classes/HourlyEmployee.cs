namespace EmployeeOOP.Classes
{
      public class HourlyEmployee : Employee
      {

            #region "Properties"

            public int Hours {  get; set; }
            public decimal HourValue { get; set; }

            #endregion

            #region "Methods"

            public override decimal GetValueToPay()
            {
                  return Hours * HourValue;
            }
            public override string ToString()
            {
                  return $"{base.ToString()}" +
                        $"Salario por horas trabajadas: {GetValueToPay():C2} \n\t";
            }


            #endregion

      }
}
