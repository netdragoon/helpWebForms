using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WindowsAppCsharp.Model;
using WindowsAppCsharp.ViewModel;

namespace WindowsAppCsharp
{
    public partial class Form1 : Form
    {
        protected DatabaseContext Database;        
        protected BindingList<PessoaViewModel> PessoasBindingList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Database == null)
            {
                Database = new DatabaseContext();
            }
            Call_Grid();
        }

        private void Call_Grid()
        {
            PessoasBindingList = new BindingList<PessoaViewModel>(
                Database.Pessoas.Select(c => new PessoaViewModel
            {
                Id = c.Id,
                Nome = c.Nome
            }).ToList());
                        
            DataGridViewPessoas.DataSource = PessoasBindingList;
            DataGridViewPessoas.Update();
            DataGridViewPessoas.Refresh();
            Update();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Database != null)
            {
                Database.Dispose();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.Nome = TxtNome.Text;
            Database.Pessoas.Add(p);
            Database.SaveChanges();
            PessoasBindingList.Add(new PessoaViewModel()
            {
                Id = p.Id,
                Nome = p.Nome
            });
            
            
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(TxtId.Text);
            Pessoa p = Database.Pessoas.Find(Id);
            p.Nome = TxtNome.Text;
            Database.Entry(p).State = System.Data.Entity.EntityState.Modified;
            Database.SaveChanges();
            PessoasBindingList
                .Where(c => c.Id == Id)
                .FirstOrDefault()
                .Nome = TxtNome.Text;
        }
    }
}
