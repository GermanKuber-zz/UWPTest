using App7.Utiles;

namespace App7.Model
{
    public class BindingModel : BindableBase
    {



        private string _nombre;
        public string Nombre
        {
            get { return this._nombre; }
            set
            {

                SetProperty(ref _nombre, value);
                this._nombre = value;

            }
        }

        private string _apellido;
        public string Apellido
        {
            get { return this._apellido; }
            set
            {

                SetProperty(ref _apellido, value);
                this._apellido = value;

            }
        }

        private int _edad;
        public int Edad
        {
            get { return this._edad; }
            set
            {

                SetProperty(ref _edad, value);
                this._edad = value;

            }
        }
    }
}
