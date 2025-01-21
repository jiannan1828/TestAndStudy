using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffineTransform
{
    internal class AffineTransform
    {
        // 真實點
        static double[,] realPoints = {
            { 0.01, 0.005 },
            { 9.9985, -0.0025 },
            { 5.01, 4.995 }
        };

        // 理想點
        static double[,] idealPoints = {
            { 0, 0 },
            { 10, 0 },
            { 5, 5 }
        };

        public static double[] TestPoint = new double[2];

        static double[,] A = {
            { realPoints[0, 0], realPoints[0, 1], 1, 0, 0, 0 },
            { realPoints[1, 0], realPoints[1, 1], 1, 0, 0, 0 },
            { realPoints[2, 0], realPoints[2, 1], 1, 0, 0, 0 },
            { 0, 0, 0, realPoints[0, 0], realPoints[0, 1], 1 },
            { 0, 0, 0, realPoints[1, 0], realPoints[1, 1], 1 },
            { 0, 0, 0, realPoints[2, 0], realPoints[2, 1], 1 }
        };

        static double[] B = {
            idealPoints[0, 0], idealPoints[1, 0], idealPoints[2, 0],
            idealPoints[0, 1], idealPoints[1, 1], idealPoints[2, 1]
        };


        // 高斯消去法求解線性方程組
        public static double[] GaussElimination()
        {
            int n = B.Length;
            double[] transformMatrix = new double[n];

            // 前向消去
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (A[j, i] != 0)
                    {
                        double factor = A[j, i] / A[i, i];
                        for (int k = i; k < n; k++)
                        {
                            A[j, k] -= factor * A[i, k];
                        }
                        B[j] -= factor * B[i];
                    }
                }
            }

            // 反向代入
            for (int i = n - 1; i >= 0; i--)
            {
                transformMatrix[i] = B[i];
                for (int j = i + 1; j < n; j++)
                {
                    transformMatrix[i] -= A[i, j] * transformMatrix[j];
                }
                transformMatrix[i] /= A[i, i];
            }

            return transformMatrix;
        }

        // 應用Affine變換
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
