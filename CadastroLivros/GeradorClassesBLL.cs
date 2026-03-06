using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CadastroLivros
{
    public class GeradorClassesBLL
    {
        public static string ValidaDados(string nomeClasse, List<string> propriedades)
        {
            if (nomeClasse.Equals("")) return "O nome deve ser preenchido";
            for (int i = 0; i < 10; i++)
                if (nomeClasse.Contains(i.ToString())) return "Não são aceitos valores numéricos em nomes de classes e propriedades";
            if (propriedades.Contains(nomeClasse)) return "Não podem existir propriedades com o mesmo nome";
            if (Regex.IsMatch(nomeClasse, @"[^a-zA-Z0-9]")) return "Não são permitidos acentuações e caracteres especiais.";
            
            foreach (string prop in propriedades)            
                if(prop.Contains(nomeClasse)) return "Uma propriedade não pode ser declarada com o mesmo nome da classe";           

            return "Ok";
        }

        public static List<string> ConverteListaParaString(ListBox.ObjectCollection listBox)
        {
            List<string> props = new List<string>();
            foreach(var prop in listBox)
                props.Add(prop.ToString());

            return props;
        }
    }
}
