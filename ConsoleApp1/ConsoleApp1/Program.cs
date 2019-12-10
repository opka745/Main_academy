using System;

namespace ConsoleApp1
{
    class Program
    {
        struct MyStruct
        {
            public int b;
            public int cr;
            public State st;
        }

        enum State
        {
            ok = 2,
            error,
            warning
        }

        static void Main(string[] args)
        {
            int i1 = 1, j = 3;
            foreach(var arg in args)
            {
                Console.WriteLine(arg);
            }
            for (int i = 0; i < args.Length; i+=2)
            {
                if(i < 0) continue;
                if(i<5 && j == 3) break;
                
            }
            MyStruct str = new MyStruct()
            {
                cr = 3,
                b = 4,
                st = State.error
            };
            int temp = 0;
            int[,] arr = new int[3, 3];
            int[,] arr1 = new int[3, 3];
            for(int i = 0; i < 9; i++)
            {
                arr1[(int)i / 3, i % 3] = arr[(int)i / 3, i % 3];
            }


            var i3 = 19;
            short a = 1, b = 1, v = 4;
            Console.WriteLine(8192 + 1024 + 512 + 64 + 16 + 15);
            Console.WriteLine(i3);

            
            //Console.WriteLine(++i1);
            Console.ReadKey(); 
        }
    }
}
