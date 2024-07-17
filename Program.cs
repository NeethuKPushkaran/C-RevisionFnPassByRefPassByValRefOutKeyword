using System;
namespace FnPassByValuePassByReferenceOutKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pass By Value
            int number = 10;
            Console.WriteLine($"Before calling Method: {number}");
            Square( number );
            Console.WriteLine($"After calling Method: {number}");

            //Pass By Reference - ref keyword
            int MulNum = 12;
            Console.WriteLine($"Before calling Method: {MulNum}");
            MultiplyByTwo(ref MulNum);
            Console.WriteLine($"After calling Method: {MulNum}");

            //Pass By Reference - out keyword
            int AddNum;
            AddNumByTwo(out AddNum);
            Console.WriteLine($"After calling Method: {AddNum}");
        }

        //Pass By Value
        static void Square( int number)
        {
            number = number * number;
            Console.WriteLine($"Inside Method: {number}");
        }

        //Pass By Reference - ref keyword

        static void MultiplyByTwo(ref int MulNum)
        {
            MulNum = MulNum * 2;
            Console.WriteLine($"Inside Method: {MulNum}");
        }

        //Pass By Reference - out keyword

        static void AddNumByTwo(out int AddNum)
        {
            AddNum = 10;
            AddNum = AddNum + 2;
            Console.WriteLine($"Inside Method: {AddNum}");
        }
    }
}