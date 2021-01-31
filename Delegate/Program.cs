using System;
using System.Collections.Generic;

namespace Delegate
{
    class Program
    {
        public  delegate void HelloDelegate(string name);
        public static Dictionary<string,HelloDelegate> HelloDic;
        static void Main(string[] args)
        {
            string name ="pee ";
            Initialization();
            
            HelloDic["Sec"](name);

            while (name.Length>0)
            {
                name =Console.ReadLine();
                if (name.Length > 0 && name!=" ")
                    if (name.Length<=3)
                    {
                        HelloDic["Bad"](name);
                    }
                    else
                    {
                        if (name.Length >= 7)
                        {
                            HelloDic["Best"](name);
                        }
                        else
                        {
                            HelloDic["Well"](name);
                        }
                    }
            };


        }

        static void SimpleHello(string name)
        {
            Console.WriteLine(@"Hello,{0} !",name);
        }
        static void HardHello(string name)
        {
            Console.WriteLine(@"Why did you come,{0} ?!", name);
        }
        static void PrettyHello(string name)
        {
            Console.WriteLine(@"OOOOW,{0} !", name);
        }

        static void Initialization()
        {
            HelloDic = new Dictionary<string, HelloDelegate>
            {
                {"Well",SimpleHello },
                {"Bad",HardHello },
                {"Best",PrettyHello },
                {"Sec",delegate(string name){ Console.WriteLine(@"{0} - poo", name);} }
            };
        }
    }
}
