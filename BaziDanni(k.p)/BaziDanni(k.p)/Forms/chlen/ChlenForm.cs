using System.Data;
using BaziDanni_k.p_.Repositories.chlen;

namespace BaziDanni_k.p_.Forms.chlen;

public sealed class ChlenForm : Form
{
    private readonly ChlenRepository _repository;
    private readonly DataGridView _grid = new() { Dock = DockStyle.Fill, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
    private readonly TextBox _txtId = new() { Width = 120 };
    private readonly TextBox _txtName = new() { Width = 220 };
    private readonly TextBox _txtEgn = new() { Width = 140 };
    private readonly MaskedTextBox _txtPhone = new("0000-000-000") { Width = 130 };
    private readonly TextBox _txtAddress = new() { Width = 280 };

    public ChlenForm(string cs)
    {
        Text = "Управление: CHLEN";
        Width = 1150;
        Height = 620;
        _repository = new ChlenRepository(cs);

        BuildUi();
        LoadData();
    }

    private void BuildUi()
    {
        var top = new GroupBox { Text = "Данни за член", Dock = DockStyle.Top, Height = 140 };
        var panel = new FlowLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(10), AutoScroll = true };

        panel.Controls.AddRange([
            CreateLabeled("Номер", _txtId),
            CreateLabeled("Име", _txtName),
            CreateLabeled("ЕГН", _txtEgn),
            CreateLabeled("Телефон", _txtPhone),
            CreateLabeled("Адрес", _txtAddress)
        ]);

        var btnAdd = new Button { Text = "Добави", Width = 100 };
        var btnEdit = new Button { Text = "Промени", Width = 100 };
        var btnDelete = new Button { Text = "Премахни", Width = 100 };
        var btnRefresh = new Button { Text = "Обнови", Width = 100 };
        btnAdd.Click += (_, _) => { _repository.Insert(GetValues()); LoadData(); };
        btnEdit.Click += (_, _) => { _repository.Update(GetValues()); LoadData(); };
        btnDelete.Click += (_, _) => { _repository.Delete(_txtId.Text.Trim()); LoadData(); };
        btnRefresh.Click += (_, _) => LoadData();
        _grid.SelectionChanged += (_, _) => BindSelected();
        panel.Controls.AddRange([btnAdd, btnEdit, btnDelete, btnRefresh]);

        top.Controls.Add(panel);
        Controls.Add(_grid);
        Controls.Add(top);
    }

    private static Panel CreateLabeled(string label, Control control)
    {
        var wrapper = new Panel { Width = control.Width + 8, Height = 52 };
        wrapper.Controls.Add(new Label { Text = label, Dock = DockStyle.Top, Height = 20 });
        control.Top = 22;
        wrapper.Controls.Add(control);
        return wrapper;
    }

    private Dictionary<string, object?> GetValues() => new()
    {
        ["N_chlen"] = _txtId.Text.Trim(),
        ["Ime_chlen"] = _txtName.Text.Trim(),
        ["EGN"] = _txtEgn.Text.Trim(),
        ["Telefon"] = _txtPhone.Text.Trim(),
        ["Adres"] = _txtAddress.Text.Trim()
    };

    private void LoadData() => _grid.DataSource = _repository.GetAll();

    private void BindSelected()
    {
        if (_grid.CurrentRow?.DataBoundItem is not DataRowView row) return;
        _txtId.Text = row["N_chlen"]?.ToString() ?? string.Empty;
        _txtName.Text = row["Ime_chlen"]?.ToString() ?? string.Empty;
        _txtEgn.Text = row["EGN"]?.ToString() ?? string.Empty;
        _txtPhone.Text = row["Telefon"]?.ToString() ?? string.Empty;
        _txtAddress.Text = row["Adres"]?.ToString() ?? string.Empty;
    }
}
