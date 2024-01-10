using System;
using System.Diagnostics;
using System.Runtime;
using System.Security.AccessControl;

namespace SwordDamageConsoleProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else for quit: ");
                string value =  Console.ReadLine();
                if (int.TryParse(value, out int key))
                {
                    Random rnd = new Random();
                    SwordDamage sword = new SwordDamage();
                    switch (key)
                    {
                        case 0:
                            sword.Roll = rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7);
                            sword.SetMagic(false);
                            sword.SetFlaming(false);
                            break;
                        case 1:
                            sword.Roll = rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7);
                            sword.SetMagic(true);
                            sword.SetFlaming(false);
                            break;
                        case 2:
                            sword.Roll = rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7);
                            sword.SetMagic(false);
                            sword.SetFlaming(true);
                            break;
                        case 3:
                            sword.Roll = rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7);
                            sword.SetMagic(true); 
                            sword.SetFlaming(true);
                            break;
                        default: return;
                    }
                    Console.WriteLine("Rolled {0} for {1} HP\n", sword.Roll, sword.Damage);
                }
                else { return; }
            }

        }
    }
}