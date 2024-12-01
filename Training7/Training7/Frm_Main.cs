using System.Windows.Forms;
using netDxf;
using netDxf.Entities;

namespace Training7
{
    public partial class Frm_Main : Form
    {

        private OpenFileDialog openDXFFileDialog = new OpenFileDialog();

        public Frm_Main()
        {
            InitializeComponent();

        }

        private void btn_OpenDXFFile_Click(object sender, EventArgs e)
        {
            openDXFFileDialog.Filter = "DXF Files (*.dxf)|*.dxf";

            if (openDXFFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_OpenDXFFile.Text = openDXFFileDialog.FileName;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                DxfDocument dxfDoc = DxfDocument.Load(openDXFFileDialog.FileName);
                MessageBox.Show($"�ɮ� {openDXFFileDialog.FileName} ���\Ū���I");
                show_lv_DXFData(dxfDoc);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ū���ɮ׮ɵo�Ϳ��~: {ex.Message}");
            }
        }

        public void show_lv_DXFData(DxfDocument dxfDoc)
        {
            int index = 0;

            foreach (var Circle in dxfDoc.Entities.Circles)
            {
                ListViewItem item = new ListViewItem("Circle " + index); // ����
                item.SubItems.Add($"{Circle.Center.X}, {Circle.Center.Y}"); // �l����
                item.SubItems.Add(Circle.Radius.ToString()); // �l����
                lv_DXFCircles.Items.Add(item);

                index++;
            }

            foreach (var Point in dxfDoc.Entities.Points)
            {
                ListViewItem item  = new ListViewItem("Point " + index); // ����
                item.SubItems.Add($"{Point.Position.X}, {Point.Position.Y}"); // �l����
                lv_DXFPoints.Items.Add(item);

                index++;
            }
        }
    }
}
