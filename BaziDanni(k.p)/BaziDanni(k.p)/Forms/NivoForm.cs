using System.Data;
using BaziDanni_k.p_.Infrastructure;
using BaziDanni_k.p_.Repositories.nivo;

namespace BaziDanni_k.p_.Forms;

public sealed partial class NivoForm : Form
{
    private readonly NivoRepository _repository;
    private readonly ColorDialog _colorDialog = new();

    public NivoForm(string cs)
    {
        _repository = new NivoRepository(cs);
        InitializeComponent();
        UiStyler.MakeButtonsMoreVisible(this);
        LoadData();
    }

    private void BtnColor_Click(object? sender, EventArgs e)
    {
        if (_colorDialog.ShowDialog() != DialogResult.OK) return;
        _txtColor.Text = _colorDialog.Color.Name;
        _txtColor.BackColor = _colorDialog.Color;
    }

    private void BtnAdd_Click(object? sender, EventArgs e) { _repository.Insert(GetValues()); LoadData(); }
    private void BtnEdit_Click(object? sender, EventArgs e) { _repository.Update(GetValues()); LoadData(); }
    private void BtnDelete_Click(object? sender, EventArgs e) { _repository.Delete(_txtId.Text.Trim()); LoadData(); }
    private void Grid_SelectionChanged(object? sender, EventArgs e) => BindSelected();

    private Dictionary<string, object?> GetValues() => new() { ["N_nivo"] = _txtId.Text.Trim(), ["Ime_nivo"] = _txtName.Text.Trim(), ["Cvyat"] = _txtColor.Text.Trim() };
    private void LoadData() => _grid.DataSource = _repository.GetAll();
    private void BindSelected()
    {
        if (_grid.CurrentRow?.DataBoundItem is not DataRowView row) return;
        _txtId.Text = row["N_nivo"]?.ToString() ?? string.Empty;
        _txtName.Text = row["Ime_nivo"]?.ToString() ?? string.Empty;
        _txtColor.Text = row["Cvyat"]?.ToString() ?? string.Empty;
    }
}
