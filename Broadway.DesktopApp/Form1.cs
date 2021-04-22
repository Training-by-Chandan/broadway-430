using System;
using System.Windows.Forms;

namespace Broadway.DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SimpleBtn.Click += SimpleBtn_Click;
            SimpleBtn.Click += SimpleBtn_Click1;

            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged1;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged2;
        }

        private void CheckBox1_CheckedChanged2(object sender, EventArgs e)
        {
            comboBox1.Items.Add(checkBox1.Checked.ToString());
        }

        private void CheckBox1_CheckedChanged1(object sender, EventArgs e)
        {
            listBox1.Items.Add(checkBox1.Checked.ToString());
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = checkBox1.Checked.ToString();
        }

        private void SimpleBtn_Click1(object sender, EventArgs e)
        {
            label1.Text = "All good here";
        }

        private void SimpleBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All good here");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Iam good");
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void SimpleBtn_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var main = new FormMain();
            main.Show();
        }
    }
}