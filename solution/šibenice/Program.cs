using System.Net.NetworkInformation;

namespace šibenice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pismena = [];
            Random random = new Random();
            bool pokracovat = true;
            string[] neco = [];
            int cislo = 0;
            int zivoty = 10;
            bool vyhravno = true;
            string[] radkySouboru = File.ReadAllLines(@"data.txt");
            string slovo = radkySouboru[random.Next(0,radkySouboru.Length)];
            char[] tisknuto = new char[slovo.Length];
            for(int i = 0;  i < slovo.Length; i++)
            {
                tisknuto[i] = '_';
            }
            


            while (pokracovat)
            {
                Console.WriteLine();
                for (int i = 0; i < tisknuto.Length; i++)
                {
                    Console.Write(tisknuto[i]);
                }
                Console.WriteLine();
                string a = Console.ReadLine();
                if (a.Length != 0)
                {
                    char vybrane = a[0];


                    cislo = 0;
                    for (int i = 0; i < slovo.Length; i++)
                    {
                        if (vybrane == slovo[i])
                        {
                            tisknuto[i] = vybrane;
                        }
                        else
                        {
                            cislo++;
                        }
                    }
                    if (cislo == slovo.Length)
                    {
                        zivoty--;
                        Console.WriteLine("špatně");
                        Console.WriteLine(slovo);
                        Console.WriteLine("životů: "+zivoty);
                    }
                }
                else
                {
                    Console.WriteLine("chyba") ;
                }
                if (zivoty == 0)
                {
                    pokracovat = false;
                    vyhravno = false;
                }
                cislo = 0;
                for (int i = 0;i < tisknuto.Length; i++)
                {
                    if (tisknuto[i]== '_')
                    {
                        cislo ++;
                    }
                }
                if (cislo==0)
                {
                    pokracovat=false;
                }
            }
            if (vyhravno)
            {
                Console.WriteLine("správně");
                Console.Write("chcete přidat slovo (ano/ne)");
                if (Console.ReadLine() == "ano")
                {
                    Console.Write("zadejte slovo: ");
                    string ahoj = Console.ReadLine();
                    File.WriteAllLines(@"data.txt",radkySouboru);
                    File.AppendAllText(@"data.txt", ahoj);
                }
            }
            else
            {
                Console.WriteLine("sprvný výsledek: " + slovo);
            }

        }
    }
}
