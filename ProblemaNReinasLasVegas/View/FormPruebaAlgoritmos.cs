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

namespace ProblemaNReinasLasVegas
{
    public partial class FormPruebaAlgoritmos : Form
    {
        private Stopwatch timeMeasure;
        private List<List<int>> resultado;
        private String[] resultadosData;
        public FormPruebaAlgoritmos()
        {
            InitializeComponent();
        }

        private void EjecutarAlgoritmoBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;
            int numeroReinas = (int)this.spinBoxNReinas.Value;
            timeMeasure = new Stopwatch();
            //Bcktg Las Vegas FIX
            Console.WriteLine("Las vegas Fix");
            {
                timeMeasure.Restart();
                resultado = Logica.ProblemaNReinas.nReinas(numeroReinas, 2);
                timeMeasure.Stop();
                resultadosData = new string[3];
                resultadosData[0] = "Bcktg Las Vegas FIX: ";
                resultadosData[2] = $" {timeMeasure.Elapsed.TotalSeconds} s";
                foreach (List<int> n in resultado)
                {
                    foreach (int number in n)
                    {
                        resultadosData[1] += number + " ";
                    }
                }
                row = (DataGridViewRow)GridViewResultadosData.Rows[0].Clone();
                row.Cells[0].Value = resultadosData[0];
                row.Cells[1].Value = resultadosData[1];
                row.Cells[2].Value = resultadosData[2];
                GridViewResultadosData.Rows.Add(row);
            }
            //Bcktg Las Vegas
            Console.WriteLine("Las vegas");
            {/*
                timeMeasure.Restart();
                resultado = Logica.ProblemaNReinas.nReinas(numeroReinas, 1);
                timeMeasure.Stop();
                resultadosData = new string[3];
                resultadosData[0] = "Bcktg Las Vegas: ";
                resultadosData[2] = $" {timeMeasure.Elapsed.TotalSeconds} s";
                foreach (List<int> n in resultado)
                {
                    foreach (int number in n)
                    {
                        resultadosData[1] += number + " ";
                    }
                }
                row = (DataGridViewRow)GridViewResultadosData.Rows[0].Clone();
                row.Cells[0].Value = resultadosData[0];
                row.Cells[1].Value = resultadosData[1];
                row.Cells[2].Value = resultadosData[2];
                GridViewResultadosData.Rows.Add(row);*/
            }
            //Backtracking
            Console.WriteLine("Backtracking");
            {   
                timeMeasure.Start();
                resultado = Logica.ProblemaNReinas.nReinas(numeroReinas, 0);
                timeMeasure.Stop();
                resultadosData = new string[3];
                resultadosData[0] = "Backtracking: ";
                resultadosData[2] = $"{timeMeasure.Elapsed.TotalSeconds} s";
                foreach (List<int> n in resultado)
                {
                    foreach (int number in n)
                    {
                        resultadosData[1] += number + " ";
                    }
                }
                row = (DataGridViewRow)GridViewResultadosData.Rows[0].Clone();
                row.Cells[0].Value = resultadosData[0];
                row.Cells[1].Value = resultadosData[1];
                row.Cells[2].Value = resultadosData[2];
                GridViewResultadosData.Rows.Add(row);
            }
            
        }
    }
}
