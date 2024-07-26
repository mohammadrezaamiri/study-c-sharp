// functions :

// یک بلوک از کد که نام دارد و برای انجام یک کار مشخص نوشته شده است و تا زمانی که او را فراخوانی نکنیم اجرا نمی شود

// استفاده مجدد از یک منطق در جاهای مختلف
// خوانا تر شدن و تمیزتر شدن کد ها


int[] numbers = { 1, 2, 3, 4, 5 }; // average of numbers [1,2,3,4,5] is : 3

PrintAverageOfNumbers(numbers);

int[] numbers2 = { 21, 23, 35, 4645, 523, 67 };

PrintAverageOfNumbers(numbers2);

PrintAverageOfNumbers(15, 48, 59, 36, 53, 78);


double Average(int[] numbers)
{
    int sum = 0;

    foreach (int num in numbers)
    {
        sum += num;
    }

    return (double)sum / numbers.Length;
}

void PrintAverageOfNumbers(params int[] numbers)
{
    Console.WriteLine($"average of numbers [{string.Join(',',numbers)}] is : " + Average(numbers));
}


