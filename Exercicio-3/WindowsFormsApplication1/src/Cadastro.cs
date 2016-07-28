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
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Cadastro : Form
    {

        public Cadastro()
        {
            InitializeComponent();
        }


        private void Box_Leave(object sender, EventArgs e)
        {
            Valida v = new Valida();
            v.vVazio((TextBox)sender);
        }

        private void Box_Enter(object sender, EventArgs e)
        {
            var box = (TextBox)sender;
            box.BorderStyle = BorderStyle.Fixed3D;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            DbControl Db = new DbControl();
            Valida v = new Valida();
            if (v.vSalvar(EndBox, ProBox, IdadeBox, NacBox, NomeBox, rg))return;
            
            Clientess cli = new Clientess(int.Parse(IdadeBox.Text),NomeBox.Text, NacBox.Text, EndBox.Text, ProBox.Text, rg.Text);
            
            NomeBox.Text = String.Empty;
            IdadeBox.Text = String.Empty;
            ProBox.Text = String.Empty;
            EndBox.Text = String.Empty;
            NacBox.Text = String.Empty;
            rg.Text = String.Empty;

            Db.InsCli(cli);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
