namespace ClassTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            string user_name="";
            Console.WriteLine("Username daxil edin:");

            while (user_name.Length < 8)
            {
                user_name = Console.ReadLine();
                if (user_name.Length < 8)
                {
                    Console.WriteLine("Duzgun Username daxil edin:");
                }
            }

            User user = new User(user_name);



            string pass_word = "";
            Console.WriteLine("Sifre daxil edin:");

            while (pass_word.Length < 8 || !pass_word.Any(char.IsDigit) || (pass_word.ToUpper().Equals(pass_word)) || (pass_word.ToLower().Equals(pass_word)))
            {
                pass_word = Console.ReadLine();
                if (pass_word.Length < 8 || !pass_word.Any(char.IsDigit) || (pass_word.ToUpper().Equals(pass_word)) || (pass_word.ToLower().Equals(pass_word)))
                {
                    Console.WriteLine("Duzgun sifre daxil edin:");
                }
            }

            user.Password = pass_word;


            Console.WriteLine(user.Username);
            Console.WriteLine(user.Password);
        }


    }
}