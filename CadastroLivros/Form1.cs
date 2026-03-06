using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp;

namespace CadastroLivros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox2.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {          
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultado = GeradorClassesBLL.ValidaDados(textBox2.Text, GeradorClassesBLL.ConverteListaParaString(listBox1.Items));

            if (textBox1.Text != textBox2.Text)
                if (resultado == "Ok")
                    listBox1.Items.Add(textBox2.Text);
                else
                    MessageBox.Show(resultado);
            else
                MessageBox.Show("O nome da classe e da propriedade devem ser diferentes");

            textBox2.Clear();
            textBox2.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nomeClasse = textBox1.Text;
            List<string> props = new List<string>();
        
            foreach(var propriedade in listBox1.Items){
                props.Add(propriedade.ToString());
            }

            string resultado = GeradorClassesBLL.ValidaDados(nomeClasse, props);
            
            if (resultado == "Ok" && props.Count > 0) GeradorClasses.GerarClasse(nomeClasse, props,radioButton1.Checked); else MessageBox.Show(resultado);
            
            textBox1.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count > 0) 
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);

            textBox2.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
