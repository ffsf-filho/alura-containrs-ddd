﻿namespace ContainRs.Api.Domain;

/// <summary>
/// ON - O contêiner está ligado e funcionando normalmente.
/// OFF - O contêiner está desligado.
/// STANDBY - O contêiner está em modo de espera, com consumo reduzido de energia.
/// LOW_POWER - O contêiner está operando em um modo de baixa energia para economizar recursos.
/// FAULT - Há uma falha no sistema de energia do contêiner.
/// CHARGING - O contêiner está conectado a uma fonte de energia e sendo carregado.
/// </summary>
public enum StatusConteiner
{
    ON, 
    OFF,
    STANDBY,
    LOW_POWER,
    FAULT,
    CHARGING
}

/// <summary>
/// Unidade modular utilizada para armazenamento, transporte ou instalações temporárias. 
/// Pode ser adaptado para diferentes finalidades, como escritórios, almoxarifados, 
/// residências, balcões para vendas de serviços e produtos, dentre outras.
/// ID "M:ContainRs.Api.Domain.Conteiner.#ctor".
/// </summary>
public class Conteiner
{
    public Guid Id { get; set; }
    public StatusConteiner Status { get; set; } = StatusConteiner.OFF;
    public string? Observacoes { get; set; }
    public Guid LocacaoId { get; set; }
}