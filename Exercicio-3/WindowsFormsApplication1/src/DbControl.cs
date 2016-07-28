using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1.src
{
    class DbControl
    {
        
        public void InsCli(Clientess cli)
        {
            try
            {
                
                using (var db = new ClienteEntities())
                {

                    var dbCli = new cliente()
                    {
                        nome = cli.getNome(),
                        endereco = cli.getend(),
                        idade = cli.getIdade(),
                        nacionalidade = cli.getNac(),
                        profissao =  cli.getPro(),
                        rg = cli.getRg()
                    };
                    db.cliente.Add(dbCli);
                    db.SaveChanges();
                    MessageBox.Show("Cliente cadastrado com sucesso");
                }
            }
            catch (Exception err)
            {
                excecoes(err);
            }
        }
        public void SelCli(String U, DataGridView GridBD )
        {
            try
            {
                using (var context = new ClienteEntities())
                {

                    if (U != string.Empty)
                    {
                        var query = from cliente in context.cliente
                                    where cliente.nome.Contains(U)
                                    select new
                                    {
                                        cliente.nome,
                                        cliente.rg,
                                        cliente.nacionalidade,
                                        cliente.idade,
                                        cliente.endereco,
                                        cliente.profissao,
                                        
                                    };
                        GridBD.DataSource = query.ToList();
                    }
                    else
                    {
                        SelAll(GridBD);
                    }
                }
                
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.InnerException.ToString());
            }
        }
        public void SelAll(DataGridView GridBD)
        {
            try
            {
                using (var context = new ClienteEntities())
                {
                    var query = from cliente in context.cliente
                                select new
                                {
                                    cliente.nome,
                                    cliente.rg,
                                    cliente.nacionalidade,
                                    cliente.idade,
                                    cliente.endereco,
                                    cliente.profissao
                                };
                    GridBD.DataSource = query.ToList();
                }
            }
            catch (Exception err)
            {
                excecoes(err);
            }
        }

        public void Delete(string rg)
        {
            using (var context = new ClienteEntities())
            {
                var query = from cliente in context.cliente
                            where cliente.rg == rg
                            select cliente;
                foreach (var teste in query)
                {
                    context.cliente.Remove(teste);
                }
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Exclusão Efetuada com Sucesso");
                }
                catch (Exception err)
                {

                    excecoes(err);

                }
            }
        }

        public void alterCli(string r, int index, Clientess LocalCli)
        {
            using (var context = new ClienteEntities())
            {
                var query = from cliente in context.cliente
                                   where cliente.rg == r
                                   select cliente;
                foreach (cliente c in query)
                {
                    c.nome = LocalCli.getNome();
                    c.rg = LocalCli.getRg();
                    c.nacionalidade = LocalCli.getNac();
                    c.idade = LocalCli.getIdade();
                    c.endereco = LocalCli.getend();
                    c.profissao = LocalCli.getPro();
                }
                try
                {
                    context.SaveChanges();
                }
                catch(Exception err)
                {
                    excecoes(err);
                }

            }
        }
        public void excecoes(Exception err)
        {
            if (err.InnerException.ToString().Contains("Violação da restrição UNIQUE KEY"))
            {
                MessageBox.Show("Não foi possivel cadastrar, RG ja existe");
            }
            else
            {
                if (err.InnerException.ToString().Contains("The underlying provider failed on Open"))
                {
                    MessageBox.Show("O Banco de dados não esta ativo");
                }
                else
                {
                    if (err.InnerException.ToString().Contains("O servidor não foi encontrado ou não estava acessível"))
                    {
                        MessageBox.Show("O banco não existe ou não esta acessivel");
                    }
                }
            }
        }
    }
}
