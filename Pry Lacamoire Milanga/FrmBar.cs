using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_Lacamoire_Milanga
{
    public partial class frmBar : Form
    {
        public int[,] matMozos = new int[5, 4];
        public int[] vecTotales = new int[10];
        public frmBar()
        {
            InitializeComponent();
        }

        private void dgvMozosyArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void FrmBar_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                dgvMozosyArticulos.Rows.Add();
            }
            dgvMozosyArticulos.Rows[0].Cells[0].Value = "Julio";
            dgvMozosyArticulos.Rows[1].Cells[0].Value = "Esteban";
            dgvMozosyArticulos.Rows[2].Cells[0].Value = "Javier";
            dgvMozosyArticulos.Rows[3].Cells[0].Value = "Gonzalo";
            dgvMozosyArticulos.Rows[4].Cells[0].Value = "Alberto";
            dgvMozosyArticulos.Columns[0].ReadOnly = true;
        }

        private void cmdValidar_Click(object sender, EventArgs e)
        {
            int fila = 0;
            int columna = 0;
            int i = 0;
            int colmat = 0;
            for (fila = 0; fila < 4; fila++)
            {
                for (columna = 0; columna < 4; columna++)
                {
                    if (dgvMozosyArticulos.Rows[fila].Cells[columna].Value == null || dgvMozosyArticulos.Rows[fila].Cells[columna].Value == "")
                    {
                        i++;
                    }

                }
            }
            if (i == 0)
            {
                fila = 0;
                columna = 1;
                while (fila <= 4)
                {
                    while (columna <= 4 && colmat <= matMozos.GetLength(1))
                    {
                        matMozos[fila, colmat] = Convert.ToInt32(dgvMozosyArticulos.Rows[fila].Cells[columna].Value);
                        colmat++;
                        columna++;
                    }
                    columna = 1;
                    colmat = 0;
                    fila++;
                }
                cmdMozodelDia.Enabled = true;
                cmdTotal.Enabled = true;
            }
            else
            {
                cmdTotal.Enabled = false;
                cmdMozodelDia.Enabled = false;
                MessageBox.Show("Recuerde rellenar todos los campos y solo ingresar valores NUMÉRICOS.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdMozodelDia_Click(object sender, EventArgs e)
        {
            int fila = 0;
            int columna = 0;
            int suma = 0;
            int mozo = 0;
            int mayor = 0;
            while (fila < matMozos.GetLength(0))
            {
                while (columna < matMozos.GetLength(1))
                {
                    suma = suma + matMozos[fila, columna];
                    columna++;
                }
                vecTotales[fila] = suma;
                columna = 0;
                fila++;
                suma = 0;


            }

            fila = 0;
            mayor = vecTotales[0];
            for (fila = 0; fila <= 4; fila++)
            {
                if (vecTotales[fila] >= mayor)
                {
                    mayor = vecTotales[fila];
                    mozo = fila;
                }
            }
            if (mozo == 0)
            {
                txtMozo.Text = "Julio";
                txtTotal.Text = Convert.ToString(mayor);
            }
            else
            {
                if (mozo == 1)
                {
                    txtMozo.Text = "Esteban";
                    txtTotal.Text = Convert.ToString(mayor);
                }


                if (mozo == 2)
                {
                    txtMozo.Text = "Javier";
                    txtTotal.Text = Convert.ToString(mayor);
                }


                if (mozo == 3)
                {
                    txtMozo.Text = "Gonzalo";
                    txtTotal.Text = Convert.ToString(mayor);
                }


                if (mozo == 4)
                {
                    txtMozo.Text = "Alberto";
                    txtTotal.Text = Convert.ToString(mayor);
                }



            }
        }

        private void cmdTotal_Click(object sender, EventArgs e)
        {
            int fila = 0;
            int columna = 0;
            int suma = 0;
            int i = 5;
            int total = 0;
            while (columna < matMozos.GetLength(1) && i <= 9)
            {
                suma = 0;
                while (fila < matMozos.GetLength(0))
                {
                    suma = suma + matMozos[fila, columna];
                    fila++;
                }
                vecTotales[i] = suma;
                total = total + suma;
                fila = 0;
                columna++;
                i++;
            }
            vecTotales[9] = total;

            txtComidas.Text = Convert.ToString(vecTotales[5]);
            txtBebidasSinAlcohol.Text = Convert.ToString(vecTotales[6]);
            txtBebidasAlcoholicas.Text = Convert.ToString(vecTotales[7]);
            txtPostres.Text = Convert.ToString(vecTotales[8]);
            txtSumaTotal.Text = Convert.ToString(vecTotales[9]);
        }

        private void dgvMozosyArticulos_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dgvMozosyArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void dgvMozosyArticulos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}