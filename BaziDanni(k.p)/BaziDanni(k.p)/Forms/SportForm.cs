using System.Data;
using BaziDanni_k.p_.Infrastructure;
using BaziDanni_k.p_.Repositories.sport;

namespace BaziDanni_k.p_.Forms;
public sealed partial class SportForm : Form
{
    private readonly SportRepository _repository;
    public SportForm(string cs)
    {
        _repository = new SportRepository(cs);
        InitializeComponent();
        UiStyler.MakeButtonsMoreVisible(this);
        LoadData();
    }
    private void Add_Click(object? s, EventArgs e){ _repository.Insert(GetValues()); LoadData(); }
    private void Edit_Click(object? s, EventArgs e){ _repository.Update(GetValues()); LoadData(); }
    private void Delete_Click(object? s, EventArgs e){ _repository.Delete(_txtId.Text.Trim()); LoadData(); }
    private void Reload_Click(object? s, EventArgs e)=>LoadData();
    private void Grid_SelectionChanged(object? s, EventArgs e)=>BindSelected();
    private Dictionary<string, object?> GetValues()=>new(){["N_sport"]=_txtId.Text.Trim(),["Ime_sport"]=_txtName.Text.Trim(),["Cvyat"]=_cmbColor.Text.Trim()};
    private void LoadData()=>_grid.DataSource=_repository.GetAll();
    private void BindSelected(){ if (_grid.CurrentRow?.DataBoundItem is not DataRowView row) return; _txtId.Text=row["N_sport"]?.ToString()??string.Empty; _txtName.Text=row["Ime_sport"]?.ToString()??string.Empty; _cmbColor.Text=row["Cvyat"]?.ToString()??string.Empty; }
}
