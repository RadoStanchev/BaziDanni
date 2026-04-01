namespace BaziDanni_k.p_.Forms;

partial class DenSedmicaForm
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        _grid = new DataGridView();
        _lblId = new Label();
        _lblDay = new Label();
        _lblColor = new Label();
        _txtId = new TextBox();
        _cmbDay = new ComboBox();
        _cmbColor = new ComboBox();
        _addBtn = new Button();
        _editBtn = new Button();
        _delBtn = new Button();
        ((System.ComponentModel.ISupportInitialize)_grid).BeginInit();
        SuspendLayout();

        _lblId.AutoSize = true; _lblId.Location = new Point(12, 15); _lblId.Text = "Номер";
        _txtId.Location = new Point(12, 38); _txtId.Size = new Size(90, 27);

        _lblDay.AutoSize = true; _lblDay.Location = new Point(122, 15); _lblDay.Text = "Ден";
        _cmbDay.Location = new Point(122, 38); _cmbDay.Width = 160; _cmbDay.DropDownStyle = ComboBoxStyle.DropDownList;
        _cmbDay.Items.AddRange(["Понеделник", "Вторник", "Сряда", "Четвъртък", "Петък", "Събота", "Неделя"]);
        _cmbDay.SelectedIndex = 0;

        _lblColor.AutoSize = true; _lblColor.Location = new Point(302, 15); _lblColor.Text = "Цвят";
        _cmbColor.Location = new Point(302, 38); _cmbColor.Width = 140; _cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
        _cmbColor.Items.AddRange(["червен", "син", "зелен", "жълт", "лилав"]);
        _cmbColor.SelectedIndex = 0;

        _addBtn.Location = new Point(462, 36); _addBtn.Size = new Size(100, 29); _addBtn.Text = "Добави"; _addBtn.Click += AddBtn_Click;
        _editBtn.Location = new Point(568, 36); _editBtn.Size = new Size(100, 29); _editBtn.Text = "Редактирай"; _editBtn.Click += EditBtn_Click;
        _delBtn.Location = new Point(674, 36); _delBtn.Size = new Size(100, 29); _delBtn.Text = "Изтрий"; _delBtn.Click += DelBtn_Click;

        _grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _grid.ReadOnly = true;
        _grid.Location = new Point(12, 100);
        _grid.Size = new Size(876, 408);
        _grid.SelectionChanged += Grid_SelectionChanged;

        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 520);
        Controls.Add(_grid);
        Controls.Add(_delBtn);
        Controls.Add(_editBtn);
        Controls.Add(_addBtn);
        Controls.Add(_cmbColor);
        Controls.Add(_lblColor);
        Controls.Add(_cmbDay);
        Controls.Add(_lblDay);
        Controls.Add(_txtId);
        Controls.Add(_lblId);
        Text = "Управление: DEN_SEDMICA";
        Name = "DenSedmicaForm";
        ((System.ComponentModel.ISupportInitialize)_grid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private DataGridView _grid = null!;
    private Label _lblId = null!;
    private Label _lblDay = null!;
    private Label _lblColor = null!;
    private TextBox _txtId = null!;
    private ComboBox _cmbDay = null!;
    private ComboBox _cmbColor = null!;
    private Button _addBtn = null!;
    private Button _editBtn = null!;
    private Button _delBtn = null!;
}
