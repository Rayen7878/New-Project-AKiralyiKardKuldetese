Bolt félkész állapotban van. A páncél ásványokat meg kell irni mint a Kard ásványokat.... a figh hiányzik teljesen .a harc rendszer teljsen 



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


1. Tűzfény Kristály – 20% (0-20): 5 sebzés 0.05
2. Kék Árnyék Kő – 15% (21-35): 10 sebzés 0.1
3. Mosszöld Obszidián – 13% (36-48): 15 sebzés 0.15
4. Ezüst Holdkő – 12% (49-60): 20 sebzés
5. Lángoló Zafír – 8% (61-68): 30 sebzés
6. Pókfonál Kő – 7% (69-75): 35 sebzés
7. Éjfél Tűz Kő – 6% (76-81): 40 sebzés
8. Fagyott Lúdtoll Kristály – 8% (82-89): 50 sebzés
9. Vihar Lángja – 6% (90-95): 60 sebzés
10. Ősi Csillagfény – 4% (96-100): 80 sebzés

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

Fénytörő Obszidián – 20% (0-20): 50 életerő 0.05
Vérvörös Jaspis – 15% (21-35): 100 életerő 0.1
Holdfény Amatészter – 13% (36-48): 150 életerő 0.15
Ékkő Tükrözült – 12% (49-60): 200 életerő 0.20
Fekete Szivárvány – 8% (61-68): 250 életerő 0.25
Tűzvirág Kristály – 7% (69-75): 300 életerő 0.30
Víz Tükörkő – 6% (76-81): 350 életerő 0.35
Csontfehér Kő – 8% (82-89): 400 életerő 0.40
Zöld Fény Kristály – 6% (90-95): 500 életerő 0.50
Fekete Holdkő – 4% (96-100): 600 életerő 0.60


using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int randomNumber = rand.Next(0, 101); // 0 és 100 között
        Console.WriteLine("A generált véletlenszám: " + randomNumber);
    }
}



 int[] jatekosStatja = { 300, 50 };
 double[] jatekosKardSebzes = { 0, 0 };




using System;

