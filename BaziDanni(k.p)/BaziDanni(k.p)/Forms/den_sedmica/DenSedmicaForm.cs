using System.Data;
using BaziDanni_k.p_.Repositories.den_sedmica;

namespace BaziDanni_k.p_.Forms.den_sedmica;

public sealed class DenSedmicaForm : Form
{
    private readonly DenSedmicaRepository _repository;
    private readonly DataGridView _grid = new() { Dock = DockStyle.Fill, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
    private readonly TextBox _txtId = new() { Width = 90 };
    private readonly ComboBox _cmbDay = new() { Width = 160, DropDownStyle = ComboBoxStyle.DropDownList };
    private readonly ComboBox _cmbColor = new() { Width = 140, DropDownStyle = ComboBoxStyle.DropDownList };

    public DenSedmicaForm(string cs)
    {
        Text = "Управление: DEN_SEDMICA";
        Width = 900;
        Height = 520;
        _repository = new DenSedmicaRepository(cs);

        _cmbDay.Items.AddRange(["Понеделник", "Вторник", "Сряда", "Четвъртък", "Петък", "Събота", "Неделя"]);
        _cmbColor.Items.AddRange(["червен", "син", "зелен", "жълт", "лилав"]);
        if (_cmbDay.Items.Count > 0) _cmbDay.SelectedIndex = 0;
        if (_cmbColor.Items.Count > 0) _cmbColor.SelectedIndex = 0;

        BuildUi();
        LoadData();
    }

    private void BuildUi()
    {
        var toolbar = new ToolStrip { Dock = DockStyle.Top };
        toolbar.Items.Add("Номер");
        toolbar.Items.Add(new ToolStripControlHost(_txtId));
        toolbar.Items.Add(new ToolStripSeparator());
        toolbar.Items.Add("Ден");
        toolbar.Items.Add(new ToolStripControlHost(_cmbDay));
        toolbar.Items.Add("Цвят");
        toolbar.Items.Add(new ToolStripControlHost(_cmbColor));

        var addBtn = new ToolStripButton("Добави");
        var editBtn = new ToolStripButton("Редактирай");
        var delBtn = new ToolStripButton("Изтрий");
        toolbar.Items.Add(addBtn);
        toolbar.Items.Add(editBtn);
        toolbar.Items.Add(delBtn);

        addBtn.Click += (_, _) => { _repository.Insert(GetValues()); LoadData(); };
        editBtn.Click += (_, _) => { _repository.Update(GetValues()); LoadData(); };
        delBtn.Click += (_, _) => { _repository.Delete(_txtId.Text.Trim()); LoadData(); };
        _grid.SelectionChanged += (_, _) => BindSelected();

        Controls.Add(_grid);
        Controls.Add(toolbar);
    }

    private Dictionary<string, object?> GetValues() => new()
    {
        ["N_den"] = _txtId.Text.Trim(),
        ["Den"] = _cmbDay.Text,
        ["Cvyat"] = _cmbColor.Text
    };

    private void LoadData() => _grid.DataSource = _repository.GetAll();

    private void BindSelected()
    {
        if (_grid.CurrentRow?.DataBoundItem is not DataRowView row) return;
        _txtId.Text = row["N_den"]?.ToString() ?? string.Empty;
        _cmbDay.Text = row["Den"]?.ToString() ?? string.Empty;
        _cmbColor.Text = row["Cvyat"]?.ToString() ?? string.Empty;
    }
}
