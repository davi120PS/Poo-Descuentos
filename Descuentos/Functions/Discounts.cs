using Descuentos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descuentos.Functions
{
    public class Discounts:Article
    {
        public void Discount()
        {
            string article;
            int quantity, option;
            double price,subtotal=0, total=0, discount=0, month=0;
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                //comentar

                Console.WriteLine(" COMPRA DE ARTICULOS ");
                Console.WriteLine("No. articulo: " + (i+1));
                Console.WriteLine("Nombre del articulo: ");
                article = Console.ReadLine();
                Console.WriteLine("Precio del articulo: ");
                price = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad del articulo: ");
                quantity = int.Parse(Console.ReadLine());
                subtotal = price*quantity;
                total = total + subtotal;
                Console.Clear();
                Console.WriteLine(total);
            }
            if (total>=5000 && total<8000)
            {
                Console.WriteLine("Tienes un descuento del 10% ");
                discount = total * 0.9;
                total = total - discount;
                Console.WriteLine($"Pagaras {total} por mes");
            }
            if (total >= 8000 && total < 10000)
            {
                Console.WriteLine("Tienes 3 meses sin intereses");
                month = total / 3;
                //discount = total * 0.9;
                //total = total - discount;
                Console.WriteLine($"Pagaras {month} por mes");
            }
            if (total >= 10000)
            {
                Console.WriteLine("Tienes 6 ó 12 meses sin intereses");
                Console.WriteLine("¿Cuantos meses quieres?");
                option = int.Parse(Console.ReadLine());

                if(option == 6)
                {
                    month = total / 6;
                    Console.WriteLine("Elegiste 6 meses sin intereses");
                    //discount = total * 0.9;
                    //total = total - discount;
                    Console.WriteLine($"Pagaras {month} por mes");
                }
                if (option == 12)
                {
                    month = total / 12;
                    Console.WriteLine("Elegiste 12 meses sin intereses");
                    //discount = total * 0.9;
                    //total = total - discount;
                    Console.WriteLine($"Pagaras {month} por mes");
                }
            }
        }
    }
}
