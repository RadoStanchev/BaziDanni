namespace BaziDanni_k.p_.Forms;
partial class SportForm
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing){ if (disposing && components!=null) components.Dispose(); base.Dispose(disposing);}    
    private void InitializeComponent(){ _grid=new DataGridView(); _txtId=new TextBox(); _txtName=new TextBox(); _cmbColor=new ComboBox(); _add=new Button(); _edit=new Button(); _delete=new Button(); _reload=new Button(); _lblId=new Label(); _lblName=new Label(); _lblColor=new Label(); ((System.ComponentModel.ISupportInitialize)_grid).BeginInit(); SuspendLayout();
        _lblId.AutoSize = true; _lblId.Location = new Point(12,15); _lblId.Text = "Номер";
        _txtId.Location = new Point(12,38); _txtId.Width=110;
        _lblName.AutoSize = true; _lblName.Location = new Point(142,15); _lblName.Text = "Спорт";
        _txtName.Location = new Point(142,38); _txtName.Width=220;
        _lblColor.AutoSize = true; _lblColor.Location = new Point(382,15); _lblColor.Text = "Цвят";
        _cmbColor.Location = new Point(382,38); _cmbColor.Width=160; _cmbColor.Items.AddRange(["червен","син","оранжев","черен","бял"]);
        _add.Location = new Point(562,36); _add.Text="Добави"; _add.Click += Add_Click;
        _edit.Location = new Point(648,36); _edit.Text="Редактирай"; _edit.Click += Edit_Click;
        _delete.Location = new Point(754,36); _delete.Text="Изтрий"; _delete.Click += Delete_Click;
        _reload.Location = new Point(840,36); _reload.Text="Презареди"; _reload.Click += Reload_Click;
        _grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _grid.ReadOnly=true; _grid.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill; _grid.Location=new Point(12,100); _grid.Size = new Size(896,428); _grid.SelectionChanged += Grid_SelectionChanged;
        ClientSize=new Size(920,540); Text="Управление: SPORT"; Name="SportForm"; AutoScaleDimensions=new SizeF(8F,20F); AutoScaleMode=AutoScaleMode.Font; Controls.AddRange([_grid,_reload,_delete,_edit,_add,_cmbColor,_lblColor,_txtName,_lblName,_txtId,_lblId]); ((System.ComponentModel.ISupportInitialize)_grid).EndInit(); ResumeLayout(false); PerformLayout(); }
    private DataGridView _grid=null!; private TextBox _txtId=null!; private TextBox _txtName=null!; private ComboBox _cmbColor=null!; private Button _add=null!; private Button _edit=null!; private Button _delete=null!; private Button _reload=null!; private Label _lblId=null!; private Label _lblName=null!; private Label _lblColor=null!;
}
