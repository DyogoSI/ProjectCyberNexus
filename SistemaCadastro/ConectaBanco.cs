using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace SistemaCadastro
{
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10667311;password=fwDZ9E8mUD;database=sql10667311");
       public string mensagem;

        public bool insereProduto(Produto novoProduto)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("sp_insereProduto", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_nome", novoProduto.Nome);
                cmd.Parameters.AddWithValue("p_tipo", novoProduto.Tipo);
                cmd.Parameters.AddWithValue("p_quantidade", novoProduto.Quantidade);
                cmd.Parameters.AddWithValue("p_preco", novoProduto.Preco);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (MySqlException erro) 
            { 
                mensagem = erro.Message;
                return false;
            }
        }
        
        public DataTable listaTipo()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaTipo", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }


        public DataTable liataProdutos()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaProduto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try{
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch(MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                    
                    return null;
            }
            finally { conexao.Close();}
        }

        public bool deletaProduto(int id_removerProduto)
        {
            MySqlCommand cmd = new MySqlCommand("sp_removerproduto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id_Produtos", id_removerProduto);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim deletaBanda

        public bool alteraProduto(Produto p, int id_produto)
        {
            MySqlCommand cmd = new MySqlCommand("sp_alteraProduto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id_alterarProduto", id_produto);
            cmd.Parameters.AddWithValue("ap_nome", p.Nome);
            cmd.Parameters.AddWithValue("ap_id_tipo", p.Tipo);
            cmd.Parameters.AddWithValue("ap_quantidade", p.Quantidade);
            cmd.Parameters.AddWithValue("ap_preco", p.Preco);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim update_banda

        public bool insereTipo(string novoTipo)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("sp_insereTipo", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nome_tipo", novoTipo);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        }

        public bool verifica(string user, string pass)
        {
            string senhaHash = Biblioteca.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("sp_consultaLogin", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nome_usuario", user);
            cmd.Parameters.AddWithValue("senha", senhaHash);
            try
            {
                conexao.Open();//abrindo a conexão;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();// tabela virtual
                da.Fill(ds); //passando os valores consultados para o DataSet
                if (ds.Tables[0].Rows.Count > 0) // verifica se houve retorno
                    return true;
                else
                    return false;

            }
            catch (MySqlException er)
            {
                mensagem = "Erro" + er.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
