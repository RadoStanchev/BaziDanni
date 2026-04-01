using System.Data;
using BaziDanni_k.p_.Infrastructure;
using BaziDanni_k.p_.Repositories.trenirovka;

namespace BaziDanni_k.p_.Forms;
public sealed partial class TrenirovkaForm : Form
{
    private readonly TrenirovkaRepository _repository;
    public TrenirovkaForm(string cs)
    {
        _repository = new TrenirovkaRepository(cs);
        InitializeComponent();
        UiStyler.MakeButtonsMoreVisible(this);
        LoadData();
    }
    private void BtnAdd_Click(object? s, EventArgs e){ _repository.Insert(GetValues()); LoadData(); }
    private void BtnEdit_Click(object? s, EventArgs e){ _repository.Update(GetValues()); LoadData(); }
    private void BtnDelete_Click(object? s, EventArgs e){ _repository.Delete(_txtGroup.Text.Trim()); LoadData(); }
    private void Grid_SelectionChanged(object? s, EventArgs e)=>BindSelected();
    private Dictionary<string, object?> GetValues()=>new(){["N_grupa"]=_txtGroup.Text.Trim(),["datata"]=_date.Value.ToString("yyyy-MM-dd"),["chas"]=_time.Value.ToString("HH:mm"),["N_chlen"]=_txtChlen.Text.Trim(),["N_den"]=_txtDay.Text.Trim()};
    private void LoadData()=>_grid.DataSource=_repository.GetAll();
    private void BindSelected(){ if (_grid.CurrentRow?.DataBoundItem is not DataRowView row) return; _txtGroup.Text=row["N_grupa"]?.ToString()??string.Empty; _txtChlen.Text=row["N_chlen"]?.ToString()??string.Empty; _txtDay.Text=row["N_den"]?.ToString()??string.Empty; if (DateTime.TryParse(row["datata"]?.ToString(), out var d)) _date.Value=d; if (DateTime.TryParse(row["chas"]?.ToString(), out var t)) _time.Value=DateTime.Today.Add(t.TimeOfDay);}    
}
