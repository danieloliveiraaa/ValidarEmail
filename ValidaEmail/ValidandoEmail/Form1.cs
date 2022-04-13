using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace ValidandoEmail
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            //USANDO MEU EMAIL COMO EXEMPLO! 
            //DANIEL
            //silvaoliveiradaniel3@gmail.com

        }




        //abrir a tela de testes
        //TESTES      //TESTES
        //TESTES      //TESTES
        //TESTES      //TESTES
        private void button1_Click(object sender, EventArgs e)
        {
            Teste testando = new Teste();
            testando.Show();
        }
        //TESTES      //TESTES
        //TESTES      //TESTES
        //TESTES      //TESTES







        private void btnEnvia_Click(object sender, EventArgs e)
        {
            //GERO UM CODIGO, RANDOMICO
            //PARA QUE O DESTINATARIO DO EMAIL CONFIRME 
            Random aleatorio = new Random();
            string codigo = Convert.ToString(aleatorio.Next());

            txtRandomEnvia.Text = codigo;

            /*
            O Simple Mail Transfer Protocol SMTP
            é um protocolo de comunicação padrão 
            da Internet para transmissão de correio eletrônico. 
            Servidores de correio e outros agentes de transferência 
            de mensagens usam SMTP para enviar e 
            receber mensagens de correio.
            */
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();

            //Host seria no caso o tipo do email a ser usado, por exemplo Gmail, Outlook e Yahoo.
            //NESSE CASO FAREI USO DO SERVIDOR DO OUTLOOK
            client.Host = "smtp-mail.outlook.com";
            
            client.EnableSsl = true;
            
            client.Port = 587;


            //Abre o Outlook,Gmail e etc, com email e senha.          --email               --senha 
            client.Credentials = new System.Net.NetworkCredential("exemplo@hotmail.com", "123456789");

            //Instância para criação da mensagem.
            MailMessage mail = new MailMessage();

            //Email que será o remetente.
            mail.From = new MailAddress("exemplo@hotmail.com");

            //Email destinatario que será, o email inserido na caixa de texto.
            mail.To.Add(new MailAddress(txtEmail.Text));

            //Titulo do email.
            mail.Subject = "CÓDIGO DE VERIFICAÇÃO DE EMAIL";


            //A mensagem que será enviada.
            mail.Body = ("Segue abaixo seu código de verificação:\n" + txtRandomEnvia.Text);

            mail.Priority = MailPriority.High;

            
            try
            {
                //Realiza o envio.
                client.Send(mail);
                MessageBox.Show("EMAIL ENVIADO PARA SUA CAIXA DE ENTRADA !! \n\nPOR FAVOR VERIFICAR !!");

                txtRandomConfirma.Visible = true;

                lblA.Visible = true;


            }
            catch (System.Exception)
            {
                //trata erro.
            }
            finally
            {
                //Após a operação o email, retorna como nulo.
                mail = null;
            }
   


        }



        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            //caso o usuario deixe a caixa vazia 
            if (txtRandomConfirma.Text == "")
            {
                txtRandomConfirma.BackColor = Color.White;
            }

            //caso digite o que foi enviado no email
            else if(txtRandomConfirma.Text == txtRandomEnvia.Text)
            {
                lblValido.Visible = true;
                pctValido.Visible = true;

                txtRandomConfirma.BackColor = Color.LightGreen;

            }

            else
            {
                txtRandomConfirma.BackColor = Color.LightCoral;
            }
        }
    }
}
