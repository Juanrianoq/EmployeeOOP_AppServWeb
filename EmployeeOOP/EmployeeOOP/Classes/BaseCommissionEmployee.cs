namespace EmployeeOOP.Classes
{
      public class BaseCommissionEmployee : CommissionEmployee
      {
            #region "Properties"

            public decimal Base { get; set; }

            #endregion

            #region "Methods"

            public override decimal GetValueToPay()
            {
                  return Base * base.GetValueToPay();
            }

            public override string ToString()
            {
                  return $"{base.ToString()}" +
                        $"Salario con comisión devengado: {GetValueToPay:C2} \n\t";
            }

            #endregion
      }
}
