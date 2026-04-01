using System.Data;
using BaziDanni_k.p_.Infrastructure;
using BaziDanni_k.p_.Repositories.sport;
using BaziDanni_k.p_.Repositories.trenior;

namespace BaziDanni_k.p_.Forms;

public sealed partial class TreniorForm : Form
{
    private readonly TreniorRepository _repository;
    private readonly SportRepository _sportRepository;

    public TreniorForm(string cs)
    {
        _repository = new TreniorRepository(cs);
        _sportRepository = new SportRepository(cs);

        InitializeComponent();
        LoadLookups();
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
        ["N_trenior"] = _txtId.Text.Trim(),
        ["Ime_trenior"] = _txtName.Text.Trim(),
        ["N_sport"] = _cmbSport.SelectedValue,
        ["Telefon_trenior"] = _txtPhone.Text.Trim()
    };

    private void LoadLookups()
    {
        _cmbSport.DataSource = _sportRepository.GetAll();
        _cmbSport.DisplayMember = "Ime_sport";
        _cmbSport.ValueMember = "N_sport";
    }

    private void LoadData() => _grid.DataSource = _repository.GetAll();

    private void BindSelected()
    {
        if (_grid.CurrentRow?.DataBoundItem is not DataRowView row) return;
        _txtId.Text = row["N_trenior"]?.ToString() ?? string.Empty;
        _txtName.Text = row["Ime_trenior"]?.ToString() ?? string.Empty;
        if (row["N_sport"] != DBNull.Value) _cmbSport.SelectedValue = row["N_sport"];
        _txtPhone.Text = row["Telefon_trenior"]?.ToString() ?? string.Empty;
    }
}
