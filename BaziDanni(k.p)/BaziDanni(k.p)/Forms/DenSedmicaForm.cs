using System.Data;
using BaziDanni_k.p_.Infrastructure;
using BaziDanni_k.p_.Repositories.den_sedmica;

namespace BaziDanni_k.p_.Forms;

public sealed partial class DenSedmicaForm : Form
{
    private readonly DenSedmicaRepository _repository;

    public DenSedmicaForm(string cs)
    {
        _repository = new DenSedmicaRepository(cs);

        InitializeComponent();

        UiStyler.StyleToolStrip(_toolbar);
        UiStyler.MakeButtonsMoreVisible(this);
        LoadData();
    }

    private void AddBtn_Click(object? sender, EventArgs e) { _repository.Insert(GetValues()); LoadData(); }
    private void EditBtn_Click(object? sender, EventArgs e) { _repository.Update(GetValues()); LoadData(); }
    private void DelBtn_Click(object? sender, EventArgs e) { _repository.Delete(_txtId.Text.Trim()); LoadData(); }
    private void Grid_SelectionChanged(object? sender, EventArgs e) => BindSelected();

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
