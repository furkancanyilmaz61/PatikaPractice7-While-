using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdır
        int count = 0;
        while (count < 10)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            count++;
        }

        Console.WriteLine(); // Boşluk bırakmak için

        // 2. 1 ile 20 arasındaki sayıları yazdır
        int number = 1;
        while (number <= 20)
        {
            Console.WriteLine(number);
            number++;
        }

        Console.WriteLine(); // Boşluk bırakmak için

        // 3. 1 ile 20 arasındaki çift sayıları yazdır
        int evenNumber = 1;
        while (evenNumber <= 20)
        {
            if (evenNumber % 2 == 0)
            {
                Console.WriteLine(evenNumber);
            }
            evenNumber++;
        }

        Console.WriteLine(); // Boşluk bırakmak için

        // 4. 50 ile 150 arasındaki sayıların toplamını yazdır
        int sum = 0;
        int currentNumber = 50;
        while (currentNumber <= 150)
        {
            sum += currentNumber;
            currentNumber++;
        }
        Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + sum);

        Console.WriteLine(); // Boşluk bırakmak için

        // 5. 1 ile 120 arasındaki tek ve çift sayıların toplamlarını yazdır
        int oddSum = 0;
        int evenSum = 0;
        int num = 1;
        while (num <= 120)
        {
            if (num % 2 == 0)
            {
                evenSum += num;
            }
            else
            {
                oddSum += num;
            }
            num++;
        }
        Console.WriteLine("Tek sayıların toplamı: " + oddSum);
        Console.WriteLine("Çift sayıların toplamı: " + evenSum);
    }
}
