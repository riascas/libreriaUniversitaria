using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades.Excepciones;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Clase que representa una editorial de libros (proveedor).
    /// </summary>
    public class Editorial
    {
        private int _idEditorial;
        private string _nombre;
        private string _contacto;
        private string _telefono;
        private string _email;

        public int IdEditorial
        {
            get { return _idEditorial; }
            set { _idEditorial = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Contacto
        {
            get { return _contacto; }
            set { _contacto = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public Editorial() { }

        public Editorial(int idEditorial, string nombre, string contacto, string telefono, string email)
        {
            _idEditorial = idEditorial;
            _nombre = nombre;
            _contacto = contacto;
            _telefono = telefono;
            _email = email;
        }

        public override string ToString()
        {
            return Nombre;
        }

        /// <summary>
        /// Valida que los datos obligatorios estén completos y correctos.
        /// </summary>
        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nombre))
                throw new EntidadInvalidaException("El nombre de la editorial no puede estar vacío.");

            // Opcional: validar formato de teléfono o email si es necesario
        }
    }
}
