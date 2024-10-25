namespace Projeto_Felix
{
    partial class FormPrincipal
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
            LoadData = new DataGridView();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)LoadData).BeginInit();
            SuspendLayout();
            // 
            // LoadData
            // 
            LoadData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LoadData.Location = new Point(143, 248);
            LoadData.Name = "LoadData";
            LoadData.RowTemplate.Height = 25;
            LoadData.Size = new Size(539, 154);
            LoadData.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(143, 111);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(147, 70);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(349, 111);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(147, 70);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(535, 111);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(147, 70);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vivaldi", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(235, 44);
            label1.Name = "label1";
            label1.Size = new Size(388, 34);
            label1.TabIndex = 4;
            label1.Text = "Lista e Gerenciamento de Produtos";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(LoadData);
            Name = "FormPrincipal";
            Text = "Form1";
         
            ((System.ComponentModel.ISupportInitialize)LoadData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView LoadData;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnExcluir;
        private Label label1;
    }
}