namespace projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string slovo;
            int číslo;
            Random random = new Random();
            Console.Write("zadejte (kámen, nůžky, papír):");
            slovo=Console.ReadLine();


            if (slovo == "kámen"  || slovo =="nůžky" || slovo =="papír")
            {
                číslo = random.Next(1,4);
                if (číslo == 1)
                {
                    Console.WriteLine("prohra");
                }
                else if (číslo == 2)
                {
                    Console.WriteLine("výhra");
                }
                else if (číslo == 3)
                {
                    Console.WriteLine("remíza");
                }
                else
                {
                    Console.WriteLine("něco se pokazilo");
                }

            }
            else 
            {
                Console.WriteLine("špatně zadané");
            }


        }
    }
}
