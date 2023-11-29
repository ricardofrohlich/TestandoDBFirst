using System;
using System.Collections.Generic;

namespace TestandoDBFirst;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
