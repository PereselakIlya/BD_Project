using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КурсачБД_И.С.Переселяк
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Данная строка кода позволяет загрузить данные в таблицу "складПомDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.складПомDataSet.Поставщик);
            this.товарTableAdapter.Fill(this.складПомDataSet.Товар);
            this.поставкиTableAdapter.Fill(this.складПомDataSet.Поставки);
            Товар.Visible = false;
            Поставщик.Visible = false;
            panel2.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button17.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.поставщикTableAdapter.Fill(this.складПомDataSet.Поставщик);
                if(!adress.Text.Equals("")||!Title.Text.Equals(""))
                {
                    this.поставщикTableAdapter.InsertQuery(Title.Text, adress.Text);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Error");
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.поставщикTableAdapter.DeleteQuery(Convert.ToInt32(id.Text));
                this.поставкиTableAdapter.DeleteQuery(Convert.ToInt32(id.Text));
                this.поставщикTableAdapter.Fill(this.складПомDataSet.Поставщик);
                this.поставкиTableAdapter.Fill(this.складПомDataSet.Поставки);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.поставщикTableAdapter.UpdateQuery(textBox2.Text, textBox1.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox3.Text));
                this.поставщикTableAdapter.Fill(this.складПомDataSet.Поставщик);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                panel2.Visible = false;
                Поставщик.Visible=false;
                Товар.Visible = true;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                this.товарTableAdapter.InsertQuery(textBox5.Text, textBox4.Text, Convert.ToInt32(textBox10.Text));
                this.товарTableAdapter.Fill(this.складПомDataSet.Товар);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.товарTableAdapter.DeleteQuery(Convert.ToInt32(textBox6.Text));
                this.товарTableAdapter.Fill(this.складПомDataSet.Товар);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                this.товарTableAdapter.UpdateQuery(textBox11.Text, textBox9.Text, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox7.Text));
                this.товарTableAdapter.Fill(this.складПомDataSet.Товар);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                panel2.Visible = false;
                Товар.Visible=false;
                Поставщик.Visible = true;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
      
                this.поставкиTableAdapter.InsertQuery(dateTimePicker1.Value, Convert.ToInt32(listBox3.SelectedValue) * Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox12.Text),Convert.ToString(listBox1.SelectedValue), Convert.ToString(listBox2.SelectedValue));
                this.поставкиTableAdapter.Fill(this.складПомDataSet.Поставки);
            } 
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                this.поставкиTableAdapter.Cheapes(this.складПомDataSet.Поставки);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                this.поставкиTableAdapter.Fill(this.складПомDataSet.Поставки);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                textBox13.Text = this.поставкиTableAdapter.Dohod(Convert.ToDateTime(listBox4.SelectedValue)).ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                textBox13.Text = this.поставкиTableAdapter.MinAmount().ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                textBox13.Text = this.поставкиTableAdapter.CountPost(Convert.ToDateTime(listBox4.SelectedValue)).ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                this.поставкиTableAdapter.Search(this.складПомDataSet.Поставки, textBox14.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(логин.Text=="admin"&& пароль.Text=="admin")
            {
                Товар.Visible = true;
                Поставщик.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button17.Visible = true;
                panel4.Visible = true;
            }
            else if(логин.Text == "user" && пароль.Text == "user")
            {
                panel4.Visible = false;
                Товар.Visible = false;
                Поставщик.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button17.Visible = false;
                panel2.Visible = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Товар.Visible = false;
            Поставщик.Visible = false;
            panel2.Visible = true;
        }

        private void Справка_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this,"Справка курсач БД.chm");
        }
    }
}
