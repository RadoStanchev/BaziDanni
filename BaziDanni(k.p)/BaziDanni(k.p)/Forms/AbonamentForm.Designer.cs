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
        _top = new TableLayoutPanel();
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
        _top.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_numPeriod).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_numPrice).BeginInit();
        SuspendLayout();
        // 
        // _grid
        // 
        _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _grid.Dock = DockStyle.Fill;
        _grid.Location = new Point(0, 55);
        _grid.Name = "_grid";
        _grid.ReadOnly = true;
        _grid.RowHeadersWidth = 51;
        _grid.Size = new Size(950, 525);
        _grid.TabIndex = 1;
        _grid.SelectionChanged += Grid_SelectionChanged;
        // 
        // _top
        // 
        _top.AutoSize = true;
        _top.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        _top.ColumnCount = 6;
        _top.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
        _top.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
        _top.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
        _top.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
        _top.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
        _top.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
        _top.Controls.Add(_lblId, 0, 0);
        _top.Controls.Add(_lblPeriod, 1, 0);
        _top.Controls.Add(_lblPrice, 2, 0);
        _top.Controls.Add(_txtId, 0, 1);
        _top.Controls.Add(_numPeriod, 1, 1);
        _top.Controls.Add(_numPrice, 2, 1);
        _top.Controls.Add(_btnAdd, 3, 1);
        _top.Controls.Add(_btnEdit, 4, 1);
        _top.Controls.Add(_btnDelete, 5, 1);
        _top.Dock = DockStyle.Top;
        _top.Location = new Point(0, 0);
        _top.Name = "_top";
        _top.Padding = new Padding(8);
        _top.Size = new Size(950, 55);
        _top.TabIndex = 0;
        // 
        // _lblId
        // 
        _lblId.AutoSize = true;
        _lblId.Text = "Номер";
        // 
        // _lblPeriod
        // 
        _lblPeriod.AutoSize = true;
        _lblPeriod.Text = "Период (мес.)";
        // 
        // _lblPrice
        // 
        _lblPrice.AutoSize = true;
        _lblPrice.Text = "Цена (лв.)";
        // 
        // _txtId
        // 
        _txtId.PlaceholderText = "N_abonament";
        _txtId.Size = new Size(150, 27);
        // 
        // _numPeriod
        // 
        _numPeriod.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
        _numPeriod.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        _numPeriod.Size = new Size(180, 27);
        _numPeriod.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // _numPrice
        // 
        _numPrice.DecimalPlaces = 2;
        _numPrice.Increment = new decimal(new int[] { 5, 0, 0, 0 });
        _numPrice.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
        _numPrice.Size = new Size(180, 27);
        // 
        // _btnAdd
        // 
        _btnAdd.Text = "Добави";
        _btnAdd.Click += BtnAdd_Click;
        // 
        // _btnEdit
        // 
        _btnEdit.Text = "Редактирай";
        _btnEdit.Click += BtnEdit_Click;
        // 
        // _btnDelete
        // 
        _btnDelete.Text = "Изтрий";
        _btnDelete.Click += BtnDelete_Click;
        // 
        // AbonamentForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(950, 580);
        Controls.Add(_grid);
        Controls.Add(_top);
        Name = "AbonamentForm";
        Text = "Управление: ABONAMENT";
        ((System.ComponentModel.ISupportInitialize)_grid).EndInit();
        _top.ResumeLayout(false);
        _top.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_numPeriod).EndInit();
        ((System.ComponentModel.ISupportInitialize)_numPrice).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private DataGridView _grid = null!;
    private TableLayoutPanel _top = null!;
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
