using System.Data;
using BaziDanni_k.p_.Repositories.nivo;

namespace BaziDanni_k.p_.Forms.nivo;

public sealed class NivoForm : Form
{
    private readonly NivoRepository _repository;
    private readonly DataGridView _grid = new() { Dock = DockStyle.Fill, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
    private readonly TextBox _txtId = new() { Width = 120, PlaceholderText = "N_nivo" };
    private readonly TextBox _txtName = new() { Width = 220, PlaceholderText = "Ime_nivo" };
    private readonly Button _btnColor = new() { Width = 120, Text = "Избери цвят" };
    private readonly TextBox _txtColor = new() { Width = 120, ReadOnly = true };

    public NivoForm(string cs)
    {
        Text = "Управление: NIVO";
        Width = 950;
        Height = 540;
        _repository = new NivoRepository(cs);

        BuildUi();
        LoadData();
    }

    private void BuildUi()
    {
        var colorDialog = new ColorDialog();
        _btnColor.Click += (_, _) =>
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _txtColor.Text = colorDialog.Color.Name;
                _txtColor.BackColor = colorDialog.Color;
            }
        };

        var top = new Panel { Dock = DockStyle.Top, Height = 100, Padding = new Padding(12) };
        var flow = new FlowLayoutPanel { Dock = DockStyle.Fill };
        flow.Controls.AddRange([new Label { Text = "Номер" }, _txtId, new Label { Text = "Ниво" }, _txtName, _btnColor, _txtColor]);

        var btnAdd = new Button { Text = "Добави", Width = 100 };
        var btnEdit = new Button { Text = "Запази", Width = 100 };
        var btnDelete = new Button { Text = "Изтрий", Width = 100 };
        flow.Controls.AddRange([btnAdd, btnEdit, btnDelete]);

        btnAdd.Click += (_, _) => { _repository.Insert(GetValues()); LoadData(); };
        btnEdit.Click += (_, _) => { _repository.Update(GetValues()); LoadData(); };
        btnDelete.Click += (_, _) => { _repository.Delete(_txtId.Text.Trim()); LoadData(); };
        _grid.SelectionChanged += (_, _) => BindSelected();

        top.Controls.Add(flow);
        Controls.Add(_grid);
        Controls.Add(top);
    }

    private Dictionary<string, object?> GetValues() => new()
    {
        ["N_nivo"] = _txtId.Text.Trim(),
        ["Ime_nivo"] = _txtName.Text.Trim(),
        ["Cvyat"] = _txtColor.Text.Trim()
    };

    private void LoadData() => _grid.DataSource = _repository.GetAll();

    private void BindSelected()
    {
        if (_grid.CurrentRow?.DataBoundItem is not DataRowView row) return;
        _txtId.Text = row["N_nivo"]?.ToString() ?? string.Empty;
        _txtName.Text = row["Ime_nivo"]?.ToString() ?? string.Empty;
        _txtColor.Text = row["Cvyat"]?.ToString() ?? string.Empty;
    }
}
