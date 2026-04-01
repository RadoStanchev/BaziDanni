namespace BaziDanni_k.p_.Forms;

partial class GrupaForm
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        _grid = new DataGridView();
        _top = new FlowLayoutPanel();
        _txtNGrupa = new TextBox();
        _cmbSport = new ComboBox();
        _cmbNivo = new ComboBox();
        _cmbTrenior = new ComboBox();
        _btnAdd = new Button(); _btnEdit = new Button(); _btnDelete = new Button(); _btnRefresh = new Button();
        ((System.ComponentModel.ISupportInitialize)_grid).BeginInit(); SuspendLayout();
        _grid.Dock = DockStyle.Fill; _grid.ReadOnly = true; _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect; _grid.MultiSelect = false; _grid.Location = new Point(0,43); _grid.SelectionChanged += Grid_SelectionChanged;
        _top.Dock = DockStyle.Top; _top.AutoSize = true; _top.AutoSizeMode = AutoSizeMode.GrowAndShrink; _top.Padding = new Padding(8);
        _txtNGrupa.Width = 150; _txtNGrupa.PlaceholderText = "N_grupa";
        _cmbSport.Width = 220; _cmbSport.DropDownStyle = ComboBoxStyle.DropDownList;
        _cmbNivo.Width = 220; _cmbNivo.DropDownStyle = ComboBoxStyle.DropDownList;
        _cmbTrenior.Width = 220; _cmbTrenior.DropDownStyle = ComboBoxStyle.DropDownList;
        _btnAdd.Text = "Добави"; _btnAdd.Click += BtnAdd_Click;
        _btnEdit.Text = "Редактирай"; _btnEdit.Click += BtnEdit_Click;
        _btnDelete.Text = "Изтрий"; _btnDelete.Click += BtnDelete_Click;
        _btnRefresh.Text = "Обнови"; _btnRefresh.Click += BtnRefresh_Click;
        _top.Controls.AddRange([_txtNGrupa,_cmbSport,_cmbNivo,_cmbTrenior,_btnAdd,_btnEdit,_btnDelete,_btnRefresh]);
        AutoScaleDimensions=new SizeF(8F,20F); AutoScaleMode=AutoScaleMode.Font; ClientSize=new Size(1100,620); Text="Управление: GRUPA"; Name="GrupaForm";
        Controls.Add(_grid); Controls.Add(_top); ((System.ComponentModel.ISupportInitialize)_grid).EndInit(); ResumeLayout(false); PerformLayout();
    }

    private DataGridView _grid = null!; private FlowLayoutPanel _top = null!; private TextBox _txtNGrupa = null!; private ComboBox _cmbSport = null!; private ComboBox _cmbNivo = null!; private ComboBox _cmbTrenior = null!; private Button _btnAdd = null!; private Button _btnEdit = null!; private Button _btnDelete = null!; private Button _btnRefresh = null!;
}
