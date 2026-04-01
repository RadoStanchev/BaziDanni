using BaziDanni_k.p_.Forms;
using BaziDanni_k.p_.Infrastructure;

namespace BaziDanni_k.p_;

public partial class Form1 : Form
{
    public const string ConnectionString =
    "User Id=SYSTEM;Password=123456;Data Source=localhost:1521/XE;";

    public Form1()
    {
        InitializeComponent();
        UiStyler.MakeButtonsMoreVisible(this);
    }

    private void BtnNivo_Click(object sender, EventArgs e)
    {
        new NivoForm(ConnectionString).ShowDialog();
    }

    private void BtnDenSedmica_Click(object sender, EventArgs e)
    {
        new DenSedmicaForm(ConnectionString).ShowDialog();
    }

    private void BtnAbonament_Click(object sender, EventArgs e)
    {
        new AbonamentForm(ConnectionString).ShowDialog();
    }

    private void BtnChlen_Click(object sender, EventArgs e)
    {
        new ChlenForm(ConnectionString).ShowDialog();
    }

    private void BtnSport_Click(object sender, EventArgs e)
    {
        new SportForm(ConnectionString).ShowDialog();
    }

    private void BtnTrenior_Click(object sender, EventArgs e)
    {
        new TreniorForm(ConnectionString).ShowDialog();
    }

    private void BtnGrupa_Click(object sender, EventArgs e)
    {
        new GrupaForm(ConnectionString).ShowDialog();
    }

    private void BtnTrenirovka_Click(object sender, EventArgs e)
    {
        new TrenirovkaForm(ConnectionString).ShowDialog();
    }

    private void BtnZapisaniAbonamenti_Click(object sender, EventArgs e)
    {
        new ZapisaniAbonamentiForm(ConnectionString).ShowDialog();
    }
}
