//variant 2
using System;


public enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}



public class CalendarEvent
{
    public string EventName { get; set; }
    public DaysOfWeek EventDay { get; set; }

    
    public CalendarEvent(string eventName, DaysOfWeek eventDay)
    {
        EventName = eventName;
        EventDay = eventDay;
    }

    public void PrintEventDetails()
    {
        Console.WriteLine($" {EventName} will be on {EventDay}.");
    }
}




class Program
{
    static void Main(string[] args)
    {
        CalendarEvent myEvent = new CalendarEvent("Independence Day", DaysOfWeek.Saturday);
        myEvent.PrintEventDetails();
    }
}
