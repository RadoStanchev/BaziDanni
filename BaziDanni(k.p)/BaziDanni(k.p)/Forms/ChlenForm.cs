using System.Data;
using BaziDanni_k.p_.Infrastructure;
using BaziDanni_k.p_.Repositories.chlen;

namespace BaziDanni_k.p_.Forms;

public sealed partial class ChlenForm : Form
{
    private readonly ChlenRepository _repository;

    public ChlenForm(string cs)
    {
        _repository = new ChlenRepository(cs);

        InitializeComponent();

        _btnAdd.Click += BtnAdd_Click;
        _btnEdit.Click += BtnEdit_Click;
        _btnDelete.Click += BtnDelete_Click;
        _btnRefresh.Click += BtnRefresh_Click;
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

    private void BtnRefresh_Click(object? sender, EventArgs e) => LoadData();

    private void Grid_SelectionChanged(object? sender, EventArgs e) => BindSelected();

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
