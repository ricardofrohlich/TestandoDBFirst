using System;
using System.Collections.Generic;

namespace TestandoDBFirst;

public partial class Pedido
{
    public int Id { get; set; }

    public DateTime? Datapedido { get; set; }

    public decimal? Valor { get; set; }

    public int? IdCliente { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }
}
