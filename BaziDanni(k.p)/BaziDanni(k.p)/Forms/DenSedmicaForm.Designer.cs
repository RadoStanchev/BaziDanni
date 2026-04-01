namespace BaziDanni_k.p_.Forms;

partial class DenSedmicaForm
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        _grid = new DataGridView();
        _toolbar = new ToolStrip();
        _txtId = new TextBox();
        _cmbDay = new ComboBox();
        _cmbColor = new ComboBox();
        _addBtn = new ToolStripButton();
        _editBtn = new ToolStripButton();
        _delBtn = new ToolStripButton();
        ((System.ComponentModel.ISupportInitialize)_grid).BeginInit();
        SuspendLayout();
        _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _grid.Dock = DockStyle.Fill;
        _grid.ReadOnly = true;
        _grid.Location = new Point(0, 27);
        _grid.SelectionChanged += Grid_SelectionChanged;

        _toolbar.Dock = DockStyle.Top;
        _toolbar.Items.Add("Номер");
        _txtId.Width = 90;
        _toolbar.Items.Add(new ToolStripControlHost(_txtId));
        _toolbar.Items.Add(new ToolStripSeparator());
        _toolbar.Items.Add("Ден");
        _cmbDay.Width = 160; _cmbDay.DropDownStyle = ComboBoxStyle.DropDownList;
        _cmbDay.Items.AddRange(["Понеделник", "Вторник", "Сряда", "Четвъртък", "Петък", "Събота", "Неделя"]);
        _cmbDay.SelectedIndex = 0;
        _toolbar.Items.Add(new ToolStripControlHost(_cmbDay));
        _toolbar.Items.Add("Цвят");
        _cmbColor.Width = 140; _cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
        _cmbColor.Items.AddRange(["червен", "син", "зелен", "жълт", "лилав"]);
        _cmbColor.SelectedIndex = 0;
        _toolbar.Items.Add(new ToolStripControlHost(_cmbColor));
        _addBtn.Text = "Добави"; _addBtn.Click += AddBtn_Click;
        _editBtn.Text = "Редактирай"; _editBtn.Click += EditBtn_Click;
        _delBtn.Text = "Изтрий"; _delBtn.Click += DelBtn_Click;
        _toolbar.Items.Add(_addBtn); _toolbar.Items.Add(_editBtn); _toolbar.Items.Add(_delBtn);

        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 520);
        Controls.Add(_grid);
        Controls.Add(_toolbar);
        Text = "Управление: DEN_SEDMICA";
        Name = "DenSedmicaForm";
        ((System.ComponentModel.ISupportInitialize)_grid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private DataGridView _grid = null!;
    private ToolStrip _toolbar = null!;
    private TextBox _txtId = null!;
    private ComboBox _cmbDay = null!;
    private ComboBox _cmbColor = null!;
    private ToolStripButton _addBtn = null!;
    private ToolStripButton _editBtn = null!;
    private ToolStripButton _delBtn = null!;
}
