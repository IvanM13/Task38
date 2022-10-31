/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

double[] arrayRandom = new double[5];
for (int i = 0; i < arrayRandom.Length; i++)
{
    arrayRandom[i] = new Random().Next(1, 100);
    Console.Write(arrayRandom[i] + " ");
}

double maxNumber = arrayRandom[0];
double minNumber = arrayRandom[0];

for (int i = 1; i < arrayRandom.Length; i++)
{
    if (maxNumber < arrayRandom[i])
    {
        maxNumber = arrayRandom[i];
    }
    if (minNumber > arrayRandom[i])
    {
        minNumber = arrayRandom[i];
    }
}

double decision = maxNumber - minNumber;

Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");
