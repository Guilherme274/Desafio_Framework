using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PrjGeradorClasses;

namespace TestesCadastroLivros
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ClasseNaoPreenchida()
        {
            
            List<string> lista = new List<string>();
            lista.Add("1");
            string mensagem = GeradorClassesBLL.ValidaDados("", lista);
                                       
            Assert.AreEqual("O nome da classe deve ser preenchido", mensagem);            
        }

        [TestMethod]
        public void PropriedadesNaoPreenchidas()
        {
            
            List<string> lista = new List<string>();
            string mensagem = GeradorClassesBLL.ValidaDados("teste", lista);
                       
            Assert.AreEqual("A lista de propriedades não pode estar vazia", mensagem);            
        }

        [TestMethod]
        public void PropriedadeComMesmoNomeDaClasse()
        {
            List<string> lista = new List<string>();
            lista.Add("teste");
            string mensagem = GeradorClassesBLL.ValidaDados("teste", lista);

            Assert.AreEqual("Uma propriedade não pode ser declarada com o mesmo nome da classe", mensagem);
        }

        [TestMethod]
        public void PropriedadesIguais()
        {
            List<string> lista = new List<string>();
            lista.Add("teste");         

            string mensagem = GeradorClassesBLL.ValidaDados("teste", lista);

            Assert.AreEqual("Não podem existir propriedades com o mesmo nome", mensagem);
        }
    }
}
