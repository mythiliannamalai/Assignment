namespace Worksope
{
    class Polindron
    {
        public void poli_num()
        {
            Console.WriteLine(" 1) Enter the number :");
            int num = int.Parse(Console.ReadLine());
            int revers = 0;
            int reminder = 0;
            int original_num = num;
            while (num != 0)
            {
                reminder = num % 10;
                revers = (revers * 10) + reminder;
                num = num / 10;
            }
            if (original_num == revers)
            {
                Console.WriteLine("{0} is polindron..", revers);
            }
            else
            {
                Console.WriteLine("{0} is not polindron..", revers);
            }
        }
            public void poli_str()
            {
                Console.WriteLine("\n 2) Enter the string : ");
                string name = Console.ReadLine();
                string reverse = string.Empty;
                for (int i = name.Length - 1; i >= 0; i--)
                {
                    reverse += name[i];
                }

                if (name == reverse)
                {
                    Console.WriteLine("{0} is Palindrome.",reverse);
                }
                else
                {
                    Console.WriteLine("{0} is not Palindrome",reverse);
                }
            }     
    }
    class Display
    {
        public static void Main(string[] args)
        {
            Polindron poli=new Polindron();
            poli.poli_num();
            poli.poli_str();
        }
     }
   
}