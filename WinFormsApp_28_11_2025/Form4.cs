using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; // Cần thêm vì sử dụng 'Size'
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_28_11_2025
{
    // Lưu ý: Đảm bảo biến 'button1' (từ file Designer) đã được khai báo 
    // trong class Form4 này hoặc trong Form4.Designer.cs
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Hàm xử lý sự kiện Click cho nút bấm (button1)
        // Lưu ý: Tên hàm là bt_OK_Click, mặc dù nút trong Designer là button1.
        private void bt_OK_Click(object sender, EventArgs e)
        {
            // Thay đổi tiêu đề của Form
            this.Text = "Article for Button";

            // Thay đổi kích thước của Form thành 500x500
            this.Size = new Size(500, 500);
        }
    }
}