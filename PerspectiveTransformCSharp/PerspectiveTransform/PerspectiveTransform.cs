using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerspectiveTransform
{

    internal class PerspectiveTransform
    {
        /// <summary>
        /// 將相機座標轉換為真實座標
        /// </summary>
        /// <param name="inputImage">帶入的圖片</param>
        /// <param name="cameraPos">相機座標</param>
        /// <param name="realPos">真實座標</param>
        /// <returns>兩數的和</returns>
        public static Bitmap ApplyPerspectiveTransform(Bitmap inputImage, PointF[] cameraPos, PointF[] realPos)
        {
            if (cameraPos.Length != 4 || realPos.Length != 4)
                throw new ArgumentException("Source and destination points must have 4 points.");

            // 計算透視變換矩陣
            float[,] perspectiveMatrix = GetPerspectiveMatrix(cameraPos, realPos);
            AdjustPerspectiveMatrix(ref perspectiveMatrix); // 修正正負號

            // 創建輸出的圖像
            Bitmap outputImage = new Bitmap(inputImage.Width, inputImage.Height);

            outputImage = inputImage; //未來修改

            return outputImage;
        }

        /// <summary>
        /// 算出透視變換矩陣
        /// </summary>
        /// <param name="cameraPos">相機座標</param>
        /// <param name="realPos">真實座標</param>
        /// <returns>兩數的和</returns>
        private static float[,] GetPerspectiveMatrix(PointF[] cameraPos, PointF[] realPos)
        {
            // 總共4組方程式, 8個未知數
            float[,] matrix = new float[8, 9];

            for (int i = 0; i < 4; i++)
            {
                matrix[i, 0] = cameraPos[i].X;
                matrix[i, 1] = cameraPos[i].Y;
                matrix[i, 2] = 1;
                matrix[i, 3] = 0;
                matrix[i, 4] = 0;
                matrix[i, 5] = 0;
                matrix[i, 6] = -realPos[i].X * cameraPos[i].X;
                matrix[i, 7] = -realPos[i].X * cameraPos[i].Y;
                matrix[i, 8] = -realPos[i].X;

                matrix[i + 4, 0] = 0;
                matrix[i + 4, 1] = 0;
                matrix[i + 4, 2] = 0;
                matrix[i + 4, 3] = cameraPos[i].X;
                matrix[i + 4, 4] = cameraPos[i].Y;
                matrix[i + 4, 5] = 1;
                matrix[i + 4, 6] = -realPos[i].Y * cameraPos[i].X;
                matrix[i + 4, 7] = -realPos[i].Y * cameraPos[i].Y;
                matrix[i + 4, 8] = -realPos[i].Y;
            }

            float[,] result = SolveLinearSystem(matrix);

            return result;
        }

        private static float[,] SolveLinearSystem(float[,] matrix)
        {
            int n = 8; // 矩陣大小為 8x9

            // 高斯消元法的消元過程
            for (int i = 0; i < n; i++)
            {
                // 找出該列中絕對值最大的元素
                int maxRow = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (Math.Abs(matrix[j, i]) > Math.Abs(matrix[maxRow, i]))
                    {
                        maxRow = j;
                    }
                }

                // 將該行移到最上面
                for (int j = i; j < n + 1; j++) // 包含最後一列
                {
                    float temp = matrix[maxRow, j];
                    matrix[maxRow, j] = matrix[i, j];
                    matrix[i, j] = temp;
                }

                // 其他行 - 該列最大元素行 * Factor = 0
                for (int k = i + 1; k < n; k++)
                {
                    float factor = -matrix[k, i] / matrix[i, i];
                    for (int j = i; j < n + 1; j++) // 包含常數項所以n+1
                    {
                        matrix[k, j] += factor * matrix[i, j];
                    }
                }
            }

            // 回代過程，求解未知數
            float[,] result = new float[3,3];
            for (int i = n - 1; i >= 0; i--)
            {
                result[(int)i/3, i%3] = - matrix[i, n] / matrix[i, i];
                for (int k = i - 1; k >= 0; k--)
                {
                    matrix[k, n] += matrix[k, i] * result[(int)i / 3, i % 3];
                }
            }

            result[2, 2] = 1;

            return result;
        }

        private static void AdjustPerspectiveMatrix(ref float[,] perspectiveMatrix)
        {
            if (perspectiveMatrix[0, 0] < 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        perspectiveMatrix[i, j] = -perspectiveMatrix[i, j];
                    }
                }
            }
        }
    }
}
