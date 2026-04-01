namespace BaziDanni_k.p_.Forms;
partial class TrenirovkaForm
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing){ if (disposing && components!=null) components.Dispose(); base.Dispose(disposing);}    
    private void InitializeComponent(){ _grid=new DataGridView(); _top=new FlowLayoutPanel(); _date=new DateTimePicker(); _time=new DateTimePicker(); _txtGroup=new TextBox(); _txtChlen=new TextBox(); _txtDay=new TextBox(); _btnAdd=new Button(); _btnEdit=new Button(); _btnDelete=new Button(); ((System.ComponentModel.ISupportInitialize)_grid).BeginInit(); SuspendLayout();
        _grid.Dock=DockStyle.Fill; _grid.ReadOnly=true; _grid.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill; _grid.Location=new Point(0,47); _grid.SelectionChanged += Grid_SelectionChanged;
        _top.Dock=DockStyle.Top; _top.AutoSize=true; _top.AutoSizeMode=AutoSizeMode.GrowAndShrink; _top.Padding=new Padding(10);
        _txtGroup.Width=90; _txtChlen.Width=90; _txtDay.Width=90; _date.Width=130; _date.Format=DateTimePickerFormat.Short; _time.Width=110; _time.Format=DateTimePickerFormat.Time; _time.ShowUpDown=true;
        _btnAdd.Text="Добави тренировка"; _btnAdd.Click += BtnAdd_Click; _btnEdit.Text="Запиши промени"; _btnEdit.Click += BtnEdit_Click; _btnDelete.Text="Изтрий"; _btnDelete.Click += BtnDelete_Click;
        _top.Controls.AddRange([new Label{Text="Група"},_txtGroup,new Label{Text="Дата"},_date,new Label{Text="Час"},_time,new Label{Text="Член"},_txtChlen,new Label{Text="Ден"},_txtDay,_btnAdd,_btnEdit,_btnDelete]);
        ClientSize=new Size(1000,560); AutoScaleDimensions=new SizeF(8F,20F); AutoScaleMode=AutoScaleMode.Font; Text="Управление: TRENIROVKA"; Name="TrenirovkaForm"; Controls.Add(_grid); Controls.Add(_top); ((System.ComponentModel.ISupportInitialize)_grid).EndInit(); ResumeLayout(false); PerformLayout(); }
    private DataGridView _grid=null!; private FlowLayoutPanel _top=null!; private DateTimePicker _date=null!; private DateTimePicker _time=null!; private TextBox _txtGroup=null!; private TextBox _txtChlen=null!; private TextBox _txtDay=null!; private Button _btnAdd=null!; private Button _btnEdit=null!; private Button _btnDelete=null!;
}
