using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Aplicativo_de_setores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNomeSetor.Text))
                {
                    MessageBox.Show("O Campo nome é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Setor setor = new Setor();
                    setor.Nome = txtNomeSetor.Text;
                    setor.IserirSetor();
                    MessageBox.Show("Setor cadastrado com sucesso!", "Suceso", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    txtNomeSetor.Clear();
                    setor.AtualizarSetor();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar setor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                Setor setor = new Setor();
                DataTable dataTable = new DataTable();
                dgvSetores.DataSource = setor.listarsetores();


                dgvSetores.AllowUserToAddRows = false;
                dgvSetores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvSetores.AutoResizeColumnHeadersHeight();
                dgvSetores.ClearSelection();
                dgvSetores.AllowUserToAddRows = false;
                setor.AtualizarSetor();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar setores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSetores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                Setor setor = new Setor();
                DataTable dataTable = new DataTable();
                dgvSetores.DataSource = setor.listarsetores();

                dgvSetores.AllowUserToAddRows = false;
                dgvSetores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                dgvSetores.ColumnHeadersHeight = 30;
                dgvSetores.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
                dgvSetores.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvSetores.EnableHeadersVisualStyles = false;
                dgvSetores.ClearSelection();
                ;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar setores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSetores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow linha = dgvSetores.Rows[e.RowIndex];


                    txtID.Text = linha.Cells[0].Value.ToString();
                    txtNome.Text = linha.Cells[1].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao peagr os dados  " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    Setor setor = new Setor();
                    setor.NomeSetor = txtNome.Text;
                    setor.Id = Convert.ToInt32(txtID.Text);

                    setor.editarsetor();

                    MessageBox.Show("Setor atualizado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txtNome.Clear();
                    txtID.Clear();
                    dgvSetores.DataSource = setor.listarsetores();
                    dgvSetores.ClearSelection();
                    dgvSetores.AllowUserToAddRows = false;
                    dgvSetores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvSetores.AutoResizeColumns();
                    dgvSetores.ClearSelection();

                }
                else
                {

                    MessageBox.Show("Selecione um setor na tabela e preencha o nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar setor: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Setor setor = new Setor();
                setor.Id = Convert.ToInt32(txtID.Text);
                if (setor.Id > 0)
                {
                    var resultado = MessageBox.Show("Tem certeza que deseja excluir o setor?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        setor.excluirsetor();
                        MessageBox.Show("Setor excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Clear();
                        txtID.Clear();
                        dgvSetores.DataSource = setor.listarsetores();
                        dgvSetores.ClearSelection();
                        dgvSetores.AllowUserToAddRows = false;
                        dgvSetores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvSetores.AutoResizeColumns();
                        dgvSetores.ClearSelection();
                        setor.AtualizarSetor();

                    }
                    else
                    {
                        if (resultado == DialogResult.No)
                        {
                            MessageBox.Show("Exclusão cancelada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtNome.Clear();
                            txtID.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um setor na tabela para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir setor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string NomeBucar = txtNome.Text.Trim();
                if (!string.IsNullOrWhiteSpace(NomeBucar))
                {
                    Setor setor = new Setor();
                    DataTable resultado = setor.PesquisarPorNome(NomeBucar);
                    dgvSetores.DataSource = resultado;
                    dgvSetores.AllowUserToAddRows = false;
                    dgvSetores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvSetores.ClearSelection();
                }
                else
                {
                    MessageBox.Show("O campo de pesquisa está vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao pesquisar setor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        
