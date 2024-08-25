namespace _2To10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veddit a");
            string a = ConvertTo2Bit(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Veddit b");
            string b = ConvertTo2Bit(Int32.Parse(Console.ReadLine()));
            string result = "";
            if (a.Length > b.Length)
            {
                b = b.PadLeft(a.Length,'0');
            }
            else
            {
                a = a.PadLeft(b.Length, '0');
            }
            for(int i = 0; i < a.Length; i++)
            {
                result += a[i] == b[i] ? "0" : "1";
            }

            Console.WriteLine(result);
            Console.WriteLine($"U vuhlady 10bit : {ConvertTo10Bit(result)}");


        }
        public static string ConvertTo2Bit(int number)
        {
            string binary = "";
            while (number > 0)
            {
                int temp = number % 2;
                binary = temp.ToString() + binary;
                number /= 2;
            }
            return binary;
        }
        public static int ConvertTo10Bit(string binary)
        {
            int value = 0;
            int baseValue = 1;

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    value += baseValue;
                }
                baseValue *= 2;
            }

            return value;
        }
        public static string ReverseStr(string str)
        {
            return "";
        }
    }
}
