using MathewBPTres.Models;
using MathewBPTres.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MathewBPTres.ViewModels
{
    public class PaisViewModel : INotifyPropertyChanged
    {
        private Pais _model;
        public Pais Model
        {
            get => _model;
            set
            {
                if (_model != value)
                {
                    _model = value;
                }
            }
        }
        public ICommand ComandoObtenerListado { get; }

        public ICommand ComandoMuestraPersonaje { get; }

        //Constructor
        public PaisViewModel()
        {
            Model = new Pais();

            ComandoObtenerListado = new Command(async () => await ObtenerListado());
            // ComandoMuestraPersonaje = new Command(async () => await ObtenerChiste());
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        public async Task ObtenerListado()
        {
            CountriesRepo repo = new CountriesRepo("Countries.db");
            Pais pais = await repo.DevuelveListadoPaises();
            repo.GuardarPaises(pais);
            Model.Name = pais.Name;
            OnPropertyChanged(nameof(Model));
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}