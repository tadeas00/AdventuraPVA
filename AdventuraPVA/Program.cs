using System;
using System.Threading;
using C = System.Console;


namespace AdventuraPVA
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            C.ForegroundColor = ConsoleColor.Red;
            C.WriteLine(@"______ _   _  ___      ___      _                 _                   "); //Doom font
            C.WriteLine(@"| ___ \ | | |/ _ \    / _ \    | |               | |                  ");
            C.WriteLine(@"| |_/ / | | / /_\ \  / /_\ \ __| |_   _____ _ __ | |_ _   _ _ __ __ _ ");
            C.WriteLine(@"|  __/| | | |  _  |  |  _  |/ _` \ \ / / _ \ '_ \| __| | | | '__/ _` |");
            C.WriteLine(@"| |   \ \_/ / | | |  | | | | (_| |\ V /  __/ | | | |_| |_| | | | (_| |");
            C.WriteLine(@"\_|    \___/\_| |_/  \_| |_/\__,_| \_/ \___|_| |_|\__|\__,_|_|  \__,_|");
            C.WriteLine();
            C.ForegroundColor = ConsoleColor.Yellow;
            string welcome = "Vítejte na cestě osudu!";
            C.SetCursorPosition((Console.WindowWidth - welcome.Length) / 2, Console.CursorTop);
            C.WriteLine(welcome);
            C.ResetColor();
            string enter = "Pro spuštění, zmačkněte Enter!";
            C.SetCursorPosition((Console.WindowWidth - enter.Length) / 2, Console.CursorTop);
            C.WriteLine(enter);
            C.ReadKey();
            gameIntro();
        }

        public static void TW(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(60);
            }
        }

        public static void gameIntro()
        {
            C.Clear();
            string sex;
            string sexInfo;
            string character;
            string race;
            string raceInfo;
            string profession;
            string professionInfo;
            Random hp = new Random();
            int health = hp.Next(25, 50);
            while (true)
            {
                TW("Jaké je pohlaví vašeho characteru?(m/ž)");
                C.WriteLine();
                sex = C.ReadLine().ToLower();
                
                if (sex == "m" || sex == "muž")
                {
                    sex = "m";
                    sexInfo = "Muž";
                    break;
                }
                else if (sex == "ž" || sex == "žena")
                {
                    C.WriteLine("Žena");
                    sex = "ž";
                    sexInfo = "Žena";
                    break;
                }
                else
                {
                    C.WriteLine("Neplatný vstup, odpověď musí být buď m/muž nebo ž/žena!");
                }
                
            } //Sex

            while (true)
            {
                TW("Napište jméno vašeho charakteru!");
                C.WriteLine();
                character = C.ReadLine();
                TW("Ahhh, "+ character + ", jméno tvé.");
                C.WriteLine();
                C.WriteLine("Opravdu si přejete se jmenovat " + character + " ?");
                string nameChar = C.ReadLine().ToLower();

                if (nameChar == "a" || nameChar == "ano" || string.IsNullOrEmpty(nameChar))
                {
                    TW("Dobře, můžeme pokračovat!");
                    break;
                }
                else
                {
                    C.WriteLine("Tím pádem...");
                }
            } //Name
            C.WriteLine();
            while (true)
            {
                TW("Hmmmmm, je na čase si vybrat rasu vašeho characteru");
                C.WriteLine();
                TW("1. - Člověk");
                C.WriteLine();
                TW("2. - Elf");
                C.WriteLine();
                TW("3. - Trpaslík");
                C.WriteLine();
                TW("4. - Půlork");
                C.WriteLine();
                TW("5. - Gnóm");
                C.WriteLine();
                C.WriteLine("Tak co si vybereš?");
                race = C.ReadLine().ToLower();

                if (race == "1" || race == "člověk" || race == "clovek")
                {
                    TW("Vybral sis Člověka. Díky tomuto výběru budeš mít lepší schopnost boje s mečem a větší šanci na úspěch při přesvědčování!");
                    race = "1";
                    raceInfo = "Člověk";
                    C.WriteLine();
                    break;
                }
                else if (race == "2" || race == "elf")
                {
                    TW("Vybral sis Elfa. Díky tomuto výběru budeš mít lepší schopnost boje s lukem a lepší obratnost!");
                    C.WriteLine();
                    race = "2";
                    raceInfo = "Elf";
                    break;
                }
                else if (race == "3" || race == "trpaslík" || race == "trpaslik")
                {
                    TW("Vybral sis Trpaslíka. Díky tomuto výběru budeš lépe bojovat na blízko s nožem a máš lepší odolnost vůči zraněním!");
                    C.WriteLine();
                    race = "3";
                    raceInfo = "Trpaslík";
                    break;
                }
                else if (race == "4" || race == "půlork" || race == "pulork")
                {
                    TW("Vybral sis Půlorka. Díky tomuto výběru budeš mít větší sílu a odolnost!");
                    C.WriteLine();
                    race = "4";
                    raceInfo = "Půlork";
                    break;
                }
                else if (race == "5" || race == "gnóm" || race == "gnom")
                {
                    TW("Vybral sis Gnóma. Díky tomuto výběru budeš mít větší odolnost a inteligenci!");
                    C.WriteLine();
                    race = "5";
                    raceInfo = "Gnóm";
                    break;
                }
                else
                {
                    C.WriteLine("Neplatný vstup, zkus to znovu!");
                }

            } //Race
            C.WriteLine();
            while (true)
            {
                TW("A co takhle povolání! Pojďme si vybrat.");
                C.WriteLine();
                TW("1. - Bojovník");
                C.WriteLine();
                TW("2. - Čaroděj");
                C.WriteLine();
                TW("3. - Druid");
                C.WriteLine();
                TW("4. - Lovec");
                C.WriteLine();
                C.WriteLine("Takže vaše volba?");
                profession = C.ReadLine().ToLower();

                if (profession == "1" || profession == "bojovník" || profession == "bojovnik")
                {
                    profession = "1";
                    professionInfo = "Bojovník";
                    break;
                }
                else if (profession == "2" || profession == "čaroděj" || profession == "carodej")
                {
                    profession = "2";
                    professionInfo = "Čaroděj";
                    break;
                }
                else if (profession == "3" || profession == "druid")
                {
                    profession = "3";
                    professionInfo = "Druid";
                    break;
                }
                else if (profession == "4" || profession == "lovec")
                {
                    profession = "4";
                    professionInfo = "Lovec";
                    break;
                }
                else
                {
                    
                }
            }
            C.WriteLine("Pro pokračování, stiskněte enter");
            C.ReadLine();
            C.Clear();
            C.WriteLine("Shrnutí vaší postavy");
            C.ForegroundColor = ConsoleColor.Yellow;
            TW("Vaše pohlaví: " + sexInfo);
            C.WriteLine();
            TW("Vaše jméno: " + character);
            C.WriteLine();
            TW("Vaše rasa: " + raceInfo);
            C.WriteLine();
            TW("Vaše povolání: " + professionInfo);
            C.WriteLine();
            TW("Vaše výše zdraví: " + health);
            C.WriteLine();
            C.ResetColor();
            C.ReadKey();
            storyIntro();
        }

        public static void storyIntro()
        {
            
        }
    }
}