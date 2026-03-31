using System.Data;
using BaziDanni_k.p_.Repositories.abonament;

namespace BaziDanni_k.p_.Forms.abonament;

public sealed class AbonamentForm : Form
{
    private readonly AbonamentRepository _repository;
    private readonly DataGridView _grid = new() { Dock = DockStyle.Fill, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };

    private readonly TextBox _txtId = new() { Width = 150, PlaceholderText = "N_abonament" };
    private readonly NumericUpDown _numPeriod = new() { Width = 180, Minimum = 1, Maximum = 120 };
    private readonly NumericUpDown _numPrice = new() { Width = 180, Minimum = 0, Maximum = 5000, DecimalPlaces = 2, Increment = 5 };

    public AbonamentForm(string cs)
    {
        Text = "Управление: ABONAMENT";
        Width = 950;
        Height = 580;
        _repository = new AbonamentRepository(cs);

        BuildUi();
        LoadData();
    }

    private void BuildUi()
    {
        var top = new TableLayoutPanel { Dock = DockStyle.Top, Height = 110, ColumnCount = 6, Padding = new Padding(8) };
        top.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18));
        top.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22));
        top.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22));
        top.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12));
        top.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12));
        top.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14));

        top.Controls.Add(new Label { Text = "Номер", AutoSize = true }, 0, 0);
        top.Controls.Add(new Label { Text = "Период (мес.)", AutoSize = true }, 1, 0);
        top.Controls.Add(new Label { Text = "Цена (лв.)", AutoSize = true }, 2, 0);
        top.Controls.Add(_txtId, 0, 1);
        top.Controls.Add(_numPeriod, 1, 1);
        top.Controls.Add(_numPrice, 2, 1);

        var btnAdd = new Button { Text = "Добави" };
        var btnEdit = new Button { Text = "Редактирай" };
        var btnDelete = new Button { Text = "Изтрий" };

        btnAdd.Click += (_, _) => { _repository.Insert(GetValues()); LoadData(); };
        btnEdit.Click += (_, _) => { _repository.Update(GetValues()); LoadData(); };
        btnDelete.Click += (_, _) => { _repository.Delete(_txtId.Text.Trim()); LoadData(); };
        _grid.SelectionChanged += (_, _) => BindSelected();

        top.Controls.Add(btnAdd, 3, 1);
        top.Controls.Add(btnEdit, 4, 1);
        top.Controls.Add(btnDelete, 5, 1);

        Controls.Add(_grid);
        Controls.Add(top);
    }

    private Dictionary<string, object?> GetValues() => new()
    {
        ["N_abonament"] = _txtId.Text.Trim(),
        ["Period_meseci"] = _numPeriod.Value.ToString(),
        ["Cena_lv"] = _numPrice.Value.ToString("0.##")
    };

    private void LoadData() => _grid.DataSource = _repository.GetAll();

    private void BindSelected()
    {
        if (_grid.CurrentRow?.DataBoundItem is not DataRowView row) return;
        _txtId.Text = row["N_abonament"]?.ToString() ?? string.Empty;
        _numPeriod.Value = decimal.TryParse(row["Period_meseci"]?.ToString(), out var p) ? Math.Clamp(p, _numPeriod.Minimum, _numPeriod.Maximum) : _numPeriod.Minimum;
        _numPrice.Value = decimal.TryParse(row["Cena_lv"]?.ToString(), out var price) ? Math.Clamp(price, _numPrice.Minimum, _numPrice.Maximum) : _numPrice.Minimum;
    }
}
