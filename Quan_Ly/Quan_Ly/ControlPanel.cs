using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly
{
    public class ControlPanel
    {
        public ControlPanel() { }
        public void Clear_TextBox(Panel panel)
        {
            int controlCount = panel.Controls.Count;

            if (controlCount == 0)
            {
                MessageBox.Show("Không có gì để làm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<TextBox> textBoxesToClear = panel.Controls.OfType<TextBox>().ToList();

                foreach (TextBox textBox in textBoxesToClear)
                {
                    // Refesh
                    textBox.Clear();
                }
            }
        }
        public void Xoa_TextBox(Panel panel)
        {
            int controlCount = panel.Controls.Count;

            if (controlCount == 0)
            {
                MessageBox.Show("Không có gì để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<TextBox> textBoxesToRemove = panel.Controls.OfType<TextBox>().ToList();

                foreach (TextBox textBox in textBoxesToRemove)
                {
                    // Giải phóng tài nguyên của TextBox
                    textBox.Dispose();
                    // Xóa TextBox khỏi Panel
                    panel.Controls.Remove(textBox);
                }
            }
        }
        public void Xoa_NumericUpDown(Panel panel)
        {
            int controlCount = panel.Controls.Count;

            if (controlCount == 0)
            {
                MessageBox.Show("Không có gì để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<NumericUpDown> numericUpDownToRemove = panel.Controls.OfType<NumericUpDown>().ToList();

                foreach (NumericUpDown numeric in numericUpDownToRemove)
                {
                    // Giải phóng tài nguyên của TextBox
                    numeric.Dispose();
                    // Xóa TextBox khỏi Panel
                    panel.Controls.Remove(numeric);
                }
            }
        }
        public void Xoa_Label(Panel panel)
        {
            int controlCount = panel.Controls.Count;

            if (controlCount == 0)
            {
                MessageBox.Show("Không có gì để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Label> labelToRemove = panel.Controls.OfType<Label>().ToList();

                foreach (Label Label in labelToRemove)
                {
                    // Giải phóng tài nguyên của TextBox
                    Label.Dispose();
                    // Xóa TextBox khỏi Panel
                    panel.Controls.Remove(Label);
                }
            }
        }
    }
}
