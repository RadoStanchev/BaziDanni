namespace BaziDanni_k.p_
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
            _btnNivo = new Button();
            _btnDenSedmica = new Button();
            _btnAbonament = new Button();
            _btnChlen = new Button();
            _btnSport = new Button();
            _btnTrenior = new Button();
            _btnGrupa = new Button();
            _btnTrenirovka = new Button();
            _btnZapisaniAbonamenti = new Button();
            SuspendLayout();
            // 
            // _btnNivo
            // 
            _btnNivo.Location = new Point(10, 10);
            _btnNivo.Name = "_btnNivo";
            _btnNivo.Size = new Size(240, 56);
            _btnNivo.TabIndex = 0;
            _btnNivo.Text = "NIVO";
            _btnNivo.UseVisualStyleBackColor = true;
            _btnNivo.Click += BtnNivo_Click;
            // 
            // _btnDenSedmica
            // 
            _btnDenSedmica.Location = new Point(260, 10);
            _btnDenSedmica.Name = "_btnDenSedmica";
            _btnDenSedmica.Size = new Size(240, 56);
            _btnDenSedmica.TabIndex = 1;
            _btnDenSedmica.Text = "DEN_SEDMICA";
            _btnDenSedmica.UseVisualStyleBackColor = true;
            _btnDenSedmica.Click += BtnDenSedmica_Click;
            // 
            // _btnAbonament
            // 
            _btnAbonament.Location = new Point(510, 10);
            _btnAbonament.Name = "_btnAbonament";
            _btnAbonament.Size = new Size(240, 56);
            _btnAbonament.TabIndex = 2;
            _btnAbonament.Text = "ABONAMENT";
            _btnAbonament.UseVisualStyleBackColor = true;
            _btnAbonament.Click += BtnAbonament_Click;
            // 
            // _btnChlen
            // 
            _btnChlen.Location = new Point(10, 76);
            _btnChlen.Name = "_btnChlen";
            _btnChlen.Size = new Size(240, 56);
            _btnChlen.TabIndex = 3;
            _btnChlen.Text = "CHLEN";
            _btnChlen.UseVisualStyleBackColor = true;
            _btnChlen.Click += BtnChlen_Click;
            // 
            // _btnSport
            // 
            _btnSport.Location = new Point(260, 76);
            _btnSport.Name = "_btnSport";
            _btnSport.Size = new Size(240, 56);
            _btnSport.TabIndex = 4;
            _btnSport.Text = "SPORT";
            _btnSport.UseVisualStyleBackColor = true;
            _btnSport.Click += BtnSport_Click;
            // 
            // _btnTrenior
            // 
            _btnTrenior.Location = new Point(510, 76);
            _btnTrenior.Name = "_btnTrenior";
            _btnTrenior.Size = new Size(240, 56);
            _btnTrenior.TabIndex = 5;
            _btnTrenior.Text = "TRENIOR";
            _btnTrenior.UseVisualStyleBackColor = true;
            _btnTrenior.Click += BtnTrenior_Click;
            // 
            // _btnGrupa
            // 
            _btnGrupa.Location = new Point(10, 142);
            _btnGrupa.Name = "_btnGrupa";
            _btnGrupa.Size = new Size(240, 56);
            _btnGrupa.TabIndex = 6;
            _btnGrupa.Text = "GRUPA";
            _btnGrupa.UseVisualStyleBackColor = true;
            _btnGrupa.Click += BtnGrupa_Click;
            // 
            // _btnTrenirovka
            // 
            _btnTrenirovka.Location = new Point(260, 142);
            _btnTrenirovka.Name = "_btnTrenirovka";
            _btnTrenirovka.Size = new Size(240, 56);
            _btnTrenirovka.TabIndex = 7;
            _btnTrenirovka.Text = "TRENIROVKA";
            _btnTrenirovka.UseVisualStyleBackColor = true;
            _btnTrenirovka.Click += BtnTrenirovka_Click;
            // 
            // _btnZapisaniAbonamenti
            // 
            _btnZapisaniAbonamenti.Location = new Point(510, 142);
            _btnZapisaniAbonamenti.Name = "_btnZapisaniAbonamenti";
            _btnZapisaniAbonamenti.Size = new Size(240, 56);
            _btnZapisaniAbonamenti.TabIndex = 8;
            _btnZapisaniAbonamenti.Text = "ZAPISANI_ABONAMENTI";
            _btnZapisaniAbonamenti.UseVisualStyleBackColor = true;
            _btnZapisaniAbonamenti.Click += BtnZapisaniAbonamenti_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(_btnZapisaniAbonamenti);
            Controls.Add(_btnTrenirovka);
            Controls.Add(_btnGrupa);
            Controls.Add(_btnTrenior);
            Controls.Add(_btnSport);
            Controls.Add(_btnChlen);
            Controls.Add(_btnAbonament);
            Controls.Add(_btnDenSedmica);
            Controls.Add(_btnNivo);
            Name = "Form1";
            Text = "Курсов проект - Управление на таблици";
            ResumeLayout(false);
        }

        #endregion

        private Button _btnNivo;
        private Button _btnDenSedmica;
        private Button _btnAbonament;
        private Button _btnChlen;
        private Button _btnSport;
        private Button _btnTrenior;
        private Button _btnGrupa;
        private Button _btnTrenirovka;
        private Button _btnZapisaniAbonamenti;
    }
}
