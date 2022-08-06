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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dotaDataSet1.dota". При необходимости она может быть перемещена или удалена.
            this.dotaTableAdapter.Fill(this.dotaDataSet1.dota);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int pob, par, nich, bud;
            pob = Convert.ToInt32(textBox3.Text);
            par = Convert.ToInt32(textBox5.Text);
            nich = Convert.ToInt32(textBox6.Text);
            bud = Convert.ToInt32(textBox7.Text)*3;
            int res = pob * 3 + par * 0 + nich;
            label12.Text = "Всего очков " + res.ToString() + "\n" + "Возможность набрать" + bud.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[1].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox4.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                k++;
                                break;//поиск по базе данных
                            }
                        }
                    }
                }
                label3.Text = "Найдено " + k.ToString() + " Совпадений";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            label3.Text = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x = 1;
            if (radioButton4.Checked == true) { x = 0; }
            if (radioButton3.Checked == true) { x = 1; }
            if (checkBox6.Checked == true) { if (x == 0) { dotaBindingSource.Sort = "Первая команда ASC"; } else { dotaBindingSource.Sort = "Первая команда DESC"; } }
            if (checkBox2.Checked == true) { if (x == 0) { dotaBindingSource.Sort = "Вторая команда ASC"; } else { dotaBindingSource.Sort = "Вторая команда DESC"; } }
            if (checkBox5.Checked == true) { if (x == 0) { dotaBindingSource.Sort = "Победа команды ASC"; } else { dotaBindingSource.Sort = "Победа команды DESC"; } }
            if (checkBox1.Checked == true) { if (x == 0) { dotaBindingSource.Sort = "Состоялся ASC"; } else { dotaBindingSource.Sort = "Состоялся DESC"; } }
            //сортировка по нескольким полям
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox6.Checked = false;
            checkBox5.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dotaBindingSource.Filter = null;
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";//сброс фильра
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool res;
            if (comboBox2.Text == "да") { res = true; } else { res = false; }
            int k = 0;
            string poisk = "";
            if (textBox1.Text != "")
            {
                k++;
                if (k > 1)
                {
                    poisk += " AND ";
                }
                poisk += "[Первая команда] LIKE'%" + textBox1.Text + "%'";
            }
            if (textBox2.Text != "")
            {
                k++;
                if (k > 1)
                {
                    poisk += " AND ";
                }
                poisk += "[Вторая команда] LIKE'%" + textBox2.Text + "%'";
            }
            if (comboBox1.Text != "")
            {
                k++;
                if (k > 1)
                {
                    poisk += " AND ";
                }
                poisk += "[Победа команды]=" + Convert.ToInt32(comboBox1.Text);
            }

            if (comboBox2.Text != "")
            {
                k++;
                if (k > 1)
                {
                    poisk += " AND ";
                }
                if (res == true)
                {
                    poisk += dotaBindingSource.Filter = "[Состоялся] = 1";
                }
                else { poisk += dotaBindingSource.Filter = "[Состоялся] = 0"; }
            }
            if (k >= 1)
            {
                dotaBindingSource.Filter = poisk;//фильрация по нескольким полям

            }
            else
            {
                if (k == 0)
                {
                    dotaBindingSource.Filter = "";//сброс фильтрации
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add s = new add();
            s.Show();
            this.Hide();
        }
    }
}
