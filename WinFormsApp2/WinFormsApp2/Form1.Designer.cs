namespace WinFormsApp2
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
            label1 = new Label();
            codigo = new TextBox();
            label2 = new Label();
            nome = new TextBox();
            label3 = new Label();
            preco = new TextBox();
            label4 = new Label();
            quantidade = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listprodutos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(127, 17);
            label1.TabIndex = 0;
            label1.Text = "Código do produto";
            // 
            // codigo
            // 
            codigo.Location = new Point(12, 87);
            codigo.Name = "codigo";
            codigo.Size = new Size(109, 23);
            codigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 128);
            label2.Name = "label2";
            label2.Size = new Size(121, 17);
            label2.TabIndex = 2;
            label2.Text = "Nome do produto";
            // 
            // nome
            // 
            nome.Location = new Point(12, 157);
            nome.Name = "nome";
            nome.Size = new Size(109, 23);
            nome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 200);
            label3.Name = "label3";
            label3.Size = new Size(120, 17);
            label3.TabIndex = 4;
            label3.Text = "Preço do produto";
            label3.Click += label3_Click;
            // 
            // preco
            // 
            preco.Location = new Point(12, 232);
            preco.Name = "preco";
            preco.Size = new Size(109, 23);
            preco.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 271);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 6;
            label4.Text = "Quantidade";
            // 
            // quantidade
            // 
            quantidade.Location = new Point(12, 289);
            quantidade.Name = "quantidade";
            quantidade.Size = new Size(109, 23);
            quantidade.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(54, 359);
            button1.Name = "button1";
            button1.Size = new Size(127, 62);
            button1.TabIndex = 8;
            button1.Text = "Adicionar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(220, 354);
            button2.Name = "button2";
            button2.Size = new Size(127, 67);
            button2.TabIndex = 9;
            button2.Text = "Encerrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(386, 354);
            button3.Name = "button3";
            button3.Size = new Size(127, 62);
            button3.TabIndex = 10;
            button3.Text = "Imprimir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listprodutos
            // 
            listprodutos.FormattingEnabled = true;
            listprodutos.ItemHeight = 15;
            listprodutos.Location = new Point(157, 44);
            listprodutos.Name = "listprodutos";
            listprodutos.Size = new Size(387, 304);
            listprodutos.TabIndex = 12;
            listprodutos.SelectedIndexChanged += listprodutos_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 443);
            Controls.Add(listprodutos);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(quantidade);
            Controls.Add(label4);
            Controls.Add(preco);
            Controls.Add(label3);
            Controls.Add(nome);
            Controls.Add(label2);
            Controls.Add(codigo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox codigo;
        private Label label2;
        private TextBox nome;
        private Label label3;
        private TextBox preco;
        private Label label4;
        private TextBox quantidade;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listprodutos;
    }
}
