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
        _txtId = new TextBox();
        _lblId = new Label();
        _txtName = new TextBox();
        _lblName = new Label();
        _txtSportId = new TextBox();
        _lblSportId = new Label();
        _txtPhone = new MaskedTextBox();
        _lblPhone = new Label();
        _btnAdd = new Button();
        _btnEdit = new Button();
        _btnDelete = new Button();
        _grid = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)_grid).BeginInit();
        SuspendLayout();

        _lblId.AutoSize = true; _lblId.Location = new Point(12, 15); _lblId.Text = "Номер";
        _txtId.Location = new Point(12, 38); _txtId.Size = new Size(100, 27);

        _lblName.AutoSize = true; _lblName.Location = new Point(132, 15); _lblName.Text = "Име на треньор";
        _txtName.Location = new Point(132, 38); _txtName.Size = new Size(220, 27);

        _lblSportId.AutoSize = true; _lblSportId.Location = new Point(372, 15); _lblSportId.Text = "Номер спорт";
        _txtSportId.Location = new Point(372, 38); _txtSportId.Size = new Size(120, 27);

        _lblPhone.AutoSize = true; _lblPhone.Location = new Point(512, 15); _lblPhone.Text = "Телефон";
        _txtPhone.Location = new Point(512, 38); _txtPhone.Mask = "0000-000-000"; _txtPhone.Size = new Size(130, 27);

        _btnAdd.Location = new Point(662, 36); _btnAdd.Size = new Size(94, 29); _btnAdd.Text = "Добави"; _btnAdd.UseVisualStyleBackColor = true;
        _btnEdit.Location = new Point(762, 36); _btnEdit.Size = new Size(94, 29); _btnEdit.Text = "Редактирай"; _btnEdit.UseVisualStyleBackColor = true;
        _btnDelete.Location = new Point(862, 36); _btnDelete.Size = new Size(94, 29); _btnDelete.Text = "Изтрий"; _btnDelete.UseVisualStyleBackColor = true;

        _grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        _grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        _grid.Location = new Point(12, 100);
        _grid.Name = "_grid";
        _grid.ReadOnly = true;
        _grid.RowHeadersWidth = 51;
        _grid.Size = new Size(956, 448);

        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(980, 560);
        Controls.Add(_grid);
        Controls.Add(_btnDelete);
        Controls.Add(_btnEdit);
        Controls.Add(_btnAdd);
        Controls.Add(_txtPhone);
        Controls.Add(_lblPhone);
        Controls.Add(_txtSportId);
        Controls.Add(_lblSportId);
        Controls.Add(_txtName);
        Controls.Add(_lblName);
        Controls.Add(_txtId);
        Controls.Add(_lblId);
        Name = "TreniorForm";
        Text = "Управление: TRENIOR";
        ((System.ComponentModel.ISupportInitialize)_grid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox _txtId;
    private Label _lblId;
    private TextBox _txtName;
    private Label _lblName;
    private TextBox _txtSportId;
    private Label _lblSportId;
    private MaskedTextBox _txtPhone;
    private Label _lblPhone;
    private Button _btnAdd;
    private Button _btnEdit;
    private Button _btnDelete;
    private DataGridView _grid;
}
