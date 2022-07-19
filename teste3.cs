using System.IO;
public   class Program
    {
        static void Main(string[] args)
        {
            double r=0;
            string[] lines = File.ReadAllLines(
                @"C:\Users\user\Desktop\teste.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(' ');
                for (int j=0;j < line.Length;i++){
                    r=r+Convert.ToDouble(line[j]);
                }
            }
            Console.WriteLine(r);
    }
    }