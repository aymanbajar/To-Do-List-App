
using System.Data;
namespace To_Do_List_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable todolist = new DataTable();
        bool isEditing = false;



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            todolist.Columns.Add("Title");
            todolist.Columns.Add("Discription");

            dataGridView1.DataSource = todolist;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isEditing = true;
            textBox1.Text = todolist.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
            textBox2.Text = todolist.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                todolist.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error " + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todolist.Rows[dataGridView1.CurrentCell.RowIndex]["Title"] = textBox1.Text;
                todolist.Rows[dataGridView1.CurrentCell.RowIndex]["Discription"] = textBox2.Text;

            }
            else
            {
                todolist.Rows.Add(textBox1.Text,textBox2.Text);

            }
            textBox1.Text = "";
            textBox2.Text = "";
            isEditing = false;
        }
    }
}
