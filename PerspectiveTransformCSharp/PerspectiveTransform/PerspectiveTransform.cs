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

            Console.WriteLine("透視變換矩陣:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(perspectiveMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            float[,] inversePerspectiveMatrix = InvertMatrix(perspectiveMatrix);
            // 輸出圖像
            Bitmap outputImage = new Bitmap(inputImage.Width, inputImage.Height);

            // 使用反向映射，將目標圖像的每個像素映射到原始圖像
            for (int y = 0; y < outputImage.Height; y++)
            {
                for (int x = 0; x < outputImage.Width; x++)
                {
                    // 計算目標點在原始圖像中的對應點
                    PointF sourcePoint = TransformPoint(x, y, inversePerspectiveMatrix);

                    // 確認點是否在原始圖像範圍內
                    if (sourcePoint.X >= 0 && sourcePoint.X < inputImage.Width &&
                        sourcePoint.Y >= 0 && sourcePoint.Y < inputImage.Height)
                    {
                        // 使用最近鄰插值或其他插值方法取得顏色
                        Color pixelColor = inputImage.GetPixel((int)sourcePoint.X, (int)sourcePoint.Y);
                        outputImage.SetPixel(x, y, pixelColor);
                    }
                    else
                    {
                        outputImage.SetPixel(x, y, Color.White);
                    }
                }
            }

            return outputImage;
        }

        /// <summary>
        /// 使用透視矩陣將座標轉換
        /// </summary>
        private static PointF TransformPoint(float x, float y, float[,] matrix)
        {
            float denom = matrix[2, 0] * x + matrix[2, 1] * y + matrix[2, 2]; // 深度 W
            float newX = (matrix[0, 0] * x + matrix[0, 1] * y + matrix[0, 2]) / denom; // x"=x'/W
            float newY = (matrix[1, 0] * x + matrix[1, 1] * y + matrix[1, 2]) / denom; // y"=y'/W

            return new PointF(newX, newY);
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

        /// <summary>
        /// 算出透視變換矩陣
        /// </summary>
        /// <param name="matrix">該矩陣</param>
        /// <returns>反矩陣</returns>
        private static float[,] InvertMatrix(float[,] matrix)
        {
            if (matrix.GetLength(0) != 3 || matrix.GetLength(1) != 3)
                throw new ArgumentException("Matrix must be 3x3.");

            // 計算行列式 det(H)
            float det = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
                        matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
                        matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

            if (Math.Abs(det) < 1e-6)
                throw new InvalidOperationException("Matrix is not invertible.");

            // 計算伴隨矩陣 adj(H)
            float[,] adj = new float[3, 3];
            adj[0, 0] = (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
            adj[0, 1] = -(matrix[0, 1] * matrix[2, 2] - matrix[0, 2] * matrix[2, 1]);
            adj[0, 2] = (matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1]);
            adj[1, 0] = -(matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
            adj[1, 1] = (matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0]);
            adj[1, 2] = -(matrix[0, 0] * matrix[1, 2] - matrix[0, 2] * matrix[1, 0]);
            adj[2, 0] = (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
            adj[2, 1] = -(matrix[0, 0] * matrix[2, 1] - matrix[0, 1] * matrix[2, 0]);
            adj[2, 2] = (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]);

            // 計算逆矩陣 H^-1 = adj(H) / det(H)
            float[,] inverse = new float[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    inverse[i, j] = adj[i, j] / det;
                }
            }

            return inverse;
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
    }
}
