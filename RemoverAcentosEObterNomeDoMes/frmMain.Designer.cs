namespace RemoverAcentosEObterNomeDoMes
{
    partial class frmMain
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
            lblData = new Label();
            btnObterMes = new Button();
            txtMes = new TextBox();
            btnObterMesSemAcento = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.Location = new Point(12, 40);
            lblData.Name = "lblData";
            lblData.Size = new Size(87, 21);
            lblData.TabIndex = 0;
            lblData.Text = "01/01/1970";
            // 
            // btnObterMes
            // 
            btnObterMes.Font = new Font("Segoe UI", 9F);
            btnObterMes.Location = new Point(125, 33);
            btnObterMes.Name = "btnObterMes";
            btnObterMes.Size = new Size(107, 35);
            btnObterMes.TabIndex = 1;
            btnObterMes.Text = "Obter o mês";
            btnObterMes.UseVisualStyleBackColor = true;
            btnObterMes.Click += btnObterMes_Click;
            // 
            // txtMes
            // 
            txtMes.BackColor = SystemColors.ButtonHighlight;
            txtMes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMes.Location = new Point(159, 103);
            txtMes.Name = "txtMes";
            txtMes.ReadOnly = true;
            txtMes.Size = new Size(123, 29);
            txtMes.TabIndex = 2;
            txtMes.TextAlign = HorizontalAlignment.Center;
            // 
            // btnObterMesSemAcento
            // 
            btnObterMesSemAcento.Font = new Font("Segoe UI", 9F);
            btnObterMesSemAcento.Location = new Point(249, 33);
            btnObterMesSemAcento.Name = "btnObterMesSemAcento";
            btnObterMesSemAcento.Size = new Size(200, 35);
            btnObterMesSemAcento.TabIndex = 3;
            btnObterMesSemAcento.Text = "Obter o mês e remover acentos";
            btnObterMesSemAcento.UseVisualStyleBackColor = true;
            btnObterMesSemAcento.Click += btnObterMesSemAcento_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(341, 99);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(97, 35);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 155);
            Controls.Add(btnLimpar);
            Controls.Add(btnObterMesSemAcento);
            Controls.Add(txtMes);
            Controls.Add(btnObterMes);
            Controls.Add(lblData);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Obter o Mês e remover acentos";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblData;
        private Button btnObterMes;
        private TextBox txtMes;
        private Button btnObterMesSemAcento;
        private Button btnLimpar;
    }
}
