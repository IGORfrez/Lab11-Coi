// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1033;
// bool found = false;
// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }
// Console.WriteLine(found ? "Cтудент найден" : "Студент не найден");

// int variant = 11;
// bool isPrime;
// if (variant < 2)
// {
//     isPrime = false;
// }
// else if (variant == 2)
// {
//     isPrime = true;
// }
// else
// {
//     isPrime = true;
//     for (int divisor = 2; divisor < variant; divisor++)
//     {
//         if (variant % divisor == 0)
//         {
//             isPrime = false;
//             break;
//         }
//     }
// }
// Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");

// int[] pointsPerLab = { 8, -1, 10, 9, -1 };
// int sum = 0;
// int countSubmitted = 0;

// foreach (int points in pointsPerLab)
// {
//     if (points < 0)
//     {
//         continue;
//     }
//     sum += points;
//     countSubmitted++;
// }

// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// Console.WriteLine($"Количество сданных работ: {countSubmitted}");

// int[] groupIds = { 101, 105, 107, 104, 110 };
// bool hasDuplicates = false;
// for (int i = 0; i < groupIds.Length; i++)
// {
//     for (int j = i + 1; j < groupIds.Length; j++)
//     {
//         if (groupIds[i] == groupIds[j])
//         {
//             hasDuplicates = true;
//             Console.WriteLine($"Найден дубликат номер зачётки {groupIds[i]} встречается дважды");
//             break;
//         }
//     }
//     if (hasDuplicates) break;
// }
// if (!hasDuplicates)
// {
//     Console.WriteLine("Все номера уникальны");
// }

// int days = 5;
// int lessonsPerDay = 6;
// bool found = false;
// for (int day = 1; day <= days && !found; day++) {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++) {
//         bool isFree = (day == 3 && lesson == 4);
//         if (isFree) {
//             Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break;
//         }
//     }
// }
// if (!found) {
//     Console.WriteLine("Свободных слотов нет");
// }

// int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8};
// int sum = 0;
// foreach (int num in numbers)
// {
//     if (num % 2 != 0)
//     {
//         continue;
//     }
//     sum += num;
// }
// Console.WriteLine($"Сумма чётных чисел: {sum}");

// int[] num = { 1, 2, 3, 2, 5 };
// bool hasDuplicates = false;
// int duplicateValue = 0;
// for (int i = 0; i < num.Length; i++)
// {
//     for (int j = i + 1; j < num.Length; j++)
//     {
//         if (num[i] == num[j])
//         {
//             hasDuplicates = true;
//             duplicateValue = num[i];
//             break;
//         }
//     }
//     if (hasDuplicates) break;
// }

// if (hasDuplicates)
// {
//     Console.WriteLine($"Найден дубликат числа {duplicateValue}");
// }
// else
// {
//     Console.WriteLine("Дубликатов нет");
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// int[] array = { 1, 3, 5, 7, 9 };
// bool isSorted = true;
// for (int i = 0; i < array.Length - 1; i++)
// {
//     if (array[i] > array[i + 1])
//     {
//         isSorted = false;
//         break;
//     }
// }
// if (isSorted)
// {
//     Console.WriteLine("Массив отсортирован по возрастанию.");
// }
// else
// {
//     Console.WriteLine("Массив не отсортирован.");
// }

// int[] array = { 5, 3, 0, 8, -2, 4 };
// int count = 0;
// foreach (int number in array)
// {
//     if (number < 0)
//     {
//         break;
//     }
//     count++;
// }
// Console.WriteLine($"Количество положительных чисел (и нуля) в начале массива до первого отрицательного: {count}");