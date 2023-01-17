using System;
using System.Threading;
using C = System.Console;
using static System.Console;


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
            SizeOfScreen();
            gameIntro();
        }
        
        private static void SizeOfScreen()
        {
            Console.SetWindowSize(200, 50);
        }

        private static void TW(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(50);
            }
        }

        public static string sex = "m";
        public static string sexInfo = "Muž";
        public static string characterName = "Pepa";
        public static string race = "1";
        public static string raceInfo = "člověk";
        public static string profession = "1";
        public static string professionInfo = "bojovník";
        public static int health = 40;
        

        public static void gameIntro()
        {
            C.Clear();
            Random hp = new Random();
            health = hp.Next(25, 50);
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
                    sex = "z";
                    sexInfo = "Žena";
                    break;
                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    C.WriteLine("Neplatný vstup, odpověď musí být buď m/muž nebo ž/žena!");
                    System.Threading.Thread.Sleep(2000);
                    ResetColor();
                }
                
            } //Sex
            while (true)
            {
                TW("Napište jméno vašeho charakteru!");
                C.WriteLine();
                characterName = C.ReadLine();
                TW("Ahhh, "+ characterName + ", jméno tvé.");
                C.WriteLine();
                C.WriteLine("Opravdu si přejete se jmenovat " + characterName + " ?");
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
                TW("Hmmmmm, je na čase si vybrat rasu vašeho characteru"); WriteLine();
                TW("1. - Člověk"); WriteLine();
                TW("2. - Elf"); WriteLine();
                TW("3. - Trpaslík"); WriteLine();
                TW("4. - Půlork"); WriteLine();
                TW("5. - Gnóm"); WriteLine();
                C.WriteLine("Tak co si vybereš?");
                race = C.ReadLine().ToLower();

                if (race == "1" || race == "člověk" || race == "clovek")
                {
                    TW("Vybral sis Člověka. Díky tomuto výběru budeš mít lepší schopnost boje s mečem a větší šanci na úspěch při přesvědčování!");
                    race = "1";
                    raceInfo = "člověk";
                    WriteLine();
                    break;
                }
                else if (race == "2" || race == "elf")
                {
                    TW("Vybral sis Elfa. Díky tomuto výběru budeš mít lepší schopnost boje s lukem a lepší obratnost!"); WriteLine();
                    race = "2";
                    if (sex == "m")
                    {
                        raceInfo = "Elf";  
                    }
                    else
                    {
                        raceInfo = "Elfka";
                    }
                    break;
                }
                else if (race == "3" || race == "trpaslík" || race == "trpaslik")
                {
                    TW("Vybral sis Trpaslíka. Díky tomuto výběru budeš lépe bojovat na blízko s nožem a máš lepší odolnost vůči zraněním!"); WriteLine();
                    race = "3";
                    if (sex == "m")        
                    {                      
                        raceInfo = "trpaslík";  
                    }                      
                    else                   
                    {                      
                        raceInfo = "trpaslice";
                    }                      
                    break;
                }
                else if (race == "4" || race == "půlork" || race == "pulork")
                {
                    TW("Vybral sis Půlorka. Díky tomuto výběru budeš mít větší sílu a odolnost!"); WriteLine();
                    race = "4";
                    if (sex == "m")        
                    {                      
                        raceInfo = "půlork";  
                    }                      
                    else                   
                    {                      
                        raceInfo = "půlorčice";
                    }                      
                    break;
                }
                else if (race == "5" || race == "gnóm" || race == "gnom")
                {
                    TW("Vybral sis Gnóma. Díky tomuto výběru budeš mít větší odolnost a inteligenci!"); WriteLine();
                    race = "5";
                    if (sex == "m")        
                    {                      
                        raceInfo = "Gnóm";  
                    }                      
                    else                   
                    {                      
                        raceInfo = "Gnómka";
                    }                      
                    break;
                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    C.WriteLine("Neplatný vstup, zkus to znovu!");
                    System.Threading.Thread.Sleep(2000);
                    ResetColor();
                }

            } //Race
            C.WriteLine();
            while (true)
            {
                TW("A co takhle povolání! Pojďme si vybrat."); WriteLine();
                ForegroundColor = ConsoleColor.Blue;
                TW("1. - Bojovník"); WriteLine();
                ForegroundColor = ConsoleColor.DarkBlue;
                TW("2. - Čaroděj"); WriteLine();
                ForegroundColor = ConsoleColor.DarkGreen;
                TW("3. - Druid"); WriteLine();
                ForegroundColor = ConsoleColor.Green;
                TW("4. - Lovec"); WriteLine();
                ResetColor();
                C.WriteLine("Takže vaše volba?");
                profession = C.ReadLine().ToLower();

                if (profession == "1" || profession == "bojovník" || profession == "bojovnik")
                {
                    profession = "1";
                    professionInfo = "bojovník";
                    break;
                }
                else if (profession == "2" || profession == "čaroděj" || profession == "carodej")
                {
                    profession = "2";
                    if (sex == "m")
                    {
                        professionInfo = "čaroděj";
                    }
                    else
                    {
                        professionInfo = "čarodějka";
                    }
                    break;
                }
                else if (profession == "3" || profession == "druid")
                {
                    profession = "3";
                    if (sex == "m")
                    {
                        professionInfo = "druid";  
                    }
                    else
                    {
                        professionInfo = "druidka";
                    }
                    break;
                }
                else if (profession == "4" || profession == "lovec")
                {
                    profession = "4";
                    if (sex == "m") 
                    {
                        professionInfo = "lovec";
                    }
                    else
                    {
                        professionInfo = "lovkyně";
                    }
                    break;
                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Neplatný vstup, zkus to znovu");
                    System.Threading.Thread.Sleep(2000);
                    ResetColor();
                }
            }
            C.WriteLine("Pro pokračování, stiskněte enter");
            C.ReadLine();
            C.Clear();
            C.WriteLine("Shrnutí vaší postavy");
            C.ForegroundColor = ConsoleColor.Yellow;
            TW("Vaše pohlaví: " + sexInfo); WriteLine();
            TW("Vaše jméno: " + characterName); WriteLine();
            TW("Vaše rasa: " + raceInfo); WriteLine();
            TW("Vaše povolání: " + professionInfo); WriteLine();
            TW("Vaše výše zdraví: " + health); WriteLine();
            C.ResetColor();
            C.ReadKey();
            System.Threading.Thread.Sleep(5000);
            C.Clear();
            storyIntro();
        }

        public static void storyIntro()
        {
            SizeOfScreen();
            //nazev to chce
            
            
            TW("Trojice lovců pokladů přišla do haly cechu dobrodruhů. Rytíř tiefling Zhack, elfský čaroděj Har a lidská klerička Ilia se vrátili z neúspěšné mise. Z jednoduchého úkolu vyčištění pyramidy, kde měli být mocné artefakty, se stala téměř sebevražedná mise. Osm párů nohou vešlo, tři páry vyšli a táhli s sebou jeden pár. Před pyramidou je nyní malá kamená hrouda, málokdo ví koho ukrývá."); WriteLine();
            TW("Ale to je teď už jedno, už nechali truchlení po opilecké a sebelitující noci. "); WriteLine();
            ForegroundColor = ConsoleColor.Yellow;
            TW("*Áaaa, tady jste!* "); ResetColor();
            TW("ozvala se mladá trpaslice za pultem"); WriteLine();
            ForegroundColor = ConsoleColor.Yellow;
            TW("*Vaší ztráty je nám líto, ale minimální počet členů pro družinu jsou čtyři. Dokud nebudete v minimálním počtu, nemůžeme vám dát další úkol.*"); ResetColor(); WriteLine();
            TW("Po této zprávě zbledli tváře všem třem dobrodruhům.");
            WriteLine();
            ForegroundColor = ConsoleColor.Cyan; 
            TW("*Nemůžeme si dovolit čekat, už teď nemáme na přespání a to je cech nejlevnější...* ");
            ResetColor();
            TW("pošeptal Har svým společníkům.");
            WriteLine();
            TW("Když šlo o myšlení, tak byl druhý nejlepší, první byl starý kouzelník Opus Magnus. Všichni chvíli stáli a vzpomínali na něj a Har se rděl, že to řek tak rychle."); WriteLine();
            Thread.Sleep(2000);
            WriteLine();
            TW("Trpaslice Jörna vycítila napjetí a rozhlédla se po hale kde odpočivali a popíjeli jiní dobrodruzi."); WriteLine();
            ForegroundColor = ConsoleColor.Yellow;
            TW((sex == "m") ? "*Uhmm... támhle ten v plášti! Je sám a má dlouholeté zkušenosti.* " : "*Uhmm... tamhle ta v plášti! Je sama a má dlouholeté zkušenosti.* "); ResetColor();
            TW("řekla."); WriteLine();
            ForegroundColor = ConsoleColor.Blue;
            TW((sex == "m") ? "*Tak proč je sám!* " : "*Tak proč je sama!* "); ResetColor(); TW("skoro vyhrkl Zhack."); WriteLine();Thread.Sleep(2000); 
            ForegroundColor = ConsoleColor.Yellow;
            TW((sex == "m") ? "*Je temperamentní a jeho družina ho, jak to říci slušně, požádala o vystoupení ze skupiny.* " : "*Je temperamentní a její družina jí, jak to říci slušně, požádala o vystoupení ze skupiny.* "); ResetColor();
            TW("odpověděla úzkostlivě cechovní úřednice a podívala se jestli jí slyšela."); WriteLine();Thread.Sleep(1500); 
            ForegroundColor = ConsoleColor.Magenta;
            TW((sex == "m") ? "*Vyhodili ho.* " : "*Vyhodili ji.* "); ResetColor();
            TW((sex == "m") ? "povzdechla si Ilia a pohlédla schovívavě k němu." : "povzdechla si Ilia a pohlédla schovívavě k ní."); WriteLine();
            TW("Cuknutí hlavy prozradilo, že je slyší. "); TW((sex == "m") ? "Nenápadně si usrkl z korbelu a podíval se na ně. Všichni čtyři na něj zírali" : "Nenápadně si usrkla z korbelu a podívala se na ně. Všichni čtyři na ní zírali."); WriteLine();
            TW((sex == "m") ? "Málem všechno vyprskl a zakašlal se. Zhack přišel k němu a popácal ho po zádech." : "Málem všechno vyprskla a zakašlala se. Zhack přišel k ní a popácal jí po zádech."); WriteLine();
            ForegroundColor = ConsoleColor.Blue; TW("*Nechceš někam vyrazit a vydělat balík peněz?* "); ResetColor(); TW("řekl přijemným hlasem jakoby mluvil s dítětem."); WriteLine(); WriteLine();
            Thread.Sleep(2000);
            while (true)
            {
                string one = "Když mě...nenecháte ve štychu tak jo.";
                string two = "Říkate balík peněz? Kdy a kde mám být.";
                string three = "A nevykašlete se ne mě, jako ti před vámi? Ale ano, bude mi potěšením.";
                WriteLine("Co odpovíte?");
                WriteLine("1. - " + one);
                WriteLine("2. - " + two);
                WriteLine("3. - " + three);
                int odpoved = Convert.ToInt32(ReadLine());
                ForegroundColor = ConsoleColor.Green;
                if (odpoved == 1)
                {
                    TW("*" + one + "*");
                    break;
                }
                else if (odpoved == 2)
                {
                     TW("*" + two + "*");
                     break;
                }
                else if (odpoved == 3)
                {
                    TW("*" + three + "*");
                    break;
                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Neplatný vstup. Vstup musí být 1/2/3. Zkuste to znovu");
                    ResetColor();
                }
            }
            ResetColor();
            TW((sex == "m") ? " řekl skřipavým hlasem prokládaný kašlem." : "řekla skřipavým hlasem prokládaný kašlem."); WriteLine();
            ForegroundColor = ConsoleColor.Green;
            TW("*Jsem "+ professionInfo + " " + characterName + " a jak jste si mohli už povšimnout, jsem " + raceInfo + ", předem voznamuju že mi jde hlavně o prachy a dobrodružství.* "); ResetColor(); TW((sex == "m") ? "s těmito slovy přejel všechny své nové společníky." : "s těmito slovy přejela všechny své nové společníky"); WriteLine();
            Thread.Sleep(1500); 
            ForegroundColor = ConsoleColor.Cyan; TW("*Budeme na to brát ohled.* "); ResetColor(); TW("odeskl Har trochu nevraživě"); WriteLine();
            Thread.Sleep(1500); 
            ForegroundColor = ConsoleColor.Green; TW("*Tak kam vyrazíme?* "); ResetColor(); TW((sex == "m") ? "uzavřel poznávání " + characterName + ".": "uzavřela poznávání " + characterName + ".");
            Thread.Sleep(3000);  WriteLine();
            WriteLine("Pro pokračování stiskněte Enter!");
            ReadKey();
            storyN1();
        }

        public static void storyN1()
        {
               Clear();
        }
    }
}
