using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MetodosOrdenamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] numeros;
        public int aux;
        public string cargando = "";
        int iteraciones = 0;
        private void MergeSort(List<int> arr)
        {
            //if (arr.Count <= 1)
            //{
            //    return;
            //}
            //var mitad = Math.Round(arr.Count / 2);

        }
        private void Merge()
        {
            int izq = (numeros.Length) / 2;
            int der = (numeros.Length) - izq;
            var izqArray = new int[izq];
            var derArray = new int[der];

            Array.Copy(numeros, 0, izqArray, 0, izqArray.Length); // se le asigna valores de el array numeros 
            Array.Copy(numeros, izqArray.Length, derArray, 0, derArray.Length);

            int i = 0;
            int j = 0;
            int a = 0;

            Stopwatch time = new Stopwatch();
            time.Start();

            while (i < izq && j < der)
            {
                iteraciones++;
                if (i < izq && (j >= der || izqArray[i] <= derArray[j]))
                {
                    numeros[a++] = izqArray[i++];
                }
                else if (j < der)
                {
                    numeros[a++] = derArray[j++];
                }
            }

            time.Stop();
            dgvMetodos.Rows.Add("Merge Sort", iteraciones, time.Elapsed.TotalMilliseconds, txtVector.Text);
            txtIteraciones.Text = iteraciones.ToString();
            txtTiempo.Text = time.Elapsed.TotalMilliseconds.ToString();
            iteraciones = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtVector.Text != "")
            {
                int l = Convert.ToInt32(txtVector.Text);
                numeros = new int[l];
                Random random = new Random();
                for (int i = 0; i < numeros.Length; i++)
                {
                    numeros[i] = random.Next(0, 100);

                }
                MessageBox.Show("Vector Creado");
            }
            else
            {
                MessageBox.Show("Ingresar un numero de elementos");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int iteraciones = 0;
            if (optBubble.Checked == true)
            {
                Stopwatch time = new Stopwatch();
                time.Start();
                for (int i = 0; i < numeros.Length; i++)
                {
                    iteraciones++;
                    for (int J = 0; J < numeros.Length - 1 - i; J++)
                    {
                        if (numeros[J] > numeros[J + 1])
                        {
                            aux = numeros[J];
                            numeros[J] = numeros[J + 1];
                            numeros[J + 1] = aux;

                        }
                        iteraciones++;
                    }
                }
                time.Stop();
                dgvMetodos.Rows.Add("Bubble Sort", iteraciones, time.Elapsed.TotalMilliseconds, txtVector.Text);
                txtIteraciones.Text = iteraciones.ToString();
                txtTiempo.Text = time.Elapsed.TotalMilliseconds.ToString();
                iteraciones = 0;
            }

            if (optQuick.Checked == true)
            {

            }

            if (optMerge.Checked == true)
            {


            }
        }
    }
}
