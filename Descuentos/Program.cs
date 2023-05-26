using System;
using Descuentos.Entities;
using Descuentos.Functions;

namespace Descuentos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Requests();
            person.Print();
            Discounts discounts = new Discounts();
            discounts.Discount();
            person.Print();
        }
    }
}
