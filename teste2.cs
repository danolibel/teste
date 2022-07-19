 class Program
    {
        static void Main(string[] args)
        {
            double number1,volume,pi;
            pi = 3.14159;
            Console.Write("Digite o raio:");
            number1 = Convert.ToDouble(Console.ReadLine());
            volume = (4/3)*pi*number1^3;
            
            Console.WriteLine("VOLUME = "+ volume.ToString("0.000"));
            Console.ReadLine();
        }
    }