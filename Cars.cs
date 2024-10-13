/*
2.Vazifa
Bir necha xil yengil avtomobillar nomi, markalari va ularning narxlari berilgan. 
Foydalanuvchi 2 ta narx kiritadi. Keyin ulardan narxi shu oraliqdagi narxli 
avtomobil haqidagi ma’lumotlarni chop etuvchi dastur tuzing.
Ma’lumotlar bazasi sifatida list yoki arraydan foydalanishingiz mumkin.
*/
namespace OOP
{   
    class Cars
    {
       private string[] carNames = { "Toyota", "Honda", "Ford", "BMW", "Tesla", "Chevrolet", "Nissan", "Audi", "Mercedes", "Volvo" };
        private string[] carModels = { "Corolla", "Civic", "Mustang", "X5", "Model S", "Camaro", "Altima", "A4", "C-Class", "XC90" };
       private decimal[] carPrices = { 20000.00M, 22000.00M, 26000.00M, 50000.00M, 80000.00M, 35000.00M, 24000.00M, 45000.00M, 55000.00M, 60000.00M };
        public void selectWithPriceRange(decimal firstInput, decimal secondInput)
        {
             {
             System.Console.WriteLine($"{firstInput}$ va {secondInput}$ orasida quyidagi mashinalar topildi: ");
                int j=0;
                for(int i = 0; i < carNames.Length; i++)
                {
                    if(carPrices[i] >= firstInput && carPrices[i] <= secondInput)
                    {
                        j++;
                        Console.WriteLine($"{j}) {carNames[i]} - {carModels[i]} - {carPrices[i]}");
                    }
                }
             }           
        }
    }
}