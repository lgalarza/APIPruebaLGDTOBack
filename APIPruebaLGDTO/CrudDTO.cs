using System.ComponentModel.DataAnnotations;

namespace APIPruebaLGDTO
{
    public class departamentoDTO
    {
        public short codigoDepartamento { get; set; }
        public string nombreDepartamento { get; set; }
    }

    public class cargosDTO
    {
        public short codigoCargo { get; set; }
        public string descripcionCargo { get; set; }
    }

    public class usuariosDTO
    {
        public string? codigoUsuario { get; set; }
        public short codigoDepartamento { get; set; }
        public string? nombreDepartamento { get; set; }
        public short codigoCargo { get; set; }
        public string? descripcionCargo { get; set; }
        public string? nombres { get; set; }
        public string? apellidos { get; set; }
        public string? email { get; set; }
        public bool? estadoUsuario { get; set; }
    }

}