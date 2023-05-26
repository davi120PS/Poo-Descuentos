using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descuentos.Entities
{
    public class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public void Requests()
        {
            Console.Write("Ingresa tu nombre: ");
            Name = Console.ReadLine();
            Console.Write("Ingresa tu telefono: ");
            Phone = Console.ReadLine();
            Console.Write("Ingresa tu email: ");
            Email = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine("Numbre: " + Name);
            Console.WriteLine("Telefono: " + Phone);
            Console.WriteLine("Correo: " + Email);
        }
    }
}
