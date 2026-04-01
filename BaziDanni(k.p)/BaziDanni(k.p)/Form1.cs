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
        UiStyler.MakeButtonsMoreVisible(this);
    }

    private Button CreateOpenButton(string text, Action onClick)
    {
        var button = new Button
        {
            Text = text,
            Width = 240,
            Height = 56,
            Margin = new Padding(10)
        };

        button.Click += (_, _) => onClick();
        return button;
    }
}
