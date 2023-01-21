using System;
using System.Collections.Generic;

namespace Aplicacion_MVC.Models;

public partial class Categoria
{
    public int IdCategoria { get; set; }

    public string Nombre { get; set; } = null!;

    public string Identificador { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();
}
