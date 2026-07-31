namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Juan");
            listBox1.Items.Add("María");
            listBox1.Items.Add("Pedro");
            listBox1.Items.Add("Ana");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int presentes = 0;

            int ausentes = 0;

            string nombres = "";

            if (checkBox1.Checked)
            {
                presentes++;
                nombres = nombres + "Juan\n";
            }
            else
            {
                ausentes++;
            }
            if (checkBox2.Checked)
            {
                presentes++;
                nombres = nombres + "María\n";
            }
            else
            {
                ausentes++;
            }
            if (checkBox3.Checked)
            {
                presentes++;
                nombres = nombres + "Pedro\n";
            }
            else
            {
                ausentes++;
            }
            if (checkBox4.Checked)
            {
                presentes++;
                nombres = nombres + "Ana\n";
            }
            else
            {
                ausentes++;
            }
            label1.Text = "Presentes: " + presentes +

                                "\nAusentes: " + ausentes +

                                "\n\nEstudiantes presentes:\n" + nombres;
        }
    }
}
