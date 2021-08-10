using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Livraria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //estabelecendo cn com banco SSPI É VALIDAÇÃO WINDOWS, necessario biblioteca: using System.Data.SqlClient;
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-D0R8GC5; integrated security=SSPI; initial Catalog=db_Livraria");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        // uso de exit para fechar aplicação
        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // mostrar e esconder senha 
        private void btnsenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtsenha.UseSystemPasswordChar = false;
        }
        // mostrar e esconder senha 
        private void btnsenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtsenha.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        // btn para enviar o login e checar com o banco
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtlogin.Text == "" || txtsenha.Text =="")
            {
                MessageBox.Show("Obrigatorio Preencher os campos Login e Senha", "Atenção!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    // abertura do banco com os dados sendo enviados para validação
                    cn.Open();
                    cm.CommandText = "select * from tbl_atendente where ds_login = ('"+txtlogin.Text+ "') and ds_senha = ('" + txtsenha.Text + "') and ds_status=1";
                    cm.Connection = cn;
                    // leitura no banco
                    dt = cm.ExecuteReader();
                    // verificar se tem linha
                    if(dt.HasRows)
                    {
                        frmmenu menu = new frmmenu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login ou Senha Invalidos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtlogin.Clear();
                        txtsenha.Clear();
                        txtlogin.Focus();
                    }
                }
                catch( Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
