using System.Data;
using BaziDanni_k.p_.Infrastructure;
using BaziDanni_k.p_.Repositories.grupa;
using BaziDanni_k.p_.Repositories.nivo;
using BaziDanni_k.p_.Repositories.sport;
using BaziDanni_k.p_.Repositories.trenior;

namespace BaziDanni_k.p_.Forms;

public sealed partial class GrupaForm : Form
{
    private readonly GrupaRepository _grupaRepository;
    private readonly SportRepository _sportRepository;
    private readonly NivoRepository _nivoRepository;
    private readonly TreniorRepository _treniorRepository;

    public GrupaForm(string connectionString)
    {
        _grupaRepository = new GrupaRepository(connectionString);
        _sportRepository = new SportRepository(connectionString);
        _nivoRepository = new NivoRepository(connectionString);
        _treniorRepository = new TreniorRepository(connectionString);

        InitializeComponent();

        UiStyler.MakeButtonsMoreVisible(this);
        LoadLookups();
        LoadData();
    }

    private void BtnAdd_Click(object? sender, EventArgs e) => AddRecord();
    private void BtnEdit_Click(object? sender, EventArgs e) => UpdateRecord();
    private void BtnDelete_Click(object? sender, EventArgs e) => DeleteRecord();
    private void BtnRefresh_Click(object? sender, EventArgs e) => LoadData();
    private void Grid_SelectionChanged(object? sender, EventArgs e) => SyncSelectedRow();

    private void LoadLookups()
    {
        _cmbSport.DataSource = _sportRepository.GetAll();
        _cmbSport.DisplayMember = "Ime_sport";
        _cmbSport.ValueMember = "N_sport";
        _cmbNivo.DataSource = _nivoRepository.GetAll();
        _cmbNivo.DisplayMember = "Ime_nivo";
        _cmbNivo.ValueMember = "N_nivo";
        _cmbTrenior.DataSource = _treniorRepository.GetAll();
        _cmbTrenior.DisplayMember = "Ime_trenior";
        _cmbTrenior.ValueMember = "N_trenior";
    }

    private void LoadData() => _grid.DataSource = _grupaRepository.GetAll();
    private void AddRecord() { _grupaRepository.Insert(GetValues()); LoadData(); }
    private void UpdateRecord() { _grupaRepository.Update(GetValues()); LoadData(); }
    private void DeleteRecord() { _grupaRepository.Delete(_txtNGrupa.Text.Trim()); LoadData(); }

    private Dictionary<string, object?> GetValues() => new()
    {
        ["N_grupa"] = _txtNGrupa.Text.Trim(),
        ["N_sport"] = _cmbSport.SelectedValue,
        ["N_nivo"] = _cmbNivo.SelectedValue,
        ["N_trenior"] = _cmbTrenior.SelectedValue
    };

    private void SyncSelectedRow()
    {
        if (_grid.CurrentRow?.DataBoundItem is not DataRowView row) return;
        _txtNGrupa.Text = row["N_grupa"]?.ToString() ?? string.Empty;
        SetComboValue(_cmbSport, row["N_sport"]);
        SetComboValue(_cmbNivo, row["N_nivo"]);
        SetComboValue(_cmbTrenior, row["N_trenior"]);
    }

    private static void SetComboValue(ComboBox comboBox, object? value)
    {
        if (value is null || value is DBNull) return;
        comboBox.SelectedValue = value;
    }
}
