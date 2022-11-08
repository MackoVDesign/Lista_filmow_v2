using System.Drawing.Text;

namespace Lista_filmów
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void hobbitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = {textBox1.Text, textBox2.Text, dateTimePicker1.Text, textBox3.Text};
            var listView = new ListViewItem(row);
            listView1.Items.Add(listView);
        }




        private void button2_Click(object sender, EventArgs e)
        {



            string[] linie = new string[listView1.Items.Count];
            int i = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                linie[i] = "";
                for (int j = 0; j < item.SubItems.Count; j++)
                    linie[i] += item.SubItems[j].Text + "";
                i++;
            }

            File.WriteAllLines("lista_filmow.txt", linie);
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usunWybraneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }
    }
}
