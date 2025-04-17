namespace Aplicativo_de_setores
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCadastrar = new Button();
            bntEditar = new Button();
            btnExcluir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            txtNome = new TextBox();
            dgvSetores = new DataGridView();
            btnPesquisar = new Button();
            btnListarTodos = new Button();
            txtNomeSetor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSetores).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            resources.ApplyResources(btnCadastrar, "btnCadastrar");
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // bntEditar
            // 
            resources.ApplyResources(bntEditar, "bntEditar");
            bntEditar.Cursor = Cursors.Hand;
            bntEditar.Name = "bntEditar";
            bntEditar.UseVisualStyleBackColor = true;
            bntEditar.Click += bntEditar_Click;
            // 
            // btnExcluir
            // 
            resources.ApplyResources(btnExcluir, "btnExcluir");
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // txtID
            // 
            resources.ApplyResources(txtID, "txtID");
            txtID.Cursor = Cursors.IBeam;
            txtID.Name = "txtID";
            // 
            // txtNome
            // 
            resources.ApplyResources(txtNome, "txtNome");
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Name = "txtNome";
            // 
            // dgvSetores
            // 
            resources.ApplyResources(dgvSetores, "dgvSetores");
            dgvSetores.AllowUserToAddRows = false;
            dgvSetores.AllowUserToDeleteRows = false;
            dgvSetores.BorderStyle = BorderStyle.Fixed3D;
            dgvSetores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSetores.Cursor = Cursors.Cross;
            dgvSetores.Name = "dgvSetores";
            dgvSetores.ReadOnly = true;
            dgvSetores.CellContentClick += dgvSetores_CellContentClick;
            dgvSetores.CellContentDoubleClick += dgvSetores_CellContentDoubleClick;
            // 
            // btnPesquisar
            // 
            resources.ApplyResources(btnPesquisar, "btnPesquisar");
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnListarTodos
            // 
            resources.ApplyResources(btnListarTodos, "btnListarTodos");
            btnListarTodos.Cursor = Cursors.Hand;
            btnListarTodos.Name = "btnListarTodos";
            btnListarTodos.UseVisualStyleBackColor = true;
            btnListarTodos.Click += btnListarTodos_Click;
            // 
            // txtNomeSetor
            // 
            resources.ApplyResources(txtNomeSetor, "txtNomeSetor");
            txtNomeSetor.Name = "txtNomeSetor";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtNomeSetor);
            Controls.Add(btnListarTodos);
            Controls.Add(btnPesquisar);
            Controls.Add(dgvSetores);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExcluir);
            Controls.Add(bntEditar);
            Controls.Add(btnCadastrar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvSetores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Button bntEditar;
        private Button btnExcluir;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtID;
        private TextBox txtNome;
        private DataGridView dgvSetores;
        private Button btnPesquisar;
        private Button btnListarTodos;
        private TextBox txtNomeSetor;
    }
}
