using System;
using System.Collections.Generic;

namespace tallercapacitacion.Models;

public partial class Tallere
{
    public int IdTaller { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateOnly? Fecha { get; set; }

    public virtual ICollection<Inscripcione> Inscripciones { get; set; } = new List<Inscripcione>();
}
