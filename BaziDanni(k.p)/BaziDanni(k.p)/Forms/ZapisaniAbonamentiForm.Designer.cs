namespace BaziDanni_k.p_.Forms;
partial class ZapisaniAbonamentiForm
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing){ if (disposing && components!=null) components.Dispose(); base.Dispose(disposing);}    
    private void InitializeComponent(){ _grid=new DataGridView(); _strip=new StatusStrip(); _txtChlen=new TextBox(); _txtGroup=new TextBox(); _txtAbonament=new TextBox(); _date=new DateTimePicker(); _btnActions=new ToolStripDropDownButton(); ((System.ComponentModel.ISupportInitialize)_grid).BeginInit(); SuspendLayout();
        _grid.Dock=DockStyle.Fill; _grid.ReadOnly=true; _grid.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill; _grid.Location=new Point(0,26); _grid.SelectionChanged += Grid_SelectionChanged;
        _strip.Dock=DockStyle.Top; _strip.SizingGrip=false; _strip.Items.Add(new ToolStripStatusLabel("Член")); _txtChlen.Width=100; _strip.Items.Add(new ToolStripControlHost(_txtChlen)); _strip.Items.Add(new ToolStripStatusLabel("Група")); _txtGroup.Width=100; _strip.Items.Add(new ToolStripControlHost(_txtGroup)); _strip.Items.Add(new ToolStripStatusLabel("Абонамент")); _txtAbonament.Width=100; _strip.Items.Add(new ToolStripControlHost(_txtAbonament)); _strip.Items.Add(new ToolStripStatusLabel("Дата")); _date.Width=130; _date.Format=DateTimePickerFormat.Short; _strip.Items.Add(new ToolStripControlHost(_date));
        _btnActions.Text="Действия"; _btnActions.DropDownItems.Add("Добави", null, AddItem_Click); _btnActions.DropDownItems.Add("Редактирай", null, EditItem_Click); _btnActions.DropDownItems.Add("Изтрий", null, DeleteItem_Click); _strip.Items.Add(_btnActions);
        ClientSize=new Size(980,560); AutoScaleDimensions=new SizeF(8F,20F); AutoScaleMode=AutoScaleMode.Font; Text="Управление: ZAPISANI_ABONAMENTI"; Name="ZapisaniAbonamentiForm"; Controls.Add(_grid); Controls.Add(_strip); ((System.ComponentModel.ISupportInitialize)_grid).EndInit(); ResumeLayout(false); PerformLayout(); }
    private DataGridView _grid=null!; private StatusStrip _strip=null!; private TextBox _txtChlen=null!; private TextBox _txtGroup=null!; private TextBox _txtAbonament=null!; private DateTimePicker _date=null!; private ToolStripDropDownButton _btnActions=null!;
}
