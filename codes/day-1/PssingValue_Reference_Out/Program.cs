namespace PssingValue_Reference_Out
{
    class Program
    {
        static void Swipe(int x, ref int y, out int z)
        {
            x = 11;
            y = 21;
            z = 31;
            System.Console.WriteLine("x: " + x + ", y: " + y + ",z: " + z);
        }
        static void Main()
        {
            int a = 10;
            int b = 20;
            int c;
            Swipe(a, ref b, out c);
            System.Console.WriteLine("a: " + a + ", b: " + b + ",c: " + c);
         
            System.Console.Write("enter a date: ");
            string value = Console.ReadLine();
            if (value != null && value != string.Empty)
            {
                // DateTime dt = DateTime.Parse(value);
                // Console.WriteLine(dt);
                DateTime dt;
                bool possible = DateTime.TryParse(value, out dt);
                if (possible)
                {
                    System.Console.WriteLine(dt.ToShortDateString());
                }
                else
                {
                    System.Console.WriteLine("not in proper format");
                }
            }
        }
    }
}
