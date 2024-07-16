using System.Xml;
using Task16._07._2024;





Weapon myWeapon = new Weapon(BulletType.Pistol, 30);
Weapon myWeapon1 = new Weapon(BulletType.Rifle, 25);
Weapon myWeapon2 = new Weapon(BulletType.Shotgun, 25);


while (true)
{
    Console.WriteLine("Choose option:");
    Console.WriteLine("1. Fill weapon");
    Console.WriteLine("2. Fire weapon");

    Console.WriteLine("3. Exit");

    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("Which bullet do you want to load?");
            Console.WriteLine("Shotgun bullet");
            Console.WriteLine("Pistol bullet");
            Console.WriteLine("Rifle bullet");
           
            string output = Console.ReadLine();
            switch (output)
            {
                case "1":
                    myWeapon2.Fill();
                    Console.WriteLine("Shotgun full");
                    break;
                case "2":
                    myWeapon.Fill();
                    Console.WriteLine("Pistol full");
                    break;
                case "3":
                    myWeapon1.Fill();
                    Console.WriteLine("Rifle full");
                    break;
                
                default:
                    {
                        Console.WriteLine("Please correct variant");
                        continue;

                    }
            }
            break;

        case "2":
            Console.WriteLine("Select weapon");
            Console.WriteLine("Shotgun");
            Console.WriteLine("Pistol");
            Console.WriteLine("Rifle");
            
            string output2 = Console.ReadLine();
            switch (output2)
            {
                case "1":


                restart2:
                    string b = Console.ReadLine();
                    switch (b)
                    {
                        case "0":
                            break;
                        default:
                            myWeapon2.Fire();
                            goto restart2;


                    }

                    break;
                case "2":
                restart:
                    string a = Console.ReadLine();
                    switch (a)
                    {
                        case "0":
                            break;
                        default:
                            myWeapon.Fire();
                            goto restart;


                    }

                    break;
                case "3":
                restart3:
                    string c = Console.ReadLine();
                    switch (c)
                    {
                        case "0":
                            break;
                        default:
                            myWeapon1.Fire();
                            goto restart3;


                    }
                    break;
              
                default:
                    {
                        Console.WriteLine("Please correct variant");
                        continue;

                    }
            }
            break;


        case "3":
            return;

        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

