using BaziDanni_k.p_.Forms.abonament;
using BaziDanni_k.p_.Forms.chlen;
using BaziDanni_k.p_.Forms.den_sedmica;
using BaziDanni_k.p_.Forms.grupa;
using BaziDanni_k.p_.Forms.nivo;
using BaziDanni_k.p_.Forms.sport;
using BaziDanni_k.p_.Forms.trenior;
using BaziDanni_k.p_.Forms.trenirovka;
using BaziDanni_k.p_.Forms.zapisani_abonamenti;

namespace BaziDanni_k.p_;

public partial class Form1 : Form
{
    public const string ConnectionString =
    "User Id=SYSTEM;Password=123456;Data Source=localhost:1521/XE;";

    public Form1()
    {
        InitializeComponent();
        BuildMenu();
    }

    private void BuildMenu()
    {
        Text = "Курсов проект - Управление на таблици";
        Width = 800;
        Height = 500;

        var panel = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(16),
            AutoScroll = true
        };

        panel.Controls.Add(CreateOpenButton("NIVO", () => new NivoForm(ConnectionString).ShowDialog()));
        panel.Controls.Add(CreateOpenButton("DEN_SEDMICA", () => new DenSedmicaForm(ConnectionString).ShowDialog()));
        panel.Controls.Add(CreateOpenButton("ABONAMENT", () => new AbonamentForm(ConnectionString).ShowDialog()));
        panel.Controls.Add(CreateOpenButton("CHLEN", () => new ChlenForm(ConnectionString).ShowDialog()));
        panel.Controls.Add(CreateOpenButton("SPORT", () => new SportForm(ConnectionString).ShowDialog()));
        panel.Controls.Add(CreateOpenButton("TRENIOR", () => new TreniorForm(ConnectionString).ShowDialog()));
        panel.Controls.Add(CreateOpenButton("GRUPA", () => new GrupaForm(ConnectionString).ShowDialog()));
        panel.Controls.Add(CreateOpenButton("TRENIROVKA", () => new TrenirovkaForm(ConnectionString).ShowDialog()));
        panel.Controls.Add(CreateOpenButton("ZAPISANI_ABONAMENTI", () => new ZapisaniAbonamentiForm(ConnectionString).ShowDialog()));

        Controls.Add(panel);
    }

    private static Button CreateOpenButton(string text, Action onClick)
    {
        var button = new Button
        {
            Text = text,
            Width = 220,
            Height = 48,
            Margin = new Padding(8)
        };

        button.Click += (_, _) => onClick();
        return button;
    }
}
