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

