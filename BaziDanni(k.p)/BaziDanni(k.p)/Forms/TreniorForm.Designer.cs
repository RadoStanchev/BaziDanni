namespace BaziDanni_k.p_.Forms;

partial class TreniorForm
{
    private System.ComponentModel.IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        _topPanel = new FlowLayoutPanel();
        _pnlId = new Panel();
        _txtId = new TextBox();
        _lblId = new Label();
        _pnlName = new Panel();
        _txtName = new TextBox();
        _lblName = new Label();
        _pnlSportId = new Panel();
        _txtSportId = new TextBox();
        _lblSportId = new Label();
        _pnlPhone = new Panel();
        _txtPhone = new MaskedTextBox();
        _lblPhone = new Label();
        _btnAdd = new Button();
        _btnEdit = new Button();
        _btnDelete = new Button();
        _grid = new DataGridView();
        _topPanel.SuspendLayout();
        _pnlId.SuspendLayout();
        _pnlName.SuspendLayout();
        _pnlSportId.SuspendLayout();
        _pnlPhone.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_grid).BeginInit();
        SuspendLayout();
        // 
        // _topPanel
        // 
        _topPanel.AutoSize = true;
        _topPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        _topPanel.Controls.Add(_pnlId);
        _topPanel.Controls.Add(_pnlName);
        _topPanel.Controls.Add(_pnlSportId);
        _topPanel.Controls.Add(_pnlPhone);
        _topPanel.Controls.Add(_btnAdd);
        _topPanel.Controls.Add(_btnEdit);
        _topPanel.Controls.Add(_btnDelete);
        _topPanel.Dock = DockStyle.Top;
        _topPanel.Location = new Point(0, 0);
        _topPanel.Name = "_topPanel";
        _topPanel.Padding = new Padding(10);
        _topPanel.Size = new Size(980, 82);
        _topPanel.TabIndex = 0;
        // 
        // _pnlId
        // 
        _pnlId.Controls.Add(_txtId);
        _pnlId.Controls.Add(_lblId);
        _pnlId.Location = new Point(13, 13);
        _pnlId.Name = "_pnlId";
        _pnlId.Size = new Size(108, 52);
        _pnlId.TabIndex = 0;
        // 
        // _txtId
        // 
        _txtId.Location = new Point(0, 22);
        _txtId.Name = "_txtId";
        _txtId.Size = new Size(100, 27);
        _txtId.TabIndex = 1;
        // 
        // _lblId
        // 
        _lblId.Dock = DockStyle.Top;
        _lblId.Location = new Point(0, 0);
        _lblId.Name = "_lblId";
        _lblId.Size = new Size(108, 20);
        _lblId.TabIndex = 0;
        _lblId.Text = "Номер";
        // 
        // _pnlName
        // 
        _pnlName.Controls.Add(_txtName);
        _pnlName.Controls.Add(_lblName);
        _pnlName.Location = new Point(127, 13);
        _pnlName.Name = "_pnlName";
        _pnlName.Size = new Size(228, 52);
        _pnlName.TabIndex = 1;
        // 
        // _txtName
        // 
        _txtName.Location = new Point(0, 22);
        _txtName.Name = "_txtName";
        _txtName.Size = new Size(220, 27);
        _txtName.TabIndex = 1;
        // 
        // _lblName
        // 
        _lblName.Dock = DockStyle.Top;
        _lblName.Location = new Point(0, 0);
        _lblName.Name = "_lblName";
        _lblName.Size = new Size(228, 20);
        _lblName.TabIndex = 0;
        _lblName.Text = "Име на треньор";
        // 
        // _pnlSportId
        // 
        _pnlSportId.Controls.Add(_txtSportId);
        _pnlSportId.Controls.Add(_lblSportId);
        _pnlSportId.Location = new Point(361, 13);
        _pnlSportId.Name = "_pnlSportId";
        _pnlSportId.Size = new Size(128, 52);
        _pnlSportId.TabIndex = 2;
        // 
        // _txtSportId
        // 
        _txtSportId.Location = new Point(0, 22);
        _txtSportId.Name = "_txtSportId";
        _txtSportId.Size = new Size(120, 27);
        _txtSportId.TabIndex = 1;
        // 
        // _lblSportId
        // 
        _lblSportId.Dock = DockStyle.Top;
        _lblSportId.Location = new Point(0, 0);
        _lblSportId.Name = "_lblSportId";
        _lblSportId.Size = new Size(128, 20);
        _lblSportId.TabIndex = 0;
        _lblSportId.Text = "Номер спорт";
        // 
        // _pnlPhone
        // 
        _pnlPhone.Controls.Add(_txtPhone);
        _pnlPhone.Controls.Add(_lblPhone);
        _pnlPhone.Location = new Point(495, 13);
        _pnlPhone.Name = "_pnlPhone";
        _pnlPhone.Size = new Size(138, 52);
        _pnlPhone.TabIndex = 3;
        // 
        // _txtPhone
        // 
        _txtPhone.Location = new Point(0, 22);
        _txtPhone.Mask = "0000-000-000";
        _txtPhone.Name = "_txtPhone";
        _txtPhone.Size = new Size(130, 27);
        _txtPhone.TabIndex = 1;
        // 
        // _lblPhone
        // 
        _lblPhone.Dock = DockStyle.Top;
        _lblPhone.Location = new Point(0, 0);
        _lblPhone.Name = "_lblPhone";
        _lblPhone.Size = new Size(138, 20);
        _lblPhone.TabIndex = 0;
        _lblPhone.Text = "Телефон";
        // 
        // _btnAdd
        // 
        _btnAdd.Location = new Point(639, 13);
        _btnAdd.Name = "_btnAdd";
        _btnAdd.Size = new Size(94, 29);
        _btnAdd.TabIndex = 4;
        _btnAdd.Text = "Добави";
        _btnAdd.UseVisualStyleBackColor = true;
        // 
        // _btnEdit
        // 
        _btnEdit.Location = new Point(739, 13);
        _btnEdit.Name = "_btnEdit";
        _btnEdit.Size = new Size(94, 29);
        _btnEdit.TabIndex = 5;
        _btnEdit.Text = "Редактирай";
        _btnEdit.UseVisualStyleBackColor = true;
        // 
        // _btnDelete
        // 
        _btnDelete.Location = new Point(839, 13);
        _btnDelete.Name = "_btnDelete";
        _btnDelete.Size = new Size(94, 29);
        _btnDelete.TabIndex = 6;
        _btnDelete.Text = "Изтрий";
        _btnDelete.UseVisualStyleBackColor = true;
        // 
        // _grid
        // 
        _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        _grid.Dock = DockStyle.Fill;
        _grid.Location = new Point(0, 82);
        _grid.Name = "_grid";
        _grid.ReadOnly = true;
        _grid.RowHeadersWidth = 51;
        _grid.Size = new Size(980, 478);
        _grid.TabIndex = 1;
        // 
        // TreniorForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(980, 560);
        Controls.Add(_grid);
        Controls.Add(_topPanel);
        Name = "TreniorForm";
        Text = "Управление: TRENIOR";
        _topPanel.ResumeLayout(false);
        _pnlId.ResumeLayout(false);
        _pnlId.PerformLayout();
        _pnlName.ResumeLayout(false);
        _pnlName.PerformLayout();
        _pnlSportId.ResumeLayout(false);
        _pnlSportId.PerformLayout();
        _pnlPhone.ResumeLayout(false);
        _pnlPhone.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_grid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private FlowLayoutPanel _topPanel;
    private Panel _pnlId;
    private TextBox _txtId;
    private Label _lblId;
    private Panel _pnlName;
    private TextBox _txtName;
    private Label _lblName;
    private Panel _pnlSportId;
    private TextBox _txtSportId;
    private Label _lblSportId;
    private Panel _pnlPhone;
    private MaskedTextBox _txtPhone;
    private Label _lblPhone;
    private Button _btnAdd;
    private Button _btnEdit;
    private Button _btnDelete;
    private DataGridView _grid;
}
