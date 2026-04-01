namespace BaziDanni_k.p_.Forms;
partial class ZapisaniAbonamentiForm
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing){ if (disposing && components!=null) components.Dispose(); base.Dispose(disposing);}    
    private void InitializeComponent(){ _grid=new DataGridView(); _cmbChlen=new ComboBox(); _cmbGroup=new ComboBox(); _cmbAbonament=new ComboBox(); _date=new DateTimePicker(); _btnAdd=new Button(); _btnEdit=new Button(); _btnDelete=new Button(); _lblChlen=new Label(); _lblGroup=new Label(); _lblAbonament=new Label(); _lblDate=new Label(); ((System.ComponentModel.ISupportInitialize)_grid).BeginInit(); SuspendLayout();
        _lblChlen.AutoSize = true; _lblChlen.Location = new Point(12,15); _lblChlen.Text = "Член";
        _cmbChlen.Location = new Point(12,38); _cmbChlen.Width=100; _cmbChlen.DropDownStyle = ComboBoxStyle.DropDownList;
        _lblGroup.AutoSize = true; _lblGroup.Location = new Point(132,15); _lblGroup.Text = "Група";
        _cmbGroup.Location = new Point(132,38); _cmbGroup.Width=100; _cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
        _lblAbonament.AutoSize = true; _lblAbonament.Location = new Point(252,15); _lblAbonament.Text = "Абонамент";
        _cmbAbonament.Location = new Point(252,38); _cmbAbonament.Width=100; _cmbAbonament.DropDownStyle = ComboBoxStyle.DropDownList;
        _lblDate.AutoSize = true; _lblDate.Location = new Point(372,15); _lblDate.Text = "Дата";
        _date.Location = new Point(372,38); _date.Width=130; _date.Format=DateTimePickerFormat.Short;
        _btnAdd.Location = new Point(522,36); _btnAdd.Text = "Добави"; _btnAdd.Click += AddItem_Click;
        _btnEdit.Location = new Point(608,36); _btnEdit.Text = "Редактирай"; _btnEdit.Click += EditItem_Click;
        _btnDelete.Location = new Point(714,36); _btnDelete.Text = "Изтрий"; _btnDelete.Click += DeleteItem_Click;

        _grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _grid.ReadOnly=true; _grid.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill; _grid.Location=new Point(12,100); _grid.Size = new Size(956,448); _grid.SelectionChanged += Grid_SelectionChanged;
        ClientSize=new Size(980,560); AutoScaleDimensions=new SizeF(8F,20F); AutoScaleMode=AutoScaleMode.Font; Text="Управление: ZAPISANI_ABONAMENTI"; Name="ZapisaniAbonamentiForm"; Controls.AddRange(new Control[] { _grid, _btnDelete, _btnEdit, _btnAdd, _date, _lblDate, _cmbAbonament, _lblAbonament, _cmbGroup, _lblGroup, _cmbChlen, _lblChlen }); ((System.ComponentModel.ISupportInitialize)_grid).EndInit(); ResumeLayout(false); PerformLayout(); }
    private DataGridView _grid=null!; private ComboBox _cmbChlen=null!; private ComboBox _cmbGroup=null!; private ComboBox _cmbAbonament=null!; private DateTimePicker _date=null!; private Button _btnAdd=null!; private Button _btnEdit=null!; private Button _btnDelete=null!; private Label _lblChlen=null!; private Label _lblGroup=null!; private Label _lblAbonament=null!; private Label _lblDate=null!;
}
