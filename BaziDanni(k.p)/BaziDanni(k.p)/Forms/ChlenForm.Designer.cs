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
        _lblId = new Label();
        _txtId = new TextBox();
        _lblName = new Label();
        _txtName = new TextBox();
        _lblEgn = new Label();
        _txtEgn = new TextBox();
        _lblPhone = new Label();
        _txtPhone = new MaskedTextBox();
        _lblAddress = new Label();
        _txtAddress = new TextBox();
        _btnAdd = new Button();
        _btnEdit = new Button();
        _btnDelete = new Button();
        _btnRefresh = new Button();
        _grid = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)_grid).BeginInit();
        SuspendLayout();
        _lblId.AutoSize = true;
        _lblId.Location = new Point(12, 15);
        _lblId.Text = "Номер";
        _txtId.Location = new Point(12, 38);
        _txtId.Name = "_txtId";
        _txtId.Size = new Size(120, 27);

        _lblName.AutoSize = true;
        _lblName.Location = new Point(152, 15);
        _lblName.Text = "Име";
        _txtName.Location = new Point(152, 38);
        _txtName.Name = "_txtName";
        _txtName.Size = new Size(220, 27);

        _lblEgn.AutoSize = true;
        _lblEgn.Location = new Point(392, 15);
        _lblEgn.Text = "ЕГН";
        _txtEgn.Location = new Point(392, 38);
        _txtEgn.Name = "_txtEgn";
        _txtEgn.Size = new Size(140, 27);

        _lblPhone.AutoSize = true;
        _lblPhone.Location = new Point(552, 15);
        _lblPhone.Text = "Телефон";
        _txtPhone.Location = new Point(552, 38);
        _txtPhone.Mask = "0000-000-000";
        _txtPhone.Name = "_txtPhone";
        _txtPhone.Size = new Size(130, 27);

        _lblAddress.AutoSize = true;
        _lblAddress.Location = new Point(702, 15);
        _lblAddress.Text = "Адрес";
        _txtAddress.Location = new Point(702, 38);
        _txtAddress.Name = "_txtAddress";
        _txtAddress.Size = new Size(280, 27);

        _btnAdd.Location = new Point(1000, 36);
        _btnAdd.Name = "_btnAdd";
        _btnAdd.Size = new Size(100, 29);
        _btnAdd.Text = "Добави";
        _btnAdd.UseVisualStyleBackColor = true;

        _btnEdit.Location = new Point(12, 70);
        _btnEdit.Name = "_btnEdit";
        _btnEdit.Size = new Size(100, 29);
        _btnEdit.Text = "Промени";
        _btnEdit.UseVisualStyleBackColor = true;

        _btnDelete.Location = new Point(118, 70);
        _btnDelete.Name = "_btnDelete";
        _btnDelete.Size = new Size(100, 29);
        _btnDelete.Text = "Премахни";
        _btnDelete.UseVisualStyleBackColor = true;

        _btnRefresh.Location = new Point(224, 70);
        _btnRefresh.Name = "_btnRefresh";
        _btnRefresh.Size = new Size(100, 29);
        _btnRefresh.Text = "Обнови";
        _btnRefresh.UseVisualStyleBackColor = true;

        _grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        _grid.Location = new Point(12, 110);
        _grid.Name = "_grid";
        _grid.ReadOnly = true;
        _grid.RowHeadersWidth = 51;
        _grid.Size = new Size(1126, 498);

        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1150, 620);
        Controls.Add(_grid);
        Controls.Add(_btnRefresh);
        Controls.Add(_btnDelete);
        Controls.Add(_btnEdit);
        Controls.Add(_btnAdd);
        Controls.Add(_txtAddress);
        Controls.Add(_lblAddress);
        Controls.Add(_txtPhone);
        Controls.Add(_lblPhone);
        Controls.Add(_txtEgn);
        Controls.Add(_lblEgn);
        Controls.Add(_txtName);
        Controls.Add(_lblName);
        Controls.Add(_txtId);
        Controls.Add(_lblId);
        Name = "ChlenForm";
        Text = "Управление: CHLEN";
        ((System.ComponentModel.ISupportInitialize)_grid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label _lblId;
    private TextBox _txtId;
    private Label _lblName;
    private TextBox _txtName;
    private Label _lblEgn;
    private TextBox _txtEgn;
    private Label _lblPhone;
    private MaskedTextBox _txtPhone;
    private Label _lblAddress;
    private TextBox _txtAddress;
    private Button _btnAdd;
    private Button _btnEdit;
    private Button _btnDelete;
    private Button _btnRefresh;
    private DataGridView _grid;
}
