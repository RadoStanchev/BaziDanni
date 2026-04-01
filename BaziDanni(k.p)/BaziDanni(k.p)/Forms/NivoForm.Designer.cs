namespace BaziDanni_k.p_.Forms;
partial class NivoForm
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing){ if (disposing && components!=null) components.Dispose(); base.Dispose(disposing);}    
    private void InitializeComponent()
    {
        _grid=new DataGridView(); _top=new Panel(); _flow=new FlowLayoutPanel(); _txtId=new TextBox(); _txtName=new TextBox(); _btnColor=new Button(); _txtColor=new TextBox(); _btnAdd=new Button(); _btnEdit=new Button(); _btnDelete=new Button();
        ((System.ComponentModel.ISupportInitialize)_grid).BeginInit(); _top.SuspendLayout(); _flow.SuspendLayout(); SuspendLayout();
        _grid.Dock=DockStyle.Fill; _grid.ReadOnly=true; _grid.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill; _grid.Location=new Point(0,51); _grid.SelectionChanged += Grid_SelectionChanged;
        _top.Dock=DockStyle.Top; _top.AutoSize=true; _top.Padding=new Padding(12); _top.Controls.Add(_flow);
        _flow.Dock=DockStyle.Fill; _flow.AutoSize=true; _flow.AutoSizeMode=AutoSizeMode.GrowAndShrink;
        _txtId.Width=120; _txtId.PlaceholderText="N_nivo"; _txtName.Width=220; _txtName.PlaceholderText="Ime_nivo"; _btnColor.Width=120; _btnColor.Text="Избери цвят"; _btnColor.Click += BtnColor_Click; _txtColor.Width=120; _txtColor.ReadOnly=true;
        _btnAdd.Text="Добави"; _btnAdd.Width=100; _btnAdd.Click += BtnAdd_Click; _btnEdit.Text="Запази"; _btnEdit.Width=100; _btnEdit.Click += BtnEdit_Click; _btnDelete.Text="Изтрий"; _btnDelete.Width=100; _btnDelete.Click += BtnDelete_Click;
        _flow.Controls.AddRange([new Label{Text="Номер"},_txtId,new Label{Text="Ниво"},_txtName,_btnColor,_txtColor,_btnAdd,_btnEdit,_btnDelete]);
        ClientSize=new Size(950,540); AutoScaleDimensions=new SizeF(8F,20F); AutoScaleMode=AutoScaleMode.Font; Text="Управление: NIVO"; Name="NivoForm"; Controls.Add(_grid); Controls.Add(_top);
        ((System.ComponentModel.ISupportInitialize)_grid).EndInit(); _top.ResumeLayout(false); _top.PerformLayout(); _flow.ResumeLayout(false); _flow.PerformLayout(); ResumeLayout(false); PerformLayout();
    }
    private DataGridView _grid=null!; private Panel _top=null!; private FlowLayoutPanel _flow=null!; private TextBox _txtId=null!; private TextBox _txtName=null!; private Button _btnColor=null!; private TextBox _txtColor=null!; private Button _btnAdd=null!; private Button _btnEdit=null!; private Button _btnDelete=null!;
}
