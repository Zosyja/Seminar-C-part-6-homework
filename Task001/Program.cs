// Показать двумерный массив размером m×n заполненный вещественными числами

int ReadInt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
double[,] FillMass(int m, int n){
    Random random = new Random();
    double[,] array = new double[m, n];
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            array[i,j] = random.Next(-10, 11);
    return array;
}
void PrintMass(double[,] matrix){
    for (int i=0; i<matrix.GetLength(0); i++){
        for (int j=0; j<matrix.GetLength(1); j++){
            Console.Write(String.Format("{0,3}", matrix[i, j]));
        }
        Console.WriteLine();
    }
}

int m = ReadInt("Введите количество строк массива: ");
int n = ReadInt("Введите количество столцов массива: ");
double[,] matrix = FillMass(m,n);
Console.WriteLine("Массив вещественных чисел: ");
PrintMass(matrix);