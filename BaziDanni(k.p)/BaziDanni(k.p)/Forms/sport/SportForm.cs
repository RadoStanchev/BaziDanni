using System.Data;
using BaziDanni_k.p_.Repositories.sport;

namespace BaziDanni_k.p_.Forms.sport;

public sealed class SportForm : Form
{
    private readonly SportRepository _repository;
    private readonly DataGridView _grid = new() { Dock = DockStyle.Fill, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
    private readonly TextBox _txtId = new() { Width = 110 };
    private readonly TextBox _txtName = new() { Width = 220 };
    private readonly ComboBox _cmbColor = new() { Width = 160 };

    public SportForm(string cs)
    {
        Text = "Управление: SPORT";
        Width = 920;
        Height = 540;
        _repository = new SportRepository(cs);

        _cmbColor.Items.AddRange(["червен", "син", "оранжев", "черен", "бял"]);

        BuildUi();
        LoadData();
    }

    private void BuildUi()
    {
        var split = new SplitContainer { Dock = DockStyle.Fill, Orientation = Orientation.Horizontal, SplitterDistance = 100 };
        var top = split.Panel1;
        var controls = new FlowLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(8) };

        controls.Controls.AddRange([
            new Label { Text = "Номер" }, _txtId,
            new Label { Text = "Спорт" }, _txtName,
            new Label { Text = "Цвят" }, _cmbColor
        ]);

        var add = new Button { Text = "Добави" };
        var edit = new Button { Text = "Редактирай" };
        var delete = new Button { Text = "Изтрий" };
        var reload = new Button { Text = "Презареди" };

        add.Click += (_, _) => { _repository.Insert(GetValues()); LoadData(); };
        edit.Click += (_, _) => { _repository.Update(GetValues()); LoadData(); };
        delete.Click += (_, _) => { _repository.Delete(_txtId.Text.Trim()); LoadData(); };
        reload.Click += (_, _) => LoadData();
        _grid.SelectionChanged += (_, _) => BindSelected();

        controls.Controls.AddRange([add, edit, delete, reload]);
        top.Controls.Add(controls);
        split.Panel2.Controls.Add(_grid);

        Controls.Add(split);
    }

    private Dictionary<string, object?> GetValues() => new()
    {
        ["N_sport"] = _txtId.Text.Trim(),
        ["Ime_sport"] = _txtName.Text.Trim(),
        ["Cvyat"] = _cmbColor.Text.Trim()
    };

    private void LoadData() => _grid.DataSource = _repository.GetAll();

    private void BindSelected()
    {
        if (_grid.CurrentRow?.DataBoundItem is not DataRowView row) return;
        _txtId.Text = row["N_sport"]?.ToString() ?? string.Empty;
        _txtName.Text = row["Ime_sport"]?.ToString() ?? string.Empty;
        _cmbColor.Text = row["Cvyat"]?.ToString() ?? string.Empty;
    }
}
