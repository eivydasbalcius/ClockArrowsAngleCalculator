namespace ClockApp
{
    internal class ClockController
    {
        public static int GetHours()
        {
            Console.WriteLine("Enter hour (1-12):");
            string? userInput = Console.ReadLine();
            if (String.IsNullOrEmpty(userInput))
            {
                return GetHours();
            }
            else
            {
                return GetHoursFromString(userInput);
            }
        }
        private static int GetHoursFromString(string? userInput)
        {
            bool isInt = int.TryParse(userInput, out int hours);
            if (isInt == true && hours > 0 && hours <= 12)
            {
                return hours;
            }
            else
            {
                Console.WriteLine("Please enter correct number");
                return GetHours();
            }
        }

        public static int GetMinutes()
        {
            Console.WriteLine("Enter minutes (0-59):");
            string? userInput = Console.ReadLine();

            if (String.IsNullOrEmpty(userInput))
            {
                return GetMinutes();
            }
            else
            {
                return GetMinutesFromString(userInput);
            }
        }


        private static int GetMinutesFromString(string? userInput)
        {
            bool isInt = int.TryParse(userInput, out int minutes);
            if (isInt == true && minutes >= 0 && minutes <= 59)
            {
                return minutes;
            }
            else
            {
                Console.WriteLine("Please enter correct number");
                return GetMinutes();
            }
        }
    }
}
