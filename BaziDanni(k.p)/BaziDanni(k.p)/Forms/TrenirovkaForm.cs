using System.Data;
using BaziDanni_k.p_.Infrastructure;
using BaziDanni_k.p_.Repositories.chlen;
using BaziDanni_k.p_.Repositories.den_sedmica;
using BaziDanni_k.p_.Repositories.trenirovka;

namespace BaziDanni_k.p_.Forms;
public sealed partial class TrenirovkaForm : Form
{
    private readonly TrenirovkaRepository _repository;
    private readonly ChlenRepository _chlenRepository;
    private readonly DenSedmicaRepository _denSedmicaRepository;
    public TrenirovkaForm(string cs)
    {
        _repository = new TrenirovkaRepository(cs);
        _chlenRepository = new ChlenRepository(cs);
        _denSedmicaRepository = new DenSedmicaRepository(cs);
        InitializeComponent();
        LoadLookups();
        LoadData();
    }
    private void BtnAdd_Click(object? s, EventArgs e){ _repository.Insert(GetValues()); LoadData(); }
    private void BtnEdit_Click(object? s, EventArgs e){ _repository.Update(GetValues()); LoadData(); }
    private void BtnDelete_Click(object? s, EventArgs e){ _repository.Delete(_txtGroup.Text.Trim()); LoadData(); }
    private void Grid_SelectionChanged(object? s, EventArgs e)=>BindSelected();
    private Dictionary<string, object?> GetValues()=>new(){["N_grupa"]=_txtGroup.Text.Trim(),["datata"]=_date.Value.ToString("yyyy-MM-dd"),["chas"]=_time.Value.ToString("HH:mm"),["N_chlen"]=_cmbChlen.SelectedValue,["N_den"]=_cmbDay.SelectedValue};
    private void LoadLookups()
    {
        _cmbChlen.DataSource = _chlenRepository.GetAll();
        _cmbChlen.DisplayMember = "Ime_chlen";
        _cmbChlen.ValueMember = "N_chlen";

        _cmbDay.DataSource = _denSedmicaRepository.GetAll();
        _cmbDay.DisplayMember = "Den";
        _cmbDay.ValueMember = "N_den";
    }
    private void LoadData()=>_grid.DataSource=_repository.GetAll();
    private void BindSelected(){ if (_grid.CurrentRow?.DataBoundItem is not DataRowView row) return; _txtGroup.Text=row["N_grupa"]?.ToString()??string.Empty; if (row["N_chlen"] != DBNull.Value) _cmbChlen.SelectedValue=row["N_chlen"]; if (row["N_den"] != DBNull.Value) _cmbDay.SelectedValue=row["N_den"]; if (DateTime.TryParse(row["datata"]?.ToString(), out var d)) _date.Value=d; if (DateTime.TryParse(row["chas"]?.ToString(), out var t)) _time.Value=DateTime.Today.Add(t.TimeOfDay);}    
}
