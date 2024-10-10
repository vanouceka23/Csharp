using System.Xml.Serialization;

namespace piškvorky
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            bool spravne=false;
            string hrac = "x";
            bool konec = false;
            string vybrane = "a";
            string[] pole = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            
            
            while (konec == false) 
            {
                vypsatpole(pole);
                Console.Write(" hraje hrac " + hrac +": ");
                vybrane = Console.ReadLine();
                spravne = false;
                for (int i = 0; i < 9; i++)
                {
                    if (vybrane == pole[i])
                        spravne = true;

                }
                
                    
                if (spravne == false)
                {
                   Console.WriteLine("chyba");
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
                    if (konec==false)
                    { 
                        if (hrac == "o")
                        {
                            hrac = "x";
                        }
                        else
                        {
                            hrac = "o";
                        }
                    }
                    


                }
            }
            Console.WriteLine( "vyhrál " + hrac );
            Console.ReadLine();

        }
        static void vypsatpole (string[] pole)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" ");
                for(int j = 0; j <3 ; j++)
                {
                    Console.Write(pole[j+3*i]);
                }
                Console.WriteLine();
            }
        }
    }
}
