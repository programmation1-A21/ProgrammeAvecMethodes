using System;

namespace ProgrammeAvecMethodes
{
    class Program
    {
        static void SaluerJoueur()
        {
          Console.WriteLine("Bonjour! Bienvenue dans mon monde virtuel!");
        }

        static string ChoisirAction()
        {
            Console.WriteLine("Qu'aimerais-tu faire aujourd'hui?");
            Console.WriteLine("1. Acheter un item dans notre boutique");            
            Console.WriteLine("2. Te promener librement dans mon univers de licornes");
            Console.WriteLine("3. Te promener librement dans mon univers de guerriers");
            return Console.ReadLine();
        }

        static void AcheterItem()
        {
            Console.WriteLine("Je n'ai rien à vendre pour le moment. Désolé!");
        }

        static void ParcourirUnivers(string nomUnivers)
        {
            Console.WriteLine($"C'est une joie de vous voir dans mon monde de {nomUnivers}");
        }

        static void Main(string[] args)
        {
            string action = "";

            SaluerJoueur();
            action = ChoisirAction(); 
            
            switch(action){
                case "1":
                    AcheterItem();
                    break;
                case "2":
                    ParcourirUnivers("licornes");
                    break;
                case "3":
                    ParcourirUnivers("guerriers");
                    break;
                default:
                    Console.WriteLine("Je ne comprends pas ton choix. Bonne journée!");
                    break;
            }
            
        }
    }
}
