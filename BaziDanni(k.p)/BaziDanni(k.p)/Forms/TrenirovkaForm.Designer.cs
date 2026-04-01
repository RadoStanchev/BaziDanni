namespace BaziDanni_k.p_.Forms;
partial class TrenirovkaForm
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing){ if (disposing && components!=null) components.Dispose(); base.Dispose(disposing);}    
    private void InitializeComponent(){ _grid=new DataGridView(); _date=new DateTimePicker(); _time=new DateTimePicker(); _txtGroup=new TextBox(); _txtChlen=new TextBox(); _txtDay=new TextBox(); _btnAdd=new Button(); _btnEdit=new Button(); _btnDelete=new Button(); _lblGroup=new Label(); _lblDate=new Label(); _lblTime=new Label(); _lblChlen=new Label(); _lblDay=new Label(); ((System.ComponentModel.ISupportInitialize)_grid).BeginInit(); SuspendLayout();
        _lblGroup.AutoSize = true; _lblGroup.Location = new Point(12,15); _lblGroup.Text = "Група";
        _txtGroup.Location = new Point(12,38); _txtGroup.Width=90;
        _lblDate.AutoSize = true; _lblDate.Location = new Point(122,15); _lblDate.Text = "Дата";
        _date.Location = new Point(122,38); _date.Width=130; _date.Format=DateTimePickerFormat.Short;
        _lblTime.AutoSize = true; _lblTime.Location = new Point(272,15); _lblTime.Text = "Час";
        _time.Location = new Point(272,38); _time.Width=110; _time.Format=DateTimePickerFormat.Time; _time.ShowUpDown=true;
        _lblChlen.AutoSize = true; _lblChlen.Location = new Point(402,15); _lblChlen.Text = "Член";
        _txtChlen.Location = new Point(402,38); _txtChlen.Width=90;
        _lblDay.AutoSize = true; _lblDay.Location = new Point(512,15); _lblDay.Text = "Ден";
        _txtDay.Location = new Point(512,38); _txtDay.Width=90;
        _btnAdd.Location = new Point(622,36); _btnAdd.Text="Добави тренировка"; _btnAdd.Click += BtnAdd_Click;
        _btnEdit.Location = new Point(760,36); _btnEdit.Text="Запиши промени"; _btnEdit.Click += BtnEdit_Click;
        _btnDelete.Location = new Point(894,36); _btnDelete.Text="Изтрий"; _btnDelete.Click += BtnDelete_Click;
        _grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _grid.ReadOnly=true; _grid.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill; _grid.Location=new Point(12,100); _grid.Size = new Size(976,448); _grid.SelectionChanged += Grid_SelectionChanged;
        ClientSize=new Size(1000,560); AutoScaleDimensions=new SizeF(8F,20F); AutoScaleMode=AutoScaleMode.Font; Text="Управление: TRENIROVKA"; Name="TrenirovkaForm"; Controls.AddRange([_grid,_btnDelete,_btnEdit,_btnAdd,_txtDay,_lblDay,_txtChlen,_lblChlen,_time,_lblTime,_date,_lblDate,_txtGroup,_lblGroup]); ((System.ComponentModel.ISupportInitialize)_grid).EndInit(); ResumeLayout(false); PerformLayout(); }
    private DataGridView _grid=null!; private DateTimePicker _date=null!; private DateTimePicker _time=null!; private TextBox _txtGroup=null!; private TextBox _txtChlen=null!; private TextBox _txtDay=null!; private Button _btnAdd=null!; private Button _btnEdit=null!; private Button _btnDelete=null!; private Label _lblGroup=null!; private Label _lblDate=null!; private Label _lblTime=null!; private Label _lblChlen=null!; private Label _lblDay=null!;
}
