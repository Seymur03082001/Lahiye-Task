using Layihe_Task.Models;

namespace Layihe_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Weapon weapon = new Weapon(30,70,10,true);
            
            do
            {
                Console.WriteLine("0.Informasiya almag ucun \n1.Shoot metodu ucun \n2.Fire metodu ucun \n3.GetRemainBulletCount metodu ucun \n4.Reload metodu ucun \n5.ChangeFireMode \n6.Proqramdan dayandirmag ucun qosayoldur");
                Console.WriteLine("Seciminizi edin: ");
            byte input = Convert.ToByte(Console.ReadLine());

                switch (input)
                {
                    case 0:
                        Console.WriteLine("Informasiya almag ucun");
                        break;
                    case 1: 
                        Console.WriteLine("Shoot metodu ucun");
                        weapon.Shoot();
                        break;
                        case 2:
                        Console.WriteLine("Fire metodu ucun");
                        weapon.Fire();
                        break;
                        case 3:
                        Console.WriteLine("GetRemainBulletCount");
                        weapon.GetRemainBulletCount();
                        break;
                        case 4:
                        Console.WriteLine("Reload metodu ucun");
                        weapon.Reload();
                        break;
                        case 5:
                        Console.WriteLine("ChangeFireMode");
                        weapon.ChangeFireMode();
                        break;
                }
                
            } while (true);
        }
    }
}