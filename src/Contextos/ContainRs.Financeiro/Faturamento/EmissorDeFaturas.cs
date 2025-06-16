using ContainRs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainRs.Financeiro.Faturamento
{
    public class EmissorDeFaturas(IRepository<Fatura> repoFatura, IEventoManager eventoManager)
    {
        private readonly IRepository<Fatura> _repoFatura = repoFatura;
        private readonly IEventoManager _eventoManager = eventoManager;

        public async Task ExecutarAsync()
        {
            var mensagens = await _eventoManager
                .RecuperNaoLidasAsync<PropostaAprovadaFaturamento>("PropostaAprovada", nameof(EmissorDeFaturas));


            foreach (var mensagem in mensagens)
            {
                Fatura fatura = new()
                {
                    Id = Guid.NewGuid(),
                    DataEmissao = DateTime.Now,
                    DataVencimento = DateTime.Now.AddDays(5),
                    Numero = "304823908",
                    Total = mensagem.Corpo.ValorProposta,
                    //LocacaoId = ?? //ACL
                };

                //persistir a fatura
                await _repoFatura.AddAsync(fatura);

                //marcar msg como lida
                await _eventoManager.MarcarComoLidaAsync(mensagem.Id, nameof(EmissorDeFaturas));
            }
        }
    }
}
