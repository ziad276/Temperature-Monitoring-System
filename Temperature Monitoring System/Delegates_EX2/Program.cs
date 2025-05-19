namespace Delegates_EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sensor => Adjust temp (input temp)
            // Display
            // Alarm

            Sensor sensor = new Sensor();
            Display display = new Display();
            Alarm alarm = new Alarm(20);

            sensor.SensorChanged += display.ShowTemp; // Subscription
            sensor.SensorChanged += alarm.FireAlarm; // Subscription


            while (true)
            {
                Console.WriteLine("Welcome To The Tempreture System");
                Console.WriteLine("1. Set The Tempreture");
                Console.WriteLine("2. Set The Alarm Value");
                Console.WriteLine("3. Exit");

                var result = Console.ReadLine();

                switch (result)
                {
                    case "1":
                        Console.WriteLine("Please Enter The Tempreture Value");
                        var temp = Console.ReadLine();
                        int tempValue = Convert.ToInt32(temp);
                        sensor.ChangeTempreture(tempValue);
                        break;

                    case "2":
                        Console.WriteLine("Please Enter The Tempreture Value For The Alarm");

                        var alarmString = Console.ReadLine();
                        int alarmValue = Convert.ToInt32(alarmString);
                        alarm.SetAlarmValue(alarmValue);
                        break;

                    case "3":
                        return;
                    
                    default:
                        Console.WriteLine("Wrong Input, Please Enter Correct Value");
                        break; 
                }

            }


        }
    }
}
