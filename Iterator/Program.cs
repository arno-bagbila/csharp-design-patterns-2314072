internal class Program
{
    private static void Main(string[] args)
    {
        var collection = new DaysInMonthCollection();
        foreach (var monthWithDays in collection)
        {
            Console.WriteLine($"Days in {monthWithDays.Date} - {monthWithDays.Days}");
        }
    }
}

