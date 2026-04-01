namespace BaziDanni_k.p_.Forms;

partial class ChlenForm
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
        _topGroup = new GroupBox();
        _topPanel = new FlowLayoutPanel();
        _pnlId = new Panel();
        _lblId = new Label();
        _txtId = new TextBox();
        _pnlName = new Panel();
        _lblName = new Label();
        _txtName = new TextBox();
        _pnlEgn = new Panel();
        _lblEgn = new Label();
        _txtEgn = new TextBox();
        _pnlPhone = new Panel();
        _lblPhone = new Label();
        _txtPhone = new MaskedTextBox();
        _pnlAddress = new Panel();
        _lblAddress = new Label();
        _txtAddress = new TextBox();
        _btnAdd = new Button();
        _btnEdit = new Button();
        _btnDelete = new Button();
        _btnRefresh = new Button();
        _grid = new DataGridView();
        _topGroup.SuspendLayout();
        _topPanel.SuspendLayout();
        _pnlId.SuspendLayout();
        _pnlName.SuspendLayout();
        _pnlEgn.SuspendLayout();
        _pnlPhone.SuspendLayout();
        _pnlAddress.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_grid).BeginInit();
        SuspendLayout();
        // 
        // _topGroup
        // 
        _topGroup.AutoSize = true;
        _topGroup.Controls.Add(_topPanel);
        _topGroup.Dock = DockStyle.Top;
        _topGroup.Location = new Point(0, 0);
        _topGroup.Name = "_topGroup";
        _topGroup.Size = new Size(1150, 99);
        _topGroup.TabIndex = 0;
        _topGroup.TabStop = false;
        _topGroup.Text = "Данни за член";
        // 
        // _topPanel
        // 
        _topPanel.AutoSize = true;
        _topPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        _topPanel.Controls.Add(_pnlId);
        _topPanel.Controls.Add(_pnlName);
        _topPanel.Controls.Add(_pnlEgn);
        _topPanel.Controls.Add(_pnlPhone);
        _topPanel.Controls.Add(_pnlAddress);
        _topPanel.Controls.Add(_btnAdd);
        _topPanel.Controls.Add(_btnEdit);
        _topPanel.Controls.Add(_btnDelete);
        _topPanel.Controls.Add(_btnRefresh);
        _topPanel.Dock = DockStyle.Fill;
        _topPanel.Location = new Point(3, 23);
        _topPanel.Name = "_topPanel";
        _topPanel.Padding = new Padding(10);
        _topPanel.Size = new Size(1144, 73);
        _topPanel.TabIndex = 0;
        // 
        // _pnlId
        // 
        _pnlId.Controls.Add(_txtId);
        _pnlId.Controls.Add(_lblId);
        _pnlId.Location = new Point(13, 13);
        _pnlId.Name = "_pnlId";
        _pnlId.Size = new Size(128, 52);
        _pnlId.TabIndex = 0;
        // 
        // _lblId
        // 
        _lblId.Dock = DockStyle.Top;
        _lblId.Location = new Point(0, 0);
        _lblId.Name = "_lblId";
        _lblId.Size = new Size(128, 20);
        _lblId.TabIndex = 0;
        _lblId.Text = "Номер";
        // 
        // _txtId
        // 
        _txtId.Location = new Point(0, 22);
        _txtId.Name = "_txtId";
        _txtId.Size = new Size(120, 27);
        _txtId.TabIndex = 1;
        // 
        // _pnlName
        // 
        _pnlName.Controls.Add(_txtName);
        _pnlName.Controls.Add(_lblName);
        _pnlName.Location = new Point(147, 13);
        _pnlName.Name = "_pnlName";
        _pnlName.Size = new Size(228, 52);
        _pnlName.TabIndex = 1;
        // 
        // _lblName
        // 
        _lblName.Dock = DockStyle.Top;
        _lblName.Location = new Point(0, 0);
        _lblName.Name = "_lblName";
        _lblName.Size = new Size(228, 20);
        _lblName.TabIndex = 0;
        _lblName.Text = "Име";
        // 
        // _txtName
        // 
        _txtName.Location = new Point(0, 22);
        _txtName.Name = "_txtName";
        _txtName.Size = new Size(220, 27);
        _txtName.TabIndex = 1;
        // 
        // _pnlEgn
        // 
        _pnlEgn.Controls.Add(_txtEgn);
        _pnlEgn.Controls.Add(_lblEgn);
        _pnlEgn.Location = new Point(381, 13);
        _pnlEgn.Name = "_pnlEgn";
        _pnlEgn.Size = new Size(148, 52);
        _pnlEgn.TabIndex = 2;
        // 
        // _lblEgn
        // 
        _lblEgn.Dock = DockStyle.Top;
        _lblEgn.Location = new Point(0, 0);
        _lblEgn.Name = "_lblEgn";
        _lblEgn.Size = new Size(148, 20);
        _lblEgn.TabIndex = 0;
        _lblEgn.Text = "ЕГН";
        // 
        // _txtEgn
        // 
        _txtEgn.Location = new Point(0, 22);
        _txtEgn.Name = "_txtEgn";
        _txtEgn.Size = new Size(140, 27);
        _txtEgn.TabIndex = 1;
        // 
        // _pnlPhone
        // 
        _pnlPhone.Controls.Add(_txtPhone);
        _pnlPhone.Controls.Add(_lblPhone);
        _pnlPhone.Location = new Point(535, 13);
        _pnlPhone.Name = "_pnlPhone";
        _pnlPhone.Size = new Size(138, 52);
        _pnlPhone.TabIndex = 3;
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
        // _txtPhone
        // 
        _txtPhone.Location = new Point(0, 22);
        _txtPhone.Mask = "0000-000-000";
        _txtPhone.Name = "_txtPhone";
        _txtPhone.Size = new Size(130, 27);
        _txtPhone.TabIndex = 1;
        // 
        // _pnlAddress
        // 
        _pnlAddress.Controls.Add(_txtAddress);
        _pnlAddress.Controls.Add(_lblAddress);
        _pnlAddress.Location = new Point(679, 13);
        _pnlAddress.Name = "_pnlAddress";
        _pnlAddress.Size = new Size(288, 52);
        _pnlAddress.TabIndex = 4;
        // 
        // _lblAddress
        // 
        _lblAddress.Dock = DockStyle.Top;
        _lblAddress.Location = new Point(0, 0);
        _lblAddress.Name = "_lblAddress";
        _lblAddress.Size = new Size(288, 20);
        _lblAddress.TabIndex = 0;
        _lblAddress.Text = "Адрес";
        // 
        // _txtAddress
        // 
        _txtAddress.Location = new Point(0, 22);
        _txtAddress.Name = "_txtAddress";
        _txtAddress.Size = new Size(280, 27);
        _txtAddress.TabIndex = 1;
        // 
        // _btnAdd
        // 
        _btnAdd.Location = new Point(973, 13);
        _btnAdd.Name = "_btnAdd";
        _btnAdd.Size = new Size(100, 29);
        _btnAdd.TabIndex = 5;
        _btnAdd.Text = "Добави";
        _btnAdd.UseVisualStyleBackColor = true;
        // 
        // _btnEdit
        // 
        _btnEdit.Location = new Point(13, 71);
        _btnEdit.Name = "_btnEdit";
        _btnEdit.Size = new Size(100, 29);
        _btnEdit.TabIndex = 6;
        _btnEdit.Text = "Промени";
        _btnEdit.UseVisualStyleBackColor = true;
        // 
        // _btnDelete
        // 
        _btnDelete.Location = new Point(119, 71);
        _btnDelete.Name = "_btnDelete";
        _btnDelete.Size = new Size(100, 29);
        _btnDelete.TabIndex = 7;
        _btnDelete.Text = "Премахни";
        _btnDelete.UseVisualStyleBackColor = true;
        // 
        // _btnRefresh
        // 
        _btnRefresh.Location = new Point(225, 71);
        _btnRefresh.Name = "_btnRefresh";
        _btnRefresh.Size = new Size(100, 29);
        _btnRefresh.TabIndex = 8;
        _btnRefresh.Text = "Обнови";
        _btnRefresh.UseVisualStyleBackColor = true;
        // 
        // _grid
        // 
        _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        _grid.Dock = DockStyle.Fill;
        _grid.Location = new Point(0, 99);
        _grid.Name = "_grid";
        _grid.ReadOnly = true;
        _grid.RowHeadersWidth = 51;
        _grid.Size = new Size(1150, 521);
        _grid.TabIndex = 1;
        // 
        // ChlenForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1150, 620);
        Controls.Add(_grid);
        Controls.Add(_topGroup);
        Name = "ChlenForm";
        Text = "Управление: CHLEN";
        _topGroup.ResumeLayout(false);
        _topGroup.PerformLayout();
        _topPanel.ResumeLayout(false);
        _pnlId.ResumeLayout(false);
        _pnlId.PerformLayout();
        _pnlName.ResumeLayout(false);
        _pnlName.PerformLayout();
        _pnlEgn.ResumeLayout(false);
        _pnlEgn.PerformLayout();
        _pnlPhone.ResumeLayout(false);
        _pnlPhone.PerformLayout();
        _pnlAddress.ResumeLayout(false);
        _pnlAddress.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_grid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox _topGroup;
    private FlowLayoutPanel _topPanel;
    private Panel _pnlId;
    private Label _lblId;
    private TextBox _txtId;
    private Panel _pnlName;
    private Label _lblName;
    private TextBox _txtName;
    private Panel _pnlEgn;
    private Label _lblEgn;
    private TextBox _txtEgn;
    private Panel _pnlPhone;
    private Label _lblPhone;
    private MaskedTextBox _txtPhone;
    private Panel _pnlAddress;
    private Label _lblAddress;
    private TextBox _txtAddress;
    private Button _btnAdd;
    private Button _btnEdit;
    private Button _btnDelete;
    private Button _btnRefresh;
    private DataGridView _grid;
}
