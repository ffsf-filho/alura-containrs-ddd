using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainRs.Vendas.Propostas;

public class ComentarProposta(Guid idPedido, Guid idProposta, string mensagem, string pessoa)
{
    public Guid IdPedido { get; } = idPedido;
    public Guid IdProposta { get; } = idProposta;
    public string Mensagem { get; } = mensagem;
    public string Pessoa { get; } = pessoa;
}