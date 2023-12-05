namespace C__DZ
{
     class Program
    {
        static void Main()
        {

            //Приложение требует пользователя ввести его FIN код до тех пор, пока код не проходит валидацию.
            //AA1234567
            //AZE123456
            //Success: "Validation OK!"
            //Error: "Error message"

            if (true)
            {

                Console.Write("Hello User\n\n");


                while (true)
                {
                    Console.Write("Input Your Fin Code: ");
                    string fin = Console.ReadLine();

                    if (fin.StartsWith("AA") && fin.Length == 9 || fin.StartsWith("AZE") && fin.Length == 10)
                    {
                        Console.WriteLine($"\nFin Code: {fin} and Validation Ok");
                        break;
                    }
                    else if (fin.StartsWith("aa") && fin.Length == 9 || fin.StartsWith("aze") && fin.Length == 10)
                    {
                        string funUpper = fin.ToUpper();

                        Console.WriteLine($"\nFin Code: {funUpper} and Validation OK!");
                        break;
                    }
                    else if (string.IsNullOrEmpty(fin))
                    {
                        Console.WriteLine("Error Please Input Fin");
                    }
                    else if (string.IsNullOrWhiteSpace(fin))
                    {
                        Console.WriteLine("Error Please Input Fin");
                    }
                    else
                    {
                        Console.WriteLine("Guide the FIN correctly");
                    }
                }


                
            }


        }
    }
}