using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TreinoForms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            btnEnter.Visible = false;
            panel2fundo.Visible = false;
            panel2.Visible = false;
            campoTexto3.ReadOnly = true;
            Sorteio.Carregar();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int iParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            
        }

        private void CampoTexto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (panel2fundo.Visible == false)
            {
                panel2fundo.Visible = true;
                panel2.Visible = false;
            }
            else
            {
                panel2fundo.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(textBox1.Text);
                string nome = textBox2.Text;
                string endereco = textBox3.Text;
                string contato = textBox4.Text;

                Participantes pessoas = new Participantes(numero, nome, endereco, contato);
                Sorteio.participantes.Add(pessoas);
                Sorteio.Salvar();
                MessageBox.Show("Adição concluída!");
                textBox1.Clear();
                textBox4.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch
            {
                MessageBox.Show("Errouuuuu");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panel2fundo.Visible == false)
            {
                panel2.Visible = true;
                panel2fundo.Visible = true;
                panel3.Visible = false;
            }
            else
            {
                panel2fundo.Visible = false;
                panel2.Visible = false;
            }

            campoTexto3.Clear();
            campoTexto3.Text += $"Número de participantes: {Sorteio.participantes.Count}\r\n\r\n";

            if (Sorteio.participantes.Count > 0)
            {
                int id = 0;
                foreach (Participantes pessoa in Sorteio.participantes)
                {
                    campoTexto3.Text += $"ID: {id}\r\n";
                    campoTexto3.Text += $"Número de sorteio: {pessoa.numero}\r\n";
                    campoTexto3.Text += $"Nome: {pessoa.nome}\r\n";
                    campoTexto3.Text += $"Endereço: {pessoa.endereco}\r\n";
                    campoTexto3.Text += $"Contato: {pessoa.contato}\r\n";
                    campoTexto3.Text += "===================================\r\n";
                    id++;
                }
            }
            else
            {
                campoTexto3.Text += "Nenhum participante cadastrado ainda!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel2fundo.Visible == false)
            {
                panel3.Visible = true;
                panel2.Visible = true;
                panel2fundo.Visible = true;
                panel4.Visible = false;
            }
            else
            {
                panel2fundo.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
            }
            
            textBox5.Clear();
            textBox5.Text += $"Número de participantes: {Sorteio.participantes.Count}\r\n\r\n";

            if (Sorteio.participantes.Count > 0)
            {
                int id = 0;
                foreach (Participantes pessoa in Sorteio.participantes)
                {
                    textBox5.Text += $"ID: {id}\r\n";
                    textBox5.Text += $"Número de sorteio: {pessoa.numero}\r\n";
                    textBox5.Text += $"Nome: {pessoa.nome}\r\n";
                    textBox5.Text += $"Endereço: {pessoa.endereco}\r\n";
                    textBox5.Text += $"Contato: {pessoa.contato}\r\n";
                    textBox5.Text += "===================================\r\n";
                    id++;
                }
            }
            else
            {
                textBox5.Text += "Nenhum participante cadastrado ainda!";
            }
        }

        private void campoTexto3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            if (panel2fundo.Visible == false)
            {
                panel5.Visible = true;
                panel4.Visible = true;
                panel3.Visible = true;
                panel2.Visible = true;
                panel2fundo.Visible = true;
            }
            else
            {
                panel2fundo.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
            }

            if (Sorteio.participantes.Count == 0)
            {
                textBox7.Text += "Nenhum participante cadastrado ainda!";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sorteio.participantes.Count > 0)
                {
                    int id = int.Parse(campoTexto4.Text);
                    Sorteio.participantes.RemoveAt(id);
                    Sorteio.Salvar();
                    campoTexto4.Clear();
                    MessageBox.Show("Remoção concluída!");
                }
                else
                {
                    MessageBox.Show("Nenhum participante cadastrado ainda!");
                }
            }
            catch
            {
                MessageBox.Show("Errouuuuu");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel2fundo.Visible == false)
            {
                panel4.Visible = true;
                panel3.Visible = true;
                panel2.Visible = true;
                panel2fundo.Visible = true;
                panel5.Visible = false;
            }
            else
            {
                panel2fundo.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
            }

            textBox6.Clear();
            textBox6.Text += "APERTE SORTEAR PARA SORTEAR UM NÚMERO!!!\r\n";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            bool fimSorteio = false;
            while (!fimSorteio)
            {
                Random sorte = new Random();
                int valor = sorte.Next(0, 150);

                foreach (Participantes pessoas in Sorteio.participantes)
                {
                    if (valor + 1 == pessoas.numero)
                    {
                        textBox6.Text += $"O NÚMERO SORTEADO FOI: {pessoas.numero}\r\n";
                        textBox6.Text += $"VENCEDOR: {pessoas.nome}\r\n";
                        fimSorteio = true;
                        break;
                    }
                }
                if (Sorteio.participantes.Count == 0)
                {
                    textBox6.Text += "Nenhum número da sorte cadastrado ainda!";
                    fimSorteio = true;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            try
            {
                if (Sorteio.participantes.Count > 0)
                {
                    int sorteio = int.Parse(textBox8.Text);

                    foreach (Participantes pessoas in Sorteio.participantes)
                    {
                        if (sorteio == pessoas.numero)
                        {
                            textBox7.Text += $"Nome: {pessoas.nome}\r\n";
                            textBox7.Text += $"Endereço: {pessoas.endereco}\r\n";
                            textBox7.Text += $"Contato: {pessoas.contato}\r\n";
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Errouuuuu");
            }
            textBox8.Clear();
        }
    }
}
