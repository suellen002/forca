using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Forca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string palavraoculta;
        private ArrayList listaletrasUsadas = new ArrayList();
        private int contadorErros=0;
        Random rndSorteio = new Random(DateTime.Now.Millisecond);
        private ArrayList listaPalavras = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            limparControles();
            listaPalavras.Add("branco");
            listaPalavras.Add("vermelho");
            listaPalavras.Add("verde");
            listaPalavras.Add("azul");
            listaPalavras.Add("amarelo");
            listaPalavras.Add("roxo");
            listaPalavras.Add("rosa");
            listaPalavras.Add("preto");

        }

        private void reiniciar()
        {
            limparControles();
            contadorErros = 0;
            textBox1.Enabled = true;
            button1.Enabled = false;
            lblGameOver.Visible = false;
            listaletrasUsadas.Clear(); // limpar lista
        }

        private void limparControles()
        {
            //limpando os controles
            lblLetrasUsadas.Text = "";
            lblMascara.Text = "";
            pictureBox1.Image = imageList1.Images[0];
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            reiniciar();
            button1.Visible = false;

            //escolher uma palavra
            palavraoculta = listaPalavras[rndSorteio.Next(listaPalavras.Count)].ToString();
            palavraoculta = palavraoculta.ToUpper();
            exibirTextoMascarado();
        }


        private void exibirLetrasUsadas()
        {
            string tmp = "";
            for (int i = 0; i<listaletrasUsadas.Count; i++ )
            {
                tmp += listaletrasUsadas[i].ToString() + " " ;
            }
            lblLetrasUsadas.Text = tmp;
        }

        private void exibirTextoMascarado()
        {
            //palavraoculta
            //lblMascara
            string mascara = "";
            for (int i = 0; i < palavraoculta.Length; i++)
            {

               if (listaletrasUsadas.Contains(palavraoculta[i].ToString())){
                   mascara += palavraoculta[i] + " ";
               }
               else
               {
                   mascara += "_ ";
               }
            }
            lblMascara.Text = mascara;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string letra = textBox1.Text;
            letra = letra.ToUpper();
            
            textBox1.Text = "";

            if (!listaletrasUsadas.Contains(letra))
            {
                listaletrasUsadas.Add(letra);

                exibirLetrasUsadas();
                exibirTextoMascarado();

                //verificar se a letra existe na palavra
                if (palavraoculta.IndexOf(letra) != -1)
                {

                    if (lblMascara.Text.Replace(" ", "") == palavraoculta)
                    {
                        lblGameOver.Text = "You win!";
                        lblGameOver.ForeColor = Color.Green;
                        lblGameOver.Visible = true;
                        button1.Text = "Jogar novamente";
                        button1.Visible = true;
                        textBox1.Enabled = false;
                        button1.Enabled = true;
                    }
                }
                else
                {
                    //Console.WriteLine("N achou");
                    contadorErros++;
                    pictureBox1.Image = imageList1.Images[contadorErros];
                    if (contadorErros == 6)
                    {
                        textBox1.Enabled = false;
                        button1.Enabled = true;
                        lblGameOver.Visible = true;
                        lblGameOver.ForeColor = Color.Red;
                        lblGameOver.Text = "Gamer over!";
                        button1.Text = "Jogar novamente";
                        button1.Visible = true;
                    }
                }
            }
        }
    }
}
