using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using netDxf;

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
            int index = 0;

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
    }
}
