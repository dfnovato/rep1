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
    public partial class frmatendente : UserControl
    {
        public frmatendente()
        {
            InitializeComponent();
        }

        //estabelecendo cn com banco SSPI É VALIDAÇÃO WINDOWS, necessario biblioteca: using System.Data.SqlClient;
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-D0R8GC5; integrated security=SSPI; initial Catalog=db_Livraria");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;

        // desabilita campos chaves ao entrar
        private void desabilitacampos()
        {
            btnnovo.Enabled = true;
            txtlogin.Enabled = false;
            txtnome.Enabled = false;
            txtsenha.Enabled = false;
            btngravar.Enabled = false;
            btnalterar.Enabled = false;
            btncancelar.Enabled = false;
            btnexcluir.Enabled = false;
        }

        // habilita novamente campos
        private void habilitacampos()
        {
            txtlogin.Enabled = true;
            txtnome.Enabled = true;
            txtsenha.Enabled = true;
            btngravar.Enabled = true;
            btncancelar.Enabled = true;
            btnnovo.Enabled = false;
            txtnome.Focus();
            
        }
        // limpar dados apos digitar
        private void limparcampos()
        {
            txtlogin.Text = "";
            txtnome.Clear();
            txtsenha.Clear();
            radioativo.Checked = true;
        }
        // funçao de limpar pesquisa
        private void limpapesquisa()
        {
            txtbusca.Clear();
            dgvfunc.DataSource = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // carrega os campos desabilitados no meu form
        private void frmatendente_Load(object sender, EventArgs e)
        {
            desabilitacampos();
        }
        // habilita e limpa campos apos click
        private void btnnovo_Click(object sender, EventArgs e)
        {
            habilitacampos();
            limpapesquisa();
        }
        // habilita e limpa campos apos click
        private void btncancelar_Click(object sender, EventArgs e)
        {
            desabilitacampos();
            limparcampos();
            
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }
        // insert no banco de dados
        private void btngravar_Click(object sender, EventArgs e)
        {
            // cadeia de if e elseif para verificar se os campos estão preenchidos
            if(txtnome.Text == "")
            {
                MessageBox.Show("Obrigatorio Preencher Nome", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnome.Focus();
            }
            else if(txtlogin.Text=="")
            {
                MessageBox.Show("Obrigatorio Preencher Login", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlogin.Focus();
            }
            else if (txtsenha.Text == "")
            {
                MessageBox.Show("Obrigatorio Preencher Senha", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsenha.Focus();
            }
            else if (txtsenha.Text.Length < 8)
            {
                MessageBox.Show("Campo senha deve conter no minimo 8 digitos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsenha.Focus();
            }
            else
            {
                try
                {

                // armazenando minha variaveis para inserir no banco
                string nome = txtnome.Text;
                string login = txtlogin.Text;
                string senha = txtsenha.Text;
                    // comando do banco sql para insert
                string strsql = "insert into tbl_atendente(ds_login,ds_senha,nm_atendente)values(@login,@senha,@atendente)";

                    cm.CommandText = strsql;
                    cm.Connection = cn;

                cm.Parameters.Add("@login",SqlDbType.VarChar).Value=login;
                cm.Parameters.Add("@senha", SqlDbType.VarChar).Value=senha;
                cm.Parameters.Add("@atendente", SqlDbType.VarChar).Value=nome;
                    // abertura do banco de dados para receber os valores
                cn.Open();
                cm.ExecuteNonQuery();
                 // limpar os parametros da memoria apos uso
                 cm.Parameters.Clear();

                    MessageBox.Show("Dados Inseridos", "Atenção!", MessageBoxButtons.OK , MessageBoxIcon.Information);
                    txtsenha.Focus();
                    limparcampos();
                    txtnome.Focus();
                }
                catch(Exception erro)
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
       
        private void txtnome_TextChanged_1(object sender, EventArgs e)
        {
            
        }
        // vai ler o txt busca e retornar os dados do banco de dados usando SqlData Adapter e Table
        private void txtbusca_TextChanged(object sender, EventArgs e)
        {
            if (txtbusca.Text != "")
            {
                try
                {
                    cn.Open();
                    // Funcao de busca usando operador like
                    cm.CommandText = "select * from tbl_atendente where nm_atendente like('%" + txtbusca.Text + "%')";
                    cm.Connection = cn;

                    // recebe os dados de uma tabela apos a execução do select
                    SqlDataAdapter da = new SqlDataAdapter();

                    // representa uma ou mais tabelas de dados, e podem ser manipuladas por metodos. Fazer um select para agrupar os dados em data table
                    DataTable dt = new DataTable();

                    // recebendo os dados da instrução select.
                    da.SelectCommand = cm;
                    da.Fill(dt);  // preenchendo tabela
                    dgvfunc.DataSource = dt; // dgv = datagridview
                    cn.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                dgvfunc.DataSource = null;
            }

        }
        // habilitando e desabilitando botoes ainda zzz
        private void manipuladados()
        {
            btnalterar.Enabled = true;
            btncancelar.Enabled = true;
            btnnovo.Enabled = false;
            btngravar.Enabled = false;
            txtnome.Enabled = true;
            txtlogin.Enabled = true;
            txtsenha.Enabled = true;
            btnexcluir.Enabled = true;
        }
        // funcao que pega dados na tabela exibida e insere nos campos 
        private void carregaatendente()
        {
            lblcodigo.Text = dgvfunc.SelectedRows[0].Cells[0].Value.ToString();
            txtlogin.Text = dgvfunc.SelectedRows[0].Cells[1].Value.ToString();
            txtsenha.Text = dgvfunc.SelectedRows[0].Cells[2].Value.ToString();
            txtnome.Text = dgvfunc.SelectedRows[0].Cells[3].Value.ToString();
            string valor= dgvfunc.SelectedRows[0].Cells[4].Value.ToString();
           // eu iria implementar radio para exclusão sem retirar do banco porem por efeitos de cru'D' resolvi deletar do banco e n seguir a aula
            if(valor == "True")
            {
                radioativo.Checked = true;          
            }
            else
            {
                radioinativo.Checked = true;      
            }
            manipuladados();
            limpapesquisa();
        }

        //double click usando carregaatendente
        private void dgvfunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregaatendente();
            if(radioativo.Checked)
            {
                btnexcluir.Enabled = true;
            }
            else
            {
                btnexcluir.Enabled = false;
            }
        }
        //funcao de alterar o banco
        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "")
            {
                MessageBox.Show("Obrigatorio Preencher Nome", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnome.Focus();
            }
            else if (txtlogin.Text == "")
            {
                MessageBox.Show("Obrigatorio Preencher Login", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlogin.Focus();
            }
            else if (txtsenha.Text == "")
            {
                MessageBox.Show("Obrigatorio Preencher Senha", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsenha.Focus();
            }
            else if (txtsenha.Text.Length < 8)
            {
                MessageBox.Show("Campo senha deve conter no minimo 8 digitos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsenha.Focus();
            }
            /*else if (radioativo.Checked)
            {
                MessageBox.Show("Campo senha deve conter no minimo 8 digitos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsenha.Focus();
            }
            */
            else
            {
                try
                {


                    string nome = txtnome.Text;
                    string login = txtlogin.Text;
                    string senha = txtsenha.Text;
                    int cd = Convert.ToInt32 (lblcodigo.Text);

                    // usando where para alterar onde o parametro cd definir.
                    string strsql = "update tbl_atendente set ds_login=@login, ds_senha=@senha, nm_atendente=@atendente where cd_atendente =@cd";
                    

                    cm.CommandText = strsql;
                    cm.Connection = cn;


                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                    cm.Parameters.Add("@atendente", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    // limpar os parametros da memoria apos uso
                    cm.Parameters.Clear();

                    MessageBox.Show("Dados Alterados", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsenha.Focus();
                    limparcampos();
                    txtnome.Focus();
                    limpapesquisa();
                    
                }
                catch (Exception erro)
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioativo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvfunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //funcao para excluir do banco, eu iria implementar o desativar com mudança de status porem para o motivo do aprendizado do CRUD realizei a exclusão do banco
        private void btnexcluir_Click(object sender, EventArgs e)
        {

            if (txtnome.Text == "")
            {
                MessageBox.Show("Obrigatorio Preencher Nome", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnome.Focus();
            }
            else if (txtlogin.Text == "")
            {
                MessageBox.Show("Obrigatorio Preencher Login", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlogin.Focus();
            }
            else if (txtsenha.Text == "")
            {
                MessageBox.Show("Obrigatorio Preencher Senha", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsenha.Focus();
            }
            else if (txtsenha.Text.Length < 8)
            {
                MessageBox.Show("Campo senha deve conter no minimo 8 digitos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsenha.Focus();
            }
            else
            {
                try
                {



                    int cd = Convert.ToInt32(lblcodigo.Text);

                    // usando where para alterar onde o parametro cd definir.
                    string strsql = "delete from tbl_atendente where cd_atendente =@cd";


                    cm.CommandText = strsql;
                    cm.Connection = cn;


                    cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    // limpar os parametros da memoria apos uso
                    cm.Parameters.Clear();

                    MessageBox.Show("exclusão", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsenha.Focus();
                    limparcampos();
                    txtnome.Focus();
                    limpapesquisa();

                }
                catch (Exception erro)
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
    }
}
