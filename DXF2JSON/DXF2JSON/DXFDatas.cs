using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using netDxf;
using netDxf.Entities;
using static netDxf.Entities.HatchBoundaryPath;

namespace DXF2JSON
{
    internal static class DXFDatas
    {
        /// <summary>
        /// 在 DataGridView 顯示 DXF 資料
        /// </summary>
        /// <param name="dgv_DXFDatas">要顯示 DXF 檔的 DataGridView</param>
        /// <param name="dxfDoc">已讀取的 DXF 文件</param>
        /// <returns>無回傳值</returns>
        public static void show_dgv_DXFDatas(DataGridView dgv_DXFDatas, DxfDocument dxfDoc)
        {
            int index = 1;

            dgv_DXFDatas.Rows.Clear();

            foreach (var Circle in dxfDoc.Entities.Circles)
            {
                dgv_DXFDatas.Rows.Add(
                    index, // 第一列：流水號
                    Circle.Center.X, // 第二列：圓心座標 X
                    Circle.Center.Y, // 第三列：圓心座標 Y
                    Circle.Radius * 2 // 第四列：直徑
                );

                index++;
            }
        }

        /// <summary>
        /// 計算 dxf 檔所有圓的邊界
        /// </summary>
        /// <param name="dxfDoc">已讀取的 DXF 文件</param>
        /// <param name="minX">左邊界</param>
        /// <param name="minY">上邊界</param>
        /// <param name="maxX">右邊界</param>
        /// <param name="maxY">下邊界</param>
        /// <returns>無回傳值</returns>
        public static void find_DXFDatas_bounds(DxfDocument dxfDoc, out double minX, out double minY, out double maxX, out double maxY)
        {
            // 初始化邊界
            minX = double.MaxValue;
            minY = double.MaxValue;
            maxX = double.MinValue;
            maxY = double.MinValue;

            // 遍歷所有圓，更新邊界
            foreach (var circle in dxfDoc.Entities.Circles)
            {
                minX = Math.Min(minX, circle.Center.X - circle.Radius);
                minY = Math.Min(minY, circle.Center.Y - circle.Radius);
                maxX = Math.Max(maxX, circle.Center.X + circle.Radius);
                maxY = Math.Max(maxY, circle.Center.Y + circle.Radius);
            }
        }
    }
}
