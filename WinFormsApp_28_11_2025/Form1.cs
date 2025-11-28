using System;
using System.Windows.Forms;

namespace WinFormsApp_28_11_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Thêm các mục mẫu cho ComboBox (nếu bạn muốn)
            cboSelection.Items.Add("Lựa chọn 1");
            cboSelection.Items.Add("Lựa chọn 2");
            cboSelection.Items.Add("Lựa chọn 3");
            cboSelection.SelectedIndex = 0; // Chọn mục đầu tiên
        }

        /// <summary>
        /// Xử lý sự kiện Click cho cả hai nút OK
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            // --- 1. Lấy dữ liệu từ các control ---

            // TextBox
            string name = txtName.Text;

            // NumericUpDown
            int quantity = (int)numQuantity.Value;

            // CheckBox
            bool isChecked = chkOption.Checked;

            // RadioButton
            bool isRadioSelected = rdoOption.Checked;

            // ComboBox
            string selectedComboItem = cboSelection.SelectedItem?.ToString() ?? "Không có";

            // DateTimePicker
            DateTime selectedDate = dtpDate.Value;

            // ListBox (Lấy mục được chọn đầu tiên, nếu có)
            string selectedListItem = lstOptions.SelectedItem?.ToString() ?? "Không có";


            // --- 2. Hiển thị dữ liệu thu thập được ---
            string message = $"Thông tin đã thu thập:\n\n" +
                             $"- Tên: {name}\n" +
                             $"- Số lượng: {quantity}\n" +
                             $"- CheckBox (đã chọn): {isChecked}\n" +
                             $"- RadioButton (đã chọn): {isRadioSelected}\n" +
                             $"- ComboBox (chọn): {selectedComboItem}\n" +
                             $"- Ngày: {selectedDate.ToShortDateString()}\n" +
                             $"- ListBox (chọn): {selectedListItem}";

            MessageBox.Show(message, "Dữ liệu Form", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Tùy chọn: Đóng form sau khi nhấn OK
            // this.Close();
        }

        private void From1_Keyup(object sender, KeyEventArgs e)
        {

        }
    }
}   