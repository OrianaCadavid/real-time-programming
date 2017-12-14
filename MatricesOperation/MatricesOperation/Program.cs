using System;

namespace MatricesOperation
{
	class MainClass
	{
		private static int[,] MatrixSum(int[,] matrix1, int[,] matrix2)
		{
			if (matrix1.GetLength (0) != matrix2.GetLength (0) || matrix1.GetLength (1) != matrix2.GetLength (1)) 
			{
				throw new System.ArgumentException("Number of rows and columns should equal for the both matrices");
			}
			int[,] matrix3 = new int[matrix1.GetLength(0) , matrix1.GetLength(1)];
			for (int i = 0; i < matrix1.GetLength (0); i++) 
			{
				for (int j = 0; j < matrix1.GetLength (1); j++) 
				{
					matrix3 [i, j] = matrix1 [i, j] + matrix2 [i, j];
				}
			}
			return matrix3;
		}
	
	
		private static int[,] MatrixSubt(int[,] matrix1, int[,] matrix2) 
		{
			if (matrix1.GetLength (0) != matrix2.GetLength (0) || matrix1.GetLength (1) != matrix2.GetLength (1)) 
			{
				throw new System.ArgumentException("Number of rows and columns should equal for the both matrices");
			}
			int[,] matrix3 = new int[matrix1.GetLength(0) , matrix1.GetLength(1)];
			for (int i = 0; i < matrix1.GetLength (0); i++) 
			{
				for (int j = 0; j < matrix1.GetLength (1); j++) 
				{
					matrix3 [i, j] = matrix1 [i, j] - matrix2 [i, j];
				}
			}
			return matrix3;
		}
			
		private static int[,] MatrixMult(int[,] matrix1, int[,] matrix2) 
		{
			if (matrix1.GetLength (1) != matrix2.GetLength (0)) 
			{
				throw new System.ArgumentException("Number of rows of matrix1 should equal number of rows of matrix2");
			}
			int[,] matrix3 = new int[matrix1.GetLength(0) , matrix2.GetLength(1)];
			for (int i = 0; i < matrix1.GetLength(0); i++) 
			{
				for (int j = 0; j < matrix2.GetLength (1); j++)
				{
					int sum = 0;
					for (int k = 0; k < matrix1.GetLength (1); k++) 
					{
						sum += matrix1 [i, k] * matrix2 [k, j];
					}
					matrix3 [i, j] = sum;
				}
			}
			return matrix3;
		}

		private static int[,] ScalarMatrixMult(int scalar, int[,] matrix) 
		{
			int[,] matrixS = new int[matrix.GetLength(0) , matrix.GetLength(1)];

			for (int i = 0; i < matrix.GetLength (0); i++) 
			{
				for (int j = 0; j < matrix.GetLength (1); j++) 
				{
					matrixS [i, j] = matrix [i, j] * scalar;
				}
			}
			return matrixS;
		}
			
		public static void PrintMatrix(int[,] matrix) {
			for (int i = 0; i < matrix.GetLength(0); i++) 
			{
				for (int j = 0; j < matrix.GetLength(0); j++) 
				{
					Console.Write (" " + matrix [i, j]);
				}
				Console.WriteLine ();
			}
		}

		public static void Main (string[] args)
		{
			int row1 = 0;
			int columns1 = 0;
			int row2 = 0;
			int columns2 = 0;
		
			Console.WriteLine("Enter the row of the matrix 1");
			row1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the columns of the matrix 1");
			columns1 = Convert.ToInt32(Console.ReadLine());

			int[,] matrix1 = new int[row1 , columns1];

			Console.WriteLine("Enter the elements of the matrix 1: Row and columns");
			for (int i = 0; i < row1; i++)
			{
				for (int j = 0; j < columns1; j++)
				{
					matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
				}
			}

			Console.WriteLine(" ");

			Console.WriteLine("Enter the row of the matrix 2");
			row2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the columns of the matrix 2");
			columns2 = Convert.ToInt32(Console.ReadLine());

			int[,] matrix2 = new int[row2, columns2];

			Console.WriteLine("Enter the elements of the matrix 2: Row and columns");
			for (int i = 0; i < row2; i++)
			{
				for (int j = 0; j < columns2; j++)
				{
					matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
				}
			}

			Console.WriteLine("Menu");
			Console.WriteLine("1.Sum of matrices");
			Console.WriteLine("2.Subtraction of matrices");
			Console.WriteLine("3.Multiplication of matrices");
			Console.WriteLine("4.Multiplication by a scalar");
			Console.WriteLine("5.Exit");
			Console.Write("> ");

			int opc;
			opc = Convert.ToInt32((Console.ReadLine()));

			switch (opc)
			{ 
			case 1:
				try 
				{
					Console.WriteLine ("The sum of the matrices is equal to: ");
					int[,] sumM = MatrixSum(matrix1, matrix2);
					PrintMatrix (sumM);
				} 
				catch (System.ArgumentException e) 
				{
					Console.WriteLine (e.Message);
				}
				break;
			
			case 2:
				try 
				{
					Console.WriteLine ("The subtraction of the matrices is equal to:  ");
					int[,] subtM = MatrixSubt(matrix1, matrix2);
					PrintMatrix (subtM);
				} 
				catch (System.ArgumentException e) 
				{
					Console.WriteLine (e.Message);
				}
				break;

			case 3:
				try 
				{
					Console.WriteLine ("The multiplication of the matrices is equal to: ");
					int[,] mult = MatrixMult(matrix1, matrix2);
					PrintMatrix(mult);
				} 
				catch (System.ArgumentException e) 
				{
					Console.WriteLine(e.Message);
				}
				break;

			case 4:
				int scalar = 0;

				Console.WriteLine("Enter the scalar:");
				scalar = Convert.ToInt32 (Console.ReadLine ());

				Console.WriteLine (" The multiplication of the matrices by a scalar is equal to: ");
				int[,] matrixS1 = ScalarMatrixMult(scalar, matrix1);
				int[,] matrixS2 = ScalarMatrixMult(scalar, matrix2);

				PrintMatrix(matrixS1);

				Console.WriteLine(" ");

				PrintMatrix(matrixS2);
				break;

			}
		}
	}
}

