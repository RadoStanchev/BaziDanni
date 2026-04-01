namespace BaziDanni_k.p_.Forms;
partial class SportForm
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing){ if (disposing && components!=null) components.Dispose(); base.Dispose(disposing);}    
    private void InitializeComponent(){ _grid=new DataGridView(); _top=new FlowLayoutPanel(); _txtId=new TextBox(); _txtName=new TextBox(); _cmbColor=new ComboBox(); _add=new Button(); _edit=new Button(); _delete=new Button(); _reload=new Button(); ((System.ComponentModel.ISupportInitialize)_grid).BeginInit(); SuspendLayout();
        _grid.Dock=DockStyle.Fill; _grid.ReadOnly=true; _grid.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill; _grid.Location=new Point(0,43); _grid.SelectionChanged += Grid_SelectionChanged;
        _top.Dock=DockStyle.Top; _top.AutoSize=true; _top.AutoSizeMode=AutoSizeMode.GrowAndShrink; _top.Padding=new Padding(8);
        _txtId.Width=110; _txtName.Width=220; _cmbColor.Width=160; _cmbColor.Items.AddRange(["червен","син","оранжев","черен","бял"]);
        _add.Text="Добави"; _add.Click += Add_Click; _edit.Text="Редактирай"; _edit.Click += Edit_Click; _delete.Text="Изтрий"; _delete.Click += Delete_Click; _reload.Text="Презареди"; _reload.Click += Reload_Click;
        _top.Controls.AddRange([new Label{Text="Номер"},_txtId,new Label{Text="Спорт"},_txtName,new Label{Text="Цвят"},_cmbColor,_add,_edit,_delete,_reload]);
        ClientSize=new Size(920,540); Text="Управление: SPORT"; Name="SportForm"; AutoScaleDimensions=new SizeF(8F,20F); AutoScaleMode=AutoScaleMode.Font; Controls.Add(_grid); Controls.Add(_top); ((System.ComponentModel.ISupportInitialize)_grid).EndInit(); ResumeLayout(false); PerformLayout(); }
    private DataGridView _grid=null!; private FlowLayoutPanel _top=null!; private TextBox _txtId=null!; private TextBox _txtName=null!; private ComboBox _cmbColor=null!; private Button _add=null!; private Button _edit=null!; private Button _delete=null!; private Button _reload=null!;
}
