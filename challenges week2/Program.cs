namespace challenges_week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is the current temperature outside in degrees farenheit?.........");
            int temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the temperature is {temp} degrees ");

            if (temp >= 0 && temp <= 10)
            {
                Console.WriteLine("Freezing outside i see");
            }
            else if (temp >= 11 && temp <= 20)
            {
                Console.WriteLine("Very cold weather");
            }
            else if (temp >= 21 && temp <= 35)
            {
                Console.WriteLine("just cold weather");
            }
            else if (temp >= 36 && temp <= 50)
            {
                Console.WriteLine("normal weather");
            }
            else if (temp >= 51 && temp <= 65)
            {
                Console.WriteLine("it is hot");
            }
            else if (temp >= 66 && temp <= 80)
            {
                Console.WriteLine("it is very hot");
            }

            string correctpassword = "password123";
            string userId = "Raheim";
            int attempts = 0;
            bool authenticated = false;

            while (attempts < 3 && !authenticated)
            {
                Console.WriteLine("enter user ID:");
                string userID = Console.ReadLine();

                Console.WriteLine("enter a password");
                string password = Console.ReadLine();

                if (password == userId && password == correctpassword)
                {
                    authenticated = true;
                }
                else
                {
                    attempts++;
                    Console.WriteLine($"Incorrect user ID or password. attempt{attempts}/3");
                }
                if (attempts == 3)
                {
                    Console.WriteLine("you have been rejectec after 3 unsuccessful attempts");
                }







            }
        }
    }
}
