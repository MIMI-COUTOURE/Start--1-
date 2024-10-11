while (true)
        {
            Console.WriteLine("Enter a date (YYYY-MM-DD) or type 'exit' to quit:");
            string userInput = Console.ReadLine();
            
            if (userInput.ToLower() == "exit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            
            if (DateTime.TryParse(userInput, out DateTime targetDate))
            {
                DateTime currentDate = DateTime.Now;
                
                TimeSpan difference = targetDate - currentDate;
                
                if (difference.Days > 0)
                {
                    Console.WriteLine($"{difference.Days} days remain until {targetDate.ToString("yyyy-MM-dd")}.");
                }
                else if (difference.Days < 0)
                {
                    Console.WriteLine($"{Math.Abs(difference.Days)} days have passed since {targetDate.ToString("yyyy-MM-dd")}.");
                }
                else
                {
                    Console.WriteLine("Today is the date!");
                }
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter the date in YYYY-MM-DD format.");
            }
        }
    