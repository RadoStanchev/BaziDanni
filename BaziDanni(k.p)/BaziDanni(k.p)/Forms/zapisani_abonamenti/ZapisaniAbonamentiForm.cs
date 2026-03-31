using System.Data;
using BaziDanni_k.p_.Repositories.zapisani_abonamenti;

namespace BaziDanni_k.p_.Forms.zapisani_abonamenti;

public sealed class ZapisaniAbonamentiForm : Form
{
    private readonly ZapisaniAbonamentiRepository _repository;
    private readonly DataGridView _grid = new() { Dock = DockStyle.Fill, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
    private readonly TextBox _txtChlen = new() { Width = 100 };
    private readonly TextBox _txtGroup = new() { Width = 100 };
    private readonly TextBox _txtAbonament = new() { Width = 100 };
    private readonly DateTimePicker _date = new() { Width = 130, Format = DateTimePickerFormat.Short };

    public ZapisaniAbonamentiForm(string cs)
    {
        Text = "Управление: ZAPISANI_ABONAMENTI";
        Width = 980;
        Height = 560;
        _repository = new ZapisaniAbonamentiRepository(cs);

        BuildUi();
        LoadData();
    }

    private void BuildUi()
    {
        var strip = new StatusStrip { Dock = DockStyle.Top, SizingGrip = false };
        strip.Items.Add(new ToolStripStatusLabel("Член"));
        strip.Items.Add(new ToolStripControlHost(_txtChlen));
        strip.Items.Add(new ToolStripStatusLabel("Група"));
        strip.Items.Add(new ToolStripControlHost(_txtGroup));
        strip.Items.Add(new ToolStripStatusLabel("Абонамент"));
        strip.Items.Add(new ToolStripControlHost(_txtAbonament));
        strip.Items.Add(new ToolStripStatusLabel("Дата"));
        strip.Items.Add(new ToolStripControlHost(_date));

        var btnAdd = new ToolStripDropDownButton("Действия");
        btnAdd.DropDownItems.Add("Добави", null, (_, _) => { _repository.Insert(GetValues()); LoadData(); });
        btnAdd.DropDownItems.Add("Редактирай", null, (_, _) => { _repository.Update(GetValues()); LoadData(); });
        btnAdd.DropDownItems.Add("Изтрий", null, (_, _) => { _repository.Delete(_txtChlen.Text.Trim()); LoadData(); });
        strip.Items.Add(btnAdd);

        _grid.SelectionChanged += (_, _) => BindSelected();

        Controls.Add(_grid);
        Controls.Add(strip);
    }

    private Dictionary<string, object?> GetValues() => new()
    {
        ["N_chlen"] = _txtChlen.Text.Trim(),
        ["N_grupa"] = _txtGroup.Text.Trim(),
        ["N_abonament"] = _txtAbonament.Text.Trim(),
        ["Data_zapis"] = _date.Value.ToString("yyyy-MM-dd")
    };

    private void LoadData() => _grid.DataSource = _repository.GetAll();

    private void BindSelected()
    {
        if (_grid.CurrentRow?.DataBoundItem is not DataRowView row) return;
        _txtChlen.Text = row["N_chlen"]?.ToString() ?? string.Empty;
        _txtGroup.Text = row["N_grupa"]?.ToString() ?? string.Empty;
        _txtAbonament.Text = row["N_abonament"]?.ToString() ?? string.Empty;
        if (DateTime.TryParse(row["Data_zapis"]?.ToString(), out var date)) _date.Value = date;
    }
}
