namespace Topic_5_Pt_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            double maximumCharge = 20;
            double minimumCharge = 4;
            double hourlyCharge = 2;
            double charge, hoursRounded, hours, minutes;

            minutes = generator.Next(1, 1441);
            Console.WriteLine(minutes);
            hours = minutes / 60;
            hoursRounded = Math.Ceiling(hours);

            Console.WriteLine("Welcome to Noah's Parking Plaza");
            Console.WriteLine("You parked for " + hoursRounded + " hours");


            if (minutes >= 540)
            {
                charge = maximumCharge;
            }
            else if (minutes < 61)
            {
                charge = minimumCharge;
            }
            else
            {
                charge = (hoursRounded - 1) * hourlyCharge + minimumCharge;
            }

            Console.WriteLine("You will be charged " + charge + "$");
        }
    }
}