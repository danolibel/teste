 class Program
    {
        static void Main(string[] args)
        {
            double number1,number2,number3,media;
 
            Console.Write("Digite a nota 1:");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota 2:");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota 3:");
            number3 = Convert.ToDouble(Console.ReadLine());
            media = (number1 + number2 + number3)/3;
            
            Console.WriteLine("MEDIA = "+ media.ToString("0.0"));
            Console.ReadLine();
        }
    }