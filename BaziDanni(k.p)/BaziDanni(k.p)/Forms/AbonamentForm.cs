using System.Data;
using BaziDanni_k.p_.Infrastructure;
using BaziDanni_k.p_.Repositories.abonament;

namespace BaziDanni_k.p_.Forms;

public sealed partial class AbonamentForm : Form
{
    private readonly AbonamentRepository _repository;

    public AbonamentForm(string cs)
    {
        _repository = new AbonamentRepository(cs);

        InitializeComponent();

        UiStyler.MakeButtonsMoreVisible(this);
        LoadData();
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        _repository.Insert(GetValues());
        LoadData();
    }

    private void BtnEdit_Click(object? sender, EventArgs e)
    {
        _repository.Update(GetValues());
        LoadData();
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        _repository.Delete(_txtId.Text.Trim());
        LoadData();
    }

    private void Grid_SelectionChanged(object? sender, EventArgs e) => BindSelected();

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
