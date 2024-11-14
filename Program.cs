

// Rastgele 10 adet sayı oluşturma

Random random = new Random();
List<int> numbers = new List<int>();

for (int i = 0; i < 10; i++)
{
    numbers.Add(random.Next(-50,50));
}

// Listeyi yazdırma
Console.WriteLine("Rastgele Sayılar: " + string.Join(", ", numbers));

// 1. Çift olan sayılar

var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
Console.WriteLine("Çift Sayılar: " + string.Join(", ", evenNumbers));

// 2. Tek olan sayılar

var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
Console.WriteLine("Tek Sayılar: " + string.Join(", ", oddNumbers));

// 3. Negatif Sayılar

var negativeNumbers = numbers.Where(n => n < 0).ToList();
Console.WriteLine("Negatif Sayılar: " + string.Join(", ", negativeNumbers));

// 4. Posizitif Sayılar

var positiveNumbers = numbers.Where(n => n > 0).ToList();
Console.WriteLine("Posizitif Sayılar: " + string.Join(", ", positiveNumbers));

// 5. 15'ten büyük ve 22'den küçük sayılar

var between15And22 = numbers.Where(n => n > 15 && n < 22).ToList();
Console.WriteLine("15'ten büyük ve 22'den küçük sayılar: " + string.Join(", ", between15And22));

// 6. Listedeki sayılar karesi

var squardNumbers = numbers.Select(n => n * n).ToList();
Console.WriteLine("Sayıların karesi: " + string.Join(", ", squardNumbers));
