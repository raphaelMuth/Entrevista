using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.src
{
    public partial class alterar : Form
    {
        Clientess Cli, Aux;
        public alterar(DataGridViewCellCollection cells)
        {
            
            Cli = new Clientess(1, "", "", "", "", "");
            Aux = new Clientess(
                int.Parse(cells[3].Value.ToString()),
                cells[0].Value.ToString(),
                cells[2].Value.ToString(),
                cells[4].Value.ToString(),
                cells[5].Value.ToString(),
                cells[1].Value.ToString());

            InitializeComponent();

            label7.Text = Aux.getNome();
            label8.Text = Aux.getNac();
            label9.Text = Aux.getend();
            label10.Text = Aux.getPro();
            label11.Text = Aux.getIdade().ToString();
            label12.Text = Aux.getRg();

        }

        private void Box_leave(object sender, EventArgs e)
        {
            Valida v = new Valida();
            v.vVazio((TextBox)sender);
        }

        private void Box_Enter(object sender, EventArgs e)
        {
            var box = (TextBox)sender;
            box.BorderStyle = BorderStyle.Fixed3D;
        }

        private void BtnSlv_Click(object sender, EventArgs e)
        {
            DbControl Db = new DbControl();
            Valida v = new Valida();
            if (v.vSalvar(EndBox, ProBox, IdadeBox, NacBox, NomeBox, rg)) return;

            Cli = new Clientess(int.Parse(IdadeBox.Text), NomeBox.Text, NacBox.Text, EndBox.Text, ProBox.Text, rg.Text);

            this.Close();
        }

        public object get()
        {
            return Cli;
        }
    }
}
