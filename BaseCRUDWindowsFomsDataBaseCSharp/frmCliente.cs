using BaseCRUDWindowsFomsDataBaseCSharp.model;
using FirebirdSql.Data.FirebirdClient;
using Microsoft.Data.SqlClient;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BaseCRUDWindowsFomsDataBaseCSharp
{
    public partial class frmCliente : Form
    {
        private string strCon = "User=SYSDBA;Password=masterkey;Database=C:\\geiewin\\SubProjetos\\Curso\\Git\\BaseCRUDWindowsFomsDataBaseCSharp\\data\\DATA.FDB;DataSource=localhost;Port=3051;Dialect=3";
        private string strSQL = string.Empty;
        FbConnection fbCon = null;
        FbCommand fbComando = null;

        public frmCliente()
        {
            InitializeComponent();
        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                strSQL = "insert into CLIENTES (Id, Nome, TpDocto, Docto, Telefone) values (@Id, @Nome, @TpDocto, @Docto, @Telefone)";

                using (FbConnection fbCon = new FbConnection(strCon))
                {
                    fbCon.Open();

                    using (FbCommand fbComando = new FbCommand("SELECT GEN_ID(GEN_CLIENTES, 1) FROM RDB$DATABASE", fbCon))
                    {
                        int novoValor = Convert.ToInt32(fbComando.ExecuteScalar());

                        using (FbCommand insertCommand = new FbCommand(strSQL, fbCon))
                        {
                            insertCommand.Parameters.Add("@Id", FbDbType.VarChar, 15).Value = novoValor.ToString();
                            insertCommand.Parameters.Add("@Nome", FbDbType.VarChar).Value = tbNome.Text;
                            insertCommand.Parameters.Add("@TpDocto", FbDbType.VarChar).Value = tbTpDocto.Text;
                            insertCommand.Parameters.Add("@Docto", FbDbType.VarChar).Value = tbDocto.Text;
                            insertCommand.Parameters.Add("@Telefone", FbDbType.VarChar).Value = tbTelefone.Text;

                            insertCommand.ExecuteNonQuery();
                            MessageBox.Show("Cadastro realizado com sucesso!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message);
            }
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate search input
                if (string.IsNullOrEmpty(tstbSearch.Text))
                {
                    throw new Exception("Por favor, informe o código do cliente para a pesquisa.");
                }

                using (FbConnection fbCon = new FbConnection(strCon))
                {
                    fbCon.Open();

                    strSQL = "select * from CLIENTES where COD_CLIENTE = @COD_CLIENTE";

                    using (FbCommand fbComando = new FbCommand(strSQL, fbCon))
                    {
                        fbComando.Parameters.Add("@COD_CLIENTE", FbDbType.VarChar).Value = tstbSearch.Text;

                        using (FbDataReader dr = fbComando.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                tstbSearch.Text = dr["COD_CLIENTE"].ToString();
                                tbNome.Text = dr["NOME"].ToString();
                                tbTpDocto.Text = dr["TP_DOCTO"].ToString();
                                tbDocto.Text = dr["DOCTO"].ToString();
                                tbTelefone.Text = dr["TELEFONE"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Cliente não cadastrado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar cliente: " + ex.Message);
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrEmpty(tstbSearch.Text))
                {
                    throw new Exception("Por favor, informe o código do cliente para a edição.");
                }

                if (string.IsNullOrEmpty(tbNome.Text))
                {
                    throw new Exception("Por favor, informe o nome do cliente.");
                }

                using (FbConnection fbCon = new FbConnection(strCon))
                {
                    fbCon.Open();

                    strSQL = "update CLIENTES set NOME = @NOME, TP_DOCTO = @TP_DOCTO, DOCTO = @DOCTO, TELEFONE = @TELEFONE where COD_CLIENTE = @COD_CLIENTE";

                    using (FbCommand fbComando = new FbCommand(strSQL, fbCon))
                    {
                        fbComando.Parameters.Add("@COD_CLIENTE", FbDbType.VarChar).Value = tstbSearch.Text;
                        fbComando.Parameters.Add("@NOME", FbDbType.VarChar).Value = tbNome.Text;
                        fbComando.Parameters.Add("@TP_DOCTO", FbDbType.VarChar).Value = tbTpDocto.Text;
                        fbComando.Parameters.Add("@DOCTO", FbDbType.VarChar).Value = tbDocto.Text;
                        fbComando.Parameters.Add("@TELEFONE", FbDbType.VarChar).Value = tbTelefone.Text;

                        int rowsAffected = fbComando.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Erro ao editar cliente.");
                        }
                        else
                        {
                            MessageBox.Show("Cliente editado com sucesso!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrEmpty(tstbSearch.Text))
                {
                    throw new Exception("Por favor, informe o código do cliente para a exclusão.");
                }

                using (FbConnection fbCon = new FbConnection(strCon))
                {
                    fbCon.Open();

                    strSQL = "delete from CLIENTES where COD_CLIENTE = @COD_CLIENTE";

                    using (FbCommand fbComando = new FbCommand(strSQL, fbCon))
                    {
                        fbComando.Parameters.Add("@COD_CLIENTE", FbDbType.VarChar).Value = tbID.Text;

                        int rowsAffected = fbComando.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Cliente não encontrado.");
                        }
                        else
                        {
                            MessageBox.Show("Cliente excluído com sucesso!");
                            // Clear textboxes after successful deletion
                            tstbSearch.Text = string.Empty;
                            tbNome.Text = string.Empty;
                            tbTpDocto.Text = string.Empty;
                            tbDocto.Text = string.Empty;
                            tbTelefone.Text = string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cliente: " + ex.Message);
            }
        }
    }
}