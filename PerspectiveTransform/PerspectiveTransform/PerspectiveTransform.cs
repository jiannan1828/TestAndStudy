using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerspectiveTransform
{

    internal static class PerspectiveTransform
    {
        /// <summary>
        /// 將相機座標轉換為真實座標
        /// </summary>
        /// <param name="inputImage">帶入的圖片</param>
        /// <param name="cameraPos">相機座標</param>
        /// <param name="realPos">真實座標</param>
        /// <returns>兩數的和</returns>
        public static Image<Bgr, byte> ApplyPerspectiveTransform(Image<Bgr, byte> inputImage, PointF[] cameraPos, PointF[] realPos)
        {
            if (cameraPos.Length != 4 || realPos.Length != 4)
                throw new ArgumentException("Source and destination points must have 4 points.");

            // 計算透視變換矩陣
            var perspectiveMatrix = CvInvoke.GetPerspectiveTransform(cameraPos, realPos);

            // 輸出影像大小
            var outputSize = new Size(inputImage.Width, inputImage.Height);

            // 進行透視變換
            var outputImage = new Image<Bgr, byte>(outputSize);
            CvInvoke.WarpPerspective(inputImage, outputImage, perspectiveMatrix, outputSize);

            return outputImage;
        }

        /// <summary>
        /// 算出透視變換矩陣
        /// </summary>
        /// <param name="cameraPos">相機座標</param>
        /// <param name="realPos">真實座標</param>
        /// <returns>兩數的和</returns>
        private static Matrix GetPerspectiveMatrix(PointF[] cameraPos, PointF[] realPos)
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
                matrix[i, 6] = -cameraPos[i].X * realPos[i].X;
                matrix[i, 7] = -cameraPos[i].Y * realPos[i].X;
                matrix[i, 8] = -realPos[i].X;

                matrix[i + 4, 0] = 0;
                matrix[i + 4, 1] = 0;
                matrix[i + 4, 2] = 0;
                matrix[i + 4, 3] = cameraPos[i].X;
                matrix[i + 4, 4] = cameraPos[i].Y;
                matrix[i + 4, 5] = 1;
                matrix[i + 4, 6] = -cameraPos[i].X * realPos[i].Y;
                matrix[i + 4, 7] = -cameraPos[i].Y * realPos[i].Y;
                matrix[i + 4, 8] = -realPos[i].Y;
            }

            float[] result = SolveLinearSystem(matrix);

            // 透視變換矩陣
            Matrix perspectiveMatrix = new Matrix(
                result[0], result[1], result[3], result[4], result[6], result[7]
            //  h11      , h12      , h21      , h22      , h13 dx   , h23 dy
            );

            return perspectiveMatrix;
        }

        // 解線性方程組（高斯消元法）
        private static float[] SolveLinearSystem(float[,] matrix)
        {
            int n = 8; // 矩陣大小為 8x8

            // 最大 次大 ....           最小
            //      最大 次大 ....      最小 1 - 2
            //           最大 次大 .... 最小 1 - 3
            // 第一行先求解第一個元素, 第二行求解第二個元素, 以此類推
            for (int i = 0; i < n; i++) // 共8行
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
                for (int j = i; j <= n; j++) // 共8列
                {
                    float temp = matrix[maxRow, j];
                    matrix[maxRow, j] = matrix[i, j];
                    matrix[i, j] = temp;
                }

                // 其他行 - 該列最大元素行 * Factor = 0
                for (int k = i + 1; k < n; k++) // 共7行
                {
                    float factor = matrix[k, i] / matrix[i, i];
                    for (int j = i; j <= n; j++) // 共8列
                    {
                        matrix[k, j] -= factor * matrix[i, j]; // 減完元素應該是 0
                    }
                }
            }

            // 這裡應該會是右上半邊有值, 左下半邊全是0
            // 其他行 - 該列最小元素行 * Factor = 0
            float[] result = new float[n];

            for (int i = n - 1; i >= 0; i--) // 共8行
            {
                result[i] = matrix[i, n] / matrix[i, i];

                for (int k = i - 1; k >= 0; k--) // 共7行
                {
                    matrix[k, n] -= matrix[k, i] * result[i]; // 減完元素應該是 0
                }
            }

            return result;
        }
    }
}
