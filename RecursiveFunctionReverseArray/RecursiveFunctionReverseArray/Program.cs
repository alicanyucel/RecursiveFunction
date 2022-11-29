// See https://aka.ms/new-console-template for more information
 class Program
    {
        public static string ReverseString(string str)
        {
            if ((str == null) || (str.Length <= 1))
                return str;
            return ReverseString(str.Substring(1)) + str[0];
        }
        static void Main(string[] args)
        {
            string myStr="Ali can Yucel";
            string reversed = ReverseString(myStr);
 
            Console.WriteLine("Kelime:" + myStr);
            Console.WriteLine("Ters cevrilmis hali:" + reversed);
            Console.ReadLine();
 
        }
    }