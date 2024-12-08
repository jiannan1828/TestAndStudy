using System;

using static DxfReader.Dxf;

namespace DxfReader
{
    internal static class UI
    {
        /// <summary>
        /// 在 DataGridView 顯示 DXF 資料
        /// </summary>
        /// <param name="dgv_DxfDatas">要顯示 DXF 檔的 DataGridView</param>
        /// <param name="DxfDoc">已讀取的 DXF 文件</param>
        /// <returns>無回傳值</returns>
        public static void show_dgv_NeedleInfo(DataGridView dgv_DxfDatas, Json dxfJson)
        {

            dgv_DxfDatas.Rows.Clear();

            foreach (var Circle in dxfJson.Circles)
            {
                dgv_DxfDatas.Rows.Add(
                    Circle.Index,
                    Circle.Name,
                    Circle.Id,
                    Circle.X,
                    Circle.Y,
                    Circle.Diameter,
                    Circle.Place,
                    Circle.Remove,
                    Circle.Replace,
                    Circle.Display,
                    Circle.Enable
                );

            }
        }

        /// <summary>
        /// 在 groupbox 中顯示植針資訊
        /// </summary>
        /// <param name="grpNeedleInfo">植針資訊的 Groupbox</param>
        /// <param name="focusedCircle">在 picturebox 上按下的圓</param>
        /// <returns>無回傳值</returns>
        public static void show_grp_NeedleInfo(GroupBox grpNeedleInfo, Json.Circle focusedCircle)
        {
            foreach (Control control in grpNeedleInfo.Controls)
            {
                switch (control)
                {
                    case TextBox textBox:

                        switch (textBox.Name)
                        {
                            case "txt_Index":
                                textBox.Text = (focusedCircle.Index).ToString();
                                break;
                            case "txt_Name":
                                textBox.Text = focusedCircle.Name;
                                break;
                            case "txt_Id":
                                textBox.Text = focusedCircle.Id;
                                break;
                            case "txt_PosX":
                                textBox.Text = (focusedCircle.X).ToString();
                                break;
                            case "txt_PosY":
                                textBox.Text = (focusedCircle.Y).ToString();
                                break;
                            case "txt_Diameter":
                                textBox.Text = (focusedCircle.Diameter).ToString();
                                break;
                        }

                        break;

                    case CheckBox checkBox:

                        switch (checkBox.Name)
                        {
                            case "chk_Place":
                                checkBox.Checked = Convert.ToBoolean(focusedCircle.Place);
                                break;
                            case "chk_Remove":
                                checkBox.Checked = Convert.ToBoolean(focusedCircle.Remove);
                                break;
                            case "chk_Replace":
                                checkBox.Checked = Convert.ToBoolean(focusedCircle.Replace);
                                break;
                            case "chk_Display":
                                checkBox.Checked = Convert.ToBoolean(focusedCircle.Display);
                                break;
                            case "chk_Enable":
                                checkBox.Checked = Convert.ToBoolean(focusedCircle.Enable);
                                break;

                        }

                        break;
                }
            }
        }
    }
}
