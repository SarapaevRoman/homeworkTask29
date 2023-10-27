// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
int i = 0;
while (i <= 7){
    array[i] = new Random().Next(1, 20);
    i++;
}
string resul = string.Join(" ", array.Select(x => x.ToString()));
Console.Write($"[{resul}]");