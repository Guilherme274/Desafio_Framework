using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjGeradorClasses
{
     public class GeradorClasses
    {
        public static void GerarClasse(string nomeClasse, List<string> props, bool temConstrutor)
        {
            string propriedades = "";
            string construtor = "";

            if (temConstrutor)
            {
                construtor = $"public {nomeClasse} (){{}}";
            }

            foreach (var prop in props)
            {                                
                propriedades += $"\npublic String {prop.Replace(" ", "_")} {{ get; set; }}";
            }

            string codigo = $@"using System; 

public class {nomeClasse}
{{ 
{propriedades}
{construtor}
}}";

            string caminhoExe = AppDomain.CurrentDomain.BaseDirectory;
            string caminhoProjeto = Path.GetFullPath(Path.Combine(caminhoExe, @"..\..\"));

            Console.WriteLine(caminhoProjeto);

            string caminho = $"{caminhoProjeto}{nomeClasse}.cs";
            System.IO.File.WriteAllText(caminho, codigo);
            MessageBox.Show("Arquivo .cs criado! Adicione-o ao projeto para vê-lo no Visual Studio.");
        }
    }
}
