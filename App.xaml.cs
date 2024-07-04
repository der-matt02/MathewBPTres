using MathewBPTres.Repositories;

namespace MathewBPTres
{
    public partial class App : Application
    {
        public static CountriesRepo CountryRepo { get; private set; }
        public App(CountriesRepo repo)
        {
            InitializeComponent();

            MainPage = new AppShell();
            CountryRepo = repo;
        }
    }
}
