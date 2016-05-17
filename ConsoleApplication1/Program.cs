using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linhas = File.ReadAllLines(".\\Base.txt");            
            int numero = 0;
            Dictionary<int, string> items = new Dictionary<int, string>(linhas.Count());
            
            foreach (string linha in linhas)
            {
                numero = int.Parse(linha.Substring(10, 6).TrimStart().TrimEnd().Trim());
                items.Add(numero, linha);
            }

            File.WriteAllLines(".\\BaseOrdenada.txt", items.OrderBy(c => c.Key).Select(c => c.Value).ToArray());
        }
    }
}
