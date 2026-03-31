using System.Data;
using BaziDanni_k.p_.Repositories.trenirovka;

namespace BaziDanni_k.p_.Forms.trenirovka;

public sealed class TrenirovkaForm : Form
{
    private readonly TrenirovkaRepository _repository;
    private readonly DataGridView _grid = new() { Dock = DockStyle.Fill, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
    private readonly DateTimePicker _date = new() { Width = 130, Format = DateTimePickerFormat.Short };
    private readonly DateTimePicker _time = new() { Width = 110, Format = DateTimePickerFormat.Time, ShowUpDown = true };
    private readonly TextBox _txtGroup = new() { Width = 90 };
    private readonly TextBox _txtChlen = new() { Width = 90 };
    private readonly TextBox _txtDay = new() { Width = 90 };

    public TrenirovkaForm(string cs)
    {
        Text = "Управление: TRENIROVKA";
        Width = 1000;
        Height = 560;
        _repository = new TrenirovkaRepository(cs);

        BuildUi();
        LoadData();
    }

    private void BuildUi()
    {
        var top = new FlowLayoutPanel { Dock = DockStyle.Top, Height = 110, Padding = new Padding(10) };
        top.Controls.AddRange([
            new Label { Text = "Група" }, _txtGroup,
            new Label { Text = "Дата" }, _date,
            new Label { Text = "Час" }, _time,
            new Label { Text = "Член" }, _txtChlen,
            new Label { Text = "Ден" }, _txtDay
        ]);

        var btnAdd = new Button { Text = "Добави тренировка" };
        var btnEdit = new Button { Text = "Запиши промени" };
        var btnDelete = new Button { Text = "Изтрий" };

        btnAdd.Click += (_, _) => { _repository.Insert(GetValues()); LoadData(); };
        btnEdit.Click += (_, _) => { _repository.Update(GetValues()); LoadData(); };
        btnDelete.Click += (_, _) => { _repository.Delete(_txtGroup.Text.Trim()); LoadData(); };
        _grid.SelectionChanged += (_, _) => BindSelected();

        top.Controls.AddRange([btnAdd, btnEdit, btnDelete]);

        Controls.Add(_grid);
        Controls.Add(top);
    }

    private Dictionary<string, object?> GetValues() => new()
    {
        ["N_grupa"] = _txtGroup.Text.Trim(),
        ["datata"] = _date.Value.ToString("yyyy-MM-dd"),
        ["chas"] = _time.Value.ToString("HH:mm"),
        ["N_chlen"] = _txtChlen.Text.Trim(),
        ["N_den"] = _txtDay.Text.Trim()
    };

    private void LoadData() => _grid.DataSource = _repository.GetAll();

    private void BindSelected()
    {
        if (_grid.CurrentRow?.DataBoundItem is not DataRowView row) return;
        _txtGroup.Text = row["N_grupa"]?.ToString() ?? string.Empty;
        _txtChlen.Text = row["N_chlen"]?.ToString() ?? string.Empty;
        _txtDay.Text = row["N_den"]?.ToString() ?? string.Empty;
        if (DateTime.TryParse(row["datata"]?.ToString(), out var date)) _date.Value = date;
        if (DateTime.TryParse(row["chas"]?.ToString(), out var time)) _time.Value = DateTime.Today.Add(time.TimeOfDay);
    }
}
