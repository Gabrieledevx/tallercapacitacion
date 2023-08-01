using System;
using System.Collections.Generic;

namespace tallercapacitacion.Models;

public partial class Asistencia
{
    public int IdAsistencia { get; set; }

    public int? IdInscripcion { get; set; }

    public DateOnly? FechaAsistencia { get; set; }

    public virtual Inscripcione? IdInscripcionNavigation { get; set; }
}
