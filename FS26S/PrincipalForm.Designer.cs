
namespace FS26S
{
    partial class PrincipalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOrigem = new System.Windows.Forms.DataGridView();
            this.codeorigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameorigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDestino = new System.Windows.Forms.DataGridView();
            this.codedestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namedestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtxCaminho = new System.Windows.Forms.RichTextBox();
            this.nudConexaoMaisCurta = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDistanciaTotal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcularRotaLargura = new System.Windows.Forms.Button();
            this.btnCalcularRotaProfundidade = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigem)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestino)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConexaoMaisCurta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistanciaTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOrigem);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origem";
            // 
            // dgvOrigem
            // 
            this.dgvOrigem.AllowUserToAddRows = false;
            this.dgvOrigem.AllowUserToDeleteRows = false;
            this.dgvOrigem.AllowUserToResizeColumns = false;
            this.dgvOrigem.AllowUserToResizeRows = false;
            this.dgvOrigem.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOrigem.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvOrigem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrigem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeorigem,
            this.nameorigem});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrigem.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrigem.EnableHeadersVisualStyles = false;
            this.dgvOrigem.Location = new System.Drawing.Point(6, 22);
            this.dgvOrigem.Name = "dgvOrigem";
            this.dgvOrigem.RowHeadersVisible = false;
            this.dgvOrigem.RowTemplate.Height = 20;
            this.dgvOrigem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrigem.Size = new System.Drawing.Size(288, 172);
            this.dgvOrigem.TabIndex = 0;
            // 
            // codeorigem
            // 
            this.codeorigem.DataPropertyName = "code";
            this.codeorigem.HeaderText = "code";
            this.codeorigem.Name = "codeorigem";
            this.codeorigem.ReadOnly = true;
            this.codeorigem.Visible = false;
            // 
            // nameorigem
            // 
            this.nameorigem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameorigem.DataPropertyName = "name";
            this.nameorigem.HeaderText = "Nome";
            this.nameorigem.Name = "nameorigem";
            this.nameorigem.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDestino);
            this.groupBox2.Location = new System.Drawing.Point(318, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destino";
            // 
            // dgvDestino
            // 
            this.dgvDestino.AllowUserToAddRows = false;
            this.dgvDestino.AllowUserToDeleteRows = false;
            this.dgvDestino.AllowUserToResizeColumns = false;
            this.dgvDestino.AllowUserToResizeRows = false;
            this.dgvDestino.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDestino.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestino.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codedestino,
            this.namedestino});
            this.dgvDestino.EnableHeadersVisualStyles = false;
            this.dgvDestino.Location = new System.Drawing.Point(6, 22);
            this.dgvDestino.Name = "dgvDestino";
            this.dgvDestino.RowHeadersVisible = false;
            this.dgvDestino.RowTemplate.Height = 20;
            this.dgvDestino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestino.Size = new System.Drawing.Size(288, 172);
            this.dgvDestino.TabIndex = 1;
            // 
            // codedestino
            // 
            this.codedestino.DataPropertyName = "code";
            this.codedestino.HeaderText = "code";
            this.codedestino.Name = "codedestino";
            this.codedestino.ReadOnly = true;
            this.codedestino.Visible = false;
            // 
            // namedestino
            // 
            this.namedestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namedestino.DataPropertyName = "name";
            this.namedestino.HeaderText = "Nome";
            this.namedestino.Name = "namedestino";
            this.namedestino.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.nudConexaoMaisCurta);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.nudDistanciaTotal);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(606, 87);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultados";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtxCaminho);
            this.groupBox3.Location = new System.Drawing.Point(249, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 67);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Caminho";
            // 
            // rtxCaminho
            // 
            this.rtxCaminho.Location = new System.Drawing.Point(6, 22);
            this.rtxCaminho.Name = "rtxCaminho";
            this.rtxCaminho.Size = new System.Drawing.Size(339, 39);
            this.rtxCaminho.TabIndex = 0;
            this.rtxCaminho.Text = "Origem -> Conexão -> Conexão -> ... -> Destino";
            // 
            // nudConexaoMaisCurta
            // 
            this.nudConexaoMaisCurta.Location = new System.Drawing.Point(154, 51);
            this.nudConexaoMaisCurta.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nudConexaoMaisCurta.Name = "nudConexaoMaisCurta";
            this.nudConexaoMaisCurta.ReadOnly = true;
            this.nudConexaoMaisCurta.Size = new System.Drawing.Size(89, 23);
            this.nudConexaoMaisCurta.TabIndex = 3;
            this.nudConexaoMaisCurta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conexão mais curta (KM):";
            // 
            // nudDistanciaTotal
            // 
            this.nudDistanciaTotal.Location = new System.Drawing.Point(154, 22);
            this.nudDistanciaTotal.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nudDistanciaTotal.Name = "nudDistanciaTotal";
            this.nudDistanciaTotal.ReadOnly = true;
            this.nudDistanciaTotal.Size = new System.Drawing.Size(89, 23);
            this.nudDistanciaTotal.TabIndex = 1;
            this.nudDistanciaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distância (KM):";
            // 
            // btnCalcularRotaLargura
            // 
            this.btnCalcularRotaLargura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularRotaLargura.Location = new System.Drawing.Point(18, 218);
            this.btnCalcularRotaLargura.Name = "btnCalcularRotaLargura";
            this.btnCalcularRotaLargura.Size = new System.Drawing.Size(294, 29);
            this.btnCalcularRotaLargura.TabIndex = 3;
            this.btnCalcularRotaLargura.Text = "CALCULAR ROTA PROFUNDIDADE";
            this.btnCalcularRotaLargura.UseVisualStyleBackColor = true;
            this.btnCalcularRotaLargura.Click += new System.EventHandler(this.btnCalcularRota_Click);
            // 
            // btnCalcularRotaProfundidade
            // 
            this.btnCalcularRotaProfundidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularRotaProfundidade.Location = new System.Drawing.Point(318, 218);
            this.btnCalcularRotaProfundidade.Name = "btnCalcularRotaProfundidade";
            this.btnCalcularRotaProfundidade.Size = new System.Drawing.Size(294, 29);
            this.btnCalcularRotaProfundidade.TabIndex = 4;
            this.btnCalcularRotaProfundidade.Text = "CALCULAR ROTA A*";
            this.btnCalcularRotaProfundidade.UseVisualStyleBackColor = true;
            this.btnCalcularRotaProfundidade.Click += new System.EventHandler(this.btnCalcularRotaA_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(630, 349);
            this.Controls.Add(this.btnCalcularRotaProfundidade);
            this.Controls.Add(this.btnCalcularRotaLargura);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrincipalForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Shown += new System.EventHandler(this.PrincipalForm_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestino)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudConexaoMaisCurta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistanciaTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvOrigem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDestino;
        private System.Windows.Forms.Button btnCalcularRotaLargura;
        private System.Windows.Forms.NumericUpDown nudDistanciaTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudConexaoMaisCurta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtxCaminho;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeorigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameorigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn codedestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedestino;
        private System.Windows.Forms.Button btnCalcularRotaProfundidade;
    }
}

