using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using OfficeOpenXml.Style;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.Office.Interop.Excel;
using TextBox = System.Windows.Forms.TextBox;
using Point = System.Drawing.Point;
using Button = System.Windows.Forms.Button;
using Label = System.Windows.Forms.Label;

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
        public TextBox CreateTextBox(string text, HorizontalAlignment align, int x, int y, int width, int height)
        {
            TextBox textBox = new TextBox();
            textBox.Name = "textBox";
            textBox.Text = text;
            textBox.TextAlign = align;
            textBox.ReadOnly = true;
            textBox.Width = width;
            textBox.Height = height;
            textBox.Location = new Point(x, y);
            return textBox;
        }
        public TextBox CreateTextBoxTen(string text, HorizontalAlignment align, int x, int y, int width, int height)
        {
            TextBox textBox = new TextBox();
            textBox.Name = "textBoxTen";
            textBox.Text = text;
            textBox.TextAlign = align;
            textBox.ReadOnly = true;
            textBox.Width = width;
            textBox.Height = height;
            textBox.Location = new Point(x, y);
            return textBox;
        }

        public NumericUpDown CreateNumericUpDown(int value, HorizontalAlignment align, int x, int y, int width)
        {
            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Maximum = 1000;
            numericUpDown.Value = value;
            numericUpDown.TextAlign = align;
            numericUpDown.Width = width;
            numericUpDown.Location = new Point(x, y);
            return numericUpDown;
        }
        public Button CreateButton(int x, int y, int width, int height, ImageList imgList)
        {
            Button btt = new Button();
            btt.ImageList = imgList;
            btt.ImageKey = "trash-outline.png";
            btt.Width = width;
            btt.Height = height;
            btt.Location = new Point(x, y);
            return btt;
        }
    }
}
