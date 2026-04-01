using System.Data;
using BaziDanni_k.p_.Infrastructure;
using BaziDanni_k.p_.Repositories.zapisani_abonamenti;

namespace BaziDanni_k.p_.Forms;
public sealed partial class ZapisaniAbonamentiForm : Form
{
    private readonly ZapisaniAbonamentiRepository _repository;
    public ZapisaniAbonamentiForm(string cs)
    {
        _repository = new ZapisaniAbonamentiRepository(cs);
        InitializeComponent();
        UiStyler.StyleToolStrip(_strip);
        UiStyler.MakeButtonsMoreVisible(this);
        LoadData();
    }
    private void AddItem_Click(object? s, EventArgs e){ _repository.Insert(GetValues()); LoadData(); }
    private void EditItem_Click(object? s, EventArgs e){ _repository.Update(GetValues()); LoadData(); }
    private void DeleteItem_Click(object? s, EventArgs e){ _repository.Delete(_txtChlen.Text.Trim()); LoadData(); }
    private void Grid_SelectionChanged(object? s, EventArgs e)=>BindSelected();
    private Dictionary<string, object?> GetValues()=>new(){["N_chlen"]=_txtChlen.Text.Trim(),["N_grupa"]=_txtGroup.Text.Trim(),["N_abonament"]=_txtAbonament.Text.Trim(),["Data_zapis"]=_date.Value.ToString("yyyy-MM-dd")};
    private void LoadData()=>_grid.DataSource=_repository.GetAll();
    private void BindSelected(){ if (_grid.CurrentRow?.DataBoundItem is not DataRowView row) return; _txtChlen.Text=row["N_chlen"]?.ToString()??string.Empty; _txtGroup.Text=row["N_grupa"]?.ToString()??string.Empty; _txtAbonament.Text=row["N_abonament"]?.ToString()??string.Empty; if (DateTime.TryParse(row["Data_zapis"]?.ToString(), out var d)) _date.Value=d; }
}
