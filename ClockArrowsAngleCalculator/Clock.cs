namespace ClockApp
{
    internal class Clock
    {
        public double Hours;
        public double Minutes;

        public Clock(double hours, double minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public double GetAngle()
        {
            double angleHrs = (30 * Hours) + (Minutes / 2);
            double angleMin = Minutes * 6;
            double angle = Math.Abs(angleHrs - angleMin);
            if (angle > 180)
            {
                return 360 - angle;
            }
            return angle;
        }
    }
}
