using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidades;

public class BitacoraProyecto
{
    [Column("id")]
    public int Id { get; set; }
    [Column("id_proyecto")]
    public Guid IdProyecto { get; set; }
    [Column("id_actividad_proyecto")]
    public Guid IdActividadProyecto { get; set; }
    [Column("fecha")]
    public DateTime Fecha { get; set; }
    [Column("id_usuario")]
    public Guid IdUsuario { get; set; }
    [Column("id_tipo_bitacora")]
    public Guid IdTipoBitacora { get; set; }
    [Column("comentarios")]
    public string Comentarios { get; set; } = "";
    [Column("id_creador")]
    public Guid IdCreador { get; set; }
    [Column("fecha_creacion")]
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    [Column("id_modificador")]
    public Guid IdModificador { get; set; }
    [Column("fecha_modificacion")]
    public DateTime FechaModificacion { get; set; } = DateTime.UtcNow;
    [Column("activo")]
    public bool? Activo { get; set; } = true;

    [JsonIgnore]
    public Proyecto? Proyecto { get; set; }
    [JsonIgnore]
    public ActividadProyecto? ActividadProyecto { get; set; }
    [JsonIgnore]
    public Usuario? Usuario { get; set; }
    [JsonIgnore]
    public TipoBitacora? TipoBitacora { get; set; }
    [JsonIgnore]
    public virtual Usuario? Creador { get; set; }
    [JsonIgnore]
    public virtual Usuario? Modificador { get; set; }
}
