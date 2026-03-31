using System.Data;
using BaziDanni_k.p_.Repositories.trenior;

namespace BaziDanni_k.p_.Forms.trenior;

public sealed class TreniorForm : Form
{
    private readonly TreniorRepository _repository;
    private readonly DataGridView _grid = new() { Dock = DockStyle.Fill, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
    private readonly TextBox _txtId = new() { Width = 100 };
    private readonly TextBox _txtName = new() { Width = 220 };
    private readonly TextBox _txtSportId = new() { Width = 120 };
    private readonly MaskedTextBox _txtPhone = new("0000-000-000") { Width = 130 };

    public TreniorForm(string cs)
    {
        Text = "Управление: TRENIOR";
        Width = 980;
        Height = 560;
        _repository = new TreniorRepository(cs);

        BuildUi();
        LoadData();
    }

    private void BuildUi()
    {
        var top = new Panel { Dock = DockStyle.Top, Height = 120, Padding = new Padding(10) };
        top.Controls.Add(new Label { Text = "Номер", Left = 10, Top = 15, Width = 90 });
        top.Controls.Add(_txtId);
        _txtId.Left = 10; _txtId.Top = 38;

        top.Controls.Add(new Label { Text = "Име на треньор", Left = 130, Top = 15, Width = 120 });
        _txtName.Left = 130; _txtName.Top = 38; top.Controls.Add(_txtName);

        top.Controls.Add(new Label { Text = "Номер спорт", Left = 370, Top = 15, Width = 100 });
        _txtSportId.Left = 370; _txtSportId.Top = 38; top.Controls.Add(_txtSportId);

        top.Controls.Add(new Label { Text = "Телефон", Left = 500, Top = 15, Width = 100 });
        _txtPhone.Left = 500; _txtPhone.Top = 38; top.Controls.Add(_txtPhone);

        var btnAdd = new Button { Text = "Добави", Left = 650, Top = 35, Width = 90 };
        var btnEdit = new Button { Text = "Редактирай", Left = 745, Top = 35, Width = 90 };
        var btnDelete = new Button { Text = "Изтрий", Left = 840, Top = 35, Width = 90 };

        btnAdd.Click += (_, _) => { _repository.Insert(GetValues()); LoadData(); };
        btnEdit.Click += (_, _) => { _repository.Update(GetValues()); LoadData(); };
        btnDelete.Click += (_, _) => { _repository.Delete(_txtId.Text.Trim()); LoadData(); };
        _grid.SelectionChanged += (_, _) => BindSelected();

        top.Controls.Add(btnAdd);
        top.Controls.Add(btnEdit);
        top.Controls.Add(btnDelete);

        Controls.Add(_grid);
        Controls.Add(top);
    }

    private Dictionary<string, object?> GetValues() => new()
    {
        ["N_trenior"] = _txtId.Text.Trim(),
        ["Ime_trenior"] = _txtName.Text.Trim(),
        ["N_sport"] = _txtSportId.Text.Trim(),
        ["Telefon_trenior"] = _txtPhone.Text.Trim()
    };

    private void LoadData() => _grid.DataSource = _repository.GetAll();

    private void BindSelected()
    {
        if (_grid.CurrentRow?.DataBoundItem is not DataRowView row) return;
        _txtId.Text = row["N_trenior"]?.ToString() ?? string.Empty;
        _txtName.Text = row["Ime_trenior"]?.ToString() ?? string.Empty;
        _txtSportId.Text = row["N_sport"]?.ToString() ?? string.Empty;
        _txtPhone.Text = row["Telefon_trenior"]?.ToString() ?? string.Empty;
    }
}
