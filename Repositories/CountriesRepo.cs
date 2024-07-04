using SQLite;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathewBPTres.Models;

namespace MathewBPTres.Repositories
{
    public class CountriesRepo
    {
        Pais pais = new Pais();
        public string _dbPath;
        private SQLiteConnection conn;

        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Pais>();
        }

        public CountriesRepo(string dbPath)
        {
            _dbPath = dbPath;
        }

        public List<Pais> DevuelveListadoPaises()
        {
            return conn.Table<Pais>().ToList();
        }

        public void GuardarPaises(Pais paises)
        {
            pais.CodigoPersonal = GenerarCodigoPersonal();
            conn.Insert(paises);
        }

        public async Task<Pais> DevuelvePais()
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync("https://api.chucknorris.io/jokes/random/");
            string response_json = await response.Result.Content.ReadAsStringAsync();

            Pais pais = JsonConvert.DeserializeObject<Pais>(response_json);

            return pais;
        }

        private string GenerarCodigoPersonal()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 2001);
            string initials = "MB";
            return $"{initials}{randomNumber}";
        }
    }
}