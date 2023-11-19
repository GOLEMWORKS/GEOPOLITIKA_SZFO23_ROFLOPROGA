namespace BankSaverAlgotythm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            string passwordMain = "1337qwerty";

            Console.WriteLine("WELCOME TO SYS.BANK.SAVING ver 0.35.4a");
            do 
            {
                Console.WriteLine("ENTER SYS.PASS.MAIN.bat");
                Thread .Sleep(1000);
                Console.WriteLine("ENTER PASS:");

                Console.WriteLine("type.brutforce.machine");
                string typeWar = (string)Console.ReadLine();
                Console.WriteLine("pass");
                var password = (string)Console.ReadLine();
                if (password == passwordMain)
                {
                    Console.WriteLine("WORKING BOOT.MAIN DRIVER 0.7.1A LOADING");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("|");
                    }
                    Thread.Sleep(1000);
                    Console.WriteLine("V");
                    Thread.Sleep(1000);
                    Console.Write("=o======8=====0================o========--0");
                    Thread.Sleep(1000);
                    Console.Write("-========0o======o=====0--=====-o");
                    Thread.Sleep(1000);
                    Console.Write("==-==============0o============>");
                    Thread.Sleep(1000);
                    Console.WriteLine($"\nCURRENT {typeWar} WORKING FINE \nRESULT: {Guid.NewGuid()} \nCURRENT TIMESTAMP: {DateTime.Now}");
                    isWorking = false;
                }
                else {
                    Console.WriteLine("INVALID PASS 88910)919->XX1MQIO0");
                    isWorking = false;
                };
            } while (isWorking);
        }
    }
}
