using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src
{
    class Clientess
    {
        private string nome;
        private string endereco;
        private int idade;
        private string profissao;
        private string nacionalidade;
        private string rg;

        public Clientess(int i, string n,string nac ,string e,string p, string r)
        {
            idade = i;
            nome = n;
            nacionalidade = nac;
            profissao = p;
            endereco = e;
            rg = r;
        }
        public string getNome()
        {
            return nome;
        }
        public string getNac()
        {
            return nacionalidade;
        }
        public string getPro()
        {
            return profissao;
        }
        public string getend()
        {
            return endereco;
        }
        public int getIdade()
        {
            return idade;
        }
        public string getRg()
        {
            return rg;
        }

        public void setNome(String n)
        {
            nome = n;
        }
        public void setNac(String nac)
        {
            nacionalidade = nac;
        }
        public void setPro( String pro)
        {
            profissao = pro;
        }
        public void setend(String end)
        {
            endereco = end;
        }
        public void setIdade(int i)
        {
            idade = i;
        }
        public void setRg(String r)
        {
            rg = r;
        }
    }
    
}
