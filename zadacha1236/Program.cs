            //ЗАДАЧА №1236	Транспонирование - 4	
// Задана целочисленная матрица, состоящая из N строк и M столбцов.
// Требуется транспонировать ее относительно горизонтали.

// Входные данные:Первая строка входного файла INPUT.TXT
// содержит два натуральных числа N и M – количество строк и столбцов матрицы. 
// В каждой из последующих N строк записаны M целых чисел – элементы матрицы. 
// Все числа во входных данных не превышают 100 по абсолютной величине. 

// Выходные данные:В выходной файл OUTPUT.TXT выведите матрицу,
//полученную транспонированием исходной матрицы относительно горизонтали.

            int n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random((int)DateTime.Now.Ticks);
            int[,] matrix = new int[n, n];
            int[,] transpMatrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(0, 10);
                    transpMatrix[j, i] = matrix[i, j];
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(transpMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
 
  
