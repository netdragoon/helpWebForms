using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Mail;
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
        internal string fileInfoTam(long length)
        {
            double value = (length / 1024);
            string label = "Kb";
            if ((length / 1024) > 1024)
            {
                value = ((length / 1024) / 1024);
                label = "Mb";
            }

            return string.Format("{0} {1}", Math.Round(value, 4), label);
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
        private long LenghtFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileInfo info = new FileInfo(fileName);
                return info.Length;
            }
            return 0;
        }

        AttachmentAndFileInfoList attFileInfo = new AttachmentAndFileInfoList();
        IList<Attachment> attachmentList;

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                attFileInfo.Add(new AttachmentAndFileInfo(openFileDialog1.FileName));
            }
            dataGridView1.DataSource = attFileInfo.ToSelectList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            attachmentList = attFileInfo.AttachmentToList();
        }
    }
}
