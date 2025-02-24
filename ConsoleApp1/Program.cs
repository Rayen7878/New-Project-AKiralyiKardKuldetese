using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Fő menü
            Random vszam = new Random();



            string[] szovegek = { "Üdvözzöllek A királyi kard Küldetés játékban", "Kaland játék,", "Készítette: Nagy Sándor & Komóczi Bence" };
            int y = Console.WindowHeight / 2 - szovegek.Length / 2;

            foreach (string szoveg in szovegek)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - szoveg.Length / 2, y++);
                Console.WriteLine(szoveg);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            string startFelirat = "|START|";
            int konzolSzelesseg = Console.WindowWidth;
            string kozepre = startFelirat.PadLeft((konzolSzelesseg + startFelirat.Length) / 2);

            Console.WriteLine(kozepre);

            Console.ReadLine();
            Console.Clear();
            goto fomenu;
        //
        fomenu:
            // uj jatek.
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }


            string szoveg2 = "|| Üdvözzöllek A királyi kard Küldetés fő menüben ||";
            string szoveg3 = "|| Új Játék ||";
            string szoveg4 = "|| Történet ||";
            string szoveg5 = "|| Kilépés || ";



            int konzolSzelesseg1 = Console.WindowWidth; // Konzolablak szélessége
            int balSzovegPozicio = (konzolSzelesseg1 - szoveg2.Length) / 2; // Középre igazítás

            Console.SetCursorPosition(balSzovegPozicio, Console.CursorTop); // Pozíció beállítása
            Console.WriteLine(szoveg2);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }

            int balSzovegPozicio1 = (konzolSzelesseg1 - szoveg3.Length) / 2;
            Console.SetCursorPosition(balSzovegPozicio1, Console.CursorTop);
            Console.WriteLine(szoveg3);


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }
            int balSzovegPozicio2 = (konzolSzelesseg1 - szoveg4.Length) / 2;
            Console.SetCursorPosition(balSzovegPozicio1, Console.CursorTop);
            Console.WriteLine(szoveg4);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }
            int balSzovegPozicio3 = (konzolSzelesseg1 - szoveg5.Length) / 2;
            Console.SetCursorPosition(balSzovegPozicio1, Console.CursorTop);
            Console.WriteLine(szoveg5);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }

            Console.Write("                                                  ||");

            string bemenet1 = Console.ReadLine();


            if (bemenet1.ToLower() == "új játék" || bemenet1.ToLower() == "uj jatek")
            {
                goto ujjatek;

            }
            else if (bemenet1.ToLower() == "történet" || bemenet1.ToLower() == "tortenet")
            {
                goto tortenet;
            }
            else if (bemenet1.ToLower() == "kilépés" || bemenet1.ToLower() == "kilepes")
            {
                Console.Clear();
                goto vege;
            }
            else
            {
                Console.Clear();
                goto fomenu;
            }
        //
        tortenet:
            Console.Clear();

            string[] jatekTortenet = {
                     "A barlang storya:\n" +
                      "Tele van felismerhetetlen szörnyekkel és teremtményekkel,\n" +
                     "de vigaszul a barlang legmélyebb pontján\n" +
                     "lehet Isabella királynő...",

                     "A barlang eredete:\n" +
                     "A barlang egy ogre vezér területe volt régen,\n" +
                     "mielőtt az emberek kiűzték onnan az ogrékat,\n" +
                     "és kibányászták az értékes érceket onnan.\n" +
                 "A bányászatok után ott hagyták az emberek,\n" +
                    "és egy elhagyatott bánya lett belőle.",

                    "Boss fight rész: Az Ogrelakhely\n" +
                      "A lovag végül eléri az ogre vezér szintjét,\n" +
                      "ahol egy hatalmas, kőből faragott trón áll.\n" +
                     "A levegő feszültséggel teli, és az egész hely érezhetően\n" +
                     "sötét és nyomasztó. Az ogre vezér már várt rá.\n" +
                     "A lovagnak itt kell szembenéznie az ogre vezér erejével.\n" +
                     "A harcban nemcsak a fizikai ereje,\n" +
                     "hanem az ügyessége, a harci képességei\n" +
                     "és a taktikai döntései is meghatározzák a küzdelmet.",

                     "A végső csata előtti feszültség:\n" +
                 "A lovag előtt áll az ogre vezér,\n" +
                     "és mindketten tudják, hogy csak\n" +
                    "az egyikük hagyhatja el élve ezt a helyet.",

                     "Boss Fight dialógusa:\n\n" +
                 "A hatalmas ogre vezér előtted áll,\n" +
                    "hatalmas fejszéje szikrázik\n" +
                    "a barlang sötét, füstös fényében.\n" +
                 "Isabella hercegnő melletted áll, de nem avatkozik közbe,\n" +
                 "csak figyel. A vezér mély, szörnyű hangon szólal meg:\n" +
                      "'Gyenge királyság! Az uralmuk már a végéhez ért.\n" +
                  "Most én fogok uralkodni!'",

                      "A vezér előre lép,\n" +
                      "és a fejszét felkészíti egy hatalmas csapásra.\n" +
                      "Te azonban tudod, hogy most nemcsak a fizikai erődet,\n" +
                      "hanem a stratégiádat is be kell vetned,\n" +
                      "ha győzni akarsz…",

                  "Zárás:\n\n" +
                  "A harcok után, ha a lovag legyőzi az ogre vezért,\n" +
              "a hercegnő hálásan segít eljutni a kijárathoz,\n" +
                  "miközben új szövetséget kötnek a királysággal.\n" +
                  "A szörnyek veresége után\n" +
                      "a királyi udvar visszanyeri a nyugalmát,\n" +
                     "de az ogre vezér halála nem biztos,\n" +
                         "hogy véget vetett minden fenyegetésnek…\n" +
                    "De ez már egy újabb történet kezdete lehet."
                        };




            Console.WriteLine(jatekTortenet[0]);
            Console.WriteLine();
            Console.WriteLine(jatekTortenet[1]);
            Console.WriteLine();






            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }

            Console.WriteLine("Vissza szertnél lépni a történet oldalról? IGEN | NEM");

            string bemenet2 = Console.ReadLine();
            if (bemenet2.ToLower() == "igen")
            {
                Console.Clear();
                goto fomenu;

            }
            else
            {
                Console.Clear();
                goto tortenet;
            }
        ujjatek:

            /*
            Játék neve: A Királyi Kard Küldetése
            Játékosunk neve:[?]
            Játékos story:
            Goldberg édesapja oda adta a királyi kardot hogy megmentse a királynőt.
            [?] Goldberg a neve!
            És a Goldberg családból származik aki, egy nagy hatalmú keleti birodalom.\n 

            [?] nagy hatalmú családból származik, amely nagy keleti kontinens uralkodója. 

            Játék story:
            Isabella királynő aki meg szerette volna látogatni a Goldberg királyságot.
            Egy borzasztóan jó rajtaütésen estek át és foglyul esett a szörnyek által akik a hirhedt északi hegyekbe vihették és [?] Goldberg útána eredt rögvest a szörnyek után.

            A barlang storya:
            Tele van felismerhetetlen szörnyekkel és teremtményekel de vigaszul a barlang legmélyebb pontján lehet Isabella királynő...
             
             */
            Console.Clear();
            int konzolSzelesseg2 = Console.WindowWidth;
            string ujjatekszoveg1 = "Üdvözöllek A királyi kard Küldetésén!";


            string jatekosNev;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }

            int balSzovegPozicioujjatek1 = (konzolSzelesseg2 - ujjatekszoveg1.Length) / 2;
            Console.SetCursorPosition(balSzovegPozicioujjatek1, Console.CursorTop);
            Console.WriteLine(ujjatekszoveg1);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
            }

            Console.Write("Kérlek add meg a játékos neved: ");
            jatekosNev = Console.ReadLine();

            Console.Clear();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }

            int balSzovegPozicioujjatek2 = (konzolSzelesseg2 - ujjatekszoveg1.Length) / 2;
            Console.SetCursorPosition(balSzovegPozicioujjatek2, Console.CursorTop);
            Console.WriteLine(ujjatekszoveg1);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }
            string ujjatekszoveg3 = $"{jatekosNev} nagy hatalmú családból származik, amely nagy keleti kontinens uralkodója.";
            int balSzovegPozicioujjatek4 = (konzolSzelesseg2 - ujjatekszoveg3.Length) / 2;
            Console.SetCursorPosition(balSzovegPozicioujjatek4, Console.CursorTop);
            Console.WriteLine(ujjatekszoveg3);

            string ujjatekszoveg2 = $"{jatekosNev} Goldberg édesapja oda adta a királyi kardot hogy megmentse a királynőt.";

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }
            int balSzovegPozicioujjatek3 = (konzolSzelesseg2 - ujjatekszoveg2.Length) / 2;
            Console.SetCursorPosition(balSzovegPozicioujjatek3, Console.CursorTop);
            Console.WriteLine(ujjatekszoveg2);
            Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine($"Isabella királynő útnak indult, hogy meglátogassa a Goldberg Királyságot.\n Azonban egy jól szervezett rajtaütés áldozatává vált, és a szörnyek fogságába esett.\n A támadók valószínűleg a hírhedt északi hegyekbe hurcolták őt.\n{jatekosNev} Goldberg, amint értesült a történtekről, habozás nélkül a nyomukba eredt, hogy kiszabadítsa a királynőt.");




            Console.ReadLine();
            Console.Clear();
            goto mainMenu;

        mainMenu:
            /*
            { }
             [

            Inventory(Bármikor Megnézheti A Hátitáskát),
            Chests(Arany Wave Végén),
            MiniBoss(Minden 5. Wave Egy MiniBoss),
            Nem Talált Az Ütés(Random Változóval),
            Bolt(Minden Wave Végén),
            Kritikus Sebzés(Egy Random Változóval Megoldani),
            Érme(Ami megmenthett téged egy haláltól,a ládából lehet ki nyitni egy nagyon kis esélyel) ]
            


            Mobs Wave 1:
                    [3]
            hp:100
            dmg:50
            Chest:13 Gold

            MiniBoss Wave 5:
                    [1]
            hp:100
            dmg:50
            Chest:13++ Gold

            */
            int[] jatekosStatja = { 300, 50 };
            double[] jatekosKardSebzes = { 0, 0 };
            string[] jatekosHatitaska = { "Királyi Kard", "Királyi Páncél", " " };
            int jatekosExpLVL = 1;
            int jatekosExp = 0;
            int jatekosPenztarca = 1000;

            string[] boltKardAsvany = { "Tűzfény Kristály", "Kék Árnyék Kő", "Mosszöld Obszidián", "Ezüst Holdkő", "Lángoló Zafír", "Pókfonál Kő", "Éjfél Tűz Kő", "Fagyott Lúdtoll Kristály", "Vihar Lángja", "Ősi Csillagfény" };
            string[] boltKardAsvanyMagyarazat = {
                    "Ez a vöröses színű ásvány a barlang falain elterjedt. Megjelenése ragyogó, szinte izzik a fénytől, és gyakran használják varázslatokhoz.",
                    "Egy mélykék színű ásvány, amely tompított fényt bocsát ki. A goblinok számára szinte a sötétségben való tájékozódást segítő eszközként szolgál.",
                 "Zöldes árnyalatú obszidián, amely az erdei területekről származik. Az ásványt gyakran használják gyógyító varázslatokhoz és védelmi varázslatokhoz.",
                        "Ez a fénylő, szürke ásvány különleges tükröződést ad, amely a holdfény hatására ragyog. Az elrejtett járatok navigálásához ideális.",
                    "Ritka, égett narancssárga zafír, amely erős mágikus energiát bocsát ki. A goblinok gyakran elrejtik az értékes darabokat, hogy védjék őket a kíváncsiskodóktól.",
                 "Szürke, szálas szerkezetű ásvány, amely a barlang mélyebb, sötétebb zugaiban található. Állítólag képes megállítani a mérgeket és elnyelni a sötét varázslatokat.",
                     "Sötét, fekete színű ásvány, amit egy titokzatos fénypont villanása jellemez. A legritkább helyeken található, és mágikus védelmet biztosít a sötétség ellen.",
                         "Egy átlátszó, szinte teljesen fehér ásvány, amely a jég birodalmait idézi. Hideg, jéghideg energia sugárzik belőle, és rendkívül nehezen hozzáférhető.",
                     "Hatalmas erejű, kék és zöld színben játszó ásvány, amely a villámlás hatására aktiválódik. Rendkívül ritka, és a legveszélyesebb goblinok is félnek tőle.",
                         "A legritkább és leghatalmasabb kristály, amely egykor a világ kezdeti fényét hordozta. A csillagok szikrázó fénye ragyog belőle, és csupán néhány darab létezik. A varázslók titkos elixíreket készítenek belőle."
                    };

            string[] boltPancelAsvany = { "Fénytörő Obszidián", "Vérvörös Jaspis", "Holdfény Amatészter", "Ékkő Tükrözült", "Fekete Szivárvány", "Tűzvirág Kristály ", "Víz Tükörkő", "Csontfehér Kő", "Zöld Fény Kristály", "Fekete Holdkő" };
            string[] boltPancelAsvanyMagyarazat = {
                            "Egy különleges fekete üveg, amely hajlítja és szórja a fényt, rendkívül ritka és nagy erejű védelmi eszközként használják.",
                     "Mély vörös színű kő, amelyet egyesek vérrel festettnek tartanak. A harcosok a vérvörös jaspist a csatatéren használják, hogy megőrizzék erejüket.",
                      "Egy szikrázó lila kristály, amely a holdfényben ragyog, és az álomvilágokba vezető varázslatok egyik kulcseleme.",
                       "Egy ritka, tükröződő kő, amely képes felnagyítani és visszaverni a környezetében lévő fényeket. A varázslók gyakran használják illúziók létrehozására.",
                      "A fekete üveges kő különböző színekben játszik a fény hatására, így varázslatos hatásokra képes. A varázslók számára különleges erővel bír.",
                      "Egy ragyogó narancssárga kristály, amely lángra lobbantja a közelében lévő anyagokat. A tűzvarázslók számára elengedhetetlen.",
                 "Egy áttetsző, vízszínű ásvány, amely tükrözi a körülötte lévő vízfelületeket. A tengerész varázslók gyakran használják a navigációs varázslataikhoz.",
                     "Egy sápadt, fehér ásvány, amely képes előhívni az ősök szellemeit, így spirituális és kommunikációs célokra is hasznos.",
                     "Egy smaragdzöld kristály, amely az életenergia növelésére használható. A gyógyítók és druida rendek legfontosabb eszköze.",
                     "Sötét színű, fénylő ásvány, amely a mágikus holdfény hatására aktiválódik. Titkos erővel bír, amely képes elnyelni a negatív energiákat."
                    };
            /*
            
            Tűzfény Kristály – 22%          (0-22)
            Kék Árnyék Kő – 16%             (23-38)
            Mosszöld Obszidián – 14%        (39-52)
            Ezüst Holdkő – 11%              (53-63)
            Lángoló Zafír – 9%              (64-72)
            Pókfonál Kő – 7%                (73-79)
            Éjfél Tűz Kő – 6%               (80-85)
            Fagyott Lúdtoll Kristály – 6%   (86-91)
            Vihar Lángja – 5%               (92-96)
            Ősi Csillagfény – 3%            (97-100)

            Fénytörő Obszidián – 22% (0-22)
            Vérvörös Jaspis – 16%    (23-38)
            Holdfény Amatészter – 14%(39-52)
            Ékkő Tükrözült – 11%     (53-63)
            Fekete Szivárvány – 9%   (64-72)
            Tűzvirág Kristály – 7%   (73-79)
            Víz Tükörkő – 6%        (80-85)
            Csontfehér Kő – 6%      (86-91)
            Zöld Fény Kristály – 5% (92-96)
            Fekete Holdkő – 3%      (97-100)







             */


            int[] mobokStatja = { 100, 50 };  // Wave-enként novekszik
            int[] mobMiniBoss = { 200, 70 };  // MiniBoss legyozese utan novekszik
            int[] mobFinalBoss = { 500, 150 }; // FinalBoss legyozese utan novekszik
            int waveCounter = 1;

            // { }
            int konzolSzelesseg3 = Console.WindowWidth;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }
            string mainJatekSzoveg1 = "Jelenleg egy tábortűz mellett ülsz!";
            int balSzovegPozicioujjatek5 = (konzolSzelesseg3 - mainJatekSzoveg1.Length) / 2;
            Console.SetCursorPosition(balSzovegPozicioujjatek5, Console.CursorTop);
            Console.WriteLine(mainJatekSzoveg1);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine($"{waveCounter * 100} méter mélyen tartózkodik {jatekosNev} Goldberg.");
            Console.WriteLine($"{jatekosNev}(-nak/-nek) {jatekosStatja[0]} életereje és {jatekosStatja[1]} sebzése van.");

            Console.Write("A hátitáskád tartalma: ");
            foreach (var elem in jatekosHatitaska)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Tapasztalati szint:{jatekosExpLVL}.");
            Console.WriteLine($"Pénztárca:{jatekosPenztarca} arany érem.");

            Console.WriteLine("|Bolt| | |Játék folytatás| | |Menü|");
            Console.Write($"    {jatekosNev}:");
            string mainmenu1 = Console.ReadLine();  // bolt|fojatek|menu

            if (mainmenu1.ToLower() == "bolt")
            {
                Console.Clear();
                goto bolt;

            }
            else if (mainmenu1.ToLower() == "Játék folytatás" || mainmenu1.ToLower() == "jatek folytatas")
            {
                Console.Clear();
                goto fojatek;
            }
            else if (mainmenu1.ToLower() == "menü" || mainmenu1.ToLower() == "menu")
            {
                Console.Clear();
                goto fomenu;
            }
            else
            {
                Console.Clear();
                goto mainMenu;
            }


        bolt:

            Console.Clear();
            int konzolSzelesseg4 = Console.WindowWidth;
            int db = 1;
            int db1 = 1;
            string boltszoveg1 = "Üdvözöllek a boltban!";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }
            int balSzovegPozicioBolt1 = (konzolSzelesseg4 - boltszoveg1.Length) / 2;
            Console.SetCursorPosition(balSzovegPozicioBolt1, Console.CursorTop);
            Console.WriteLine(boltszoveg1);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }
            // { }
            Console.WriteLine("A boltban ásványok találhatóak amik a felszerelést fejleszti legyen az kard vagy páncél! ");
            Console.WriteLine("Szeretnél szerencsét próbálni? 10 arany érem egy láda... IGEN | NEM");
            Console.WriteLine($"Pénztárcád: {jatekosPenztarca}");

            //Bolt láda nyitás | Véletszám | vszam

            string boltDontes3 = Console.ReadLine();
            if (boltDontes3.ToLower() == "igen")
            {
                Console.WriteLine("Milyen ásványt szeretnél nyitni? KARD | PÁNCÉL");
                string boltDontes4 = Console.ReadLine();
                if (boltDontes4.ToLower() == "kard")
                {

                    Console.WriteLine("A kard fejlesztéshez szükséges ásványok nevei:");
                    foreach (var item in boltKardAsvany)
                    {
                        Console.WriteLine($"{db,4}. {item,4}.");
                        db++;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Biztosan nyitni szeretnél egy ládát ? IGEN | NEM");
                    string boltDontes5 = Console.ReadLine();
                    if (boltDontes5.ToLower() == "igen" && jatekosPenztarca >= 10)
                    {
                        jatekosPenztarca = jatekosPenztarca - 10;
                        int generaltszam = 0;
                        for (int i = 0; i < 1; i++)
                        {
                            int randomNumber = vszam.Next(0, 101);
                            Console.WriteLine($"{randomNumber}. számot nyitottál.");
                            generaltszam = randomNumber;
                        }
                        // <  > int[] jatekosStatja = { 300, 50 };
                        //      double[] jatekosKardSebzes = { 0, 0 };
                        if (generaltszam <= 22)
                        {
                            // 1. Tűzfény Kristály – 20% (0-20): 5 sebzés
                            Console.WriteLine("");
                            Console.WriteLine("1. Tűzfény Kristály – 20% (0-20): +5 sebzés | +0.05 kritikus sebzés");
                            Console.WriteLine("");
                            Console.WriteLine("Biztosan meg szertnéd tartani? IGEN | NEM");
                            string boltValasz1 = Console.ReadLine();
                            if (boltValasz1.ToLower() == "igen")
                            {
                                jatekosKardSebzes[1] = 0.05;
                                jatekosKardSebzes[0] = 5;
                                Console.Clear();
                                goto bolt;
                            }
                            else
                            {
                                Console.Clear();
                                goto bolt;
                            }

                        }
                        else if (generaltszam <= 37)
                        {
                            // 2. Kék Árnyék Kő – 15% (21-35): 10 sebzés
                            Console.WriteLine("");
                            Console.WriteLine("2. Kék Árnyék Kő – 15% (21-35): 10 sebzés |0.1 kritikus sebzés");
                            Console.WriteLine("");
                            Console.WriteLine("Biztosan meg szertnéd tartani? IGEN | NEM");
                            string boltValasz1 = Console.ReadLine();
                            if (boltValasz1.ToLower() == "igen")
                            {
                                jatekosKardSebzes[1] = 0.1;
                                jatekosKardSebzes[0] = 10;
                                Console.Clear();
                                goto bolt;
                            }
                            else
                            {
                                Console.Clear();
                                goto bolt;
                            }

                        }
                        else if (generaltszam <= 50)
                        {
                            // 3. Mosszöld Obszidián – 13% (36-48): 15 sebzés
                            Console.WriteLine("");
                            Console.WriteLine("3. Mosszöld Obszidián – 13% (36-48): 15 sebzés |0.15 kritikus sebzés");
                            Console.WriteLine("");
                            Console.WriteLine("Biztosan meg szertnéd tartani? IGEN | NEM");
                            string boltValasz1 = Console.ReadLine();
                            if (boltValasz1.ToLower() == "igen")
                            {
                                jatekosKardSebzes[1] = 0.15;
                                jatekosKardSebzes[0] = 15;
                                Console.Clear();
                                goto bolt;
                            }
                            else
                            {
                                Console.Clear();
                                goto bolt;
                            }
                        }
                        else if (generaltszam <= 62)
                        {
                            // 4. Ezüst Holdkő – 12% (49-60): 20 sebzés
                            Console.WriteLine("");
                            Console.WriteLine("4. Ezüst Holdkő – 12% (49-60): 20 sebzés | 0.2 kritikus sebzés");
                            Console.WriteLine("");
                            Console.WriteLine("Biztosan meg szertnéd tartani? IGEN | NEM");
                            string boltValasz1 = Console.ReadLine();
                            if (boltValasz1.ToLower() == "igen")
                            {
                                jatekosKardSebzes[1] = 0.2;
                                jatekosKardSebzes[0] = 20;
                                Console.Clear();
                                goto bolt;
                            }
                            else
                            {
                                Console.Clear();
                                goto bolt;
                            }
                        }
                        else if (generaltszam <= 70)
                        {
                            // 5. Lángoló Zafír – 8% (61-68): 30 sebzés
                            Console.WriteLine("");
                            Console.WriteLine("5. Lángoló Zafír – 8% (61-68): 30 sebzés | 0.3 kritikus sebzés");
                            Console.WriteLine("");
                            Console.WriteLine("Biztosan meg szertnéd tartani? IGEN | NEM");
                            string boltValasz1 = Console.ReadLine();
                            if (boltValasz1.ToLower() == "igen")
                            {
                                jatekosKardSebzes[1] = 0.3;
                                jatekosKardSebzes[0] = 30;
                                Console.Clear();
                                goto bolt;
                            }
                            else
                            {
                                Console.Clear();
                                goto bolt;
                            }
                        }
                        else if (generaltszam <= 77)
                        {
                            // 6. Pókfonál Kő – 7% (69-75): 35 sebzés
                            Console.WriteLine("");
                            Console.WriteLine("6. Pókfonál Kő – 7% (69-75): 35 sebzés | 0.35 kritikus sebzés");
                            Console.WriteLine("");
                            Console.WriteLine("Biztosan meg szertnéd tartani? IGEN | NEM");
                            string boltValasz1 = Console.ReadLine();
                            if (boltValasz1.ToLower() == "igen")
                            {
                                jatekosKardSebzes[1] = 0.35;
                                jatekosKardSebzes[0] = 35;
                                Console.Clear();
                                goto bolt;
                            }
                            else
                            {
                                Console.Clear();
                                goto bolt;
                            }
                        }
                        else if (generaltszam <= 83)
                        {
                            // 7. Éjfél Tűz Kő – 6% (76-81): 40 sebzés
                            Console.WriteLine("");
                            Console.WriteLine("7. Éjfél Tűz Kő – 6% (76-81): +40 sebzés | +0.4% kritikus");
                            Console.WriteLine("");
                            Console.WriteLine("Biztosan meg szertnéd tartani? IGEN | NEM");
                            string boltValasz1 = Console.ReadLine();
                            if (boltValasz1.ToLower() == "igen")
                            {
                                jatekosKardSebzes[1] = 0.4;
                                jatekosKardSebzes[0] = 40;
                                Console.Clear();
                                goto bolt;
                            }
                            else
                            {
                                Console.Clear();
                                goto bolt;
                            }
                        }
                        else if (generaltszam <= 91)
                        {
                            // 8. Fagyott Lúdtoll Kristály – 8% (82-89): 50 sebzés
                            Console.WriteLine("");
                            Console.WriteLine("8. Fagyott Lúdtoll Kristály – 8% (82-89): 50 sebzés | 0.5 kritikus sebzés");
                            Console.WriteLine("");
                            Console.WriteLine("Biztosan meg szertnéd tartani? IGEN | NEM");
                            string boltValasz1 = Console.ReadLine();
                            if (boltValasz1.ToLower() == "igen")
                            {
                                jatekosKardSebzes[1] = 0.5;
                                jatekosKardSebzes[0] = 50;
                                Console.Clear();
                                goto bolt;
                            }
                            else
                            {
                                Console.Clear();
                                goto bolt;
                            }
                        }
                        else if (generaltszam <= 97)
                        {
                            // 9. Vihar Lángja – 6% (90-95): 60 sebzés
                            Console.WriteLine("");
                            Console.WriteLine("9. Vihar Lángja – 6% (90-95): 60 sebzés | 0.6 kritikus sebzés");
                            Console.WriteLine("");
                            Console.WriteLine("Biztosan meg szertnéd tartani? IGEN | NEM");
                            string boltValasz1 = Console.ReadLine();
                            if (boltValasz1.ToLower() == "igen")
                            {
                                jatekosKardSebzes[1] = 0.6;
                                jatekosKardSebzes[0] = 60;
                                Console.Clear();
                                goto bolt;
                            }
                            else
                            {
                                Console.Clear();
                                goto bolt;
                            }
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ősi Csillagfény – 4% (96-100): 80 sebzés | 0.8 kritikus sebzés");
                            Console.WriteLine("");
                            Console.WriteLine("Biztosan meg szertnéd tartani? IGEN | NEM");
                            string boltValasz1 = Console.ReadLine();
                            if (boltValasz1.ToLower() == "igen")
                            {
                                jatekosKardSebzes[1] = 0.8;
                                jatekosKardSebzes[0] = 80;
                                Console.Clear();
                                goto bolt;
                            }
                            else
                            {
                                Console.Clear();
                                goto bolt;
                            }
                        }




                    }
                    else
                    {
                        goto bolt;
                    }
                }
            }
            Console.WriteLine("Meg szeretnéd tekinteni a bolt tartalmát? IGEN | NEM");
            string boltDontes = Console.ReadLine();

            if (boltDontes.ToLower() == "igen")
            {
                Console.WriteLine("A kard fejlesztéshez szükséges ásványok nevei:");
                foreach (var item in boltKardAsvany)
                {
                    Console.WriteLine($"{db,4}. {item,4}.");
                    db++;
                }
                Console.WriteLine();
                Console.WriteLine("A páncél fejlesztéshez szükséges ásványok nevei:");
                foreach (var item in boltKardAsvany)
                {
                    Console.WriteLine($"{db1,4}. {item,4}.");
                    db1++;
                }
                Console.WriteLine();
            }
            else if (boltDontes.ToLower() == "nem")
            {
                Console.WriteLine("Vissza szeretnél lépni a tábortűzhöz? IGEN | NEM");
                string boltDontes1 = Console.ReadLine();
                if (boltDontes1.ToLower() == "igen")
                {
                    Console.Clear();
                    goto mainMenu;
                }
                else
                {
                    Console.Clear();
                    goto bolt;
                }

            }


            Console.WriteLine("Vissza szeretnél lépni a tábortűzhöz? IGEN | NEM");
            string boltDontes2 = Console.ReadLine();

            if (boltDontes2.ToLower() == "igen")
            {
                Console.Clear();
                goto mainMenu;
            }
            else if (boltDontes2.ToLower() == "nem")
            {
                Console.Clear();
                goto bolt;
            }






            goto fojatek;


        fojatek:


        vege:



            Console.Clear();



            // felirat kozepre Viszlát.... 

            Console.WriteLine("A játék vége.");
            Console.ReadKey();


        }
    }
}