using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Заглавие на програмата
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=========================================");
            Console.WriteLine("   Добре дошли в Калкулатора на валути  ");
            Console.WriteLine("=========================================");
            Console.ResetColor();

            // Кратко описание
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[ Този калкулатор ви позволява да изчислявате валути от следните типове: USD, EUR, GBP, BGN ]\n");
            Console.ResetColor();

            // Въвеждане на валута от която искаме да ни го изчисли
            Console.Write("Въведете валутата, от която искате да конвертирате [ USD, EUR, GBP, BGN ]: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string fromCurrency = Console.ReadLine().ToUpper();
            Console.ResetColor();

            // Въвеждане на валутата в която искаме да ни го изчисли
            Console.Write("Въведете валутата, към която искате да конвертирате [ USD, EUR, GBP, BGN ]: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string toCurrency = Console.ReadLine().ToUpper();
            Console.ResetColor();

            // Въвеждане на сума
            Console.Write("Въведете сумата, която искате да конвертирате: ");
            Console.ForegroundColor = ConsoleColor.Red;
            double amount = double.Parse(Console.ReadLine());
            Console.ResetColor();

            // Фиксирани стоиности на валутите
            double usdToEur = 0.91;
            double usdToGbp = 0.77;
            double usdToBgn = 1.75;
            double eurToUsd = 1.95;
            double eurToGbp = 0.85;
            double eurToBgn = 1.95;
            double gbpToUsd = 1.30;
            double gbpToEur = 1.18;
            double gbpToBgn = 2.30;
            double bgnToUsd = 0.57;
            double bgnToEur = 0.51;
            double bgnToGbp = 0.43;

            // Променлива за крайната стойност
            double convertedAmount = 0;

            // Логика за калкулиране
            if (fromCurrency == "USD" && toCurrency == "EUR")
            {
                convertedAmount = amount * usdToEur;
            }
            else if (fromCurrency == "USD" && toCurrency == "GBP")
            {
                convertedAmount = amount * usdToGbp;
            }
            else if (fromCurrency == "USD" && toCurrency == "BGN")
            {
                convertedAmount = amount * usdToBgn;
            }
            else if (fromCurrency == "EUR" && toCurrency == "USD")
            {
                convertedAmount = amount * eurToUsd;
            }
            else if (fromCurrency == "EUR" && toCurrency == "GBP")
            {
                convertedAmount = amount * eurToGbp;
            }
            else if (fromCurrency == "EUR" && toCurrency == "BGN")
            {
                convertedAmount = amount * eurToBgn;
            }
            else if (fromCurrency == "GBP" && toCurrency == "USD")
            {
                convertedAmount = amount * gbpToUsd;
            }
            else if (fromCurrency == "GBP" && toCurrency == "EUR")
            {
                convertedAmount = amount * gbpToEur;
            }
            else if (fromCurrency == "GBP" && toCurrency == "BGN")
            {
                convertedAmount = amount * gbpToBgn;
            }
            else if (fromCurrency == "BGN" && toCurrency == "USD")
            {
                convertedAmount = amount * bgnToUsd;
            }
            else if (fromCurrency == "BGN" && toCurrency == "EUR")
            {
                convertedAmount = amount * bgnToEur;
            }
            else if (fromCurrency == "BGN" && toCurrency == "GBP")
            {
                convertedAmount = amount * bgnToGbp;
            }
            else
            {
                // Съобщение за грешка
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[Грешка: Невалидна валутна.]");
                Console.ResetColor();
                return;
            }

            // Показване на крайния резултата
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n========================================");
            Console.WriteLine($"    {amount} {fromCurrency} = {convertedAmount} {toCurrency}");
            Console.WriteLine("========================================");
            Console.ResetColor();
        }
    }
}