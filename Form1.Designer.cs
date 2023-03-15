
namespace ReajusteSalarial
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHtrabalhadas = new System.Windows.Forms.TextBox();
            this.grpboxCategoria = new System.Windows.Forms.GroupBox();
            this.rbtnVeterano = new System.Windows.Forms.RadioButton();
            this.rbtnCalouro = new System.Windows.Forms.RadioButton();
            this.grpBoxTurno = new System.Windows.Forms.GroupBox();
            this.rbtnNoturno = new System.Windows.Forms.RadioButton();
            this.rbtnVespertino = new System.Windows.Forms.RadioButton();
            this.rbtnMatutino = new System.Windows.Forms.RadioButton();
            this.lbxresumo = new System.Windows.Forms.ListBox();
            this.lblSituacaoEstagiario = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpboxCategoria.SuspendLayout();
            this.grpBoxTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário Mínimo:";
            // 
            // txtSalMin
            // 
            this.txtSalMin.Location = new System.Drawing.Point(118, 33);
            this.txtSalMin.Name = "txtSalMin";
            this.txtSalMin.Size = new System.Drawing.Size(100, 20);
            this.txtSalMin.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtSalMin, "Informe o valor atual para o salário mínino");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horas Trabalhadas:";
            // 
            // txtHtrabalhadas
            // 
            this.txtHtrabalhadas.Location = new System.Drawing.Point(118, 59);
            this.txtHtrabalhadas.Name = "txtHtrabalhadas";
            this.txtHtrabalhadas.Size = new System.Drawing.Size(100, 20);
            this.txtHtrabalhadas.TabIndex = 3;
            // 
            // grpboxCategoria
            // 
            this.grpboxCategoria.Controls.Add(this.rbtnVeterano);
            this.grpboxCategoria.Controls.Add(this.rbtnCalouro);
            this.grpboxCategoria.Location = new System.Drawing.Point(15, 95);
            this.grpboxCategoria.Name = "grpboxCategoria";
            this.grpboxCategoria.Size = new System.Drawing.Size(200, 42);
            this.grpboxCategoria.TabIndex = 4;
            this.grpboxCategoria.TabStop = false;
            this.grpboxCategoria.Text = "Categoria";
            // 
            // rbtnVeterano
            // 
            this.rbtnVeterano.AutoSize = true;
            this.rbtnVeterano.Location = new System.Drawing.Point(126, 17);
            this.rbtnVeterano.Name = "rbtnVeterano";
            this.rbtnVeterano.Size = new System.Drawing.Size(68, 17);
            this.rbtnVeterano.TabIndex = 1;
            this.rbtnVeterano.TabStop = true;
            this.rbtnVeterano.Text = "Veterano";
            this.rbtnVeterano.UseVisualStyleBackColor = true;
            // 
            // rbtnCalouro
            // 
            this.rbtnCalouro.AutoSize = true;
            this.rbtnCalouro.Location = new System.Drawing.Point(10, 17);
            this.rbtnCalouro.Name = "rbtnCalouro";
            this.rbtnCalouro.Size = new System.Drawing.Size(61, 17);
            this.rbtnCalouro.TabIndex = 0;
            this.rbtnCalouro.TabStop = true;
            this.rbtnCalouro.Text = "Calouro";
            this.rbtnCalouro.UseVisualStyleBackColor = true;
            // 
            // grpBoxTurno
            // 
            this.grpBoxTurno.Controls.Add(this.rbtnNoturno);
            this.grpBoxTurno.Controls.Add(this.rbtnVespertino);
            this.grpBoxTurno.Controls.Add(this.rbtnMatutino);
            this.grpBoxTurno.Location = new System.Drawing.Point(257, 36);
            this.grpBoxTurno.Name = "grpBoxTurno";
            this.grpBoxTurno.Size = new System.Drawing.Size(139, 100);
            this.grpBoxTurno.TabIndex = 5;
            this.grpBoxTurno.TabStop = false;
            this.grpBoxTurno.Text = "Turno";
            // 
            // rbtnNoturno
            // 
            this.rbtnNoturno.AutoSize = true;
            this.rbtnNoturno.Location = new System.Drawing.Point(6, 72);
            this.rbtnNoturno.Name = "rbtnNoturno";
            this.rbtnNoturno.Size = new System.Drawing.Size(63, 17);
            this.rbtnNoturno.TabIndex = 3;
            this.rbtnNoturno.TabStop = true;
            this.rbtnNoturno.Text = "Noturno";
            this.rbtnNoturno.UseVisualStyleBackColor = true;
            // 
            // rbtnVespertino
            // 
            this.rbtnVespertino.AutoSize = true;
            this.rbtnVespertino.Location = new System.Drawing.Point(6, 49);
            this.rbtnVespertino.Name = "rbtnVespertino";
            this.rbtnVespertino.Size = new System.Drawing.Size(75, 17);
            this.rbtnVespertino.TabIndex = 2;
            this.rbtnVespertino.TabStop = true;
            this.rbtnVespertino.Text = "Vespertino";
            this.rbtnVespertino.UseVisualStyleBackColor = true;
            // 
            // rbtnMatutino
            // 
            this.rbtnMatutino.AutoSize = true;
            this.rbtnMatutino.Location = new System.Drawing.Point(6, 26);
            this.rbtnMatutino.Name = "rbtnMatutino";
            this.rbtnMatutino.Size = new System.Drawing.Size(66, 17);
            this.rbtnMatutino.TabIndex = 1;
            this.rbtnMatutino.TabStop = true;
            this.rbtnMatutino.Text = "Matutino";
            this.rbtnMatutino.UseVisualStyleBackColor = true;
            // 
            // lbxresumo
            // 
            this.lbxresumo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxresumo.FormattingEnabled = true;
            this.lbxresumo.ItemHeight = 14;
            this.lbxresumo.Location = new System.Drawing.Point(17, 161);
            this.lbxresumo.MultiColumn = true;
            this.lbxresumo.Name = "lbxresumo";
            this.lbxresumo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxresumo.Size = new System.Drawing.Size(379, 88);
            this.lbxresumo.TabIndex = 6;
            // 
            // lblSituacaoEstagiario
            // 
            this.lblSituacaoEstagiario.BackColor = System.Drawing.Color.Yellow;
            this.lblSituacaoEstagiario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSituacaoEstagiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacaoEstagiario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSituacaoEstagiario.Location = new System.Drawing.Point(17, 271);
            this.lblSituacaoEstagiario.Name = "lblSituacaoEstagiario";
            this.lblSituacaoEstagiario.Size = new System.Drawing.Size(279, 23);
            this.lblSituacaoEstagiario.TabIndex = 7;
            this.lblSituacaoEstagiario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(302, 271);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(92, 24);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 334);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSituacaoEstagiario);
            this.Controls.Add(this.lbxresumo);
            this.Controls.Add(this.grpBoxTurno);
            this.Controls.Add(this.grpboxCategoria);
            this.Controls.Add(this.txtHtrabalhadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalMin);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxCategoria.ResumeLayout(false);
            this.grpboxCategoria.PerformLayout();
            this.grpBoxTurno.ResumeLayout(false);
            this.grpBoxTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHtrabalhadas;
        private System.Windows.Forms.GroupBox grpboxCategoria;
        private System.Windows.Forms.RadioButton rbtnVeterano;
        private System.Windows.Forms.RadioButton rbtnCalouro;
        private System.Windows.Forms.GroupBox grpBoxTurno;
        private System.Windows.Forms.RadioButton rbtnNoturno;
        private System.Windows.Forms.RadioButton rbtnVespertino;
        private System.Windows.Forms.RadioButton rbtnMatutino;
        private System.Windows.Forms.ListBox lbxresumo;
        private System.Windows.Forms.Label lblSituacaoEstagiario;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

