using System.Data;
using BaziDanni_k.p_.Infrastructure;
using BaziDanni_k.p_.Repositories.trenior;

namespace BaziDanni_k.p_.Forms;

public sealed partial class TreniorForm : Form
{
    private readonly TreniorRepository _repository;

    public TreniorForm(string cs)
    {
        _repository = new TreniorRepository(cs);

        InitializeComponent();

        _btnAdd.Click += BtnAdd_Click;
        _btnEdit.Click += BtnEdit_Click;
        _btnDelete.Click += BtnDelete_Click;
        _grid.SelectionChanged += Grid_SelectionChanged;
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
        ["N_sport"] = _txtSportId.Text.Trim(),
        ["Telefon_trenior"] = _txtPhone.Text.Trim()
    };

    private void LoadData() => _grid.DataSource = _repository.GetAll();

    private void BindSelected()
    {
        if (_grid.CurrentRow?.DataBoundItem is not DataRowView row) return;
        _txtId.Text = row["N_trenior"]?.ToString() ?? string.Empty;
        _txtName.Text = row["Ime_trenior"]?.ToString() ?? string.Empty;
        _txtSportId.Text = row["N_sport"]?.ToString() ?? string.Empty;
        _txtPhone.Text = row["Telefon_trenior"]?.ToString() ?? string.Empty;
    }
}
