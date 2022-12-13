using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layihe_Task.Models
{
    internal class Weapon
    {
        public int _capacity;
        public int _count = 70;
        public double _dischargeSecond;
        public bool _shootMode;

        
        public int Capacity
        {
            get => _capacity;
            set 
            { 
                if(_capacity > 0) 
                { 
                    _capacity = value; 
                }
            }
        }
        
        public int Count
        {
            get => _count;
            set 
            { 
                if(_count > 0)
                {
                    _count = value;
                }
            }
        }

        
        public double DischargeSecond
        {
            get => _dischargeSecond;
            set 
            { 
                _dischargeSecond = value; 
            }
        }

        
        public bool ShootMode
        {
            get => _shootMode;
            set 
            { 
                _shootMode = value; 
            }
        }
        public Weapon(int capacity, int count, double dischargeSecond, bool shootMode)
        {
            Capacity = capacity;
            Count = count;
            DischargeSecond = dischargeSecond;
            ShootMode = shootMode;
        }

        public void Shoot()
        {
            
                if(Count > 0)
                {
                    _count --;
                    Console.WriteLine("say: "+ _count);
                }
                else
                {
                    Console.WriteLine("Silahda hewne yoxdu");
                }
        
            
        }
        public void Fire()
        {
            Count = 0;
            var second =(Capacity / DischargeSecond) * Count;
            Console.WriteLine("Saniye bitdiyi qeyd olunur");
        }
        public void GetRemainBulletCount()
        {
            Console.WriteLine(Capacity - Count);
        }
        public void Reload()
        {
            Count = Capacity;
            Console.WriteLine("Yenilendi");
            string cavab = Console.ReadLine();
            if (cavab.ToLower().Trim() == null)
            {
                Console.WriteLine("");
            }
            else if(cavab.ToLower().Trim() != "0")
            {
                Console.WriteLine("");
            }
        }
        public void ChangeFireMode()
        {
            if(ShootMode == true)
            {
                if(Count >0)
                {
                    Fire();
                    Console.WriteLine("Mode istifade eliyir");
                }
                else
                {
                    Console.WriteLine("Silahda hewne yoxdu");
                }
            }
        }
    }
}
