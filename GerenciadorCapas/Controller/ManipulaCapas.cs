using GerenciadorCapas.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCapas.Controller
{
    internal class ManipulaCapas
    {
        public void CadFuncionario()
        {
            //A Função Conectar retorna o caminho
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            //Criar o CMD da aplicação e setar a Procedure usada e o banco
            SqlCommand cmd = new SqlCommand("pAdicionarFuncionario", cn);
            //Indicar que o cmd é uma procedure
            cmd.CommandType = CommandType.StoredProcedure;



            try
            {
                cmd.Parameters.AddWithValue("nomeFunc", MdFuncionario.Nome);
                //Lidar com id auto increment
                SqlParameter nv = cmd.Parameters.Add("idFunc", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario Cadastrado com Sucesso");
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar");
                throw;
            }
        }

        public void CadFornecedor()
        {
            //A Função Conectar retorna o caminho
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            //Criar o CMD da aplicação e setar a Procedure usada e o banco
            SqlCommand cmd = new SqlCommand("pAdicionarFornecedor", cn);
            //Indicar que o cmd é uma procedure
            cmd.CommandType = CommandType.StoredProcedure;



            try
            {
                cmd.Parameters.AddWithValue("nomeForn", MdFornecedor.Nome);
                cmd.Parameters.AddWithValue("telForn", MdFornecedor.Telefone);
                //Lidar com id auto increment
                SqlParameter nv = cmd.Parameters.Add("idFOrn", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor Cadastrado com Sucesso");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar");
                throw;
            }
        }

        public void CadPedido()
        {
            //A Função Conectar retorna o caminho
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            //Criar o CMD da aplicação e setar a Procedure usada e o banco
            SqlCommand cmd = new SqlCommand("pAdicionarPedido", cn);
            //Indicar que o cmd é uma procedure
            cmd.CommandType = CommandType.StoredProcedure;



            try
            {
                cmd.Parameters.AddWithValue("dtInicio", MdPedido.DataInicio);
                cmd.Parameters.AddWithValue("dtEntr", MdPedido.DataEntrega);
                cmd.Parameters.AddWithValue("pagPend", MdPedido.Valor);
                cmd.Parameters.AddWithValue("qtdPend", MdPedido.Quantidade);
                cmd.Parameters.AddWithValue("idFornFK", MdPedido.Fornecedor);
                //Lidar com id auto increment
                SqlParameter nv = cmd.Parameters.Add("idPed", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pedido Cadastrado com Sucesso");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar pedido");
                throw;
            }
        }

        public void CadEntrega()
        {
            //A Função Conectar retorna o caminho
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            //Criar o CMD da aplicação e setar a Procedure usada e o banco
            SqlCommand cmd = new SqlCommand("pFazerEntrega", cn);
            //Indicar que o cmd é uma procedure
            cmd.CommandType = CommandType.StoredProcedure;



            try
            {
                cmd.Parameters.AddWithValue("idPedFK", MdEntrega.Pedido);
                cmd.Parameters.AddWithValue("dtEntr", MdEntrega.Data);
                cmd.Parameters.AddWithValue("QtdEntr", MdEntrega.Quantidade);
                cmd.Parameters.AddWithValue("sitEntr", MdEntrega.Situacao);

                //Lidar com id auto increment
                SqlParameter nv = cmd.Parameters.Add("idEntr", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Entrega Cadastrado com Sucesso");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar pedido");
                throw;
            }
        }

        public void AltFuncionario()
        {
            //A Função Conectar retorna o caminho
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            //Criar o CMD da aplicação e setar a Procedure usada e o banco
            SqlCommand cmd = new SqlCommand("pAlterarFuncionario", cn);
            //Indicar que o cmd é uma procedure
            cmd.CommandType = CommandType.StoredProcedure;



            try
            {
                cmd.Parameters.AddWithValue("idEntr", MdPedido.Codigo);
                cmd.Parameters.AddWithValue("dtInicio", MdPedido.DataInicio);
                cmd.Parameters.AddWithValue("dtEntr", MdPedido.DataEntrega);
                cmd.Parameters.AddWithValue("pagPend", MdPedido.Valor);
                cmd.Parameters.AddWithValue("qtdPend", MdPedido.Quantidade);
                cmd.Parameters.AddWithValue("idFornFK", MdPedido.Fornecedor);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("FUncionario Alterado com Sucesso");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar alteração");
                throw;
            }
        }

        public void AltFornecedor()
        {
            //A Função Conectar retorna o caminho
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            //Criar o CMD da aplicação e setar a Procedure usada e o banco
            SqlCommand cmd = new SqlCommand("pAlterarForncedor", cn);
            //Indicar que o cmd é uma procedure
            cmd.CommandType = CommandType.StoredProcedure;



            try
            {
                cmd.Parameters.AddWithValue("idForn", MdFornecedor.Codigo);
                cmd.Parameters.AddWithValue("nomeForn", MdFornecedor.Nome);
                cmd.Parameters.AddWithValue("telForn", MdFornecedor.Telefone);
                cmd.Parameters.AddWithValue("qtdPend", MdFornecedor.Quantidade);
                cmd.Parameters.AddWithValue("pagPend", MdFornecedor.Pagamento);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor Alterado com Sucesso");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar alteração");
                throw;
            }
        }

        public void DelFornecedor()
        {
            //A Função Conectar retorna o caminho
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            //Criar o CMD da aplicação e setar a Procedure usada e o banco
            SqlCommand cmd = new SqlCommand("pDeletarFornecedor", cn);
            //Indicar que o cmd é uma procedure
            cmd.CommandType = CommandType.StoredProcedure;



            try
            {
                cmd.Parameters.AddWithValue("idForn", MdFornecedor.Codigo);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Forncedor Deletado com Sucesso");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a exclusão");
                throw;
            }
        }

        public void DelFuncionario()
        {
            //A Função Conectar retorna o caminho
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            //Criar o CMD da aplicação e setar a Procedure usada e o banco
            SqlCommand cmd = new SqlCommand("pDeletarFuncionario", cn);
            //Indicar que o cmd é uma procedure
            cmd.CommandType = CommandType.StoredProcedure;



            try
            {
                cmd.Parameters.AddWithValue("idFunc", MdFuncionario.Codigo);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário Deletado com Sucesso");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a exclusão");
                throw;
            }
        }

        public void PendFuncionario()
        {
            //Aponta para o nosso model
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            //Diz qual procedure vai ser usada
            SqlCommand cmd = new SqlCommand("pBuscaPendFunc", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                //Setar quais parametros vao ser usados
                cmd.Parameters.AddWithValue("pagPend",MdFuncionario.Pagamento);
                //Abrir conexao com o banco de ddos
                cn.Open();
                //Prepara um objeto para guardar os registros
                var registros = cmd.ExecuteReader();
                //Model - Procedure
                if (registros.Read())
                {
                    MdFuncionario.Nome = (string)registros["nomeFunc"];
                    MdFuncionario.Quantidade = (string)registros["qtdPend"];
                    MdFuncionario.Pagamento = (float)registros["pagPend"];
                    MessageBox.Show("Foram encontradas as seguintes pendências");

                }
                else
                {
                    
                    MessageBox.Show("Não foram encontradas pendências");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no programa");
                throw;
            }
        }

        public void PendFornecedor()
        {
            //Aponta para o nosso model
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            //Diz qual procedure vai ser usada
            SqlCommand cmd = new SqlCommand("pBuscaPendForn", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                //Setar quais parametros vao ser usados
                cmd.Parameters.AddWithValue("pagPend", MdFornecedor.Pagamento);
                //Abrir conexao com o banco de ddos
                cn.Open();
                //Prepara um objeto para guardar os registros
                var registros = cmd.ExecuteReader();
                //Model - Procedure
                if (registros.Read())
                {
                    MdFornecedor.Nome = (string)registros["nomeForn"];
                    MdFornecedor.Telefone = (string)registros["telForn"];
                    MdFornecedor.Pagamento = (float)registros["pagPend"];
                    MessageBox.Show("Foram encontradas as seguintes pendências");

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Não foram encontradas pendências");
                throw;
            }
        }

    }
}
