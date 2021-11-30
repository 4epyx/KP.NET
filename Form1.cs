using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Form1 : Form
    {
        public Graph CurrentGraph;
        public String StartVertex;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            pictureBox1.Image = Image.FromFile(@"C:\Users\Пукурузная калочка\source\repos\Kursach\Resources\graph1.png");
            CurrentGraph = Graphs.G1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Choose_Vertex vForm = new Choose_Vertex();
            vForm.Owner = this;
            vForm.ShowDialog();
            if (!button1.Enabled)
            {
                byte[,] AMatrix = CurrentGraph.getAMatrix();

                char[] VNames = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                richTextBox1.Text = "Матрица смежности:\n";
                richTextBox1.Text += "  A B C D E F G\n";
                for (int i = 0; i < AMatrix.GetLength(0); i++)
                {
                    richTextBox1.Text += VNames[i] + " ";
                    for (int j = 0; j < AMatrix.GetLength(0); j++)
                    {
                        richTextBox1.Text += $"{AMatrix[i, j]} ";
                    }
                    richTextBox1.Text += "\n";
                }

                List<Vertex> Contur = CurrentGraph.GetContur(StartVertex);
                if (Contur.Count <= 0)
                {
                    richTextBox1.Text += "Контур из данной точки не найден.";
                }
                else
                {
                    richTextBox1.Text += "Контур:\n";
                    richTextBox1.Text += Contur[0].getName();
                    for (int i = 1; i < Contur.Count; i++)
                    {
                        richTextBox1.Text += "-" + Contur[i].getName();
                    }
                }
            }
            else
            {
                richTextBox1.Text = "Граф не выбран";
            }
        }


        
    }
}
