using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL
{
    public class ConfiguracionBLL
    {
        private readonly ConfiguracionDAL _dal = new ConfiguracionDAL();

        /// <summary>Obtiene la configuración actual.</summary>
        public Configuracion ObtenerConfiguracion()
        {
            return _dal.Obtener();
        }

        /// <summary>Guarda la configuración.</summary>
        public void GuardarConfiguracion(Configuracion cfg)
        {
            _dal.Guardar(cfg);
        }
    }
}
