using System;
using System.Collections.Generic;

namespace MvcNotasEstudiante.Models
{
    public partial class Nota
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string? Carnet { get; set; }
        public string? ApellidosYNombres { get; set; }
        public int? IP { get; set; }
        public int? IiP { get; set; }
        public int? Sist { get; set; }
        public int? Proy { get; set; }
        public int? NF { get; set; }
    }
}
