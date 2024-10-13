using System;
namespace OOP
{
    class Program
    {
        static void Main()
        {
            Cars uzAvtoSalon = new Cars();
            Console.WriteLine("Qaysi narxdagi avtomobil olmoqchisiz? (masalan 20 000 va 50 000) ");
            if(decimal.TryParse(Console.ReadLine(), out decimal firstInput) &&
               decimal.TryParse(Console.ReadLine(), out decimal secondInput))
               {
                if(firstInput > secondInput)
                {
                    decimal temp;
                    temp = firstInput;
                    firstInput = secondInput; // <= avval kichik qiymat keyin kattasi kiritilsa qiymatlarni almashtirish uchun
                    secondInput = temp;
                }
                uzAvtoSalon.selectWithPriceRange(firstInput, secondInput);
               }
               else
               {
                System.Console.WriteLine("Qiymat xato kiritildi qayta urunib ko'ring: ");
                Main();
               }
        }
    }
}