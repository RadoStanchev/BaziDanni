namespace BaziDanni_k.p_.Forms;

partial class GrupaForm
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        _grid = new DataGridView();
        _txtNGrupa = new TextBox();
        _cmbSport = new ComboBox();
        _cmbNivo = new ComboBox();
        _cmbTrenior = new ComboBox();
        _btnAdd = new Button(); _btnEdit = new Button(); _btnDelete = new Button(); _btnRefresh = new Button();
        _lblNGrupa = new Label(); _lblSport = new Label(); _lblNivo = new Label(); _lblTrenior = new Label();
        ((System.ComponentModel.ISupportInitialize)_grid).BeginInit(); SuspendLayout();

        _lblNGrupa.AutoSize = true; _lblNGrupa.Location = new Point(12, 15); _lblNGrupa.Text = "Номер група";
        _txtNGrupa.Location = new Point(12, 38); _txtNGrupa.Width = 150; _txtNGrupa.PlaceholderText = "N_grupa";
        _lblSport.AutoSize = true; _lblSport.Location = new Point(182, 15); _lblSport.Text = "Спорт";
        _cmbSport.Location = new Point(182, 38); _cmbSport.Width = 220; _cmbSport.DropDownStyle = ComboBoxStyle.DropDownList;
        _lblNivo.AutoSize = true; _lblNivo.Location = new Point(422, 15); _lblNivo.Text = "Ниво";
        _cmbNivo.Location = new Point(422, 38); _cmbNivo.Width = 220; _cmbNivo.DropDownStyle = ComboBoxStyle.DropDownList;
        _lblTrenior.AutoSize = true; _lblTrenior.Location = new Point(662, 15); _lblTrenior.Text = "Треньор";
        _cmbTrenior.Location = new Point(662, 38); _cmbTrenior.Width = 220; _cmbTrenior.DropDownStyle = ComboBoxStyle.DropDownList;

        _btnAdd.Location = new Point(902, 36); _btnAdd.Text = "Добави"; _btnAdd.Click += BtnAdd_Click;
        _btnEdit.Location = new Point(1002, 36); _btnEdit.Text = "Редактирай"; _btnEdit.Click += BtnEdit_Click;
        _btnDelete.Location = new Point(902, 70); _btnDelete.Text = "Изтрий"; _btnDelete.Click += BtnDelete_Click;
        _btnRefresh.Location = new Point(1002, 70); _btnRefresh.Text = "Обнови"; _btnRefresh.Click += BtnRefresh_Click;

        _grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _grid.ReadOnly = true; _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect; _grid.MultiSelect = false;
        _grid.Location = new Point(12, 110); _grid.Size = new Size(1076, 498); _grid.SelectionChanged += Grid_SelectionChanged;

        AutoScaleDimensions = new SizeF(8F,20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(1100,620); Text = "Управление: GRUPA"; Name = "GrupaForm";
        Controls.AddRange([_grid,_btnRefresh,_btnDelete,_btnEdit,_btnAdd,_cmbTrenior,_lblTrenior,_cmbNivo,_lblNivo,_cmbSport,_lblSport,_txtNGrupa,_lblNGrupa]);
        ((System.ComponentModel.ISupportInitialize)_grid).EndInit(); ResumeLayout(false); PerformLayout();
    }

    private DataGridView _grid = null!; private TextBox _txtNGrupa = null!; private ComboBox _cmbSport = null!; private ComboBox _cmbNivo = null!; private ComboBox _cmbTrenior = null!; private Button _btnAdd = null!; private Button _btnEdit = null!; private Button _btnDelete = null!; private Button _btnRefresh = null!; private Label _lblNGrupa = null!; private Label _lblSport = null!; private Label _lblNivo = null!; private Label _lblTrenior = null!;
}
