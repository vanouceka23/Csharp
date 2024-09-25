using System.Xml.Serialization;

namespace piškvorky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hrac = "x";
            bool konec = false;
            string vybrane = "a";
            string[] pole = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            
            
            while (konec == false) 
            {
                vypsatpole(pole);
                Console.Write("hraje hrac:" ,hrac );
                vybrane = Console.ReadLine();
                if (vybrane == "x" || vybrane == "o")
                {
                    Console.WriteLine("nypište číslo které nebylo vybrané");
                }
                else 
                {
                    for (int i = 0; i < 9; i++) 
                    {
                        if (vybrane == pole[i]) 
                        {
                            pole[i] = hrac;
                        }
                    }
                    if (hrac == "o") 
                    {
                        hrac = "x";
                    }
                    else 
                    {
                        hrac="o";
                    }
                    for (int i = 0; i < 3; i++) 
                    {
                        if (pole[i] == pole[i + 3] && pole[i] == pole[i + 6])
                        {
                            konec = true;
                        }
                    }
                    for (int i = 0; i < 9;i+=3) 
                    {
                        if (pole[i]== pole[i+1] && pole[i]== pole[i + 2]) 
                        {
                            konec=true;
                        }
                    }
                    if (pole[0]== pole[4] && pole[0] == pole[8]) 
                    {
                        konec=(true);
                    }
                    if (pole[2] == pole[4] && pole[2] == pole[6]) 
                    {
                        konec=(true);
                    }


                }
            }
            Console.WriteLine( "vyhrál " + hrac );

        }
        static void vypsatpole (string[] pole)
        {
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j <3 ; j++)
                {
                    Console.Write(pole[j+3*i]);
                }
                Console.WriteLine();
            }
        }
    }
}
