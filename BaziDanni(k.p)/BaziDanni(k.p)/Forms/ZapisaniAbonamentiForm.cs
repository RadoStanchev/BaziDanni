using System.Data;
using BaziDanni_k.p_.Infrastructure;
using BaziDanni_k.p_.Repositories.abonament;
using BaziDanni_k.p_.Repositories.chlen;
using BaziDanni_k.p_.Repositories.grupa;
using BaziDanni_k.p_.Repositories.zapisani_abonamenti;

namespace BaziDanni_k.p_.Forms;
public sealed partial class ZapisaniAbonamentiForm : Form
{
    private readonly ZapisaniAbonamentiRepository _repository;
    private readonly ChlenRepository _chlenRepository;
    private readonly GrupaRepository _grupaRepository;
    private readonly AbonamentRepository _abonamentRepository;
    public ZapisaniAbonamentiForm(string cs)
    {
        _repository = new ZapisaniAbonamentiRepository(cs);
        _chlenRepository = new ChlenRepository(cs);
        _grupaRepository = new GrupaRepository(cs);
        _abonamentRepository = new AbonamentRepository(cs);
        InitializeComponent();
        LoadLookups();
        LoadData();
    }
    private void AddItem_Click(object? s, EventArgs e){ _repository.Insert(GetValues()); LoadData(); }
    private void EditItem_Click(object? s, EventArgs e){ _repository.Update(GetValues()); LoadData(); }
    private void DeleteItem_Click(object? s, EventArgs e){ _repository.Delete(_cmbChlen.SelectedValue?.ToString() ?? string.Empty); LoadData(); }
    private void Grid_SelectionChanged(object? s, EventArgs e)=>BindSelected();
    private Dictionary<string, object?> GetValues()=>new(){["N_chlen"]=_cmbChlen.SelectedValue,["N_grupa"]=_cmbGroup.SelectedValue,["N_abonament"]=_cmbAbonament.SelectedValue,["Data_zapis"]=_date.Value.ToString("yyyy-MM-dd")};
    private void LoadLookups()
    {
        _cmbChlen.DataSource = _chlenRepository.GetAll();
        _cmbChlen.DisplayMember = "Ime_chlen";
        _cmbChlen.ValueMember = "N_chlen";

        _cmbGroup.DataSource = _grupaRepository.GetAll();
        _cmbGroup.DisplayMember = "N_grupa";
        _cmbGroup.ValueMember = "N_grupa";

        _cmbAbonament.DataSource = _abonamentRepository.GetAll();
        _cmbAbonament.DisplayMember = "N_abonament";
        _cmbAbonament.ValueMember = "N_abonament";
    }
    private void LoadData()=>_grid.DataSource=_repository.GetAll();
    private void BindSelected(){ if (_grid.CurrentRow?.DataBoundItem is not DataRowView row) return; if (row["N_chlen"] != DBNull.Value) _cmbChlen.SelectedValue=row["N_chlen"]; if (row["N_grupa"] != DBNull.Value) _cmbGroup.SelectedValue=row["N_grupa"]; if (row["N_abonament"] != DBNull.Value) _cmbAbonament.SelectedValue=row["N_abonament"]; if (DateTime.TryParse(row["Data_zapis"]?.ToString(), out var d)) _date.Value=d; }
}
