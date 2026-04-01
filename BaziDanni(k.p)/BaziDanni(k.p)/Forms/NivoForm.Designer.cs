namespace BaziDanni_k.p_.Forms;
partial class NivoForm
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing){ if (disposing && components!=null) components.Dispose(); base.Dispose(disposing);}    
    private void InitializeComponent()
    {
        _grid=new DataGridView(); _txtId=new TextBox(); _txtName=new TextBox(); _btnColor=new Button(); _txtColor=new TextBox(); _btnAdd=new Button(); _btnEdit=new Button(); _btnDelete=new Button(); _lblId=new Label(); _lblName=new Label(); _lblColor=new Label();
        ((System.ComponentModel.ISupportInitialize)_grid).BeginInit(); SuspendLayout();
        _lblId.AutoSize = true; _lblId.Location = new Point(12,15); _lblId.Text = "Номер";
        _txtId.Location = new Point(12,38); _txtId.Width=120; _txtId.PlaceholderText="N_nivo";
        _lblName.AutoSize = true; _lblName.Location = new Point(152,15); _lblName.Text = "Ниво";
        _txtName.Location = new Point(152,38); _txtName.Width=220; _txtName.PlaceholderText="Ime_nivo";
        _btnColor.Location = new Point(392,36); _btnColor.Width=120; _btnColor.Text="Избери цвят"; _btnColor.Click += BtnColor_Click;
        _lblColor.AutoSize = true; _lblColor.Location = new Point(532,15); _lblColor.Text = "Цвят";
        _txtColor.Location = new Point(532,38); _txtColor.Width=120; _txtColor.ReadOnly=true;
        _btnAdd.Location = new Point(672,36); _btnAdd.Width=100; _btnAdd.Text="Добави"; _btnAdd.Click += BtnAdd_Click;
        _btnEdit.Location = new Point(778,36); _btnEdit.Width=100; _btnEdit.Text="Запази"; _btnEdit.Click += BtnEdit_Click;
        _btnDelete.Location = new Point(884,36); _btnDelete.Width=100; _btnDelete.Text="Изтрий"; _btnDelete.Click += BtnDelete_Click;

        _grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _grid.ReadOnly=true; _grid.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill; _grid.Location=new Point(12,100); _grid.Size = new Size(926,428); _grid.SelectionChanged += Grid_SelectionChanged;
        ClientSize=new Size(950,540); AutoScaleDimensions=new SizeF(8F,20F); AutoScaleMode=AutoScaleMode.Font; Text="Управление: NIVO"; Name="NivoForm";
        Controls.AddRange([_grid,_btnDelete,_btnEdit,_btnAdd,_txtColor,_lblColor,_btnColor,_txtName,_lblName,_txtId,_lblId]);
        ((System.ComponentModel.ISupportInitialize)_grid).EndInit(); ResumeLayout(false); PerformLayout();
    }
    private DataGridView _grid=null!; private TextBox _txtId=null!; private TextBox _txtName=null!; private Button _btnColor=null!; private TextBox _txtColor=null!; private Button _btnAdd=null!; private Button _btnEdit=null!; private Button _btnDelete=null!; private Label _lblId=null!; private Label _lblName=null!; private Label _lblColor=null!;
}
