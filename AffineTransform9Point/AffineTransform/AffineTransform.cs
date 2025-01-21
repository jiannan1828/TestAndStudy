using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffineTransform
{
    internal class AffineTransform
    {
        // 真實點 (9點)
        public static double[,] realPoints = {
            { -0.0039,  1.0043 }, { 9.9998, -1.0007 }, { 19.9982, 1.0028 },
            {  0.0042,  9.0032 }, { 10.0046, 10.9988 }, { 19.9960, 9.9995 },
            { -0.0048, 19.9963 }, { 9.9977, 21.0028 }, { 19.9995, 20.5015 }
        };

        // 理想點 (9點)
        public static double[,] idealPoints = {
            {  0,  0 }, { 10,  0 }, { 20,  0 },
            {  0, 10 }, { 10, 10 }, { 20, 10 },
            {  0, 20 }, { 10, 20 }, { 20, 20 }
        };

        public static double[] TestPoint = new double[2];

        public static double[,] A = new double[18, 6];

        public static double[] b = new double[18];

        public static double[,] Transpose(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[,] result = new double[cols, rows];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[j, i] = matrix[i, j];
            return result;
        }

        public static double[,] Multiply(double[,] A, double[,] B)
        {
            int rowsA = A.GetLength(0);
            int colsA = A.GetLength(1);
            int colsB = B.GetLength(1);

            double[,] result = new double[rowsA, colsB];
            for (int i = 0; i < rowsA; i++)
                for (int j = 0; j < colsB; j++)
                    for (int k = 0; k < colsA; k++)
                        result[i, j] += A[i, k] * B[k, j];
            return result;
        }

        public static double[] Multiply(double[,] A, double[] b)
        {
            int rowsA = A.GetLength(0);
            int colsA = A.GetLength(1);

            double[] result = new double[rowsA];
            for (int i = 0; i < rowsA; i++)
                for (int j = 0; j < colsA; j++)
                    result[i] += A[i, j] * b[j];
            return result;
        }

        public static double[] SolveLinearSystem(double[,] A, double[] b)
        {
            int n = A.GetLength(0);
            double[] x = new double[n];
            double[,] augmentedMatrix = new double[n, n + 1];

            // 擴展矩陣
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    augmentedMatrix[i, j] = A[i, j];
                }
                augmentedMatrix[i, n] = b[i];
            }

            // 高斯消去
            for (int i = 0; i < n; i++)
            {
                for (int k = i + 1; k < n; k++)
                {
                    double factor = augmentedMatrix[k, i] / augmentedMatrix[i, i];
                    for (int j = i; j < n + 1; j++)
                    {
                        augmentedMatrix[k, j] -= factor * augmentedMatrix[i, j];
                    }
                }
            }

            // 反向代入
            for (int i = n - 1; i >= 0; i--)
            {
                x[i] = augmentedMatrix[i, n];
                for (int j = i + 1; j < n; j++)
                {
                    x[i] -= augmentedMatrix[i, j] * x[j];
                }
                x[i] /= augmentedMatrix[i, i];
            }

            return x;
        }

        public static double[] ApplyAffineTransform(double[] point, double[] transformMatrix)
        {
            double a11 = transformMatrix[0];
            double a12 = transformMatrix[1];
            double tx = transformMatrix[2];
            double a21 = transformMatrix[3];
            double a22 = transformMatrix[4];
            double ty = transformMatrix[5];

            double[] result = new double[2];
            result[0] = a11 * point[0] + a12 * point[1] + tx;
            result[1] = a21 * point[0] + a22 * point[1] + ty;

            return result;
        }
    }
}
