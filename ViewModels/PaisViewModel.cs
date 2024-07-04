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
        public ICommand ComandoActualizarPais { get; }
        public ICommand ComandoEliminarPais { get; }

        //Constructor
        public PaisViewModel()
        {
            Model = new Pais();

            ComandoObtenerListado = new Command(async () => await ObtenerListado());
            ComandoActualizarPais = new Command(async () => await ActualizarPais());
            ComandoEliminarPais = new Command<string>(codigoPersonal => EliminarPais(codigoPersonal));

            ObtenerListado().ConfigureAwait(false);
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        public async Task ObtenerListado()
        {
            CountriesRepo repo = new CountriesRepo("CT.BD");
            OnPropertyChanged(nameof(Countries));
        }

        public async Task ActualizarPais()
        {
            repo.UpdateCountry(Model);
            await ObtenerListado();
        }

        public void EliminarPais(string codigoPersonal)
        {
            repo.DeleteCountry(codigoPersonal);
            ObtenerListado().ConfigureAwait(false);
        }



        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}