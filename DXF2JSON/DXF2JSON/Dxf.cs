using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using netDxf;
using netDxf.Entities;
using static netDxf.Entities.HatchBoundaryPath;

namespace DxfDatas
{
    public static class Dxf
    {
        public class Json
        {
            public class Circle
            {
                public int Index { get; set; }
                public string? Name { get; set; }
                public string? ID { get; set; }
                public double X { get; set; }
                public double Y { get; set; }
                public double Diameter { get; set; }
                public string? Place { get; set; }
                public string? Remove { get; set; }
                public string? Replace { get; set; }
                public string? display { get; set; }
                public string? Enable { get; set; }
                public string? Reserve1 { get; set; }
                public string? Reserve2 { get; set; }
                public string? Reserve3 { get; set; }
                public string? Reserve4 { get; set; }
                public string? Reserve5 { get; set; }
            }

            public List<Circle> Circles { get; set; }

            public Json()
            {
                Circles = new List<Circle>();
            }
        }

        /// <summary>
        /// 在 DataGridView 顯示 DXF 資料
        /// </summary>
        /// <param name="dgv_DxfDatas">要顯示 DXF 檔的 DataGridView</param>
        /// <param name="DxfDoc">已讀取的 DXF 文件</param>
        /// <returns>無回傳值</returns>
        public static void show_dgv_Dxf(DataGridView dgv_DxfDatas, Json dxfJson)
        {

            dgv_DxfDatas.Rows.Clear();

            foreach (var Circle in dxfJson.Circles)
            {
                dgv_DxfDatas.Rows.Add(
                    Circle.X, // 第一行：圓心座標 X
                    Circle.Y, // 第二行：圓心座標 Y
                    Circle.Diameter // 第三行：直徑
                );

            }
        }

        /// <summary>
        /// 計算 dxf 檔所有圓的邊界
        /// </summary>
        /// <param name="DxfDoc">已讀取的 DXF 文件</param>
        /// <param name="minX">左邊界</param>
        /// <param name="minY">上邊界</param>
        /// <param name="maxX">右邊界</param>
        /// <param name="maxY">下邊界</param>
        /// <returns>無回傳值</returns>
        public static void find_Dxf_bounds(Json dxfJson, out double minX, out double minY, out double maxX, out double maxY, out double width, out double height)
        {
            // 初始化邊界
            minX = double.MaxValue;
            minY = double.MaxValue;
            maxX = double.MinValue;
            maxY = double.MinValue;

            // 遍歷所有圓，更新邊界
            foreach (var circle in dxfJson.Circles)
            {
                minX = Math.Min(minX, circle.X - circle.Diameter / 2);
                minY = Math.Min(minY, circle.Y - circle.Diameter / 2);
                maxX = Math.Max(maxX, circle.X + circle.Diameter / 2);
                maxY = Math.Max(maxY, circle.Y + circle.Diameter / 2);
            }

            width = maxX - minX;
            height = maxY - minY;
        }

        /// <summary>
        /// 將 DXF 檔中的資料轉成 JSON
        /// </summary>
        /// <param name="dgv_DxfDatas">要顯示 DXF 檔的 DataGridView</param>
        /// <param name="DxfDoc">已讀取的 DXF 文件</param>
        /// <returns>無回傳值</returns>
        public static void transform_Dxf2Json(DxfDocument DxfDoc, out Json dxf2Json)
        {
            dxf2Json = new Json();

            int index = 0;

            foreach (var circle in DxfDoc.Entities.Circles)
            {
                
                dxf2Json.Circles.Add(new Json.Circle
                {
                    Index = index,
                    X = circle.Center.X,
                    Y = circle.Center.Y,
                    Diameter = circle.Radius * 2,
                });

                index++;
            }
        }
    }
}
