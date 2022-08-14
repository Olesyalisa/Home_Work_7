/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
double[,] MassiveMN(int oneM, int twoN) 
{ 
    double[,] arr = new double[oneM, twoN]; 
    Random rnd = new Random(); 
 
    for (int i = 0; i < arr.GetLength(0); i++) 
    { 
        for (int s = 0; s < arr.GetLength(1); s++) 
        { 
            arr[i, s] = Math.Round(((rnd.NextDouble() -0.5)* 100),1); 
        } 
 
    } 
    return arr; 
} 
void TwoMass(double[,] arr) 
{ 
    for (int i = 0; i < arr.GetLength(0); i++) 
    { 
        for (int s = 0; s < arr.GetLength(1); s++) 
        { 
            Console.Write(" " + arr[i, s]); 
        } 
        Console.WriteLine(); 
    } 
} 
 
Console.WriteLine("Строки(oneM): "); 
int oneM = int.Parse(Console.ReadLine()); 
 
Console.WriteLine("Столбцы(twoN): "); 
int twoN = int.Parse(Console.ReadLine()); 
 
double[,] TwodimensionalMassive = MassiveMN(oneM, twoN); 
TwoMass(TwodimensionalMassive);