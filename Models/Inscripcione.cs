using System;
using System.Collections.Generic;

namespace tallercapacitacion.Models;

public partial class Inscripcione
{
    public int IdInscripcion { get; set; }

    public int? IdParticipante { get; set; }

    public int? IdTaller { get; set; }

    public DateOnly? FechaInscripcion { get; set; }

    public virtual ICollection<Asistencia> Asistencia { get; set; } = new List<Asistencia>();

    public virtual Participante? IdParticipanteNavigation { get; set; }

    public virtual Tallere? IdTallerNavigation { get; set; }
}
