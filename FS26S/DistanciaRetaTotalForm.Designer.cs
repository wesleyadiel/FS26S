
namespace FS26S
{
    partial class DistanciaRetaTotalForm
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
            this.nudDistancia = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDistancia
            // 
            this.nudDistancia.Location = new System.Drawing.Point(148, 83);
            this.nudDistancia.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.nudDistancia.Name = "nudDistancia";
            this.nudDistancia.Size = new System.Drawing.Size(120, 23);
            this.nudDistancia.TabIndex = 0;
            this.nudDistancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distância em linha reta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Origem";
            // 
            // txtOrigem
            // 
            this.txtOrigem.Enabled = false;
            this.txtOrigem.Location = new System.Drawing.Point(12, 49);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(118, 23);
            this.txtOrigem.TabIndex = 3;
            // 
            // txtDestino
            // 
            this.txtDestino.Enabled = false;
            this.txtDestino.Location = new System.Drawing.Point(148, 49);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(120, 23);
            this.txtDestino.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destino";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(193, 112);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // DistanciaRetaTotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 146);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDistancia);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DistanciaRetaTotalForm";
            this.Text = "Distancia em linha reta";
            this.Shown += new System.EventHandler(this.DistanciaRetaTotalForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDistancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
    }
}