using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.src;

namespace WindowsFormsApplication1
{
    public partial class Consulta : Form
    {

        public Consulta()
        {
            InitializeComponent();

            
        }

        private void textBox1_Enter(object sender, KeyEventArgs e)
        {
            DbControl Controlador = new DbControl();
            TextBox t = (TextBox)sender;
            if (e.KeyCode == Keys.Enter ) {
                    Controlador.SelCli(t.Text, GridBD);
            }
        }

        private void deletar_Click(object sender, EventArgs e)
        {
           if(GridBD.SelectedCells.Count > 0) { 
                int row = GridBD.CurrentCell.RowIndex;
                DbControl Controlador = new DbControl();
                Controlador.Delete(GridBD.Rows[row].Cells[1].Value.ToString());
                Controlador.SelCli(textBox1.Text.ToString(), GridBD);
            }
            else
            {
                MessageBox.Show("Selecione alguma linha");
            }
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
           
            if (GridBD.SelectedCells.Count > 0)
            {
                int AtuRow = GridBD.CurrentCell.RowIndex;
                DbControl Controlador = new DbControl();

                alterar alt = new alterar((DataGridViewCellCollection)GridBD.Rows[AtuRow].Cells);
                alt.ShowDialog();

                Clientess LocalCli = (Clientess)alt.get();

                if (LocalCli.getNome() != "")
                {
                    Controlador.alterCli(GridBD.Rows[AtuRow].Cells[1].Value.ToString(), AtuRow, LocalCli);
                    Controlador.SelCli(textBox1.Text, GridBD);
                }
                else
                {
                    return;
                }
             }
            else
            {
                MessageBox.Show("Selecione alguma linha");
                return;
            }
        }
    }
}
