using ClockApp;

class Program
{
    public static void Main()
    {
        Console.WriteLine("This is a virutal Analog Clock. You will be able to enter hours and minutes to calculate lesser angle between hours and minutes arrows");
        Clock clock = new(ClockController.GetHours(), ClockController.GetMinutes());
        Console.WriteLine("Lesser angle is: {0}°", clock.GetAngle());
    }
}
