using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario.c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string ruta_archivo = "C:\\Users\\luisa\\Downloads\\datos.txt";
            bool archivo_existe = File.Exists(ruta_archivo);

            InitializeComponent();

            using (StreamWriter writer = new StreamWriter(ruta_archivo, true))
                if (archivo_existe)
                {
                    writer.WriteLine();
                }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            string genero = "  ";

            if (radioButton1.Checked)
            {
                genero = "hombre";

            }
            else if (radioButton2.Checked)
            {
                genero = "Mujer";
            }
            string nombres = textBox1.Text;
            string apelli = textBox2.Text;
            string tel = textBox3.Text;
            string estatu = textBox5.Text;
            string edad = textBox4.Text;

            string datos = $"Nombres: {nombres}\r\nApellidos: {apelli}\r\nTelefono. {tel}\r\nEstatura: {estatu}cm\r\nedad: {edad}años\r\nGenero:{genero}\r\n";
            Console.WriteLine(datos);
            MessageBox.Show("datos guardados con exito:\n\n" + datos, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
