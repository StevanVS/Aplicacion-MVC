using System;
using System.Collections.Generic;

namespace Aplicacion_MVC.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public int IdCategoria { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool Estado { get; set; }

    public virtual Categoria IdCategoriaNavigation { get; set; } = null!;
}
