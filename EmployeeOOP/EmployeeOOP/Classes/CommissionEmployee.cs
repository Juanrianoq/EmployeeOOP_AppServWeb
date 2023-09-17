using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
      public class CommissionEmployee : Employee
      {

            #region "Properties"

            public int CommisionPercentaje {  get; set; }
            public decimal Sales { get; set; }

            #endregion

            #region "Methods"

            public override decimal GetValueToPay()
            {
                  return Convert.ToDecimal(Sales + (Sales * CommisionPercentaje));
            }
            public override string ToString()
            {
                  return $"{base.ToString()}" +
                        $"Comision por ventas: {GetValueToPay:C2} \n\t";
            }

            #endregion

      }
}
