using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.src
{
    class Valida
    {

        public bool vVazio(TextBox texto)
        {
            if (string.IsNullOrWhiteSpace(texto.Text))
            {
                texto.BorderStyle = BorderStyle.FixedSingle;
                return true;
            }
            return false;
        }
        public void m(string men, TextBox temp)
        {
            MessageBox.Show(men);
            temp.Focus();
        }
        public bool vSalvar(TextBox e, TextBox p, TextBox i, TextBox nac, TextBox n, TextBox rg)
        {
            if (vVazio(n))
            {
                m("Preencha o nome antes de salvar", n);
                return true;
            }

            if (vVazio(nac))
            {
                m("Preencha a nacionalidade antes de salvar",nac);
                return true;
            }

            if (vVazio(e))
            {
                m("Preencha o endereço antes de salvar",e);
                return true;
            }

            if (vVazio(p))
            {
                m("Preencha a profissão antes de salvar",p);
                return true;
            }

            if (!vVazio(rg))
            {
                if(rg.Text.Length != 7)
                {
                    m("Rg invalido",rg);
                    return true;
                }
            }else
            {
                m("Rg vazio",rg);
                return true;
            }

            int a = new int();
            if (!vVazio(i))
            {
                if (int.TryParse(i.Text, out a))
                {
                    if (a < 0 || a > 120)
                    {
                        m("Idade invalida",i);
                        return true;
                    }
                }
                else
                {
                    m("Idade invalida",i);
                    return true;
                }
            }
            else
            {
                m("Preencha a idade antes de salvar",i);
                return true;
            }

            return false;
        }
    }

}
