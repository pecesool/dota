using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dota
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            autho main = this.Owner as autho;
            bool sush = false;
            if (main != null && (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text)))
            {
                for (int i = 0; i < main.dataGridView1.RowCount - 1; i++)
                {
                    if (main.dataGridView1.Rows[i].Cells[1].Value.ToString() == textBox1.Text)
                    {
                        MessageBox.Show("Этот пользователь уже существует");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        sush = true;//проверка на наличие существующего пользователя
                    }
                }
                if (!sush)
                {
                    DataRow nRow = main.dotaDataSet.Tables[0].NewRow();
                    int rc = main.dataGridView1.RowCount;
                    nRow[0] = rc;
                    nRow[1] = textBox1.Text;
                    nRow[2] = textBox2.Text;
                    main.dotaDataSet.Tables[0].Rows.Add(nRow);
                    main.авторизацияTableAdapter.Update(main.dotaDataSet.авторизация);
                    main.dotaDataSet.Tables[0].AcceptChanges();
                    main.dataGridView1.Refresh();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    MessageBox.Show("Данные успешно сохранены");
                    Close();//сохранение нового пользователя
                }
            }
            else
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);//ошибка
            }
        }
    }
}
