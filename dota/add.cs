using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dota
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dotaDataSet1.dota". При необходимости она может быть перемещена или удалена.
            this.dotaTableAdapter.Fill(this.dotaDataSet1.dota);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }//загрузка изображение из файлов
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dotaTableAdapter.Adapter.Update(dotaDataSet1.dota);
            dotaDataSet1.Tables[0].AcceptChanges();
            dataGridView1.Refresh();
            menu s = new menu();
            s.Show();
            this.Hide();//сохранение и переход на другую форму
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool res;
            int b;
            if (comboBox1.Text == "1") { b = 1; } else { b = 2; }
            if (comboBox2.Text == "да") { res = true; } else { res = false; }
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
                DataRow nRow = dotaDataSet1.Tables[0].NewRow();
                int rc = dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = b;
                nRow[4] = dateTimePicker1.Value;
                nRow[5] = img;
                nRow[6] = res;
                dotaDataSet1.Tables[0].Rows.Add(nRow);

                dotaTableAdapter.Adapter.Update(dotaDataSet1.dota);
                dotaDataSet1.Tables[0].AcceptChanges();
                dataGridView1.Refresh();//сохранение записи
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
