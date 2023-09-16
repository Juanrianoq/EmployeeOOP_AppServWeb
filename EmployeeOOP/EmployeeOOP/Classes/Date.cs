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
		  _day = day;
		  _month = month;
		  _year = year;
	    }
            public override string ToString()
            {
		  // Dia/Mes/Año
		  var dateConcatenated = $"{_day}/{_month}/{_year}";
		  return dateConcatenated;
            }

            #endregion

      }
}
