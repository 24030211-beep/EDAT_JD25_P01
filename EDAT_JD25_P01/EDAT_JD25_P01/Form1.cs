namespace EDAT_JD25_P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Sueldo_TextChanged(object sender, EventArgs e)
        {

        }


        private void BGenerarDatos_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();

            string[] nombres = { "Ximena", "Luis", "Gael", "Rodrigo", "Fernanda" };
            int[] numeros = { 1234, 8940, 1023, 56748, 3495 };
            double[] sueldo = { 10.546, 9.785, 20.894, 15.467, 24.987 };
            char[] grupo = { '1', '2', '3', '4', '5' };
            bool[] seguromedico = { true, false };


            Random rnd = new Random();
            empleado.Nombre = nombres[rnd.Next(nombres.Length)];
            empleado.Numero = numeros[rnd.Next(numeros.Length)];
            empleado.Sueldo = sueldo[rnd.Next(sueldo.Length)];
            empleado.Grupo = grupo[rnd.Next(grupo.Length)];
            empleado.SeguroMedico = seguromedico[rnd.Next(seguromedico.Length)];
            empleado.FechaNacimiento = new DateTime(rnd.Next(1977, 2005), rnd.Next(1, 13), rnd.Next(1, DateTime.DaysInMonth(rnd.Next(1977, 2005), rnd.Next(1, 13)) + 1));
            FechaNacimiento.Text = empleado.FechaNacimiento.ToShortDateString();


            if (empleado.Nombre == "Ximena" || empleado.Nombre == "Fernanda")
            {
                Sexo2.Checked = true;
            }
            else
            {
                Sexo.Checked = true;
            }


            Nombre.Text = empleado.Nombre;
            Numero.Text = empleado.Numero.ToString();
            Sueldo.Text = "$ " + empleado.Sueldo.ToString();
            Grupo.Items.Add(empleado.Grupo);
            Grupo.Text = empleado.Grupo.ToString();
            SeguroMedico.Checked = (empleado.SeguroMedico);
        }

        public class Empleado
        {

            public string Nombre { get; set; }
            public int Numero { get; set; }

            public char Grupo { get; set; }

            public double Sueldo { get; set; }

            public bool SeguroMedico { get; set; }

            public string Sexo { get; set; }
            public string Sexo2 { get; set; }

            public DateTime FechaNacimiento { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Grupo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
