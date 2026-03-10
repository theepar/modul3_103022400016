using System.Diagnostics.Eventing.Reader;

namespace Modul3_103022400016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double celtoFah(double suhu) 
        {
            return (suhu * 9 / 5) + 32 ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string suhuAwal = comboBox1.Text;
            string suhuAkhir = comboBox2.Text;
            string nilaiAwalText = textBox1.Text;


            if (suhuAwal == null)
            {
                Console.WriteLine("pilih suhu pertama");
            }
            else if (suhuAkhir == null) 
            {
                Console.WriteLine("pilih suhu kedua");
            }

            if (suhuAwal == "Celsius" && suhuAkhir == "Fahrenheit")
            {
                textBox2.Text = celtoFah(double.Parse(nilaiAwalText)).ToString();
            }
       
            else if (suhuAwal == "Fahrenheit" && suhuAkhir == "Celsius")
            {
                double nilaiAwal = double.Parse(nilaiAwalText);
                double nilaiAkhir = (nilaiAwal - 32) * 5 / 9;
                textBox2.Text = nilaiAkhir.ToString();
            }
            else if (suhuAwal == "Celsius" && suhuAkhir == "Kelvin")
            {
                double nilaiAwal = double.Parse(nilaiAwalText);
                double nilaiAkhir = nilaiAwal + 273;
                textBox2.Text = nilaiAkhir.ToString();
            }
            else if (suhuAwal == "Kelvin" && suhuAkhir == "Celsius")
            {
                double nilaiAwal = double.Parse(nilaiAwalText);
                double nilaiAkhir = nilaiAwal - 273;
                textBox2.Text = nilaiAkhir.ToString();
            }
            else if (suhuAwal == "Fahrenheit" && suhuAkhir == "Kelvin")
            {
                double nilaiAwal = double.Parse(nilaiAwalText);
                double nilaiAkhir = (nilaiAwal - 32) * 5 / 9 + 273;
                textBox2.Text = nilaiAkhir.ToString();
            }
            else if (suhuAwal == "Kelvin" && suhuAkhir == "Fahrenheit")
            {
                double nilaiAwal = double.Parse(nilaiAwalText);
                double nilaiAkhir = (nilaiAwal - 273) * 9 / 5 + 32;
                textBox2.Text = nilaiAkhir.ToString();
            }
            else if (suhuAwal == "Celsius" && suhuAkhir == "Reamur")
            {
                double nilaiAwal = double.Parse(nilaiAwalText);
                double nilaiAkhir = nilaiAwal * 4 / 5;
                textBox2.Text = nilaiAkhir.ToString();
            }
            else if (suhuAwal == "Reamur" && suhuAkhir == "Celsius")
            {
                double nilaiAwal = double.Parse(nilaiAwalText);
                double nilaiAkhir = nilaiAwal * 5 / 4;
                textBox2.Text = nilaiAkhir.ToString();
            }
            else if (suhuAwal == suhuAkhir)
            {
                double suhu = double.Parse(nilaiAwalText);
                textBox2.Text = suhu.ToString();
            }
             else
            {
                Console.WriteLine("pilih suhu yang valid");
            }
        }
       
    }
}
