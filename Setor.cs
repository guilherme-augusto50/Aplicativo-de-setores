using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;

namespace Aplicativo_de_setores
{
    class Setor
    {
        private int id;
        private string nome;
        private string nomesetor;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string NomeSetor
        {
            get { return nomesetor; }
            set { nomesetor = value; }
        }

        public void IserirSetor()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoDb().Conectar())
                {
                    string query = "INSERT INTO setores (nome) VALUES (@nome)";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@nome", Nome);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                Console.WriteLine("Erro ao inserir setor");
            }

        }
        public void AtualizarSetor()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoDb().Conectar())
                {
                    string query = "UPDATE setores SET nome = @nome WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@nome", Nome);
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                Console.WriteLine("Erro ao atualizar setor");
            }
        }
        public object listarsetores()
        {
            try
            {
                var Lista = new List<Setor>();
                using (MySqlConnection conexao = new ConexaoDb().Conectar())
                {
                    string query = "SELECT id, nome FROM setores";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }


            }
            catch
            {
                MessageBox.Show("Erro ao listar setores");
                return null;
            }
        }
        public void editarsetor()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoDb().Conectar())
                {
                    string atualizar = "UPDATE setores SET nome = @nome WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(atualizar, conexao);
                    cmd.Parameters.AddWithValue("@nome", nomesetor);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao editar setor: " + ex.Message);
            }
        }
        public void excluirsetor()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoDb().Conectar())
                {
                    string excluir = "DELETE FROM setores WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(excluir, conexao);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir setor: " + ex.Message);
            }
        }
        public DataTable PesquisarPorNome(string nome)
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoDb().Conectar())
                {
                    string sql = "SELECT * FROM setores WHERE nome LIKE @nome";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar setor: " + ex.Message);
                return null;
            }
        }

    }
}
