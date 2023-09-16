using EmployeeOOP.Exceptions;
using System;

namespace EmployeeOOP.Classes
{
      public class Date
      {
	    #region "Fields"

	    private int _year;
	    private int _month;
	    private int _day;

            #endregion

            #region "Methods"

            public Date(int day, int month, int year)
            {
                  _day = ValidateDay(day, month, year);
                  _month = ValidateMonth(month);
                  _year = ValidateYear(year);
            }
            public override string ToString()
            {
		  // Dia/Mes/Año
		  var dateConcatenated = $"{_day:00}/{_month:00}/{_year:0000}";
		  return dateConcatenated;
            }

            #endregion

            #region "Validations"

            private int ValidateYear(int year)
            {
                  if (year >= 1900)
                        return year;
                  else
                        throw new YearException(String.Format("El año {0} no es valido", year));
            }
            private int ValidateMonth(int month)
            {
                  if (month >= 0 && month <= 12)
                        return month;
                  else
                        throw new MonthException(String.Format("El mes {0} no es valido", month));
            }
            private int ValidateDay(int day, int month, int year)
            {
                  if (month == 2 && day == 29 && IsLeapYear(year))
                  {
                        return day;
                  }
                  
                  if(month == 2 && day == 29 && IsLeapYear(year))
                  {
                        bool IsLeapYear = false;
                        IsLeapYearException(IsLeapYear, year);
                  }

                  int[] daysPerMonth = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30 ,31};
                  if (day >= 1 && day <= daysPerMonth[month])
                  {
                        return day;
                  }
                  else
                  {
                        throw new DayException(String.Format("El dia {0} no es valido para el mes {1}.", day, month));
                  }         
            }
            private void IsLeapYearException(bool IsLeapYear, int year)
            {
                  if (!IsLeapYear)
                  {
                        throw new YearException(String.Format("El año {0} no es bisiesto.", year));
                  }
            }
            private bool IsLeapYear(int year)
            {
                  return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
            }

            #endregion

      }
}