class Program
{
    static void Main()
    {
        string[] boltKardAsvany = { "Tűzfény Kristály", "Kék Árnyék Kő", "Mosszöld Obszidián", "Ezüst Holdkő", "Lángoló Zafír", "Pókfonál Kő", "Éjfél Tűz Kő", "Fagyott Lúdtoll Kristály", "Vihar Lángja", "Ősi Csillagfény" };
        double[] jatekosKardSebzes = new double[2]; // [0] sebzés, [1] szorzó
        Random rand = new Random();
        int generaltszam = rand.Next(0, 101); // 0-100 közötti véletlenszám
        
        Start:
        Console.Clear(); // Törli a konzolt minden alkalommal, amikor újraindítjuk
        Console.WriteLine("Generálunk egy ásványt...");

        if (generaltszam <= 22)
        {
            // 1. Tűzfény Kristály – 20% (0-20): 5 sebzés
            Console.WriteLine("Nyitottál egy " + boltKardAsvany[0] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosKardSebzes[1] = 0.05;
                jatekosKardSebzes[0] = 5;
                Console.WriteLine("Tartod a " + boltKardAsvany[0] + " ásványt. Sebzés: " + jatekosKardSebzes[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else if (generaltszam <= 37)
        {
            // 2. Kék Árnyék Kő – 15% (21-35): 10 sebzés
            Console.WriteLine("Nyitottál egy " + boltKardAsvany[1] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosKardSebzes[1] = 0.10;
                jatekosKardSebzes[0] = 10;
                Console.WriteLine("Tartod a " + boltKardAsvany[1] + " ásványt. Sebzés: " + jatekosKardSebzes[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else if (generaltszam <= 50)
        {
            // 3. Mosszöld Obszidián – 13% (36-48): 15 sebzés
            Console.WriteLine("Nyitottál egy " + boltKardAsvany[2] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosKardSebzes[1] = 0.15;
                jatekosKardSebzes[0] = 15;
                Console.WriteLine("Tartod a " + boltKardAsvany[2] + " ásványt. Sebzés: " + jatekosKardSebzes[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else if (generaltszam <= 62)
        {
            // 4. Ezüst Holdkő – 12% (49-60): 20 sebzés
            Console.WriteLine("Nyitottál egy " + boltKardAsvany[3] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosKardSebzes[1] = 0.20;
                jatekosKardSebzes[0] = 20;
                Console.WriteLine("Tartod a " + boltKardAsvany[3] + " ásványt. Sebzés: " + jatekosKardSebzes[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else if (generaltszam <= 70)
        {
            // 5. Lángoló Zafír – 8% (61-68): 30 sebzés
            Console.WriteLine("Nyitottál egy " + boltKardAsvany[4] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosKardSebzes[1] = 0.30;
                jatekosKardSebzes[0] = 30;
                Console.WriteLine("Tartod a " + boltKardAsvany[4] + " ásványt. Sebzés: " + jatekosKardSebzes[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else if (generaltszam <= 77)
        {
            // 6. Pókfonál Kő – 7% (69-75): 35 sebzés
            Console.WriteLine("Nyitottál egy " + boltKardAsvany[5] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosKardSebzes[1] = 0.35;
                jatekosKardSebzes[0] = 35;
                Console.WriteLine("Tartod a " + boltKardAsvany[5] + " ásványt. Sebzés: " + jatekosKardSebzes[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else if (generaltszam <= 83)
        {
            // 7. Éjfél Tűz Kő – 6% (76-81): 40 sebzés
            Console.WriteLine("Nyitottál egy " + boltKardAsvany[6] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosKardSebzes[1] = 0.40;
                jatekosKardSebzes[0] = 40;
                Console.WriteLine("Tartod a " + boltKardAsvany[6] + " ásványt. Sebzés: " + jatekosKardSebzes[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else if (generaltszam <= 91)
        {
            // 8. Fagyott Lúdtoll Kristály – 8% (82-89): 50 sebzés
            Console.WriteLine("Nyitottál egy " + boltKardAsvany[7] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosKardSebzes[1] = 0.50;
                jatekosKardSebzes[0] = 50;
                Console.WriteLine("Tartod a " + boltKardAsvany[7] + " ásványt. Sebzés: " + jatekosKardSebzes[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else if (generaltszam <= 97)
        {
            // 9. Vihar Lángja – 6% (90-95): 60 sebzés
            Console.WriteLine("Nyitottál egy " + boltKardAsvany[8] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosKardSebzes[1] = 0.60;
                jatekosKardSebzes[0] = 60;
                Console.WriteLine("Tartod a " + boltKardAsvany[8] + " ásványt. Sebzés: " + jatekosKardSebzes[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else
        {
            // 10. Ősi Csillagfény – 4% (96-100): 80 sebzés
            Console.WriteLine("Nyitottál egy " + boltKardAsvany[9] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosKardSebzes[1] = 0.80;
                jatekosKardSebzes[0] = 80;
                Console.WriteLine("Tartod a " + boltKardAsvany[9] + " ásványt. Sebzés: " + jatekosKardSebzes[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
    }
}

Páncél if bolt nyitás valami

using System;

class Program
{
    static void Main()
    {
        string[] boltPancelAsvany = { "Fénytörő Obszidián", "Vérvörös Jaspis", "Holdfény Amatészter", "Ékkő Tükrözült", "Fekete Szivárvány", "Tűzvirág Kristály", "Víz Tükörkő", "Csontfehér Kő", "Zöld Fény Kristály", "Fekete Holdkő" };
        double[] jatekosPancel = new double[2]; // [0] életerő, [1] szorzó
        Random rand = new Random();
        int generaltszam = rand.Next(0, 101); // 0-100 közötti véletlenszám
        
        Start:
        Console.Clear(); // Törli a konzolt minden alkalommal, amikor újraindítjuk
        Console.WriteLine("Generálunk egy páncél ásványt...");

        if (generaltszam <= 22)
        {
            // 1. Fénytörő Obszidián – 20% (0-20): 50 életerő 0.05
            Console.WriteLine("Nyitottál egy " + boltPancelAsvany[0] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosPancel[1] = 0.05;
                jatekosPancel[0] = 50;
                Console.WriteLine("Tartod a " + boltPancelAsvany[0] + " ásványt. Életerő: " + jatekosPancel[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else if (generaltszam <= 37)
        {
            // 2. Vérvörös Jaspis – 15% (21-35): 100 életerő 0.1
            Console.WriteLine("Nyitottál egy " + boltPancelAsvany[1] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosPancel[1] = 0.10;
                jatekosPancel[0] = 100;
                Console.WriteLine("Tartod a " + boltPancelAsvany[1] + " ásványt. Életerő: " + jatekosPancel[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else if (generaltszam <= 50)
        {
            // 3. Holdfény Amatészter – 13% (36-48): 150 életerő 0.15
            Console.WriteLine("Nyitottál egy " + boltPancelAsvany[2] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosPancel[1] = 0.15;
                jatekosPancel[0] = 150;
                Console.WriteLine("Tartod a " + boltPancelAsvany[2] + " ásványt. Életerő: " + jatekosPancel[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else if (generaltszam <= 62)
        {
            // 4. Ékkő Tükrözült – 12% (49-60): 200 életerő 0.20
            Console.WriteLine("Nyitottál egy " + boltPancelAsvany[3] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosPancel[1] = 0.20;
                jatekosPancel[0] = 200;
                Console.WriteLine("Tartod a " + boltPancelAsvany[3] + " ásványt. Életerő: " + jatekosPancel[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else if (generaltszam <= 70)
        {
            // 5. Fekete Szivárvány – 8% (61-68): 250 életerő 0.25
            Console.WriteLine("Nyitottál egy " + boltPancelAsvany[4] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosPancel[1] = 0.25;
                jatekosPancel[0] = 250;
                Console.WriteLine("Tartod a " + boltPancelAsvany[4] + " ásványt. Életerő: " + jatekosPancel[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else if (generaltszam <= 77)
        {
            // 6. Tűzvirág Kristály – 7% (69-75): 300 életerő 0.30
            Console.WriteLine("Nyitottál egy " + boltPancelAsvany[5] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosPancel[1] = 0.30;
                jatekosPancel[0] = 300;
                Console.WriteLine("Tartod a " + boltPancelAsvany[5] + " ásványt. Életerő: " + jatekosPancel[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else if (generaltszam <= 83)
        {
            // 7. Víz Tükörkő – 6% (76-81): 350 életerő 0.35
            Console.WriteLine("Nyitottál egy " + boltPancelAsvany[6] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosPancel[1] = 0.35;
                jatekosPancel[0] = 350;
                Console.WriteLine("Tartod a " + boltPancelAsvany[6] + " ásványt. Életerő: " + jatekosPancel[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else if (generaltszam <= 91)
        {
            // 8. Csontfehér Kő – 8% (82-89): 400 életerő 0.40
            Console.WriteLine("Nyitottál egy " + boltPancelAsvany[7] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosPancel[1] = 0.40;
                jatekosPancel[0] = 400;
                Console.WriteLine("Tartod a " + boltPancelAsvany[7] + " ásványt. Életerő: " + jatekosPancel[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else if (generaltszam <= 97)
        {
            // 9. Zöld Fény Kristály – 6% (90-95): 500 életerő 0.50
            Console.WriteLine("Nyitottál egy " + boltPancelAsvany[8] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosPancel[1] = 0.50;
                jatekosPancel[0] = 500;
                Console.WriteLine("Tartod a " + boltPancelAsvany[8] + " ásványt. Életerő: " + jatekosPancel[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
        else
        {
            // 10. Fekete Holdkő – 4% (96-100): 600 életerő 0.60
            Console.WriteLine("Nyitottál egy " + boltPancelAsvany[9] + " ásványt.");
            Console.WriteLine("Biztosan meg szeretnéd tartani?");
            Console.WriteLine("Igen vagy Nem?");
            string valasz = Console.ReadLine();
            
            if (valasz.ToLower() == "igen")
            {
                jatekosPancel[1] = 0.60;
                jatekosPancel[0] = 600;
                Console.WriteLine("Tartod a " + boltPancelAsvany[9] + " ásványt. Életerő: " + jatekosPancel[0]);
            }
            else
            {
                goto Start; // Vissza az első kódsorhoz, új ásványt generál
            }
        }
    }
}



