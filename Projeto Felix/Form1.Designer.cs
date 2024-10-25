namespace Projeto_Felix
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalvar = new Button();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(330, 299);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(164, 58);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(237, 161);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(356, 23);
            txtNome.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(237, 221);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(356, 23);
            txtPreco.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(251, 102);
            label1.Name = "label1";
            label1.Size = new Size(328, 33);
            label1.TabIndex = 3;
            label1.Text = "Cadastro/ Atualização";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 164);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 224);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "Preço";
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(btnSalvar);
            Name = "FormCadastro";
            Text = "Cadastro";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox txtNome;
        private TextBox txtPreco;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}