namespace BaziDanni_k.p_.Forms;

partial class AbonamentForm
{
    private System.ComponentModel.IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        _grid = new DataGridView();
        _lblId = new Label();
        _lblPeriod = new Label();
        _lblPrice = new Label();
        _txtId = new TextBox();
        _numPeriod = new NumericUpDown();
        _numPrice = new NumericUpDown();
        _btnAdd = new Button();
        _btnEdit = new Button();
        _btnDelete = new Button();
        ((System.ComponentModel.ISupportInitialize)_grid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_numPeriod).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_numPrice).BeginInit();
        SuspendLayout();
        // 
        // _lblId
        // 
        _lblId.AutoSize = true;
        _lblId.Location = new Point(12, 15);
        _lblId.Name = "_lblId";
        _lblId.Size = new Size(49, 20);
        _lblId.TabIndex = 0;
        _lblId.Text = "Номер";
        // 
        // _lblPeriod
        // 
        _lblPeriod.AutoSize = true;
        _lblPeriod.Location = new Point(182, 15);
        _lblPeriod.Name = "_lblPeriod";
        _lblPeriod.Size = new Size(112, 20);
        _lblPeriod.TabIndex = 1;
        _lblPeriod.Text = "Период (мес.)";
        // 
        // _lblPrice
        // 
        _lblPrice.AutoSize = true;
        _lblPrice.Location = new Point(382, 15);
        _lblPrice.Name = "_lblPrice";
        _lblPrice.Size = new Size(79, 20);
        _lblPrice.TabIndex = 2;
        _lblPrice.Text = "Цена (лв.)";
        // 
        // _txtId
        // 
        _txtId.Location = new Point(12, 38);
        _txtId.Name = "_txtId";
        _txtId.PlaceholderText = "N_abonament";
        _txtId.Size = new Size(150, 27);
        _txtId.TabIndex = 3;
        // 
        // _numPeriod
        // 
        _numPeriod.Location = new Point(182, 38);
        _numPeriod.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
        _numPeriod.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        _numPeriod.Name = "_numPeriod";
        _numPeriod.Size = new Size(180, 27);
        _numPeriod.TabIndex = 4;
        _numPeriod.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // _numPrice
        // 
        _numPrice.DecimalPlaces = 2;
        _numPrice.Increment = new decimal(new int[] { 5, 0, 0, 0 });
        _numPrice.Location = new Point(382, 38);
        _numPrice.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
        _numPrice.Name = "_numPrice";
        _numPrice.Size = new Size(180, 27);
        _numPrice.TabIndex = 5;
        // 
        // _btnAdd
        // 
        _btnAdd.Location = new Point(582, 36);
        _btnAdd.Name = "_btnAdd";
        _btnAdd.Size = new Size(100, 29);
        _btnAdd.TabIndex = 6;
        _btnAdd.Text = "Добави";
        _btnAdd.Click += BtnAdd_Click;
        // 
        // _btnEdit
        // 
        _btnEdit.Location = new Point(688, 36);
        _btnEdit.Name = "_btnEdit";
        _btnEdit.Size = new Size(100, 29);
        _btnEdit.TabIndex = 7;
        _btnEdit.Text = "Редактирай";
        _btnEdit.Click += BtnEdit_Click;
        // 
        // _btnDelete
        // 
        _btnDelete.Location = new Point(794, 36);
        _btnDelete.Name = "_btnDelete";
        _btnDelete.Size = new Size(100, 29);
        _btnDelete.TabIndex = 8;
        _btnDelete.Text = "Изтрий";
        _btnDelete.Click += BtnDelete_Click;
        // 
        // _grid
        // 
        _grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _grid.Location = new Point(12, 100);
        _grid.Name = "_grid";
        _grid.ReadOnly = true;
        _grid.RowHeadersWidth = 51;
        _grid.Size = new Size(926, 468);
        _grid.TabIndex = 9;
        _grid.SelectionChanged += Grid_SelectionChanged;
        // 
        // AbonamentForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(950, 580);
        Controls.Add(_grid);
        Controls.Add(_btnDelete);
        Controls.Add(_btnEdit);
        Controls.Add(_btnAdd);
        Controls.Add(_numPrice);
        Controls.Add(_numPeriod);
        Controls.Add(_txtId);
        Controls.Add(_lblPrice);
        Controls.Add(_lblPeriod);
        Controls.Add(_lblId);
        Name = "AbonamentForm";
        Text = "Управление: ABONAMENT";
        ((System.ComponentModel.ISupportInitialize)_grid).EndInit();
        ((System.ComponentModel.ISupportInitialize)_numPeriod).EndInit();
        ((System.ComponentModel.ISupportInitialize)_numPrice).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private DataGridView _grid = null!;
    private Label _lblId = null!;
    private Label _lblPeriod = null!;
    private Label _lblPrice = null!;
    private TextBox _txtId = null!;
    private NumericUpDown _numPeriod = null!;
    private NumericUpDown _numPrice = null!;
    private Button _btnAdd = null!;
    private Button _btnEdit = null!;
    private Button _btnDelete = null!;
}
