using System.Collections;

public class DaysInMonthCollection : IEnumerable<MonthWithDays>
{
    public IEnumerator<MonthWithDays> GetEnumerator()
    {
        return new DaysInMonthEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}