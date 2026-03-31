using System.Data;
using BaziDanni_k.p_.Repositories.grupa;
using BaziDanni_k.p_.Repositories.nivo;
using BaziDanni_k.p_.Repositories.sport;
using BaziDanni_k.p_.Repositories.trenior;
using BaziDanni_k.p_.Infrastructure;

namespace BaziDanni_k.p_.Forms.grupa;

public sealed class GrupaForm : Form
{
    private readonly GrupaRepository _grupaRepository;
    private readonly SportRepository _sportRepository;
    private readonly NivoRepository _nivoRepository;
    private readonly TreniorRepository _treniorRepository;

    private readonly DataGridView _grid = new()
    {
        Dock = DockStyle.Fill,
        ReadOnly = true,
        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
        SelectionMode = DataGridViewSelectionMode.FullRowSelect,
        MultiSelect = false
    };

    private readonly TextBox _txtNGrupa = new() { Width = 150, PlaceholderText = "N_grupa" };
    private readonly ComboBox _cmbSport = new() { Width = 220, DropDownStyle = ComboBoxStyle.DropDownList };
    private readonly ComboBox _cmbNivo = new() { Width = 220, DropDownStyle = ComboBoxStyle.DropDownList };
    private readonly ComboBox _cmbTrenior = new() { Width = 220, DropDownStyle = ComboBoxStyle.DropDownList };

    public GrupaForm(string connectionString)
    {
        Text = "Управление: GRUPA";
        Width = 1100;
        Height = 620;

        _grupaRepository = new GrupaRepository(connectionString);
        _sportRepository = new SportRepository(connectionString);
        _nivoRepository = new NivoRepository(connectionString);
        _treniorRepository = new TreniorRepository(connectionString);

        BuildUi();
        LoadLookups();
        LoadData();
    }

    private void BuildUi()
    {
        var top = new FlowLayoutPanel
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            Padding = new Padding(8)
        };

        top.Controls.Add(_txtNGrupa);
        top.Controls.Add(_cmbSport);
        top.Controls.Add(_cmbNivo);
        top.Controls.Add(_cmbTrenior);

        var btnAdd = new Button { Text = "Добави" };
        var btnEdit = new Button { Text = "Редактирай" };
        var btnDelete = new Button { Text = "Изтрий" };
        var btnRefresh = new Button { Text = "Обнови" };

        btnAdd.Click += (_, _) => AddRecord();
        btnEdit.Click += (_, _) => UpdateRecord();
        btnDelete.Click += (_, _) => DeleteRecord();
        btnRefresh.Click += (_, _) => LoadData();
        _grid.SelectionChanged += (_, _) => SyncSelectedRow();

        top.Controls.Add(btnAdd);
        top.Controls.Add(btnEdit);
        top.Controls.Add(btnDelete);
        top.Controls.Add(btnRefresh);

        Controls.Add(_grid);
        Controls.Add(top);

        UiStyler.MakeButtonsMoreVisible(this);
    }

    private void LoadLookups()
    {
        var sports = _sportRepository.GetAll();
        var niva = _nivoRepository.GetAll();
        var treniori = _treniorRepository.GetAll();

        _cmbSport.DataSource = sports;
        _cmbSport.DisplayMember = "Ime_sport";
        _cmbSport.ValueMember = "N_sport";

        _cmbNivo.DataSource = niva;
        _cmbNivo.DisplayMember = "Ime_nivo";
        _cmbNivo.ValueMember = "N_nivo";

        _cmbTrenior.DataSource = treniori;
        _cmbTrenior.DisplayMember = "Ime_trenior";
        _cmbTrenior.ValueMember = "N_trenior";
    }

    private void LoadData()
    {
        _grid.DataSource = _grupaRepository.GetAll();
    }

    private void AddRecord()
    {
        _grupaRepository.Insert(GetValues());
        LoadData();
    }

    private void UpdateRecord()
    {
        _grupaRepository.Update(GetValues());
        LoadData();
    }

    private void DeleteRecord()
    {
        _grupaRepository.Delete(_txtNGrupa.Text.Trim());
        LoadData();
    }

    private Dictionary<string, object?> GetValues()
    {
        return new Dictionary<string, object?>
        {
            ["N_grupa"] = _txtNGrupa.Text.Trim(),
            ["N_sport"] = _cmbSport.SelectedValue,
            ["N_nivo"] = _cmbNivo.SelectedValue,
            ["N_trenior"] = _cmbTrenior.SelectedValue
        };
    }

    private void SyncSelectedRow()
    {
        if (_grid.CurrentRow?.DataBoundItem is not DataRowView row)
        {
            return;
        }

        _txtNGrupa.Text = row["N_grupa"]?.ToString() ?? string.Empty;
        SetComboValue(_cmbSport, row["N_sport"]);
        SetComboValue(_cmbNivo, row["N_nivo"]);
        SetComboValue(_cmbTrenior, row["N_trenior"]);
    }

    private static void SetComboValue(ComboBox comboBox, object? value)
    {
        if (value is null || value is DBNull)
        {
            return;
        }

        comboBox.SelectedValue = value;
    }
}
