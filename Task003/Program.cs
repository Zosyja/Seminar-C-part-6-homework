// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int ReadInt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int[,] FillMass(int m, int n){
    Random random = new Random();
    int[,] array = new int[m, n];
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            array[i,j] = random.Next(0, 10);
    return array;
}
void PrintMass(int[,] matrix){
    for (int i=0; i<matrix.GetLength(0); i++){
        for (int j=0; j<matrix.GetLength(1); j++){
            Console.Write(String.Format("{0,3}", matrix[i, j]));
        }
        Console.WriteLine();
    }
}

int m = ReadInt("Введите количество строк массива (m): ");
int n = ReadInt("Введите количество столцов массива (n): ");
int[,] matrix = FillMass(m,n);
Console.WriteLine("Исходный массив: ");
PrintMass(matrix);
Console.WriteLine();

for (int i=0; i<matrix.GetLength(0); i++){
    for (int j=0; j<matrix.GetLength(1); j++){
        if (i%2==0 && j%2==0) matrix[i,j] = matrix[i,j] * matrix[i,j];
    }
}
PrintMass(matrix);