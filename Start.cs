namespace GradePTIT
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            dataHK1.CellValidating += dataHK_CellValidating!;
            dataHK2.CellValidating += dataHK_CellValidating!;
            dataHK3.CellValidating += dataHK_CellValidating!;
            dataHK4.CellValidating += dataHK_CellValidating!;
            dataHK5.CellValidating += dataHK_CellValidating!;
            dataHK6.CellValidating += dataHK_CellValidating!;
            dataHK7.CellValidating += dataHK_CellValidating!;
            dataHK8.CellValidating += dataHK_CellValidating!;
            dataHK9.CellValidating += dataHK_CellValidating!;
            GPA_HK1.Text = "";
            GPA_HK2.Text = "";
            GPA_HK3.Text = "";
            GPA_HK4.Text = "";
            GPA_HK5.Text = "";
            GPA_HK6.Text = "";
            GPA_HK7.Text = "";
            GPA_HK8.Text = "";
            GPA_HK9.Text = "";
            CPA.Text = "";
        }
        private void tinhGPA(DataGridView dgv, Label lbl)
        {
            float totalTC = 0;
            float totalTichLuy = 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;
                float soTC = 0;
                float diem = 0;
                if (float.TryParse(Convert.ToString(row.Cells[1].Value), out diem) && float.TryParse(Convert.ToString(row.Cells[2].Value), out soTC))
                {
                    totalTC += soTC;
                    totalTichLuy += soTC * diem;
                }
            }
            float gpa = (totalTC > 0) ? (totalTichLuy / totalTC) : 0;
            string x = "";
            if (dgv == dataHK1) x = "1";
            if (dgv == dataHK2) x = "2";
            if (dgv == dataHK3) x = "3";
            if (dgv == dataHK4) x = "4";
            if (dgv == dataHK5) x = "5";
            if (dgv == dataHK6) x = "6";
            if (dgv == dataHK7) x = "7";
            if (dgv == dataHK8) x = "8";
            if (dgv == dataHK9) x = "9";
            lbl.Text = $"Điểm GPA kỳ {x} của bạn là {gpa:F2}";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void dataHK1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //hạn chế đầu vào HK1
        private void dataHK_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2) // cột Số TC hoặc Điểm
            {
                if (!double.TryParse(Convert.ToString(e.FormattedValue), out _))
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ!");
                    e.Cancel = true;
                }
            }
        }


        private void HK1_Click(object sender, EventArgs e)
        {

        }
        //thêm môn hk1
        private void button1_Click_1(object sender, EventArgs e)
        {

            dataHK1.Rows.Add("", 0, 0.0);
        }
        //tính gpa hk1
        private void button2_Click(object sender, EventArgs e)
        {
            tinhGPA(dataHK1, GPA_HK1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //thêm môn HK2
        private void button3_Click(object sender, EventArgs e)
        {
            dataHK2.Rows.Add("", 0, 0.0);
        }
        //tính gpa HK2
        private void button4_Click(object sender, EventArgs e)
        {
            tinhGPA(dataHK2, GPA_HK2);
        }
        //thêm môn HK3
        private void button5_Click(object sender, EventArgs e)
        {
            dataHK3.Rows.Add("", 0, 0.0);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //thêm môn HK4
        private void button7_Click(object sender, EventArgs e)
        {
            dataHK4.Rows.Add("", 0, 0.0);
        }

        private void HK5_Click(object sender, EventArgs e)
        {

        }
        //thêm môn HK5
        private void button9_Click(object sender, EventArgs e)
        {
            dataHK5.Rows.Add("", 0, 0.0);
        }
        //thêm môn HK6
        private void button11_Click(object sender, EventArgs e)
        {
            dataHK6.Rows.Add("", 0, 0.0);
        }
        //thêm môn HK7
        private void button13_Click(object sender, EventArgs e)
        {
            dataHK7.Rows.Add("", 0, 0.0);
        }
        //thêm môn HK8
        private void button15_Click(object sender, EventArgs e)
        {
            dataHK8.Rows.Add("", 0, 0.0);
        }//thêm môn HK9
        private void button17_Click(object sender, EventArgs e)
        {
            dataHK9.Rows.Add("", 0, 0.0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Tính gpa hK3
        private void button6_Click(object sender, EventArgs e)
        {
            tinhGPA(dataHK3, GPA_HK3);
        }
        //tính gpa HK4
        private void button8_Click(object sender, EventArgs e)
        {
            tinhGPA(dataHK4, GPA_HK4);
        }
        //tính gpa HK5
        private void button10_Click(object sender, EventArgs e)
        {
            tinhGPA(dataHK5, GPA_HK5);
        }
        //tính gpa HK6
        private void button12_Click(object sender, EventArgs e)
        {
            tinhGPA(dataHK6, GPA_HK6);
        }
        //tính gpa HK7
        private void button14_Click(object sender, EventArgs e)
        {
            tinhGPA(dataHK7, GPA_HK7);
        }
        //tính gpa HK8
        private void button16_Click(object sender, EventArgs e)
        {
            tinhGPA(dataHK8, GPA_HK8);
        }
        //tính gpa HK9
        private void button18_Click(object sender, EventArgs e)
        {
            tinhGPA(dataHK9, GPA_HK9);
        }

        private void CPA_Click(object sender, EventArgs e)
        {

        }
        private void TinhCPA(Label lblCPA)
        {
            float totalTC = 0;
            float totalTichLuy = 0;

            List<DataGridView> allHKs = new List<DataGridView>()
    {
        dataHK1, dataHK2, dataHK3, dataHK4,
        dataHK5, dataHK6, dataHK7, dataHK8, dataHK9
    };

            foreach (var dgv in allHKs)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    float soTC = 0;
                    float diem = 0;

                    // Lưu ý: đổi thứ tự nếu bạn đang để Điểm trước SốTC
                    if (float.TryParse(Convert.ToString(row.Cells[1].Value), out diem) &&
                        float.TryParse(Convert.ToString(row.Cells[2].Value), out soTC))
                    {
                        totalTC += soTC;
                        totalTichLuy += soTC * diem;
                    }
                }
            }

            float cpa = (totalTC > 0) ? (totalTichLuy / totalTC) : 0;
            lblCPA.Text = $"CPA toàn khóa của bạn là: {cpa:F2}";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            TinhCPA(CPA);
        }
    }
}
