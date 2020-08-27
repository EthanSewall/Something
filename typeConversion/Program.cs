using System;

namespace typeConversion
{
    class Numeral
    {
        private int value;

        static readonly string[] numeralDigits =
            {
                "I",
                "II",
                "III",
                "IV",
                "V",
                "VI",
                "VII",
                "VIII",
                "IX",
                "X",
                "XI",
                "XII",
                "XIII",
                "XIV",
                "XV",
                "XVI",
                "XVII",
                "XVIII",
                "XIX",
                "XX",
                "XXI",
                "XXII",
                "XXIII",
                "XXIV",
                "XXX",
                "XL",
                "L",
                "LX",
                "LXX",
                "LXXX",
                "XC",
                "C",
                "CI",
                "CII",
                "CC",
                "CCC",
                "CD",
                "D",
                "DC",
                "DCC",
                "DCCC",
                "CM",
                "M",
                "MI",
                "MII",
                "MIII",
                "MCM",
                "MM",
                "MMI",
                "MMII",
                "MMC",
                "MMM",
                "MMMM",
                "V"
            };
        public Numeral(int value)
        {
            this.value = value;
        }
        // Declare a conversion from an int to a Numeral. 
        //Note this is a conversion operator named Numeral:
        static public implicit operator Numeral(int value)
        {
            // Note that because Numeral is declared as a struct,
            // calling new on the struct merely calls the constructor
            // rather than allocating an object on the heap:
            return new Numeral(value);
        }
        // Declare an explicit conversion from a Numeral to an int:
        static public explicit operator int(Numeral num)
        {
            return num.value;
        }
        // Declare an implicit conversion from a Numeral to
        // a string:
        static public implicit operator string(Numeral num)
        {
            string rtnvalue = "Conversion not yet implemented";

            if (num.value <= 20)
            {
                rtnvalue = numeralDigits[num.value - 1];
            }

            else
            {
                String[] m = { "", "M", "MM", "MMM" };
                String[] c = {"", "C", "CC", "CCC", "CD", "D",
                            "DC", "DCC", "DCCC", "CM"};
                String[] x = {"", "X", "XX", "XXX", "XL", "L",
                            "LX", "LXX", "LXXX", "XC"};
                String[] i = {"", "I", "II", "III", "IV", "V",
                            "VI", "VII", "VIII", "IX"};

                String thousands = m[num.value / 1000];
                String hundereds = c[(num.value % 1000) / 100];
                String tens = x[(num.value % 100) / 10];
                String ones = i[num.value % 10];
                String ans = thousands + hundereds + tens + ones;
                rtnvalue = ans;
            }
            return (rtnvalue);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Numeral num1 = new Numeral(5);
            num1 = 12;

            Console.WriteLine((int)num1);

            Console.WriteLine(num1);

            Console.ReadKey();
        }
    }
}
