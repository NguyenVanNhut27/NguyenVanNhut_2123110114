using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_28_11_2025
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xử lý sự kiện khi Form kết thúc việc thay đổi kích thước.
        /// (Đã đổi tên từ Form1_ResizeEnd thành Form5_ResizeEnd)
        /// </summary>
        private void Form5_ResizeEnd(object sender, System.EventArgs e)
        {
            // Lấy kích thước hiện tại của Form
            int width = this.Size.Width;
            int height = this.Size.Height;

            // Hiển thị kích thước lên thanh tiêu đề của Form
            this.Text = width.ToString() + " - " + height.ToString();
        }

        /// <summary>
        /// Xử lý sự kiện khi Form được tải và hiển thị lần đầu tiên.
        /// (Đã đổi tên từ Form1_Load thành Form5_Load)
        /// </summary>
        private void Form5_Load(object sender, System.EventArgs e)
        {
            // Lấy kích thước ban đầu của Form
            int width = this.Size.Width;
            int height = this.Size.Height;

            // Hiển thị kích thước lên thanh tiêu đề của Form
            this.Text = width.ToString() + " - " + height.ToString();
        }

    }
}