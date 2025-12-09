namespace WP.Asaas.Sdk.Models.Webhook.Enums;

/// <summary>
/// Eventos disponíveis para webhooks do Asaas
/// </summary>
public enum WebhookEvent
{
    // ========== PAYMENT EVENTS ==========
    
    /// <summary>
    /// Pagamento autorizado (pré-autorização de cartão de crédito)
    /// </summary>
    PAYMENT_AUTHORIZED,
    
    /// <summary>
    /// Aguardando aprovação de risco para receber antecipação
    /// </summary>
    PAYMENT_AWAITING_RISK_ANALYSIS,
    
    /// <summary>
    /// Pagamento aprovado pela análise de risco
    /// </summary>
    PAYMENT_APPROVED_BY_RISK_ANALYSIS,
    
    /// <summary>
    /// Pagamento reprovado pela análise de risco
    /// </summary>
    PAYMENT_REPROVED_BY_RISK_ANALYSIS,
    
    /// <summary>
    /// Geração de nova cobrança
    /// </summary>
    PAYMENT_CREATED,
    
    /// <summary>
    /// Alteração no vencimento ou valor de cobrança existente
    /// </summary>
    PAYMENT_UPDATED,
    
    /// <summary>
    /// Cobrança confirmada (pagamento creditado na conta)
    /// </summary>
    PAYMENT_CONFIRMED,
    
    /// <summary>
    /// Cobrança recebida (saldo já disponível para uso)
    /// </summary>
    PAYMENT_RECEIVED,
    
    /// <summary>
    /// Pagamento antecipado
    /// </summary>
    PAYMENT_ANTICIPATED,
    
    /// <summary>
    /// Cobrança vencida
    /// </summary>
    PAYMENT_OVERDUE,
    
    /// <summary>
    /// Cobrança removida
    /// </summary>
    PAYMENT_DELETED,
    
    /// <summary>
    /// Cobrança restaurada
    /// </summary>
    PAYMENT_RESTORED,
    
    /// <summary>
    /// Cobrança estornada
    /// </summary>
    PAYMENT_REFUNDED,
    
    /// <summary>
    /// Estorno em processamento
    /// </summary>
    PAYMENT_REFUND_IN_PROGRESS,
    
    /// <summary>
    /// Estorno negado
    /// </summary>
    PAYMENT_REFUND_DENIED,
    
    /// <summary>
    /// Recebimento em dinheiro de cobrança foi desfeito
    /// </summary>
    PAYMENT_RECEIVED_IN_CASH_UNDONE,
    
    /// <summary>
    /// Chargeback recebido
    /// </summary>
    PAYMENT_CHARGEBACK_REQUESTED,
    
    /// <summary>
    /// Disputa de chargeback
    /// </summary>
    PAYMENT_CHARGEBACK_DISPUTE,
    
    /// <summary>
    /// Aguardando reversão de chargeback
    /// </summary>
    PAYMENT_AWAITING_CHARGEBACK_REVERSAL,
    
    /// <summary>
    /// Recebimento de negativação em cartório
    /// </summary>
    PAYMENT_DUNNING_RECEIVED,
    
    /// <summary>
    /// Negativação em cartório solicitada
    /// </summary>
    PAYMENT_DUNNING_REQUESTED,
    
    /// <summary>
    /// Boleto visualizado pelo cliente
    /// </summary>
    PAYMENT_BANK_SLIP_VIEWED,
    
    /// <summary>
    /// Checkout visualizado pelo cliente
    /// </summary>
    PAYMENT_CHECKOUT_VIEWED,
    
    /// <summary>
    /// Captura de cartão de crédito recusada
    /// </summary>
    PAYMENT_CREDIT_CARD_CAPTURE_REFUSED,
    
    /// <summary>
    /// Pagamento parcialmente estornado
    /// </summary>
    PAYMENT_PARTIALLY_REFUNDED,
    
    /// <summary>
    /// Split de pagamento cancelado
    /// </summary>
    PAYMENT_SPLIT_CANCELLED,
    
    /// <summary>
    /// Divergência no split bloqueada
    /// </summary>
    PAYMENT_SPLIT_DIVERGENCE_BLOCK,
    
    /// <summary>
    /// Bloqueio de divergência do split finalizado
    /// </summary>
    PAYMENT_SPLIT_DIVERGENCE_BLOCK_FINISHED,
    
    // ========== INVOICE EVENTS ==========
    
    /// <summary>
    /// Nota fiscal criada
    /// </summary>
    INVOICE_CREATED,
    
    /// <summary>
    /// Nota fiscal atualizada
    /// </summary>
    INVOICE_UPDATED,
    
    /// <summary>
    /// Nota fiscal sincronizada
    /// </summary>
    INVOICE_SYNCHRONIZED,
    
    /// <summary>
    /// Nota fiscal autorizada
    /// </summary>
    INVOICE_AUTHORIZED,
    
    /// <summary>
    /// Nota fiscal em processamento de cancelamento
    /// </summary>
    INVOICE_PROCESSING_CANCELLATION,
    
    /// <summary>
    /// Nota fiscal cancelada
    /// </summary>
    INVOICE_CANCELED,
    
    /// <summary>
    /// Cancelamento de nota fiscal negado
    /// </summary>
    INVOICE_CANCELLATION_DENIED,
    
    /// <summary>
    /// Erro ao processar nota fiscal
    /// </summary>
    INVOICE_ERROR,
    
    // ========== TRANSFER EVENTS ==========
    
    /// <summary>
    /// Transferência criada
    /// </summary>
    TRANSFER_CREATED,
    
    /// <summary>
    /// Transferência pendente/agendada
    /// </summary>
    TRANSFER_PENDING,
    
    /// <summary>
    /// Transferência em processamento bancário
    /// </summary>
    TRANSFER_IN_BANK_PROCESSING,
    
    /// <summary>
    /// Transferência bloqueada
    /// </summary>
    TRANSFER_BLOCKED,
    
    /// <summary>
    /// Transferência concluída
    /// </summary>
    TRANSFER_DONE,
    
    /// <summary>
    /// Transferência falhou
    /// </summary>
    TRANSFER_FAILED,
    
    /// <summary>
    /// Transferência cancelada
    /// </summary>
    TRANSFER_CANCELLED,
    
    // ========== BILL EVENTS ==========
    
    /// <summary>
    /// Conta criada
    /// </summary>
    BILL_CREATED,
    
    /// <summary>
    /// Conta pendente
    /// </summary>
    BILL_PENDING,
    
    /// <summary>
    /// Conta em processamento bancário
    /// </summary>
    BILL_BANK_PROCESSING,
    
    /// <summary>
    /// Conta paga
    /// </summary>
    BILL_PAID,
    
    /// <summary>
    /// Conta cancelada
    /// </summary>
    BILL_CANCELLED,
    
    /// <summary>
    /// Falha no pagamento de conta
    /// </summary>
    BILL_FAILED,
    
    /// <summary>
    /// Conta estornada
    /// </summary>
    BILL_REFUNDED,
    
    // ========== RECEIVABLE ANTICIPATION EVENTS ==========
    
    /// <summary>
    /// Antecipação cancelada
    /// </summary>
    RECEIVABLE_ANTICIPATION_CANCELLED,
    
    /// <summary>
    /// Antecipação agendada
    /// </summary>
    RECEIVABLE_ANTICIPATION_SCHEDULED,
    
    /// <summary>
    /// Antecipação pendente
    /// </summary>
    RECEIVABLE_ANTICIPATION_PENDING,
    
    /// <summary>
    /// Antecipação creditada
    /// </summary>
    RECEIVABLE_ANTICIPATION_CREDITED,
    
    /// <summary>
    /// Antecipação debitada
    /// </summary>
    RECEIVABLE_ANTICIPATION_DEBITED,
    
    /// <summary>
    /// Antecipação negada
    /// </summary>
    RECEIVABLE_ANTICIPATION_DENIED,
    
    /// <summary>
    /// Antecipação vencida
    /// </summary>
    RECEIVABLE_ANTICIPATION_OVERDUE,
    
    // ========== MOBILE PHONE RECHARGE EVENTS ==========
    
    /// <summary>
    /// Recarga de celular pendente
    /// </summary>
    MOBILE_PHONE_RECHARGE_PENDING,
    
    /// <summary>
    /// Recarga de celular cancelada
    /// </summary>
    MOBILE_PHONE_RECHARGE_CANCELLED,
    
    /// <summary>
    /// Recarga de celular confirmada
    /// </summary>
    MOBILE_PHONE_RECHARGE_CONFIRMED,
    
    /// <summary>
    /// Recarga de celular estornada
    /// </summary>
    MOBILE_PHONE_RECHARGE_REFUNDED,
    
    // ========== ACCOUNT STATUS EVENTS ==========
    
    /// <summary>
    /// Informações bancárias aprovadas
    /// </summary>
    ACCOUNT_STATUS_BANK_ACCOUNT_INFO_APPROVED,
    
    /// <summary>
    /// Informações bancárias aguardando aprovação
    /// </summary>
    ACCOUNT_STATUS_BANK_ACCOUNT_INFO_AWAITING_APPROVAL,
    
    /// <summary>
    /// Informações bancárias pendentes
    /// </summary>
    ACCOUNT_STATUS_BANK_ACCOUNT_INFO_PENDING,
    
    /// <summary>
    /// Informações bancárias rejeitadas
    /// </summary>
    ACCOUNT_STATUS_BANK_ACCOUNT_INFO_REJECTED,
    
    /// <summary>
    /// Informações comerciais aprovadas
    /// </summary>
    ACCOUNT_STATUS_COMMERCIAL_INFO_APPROVED,
    
    /// <summary>
    /// Informações comerciais aguardando aprovação
    /// </summary>
    ACCOUNT_STATUS_COMMERCIAL_INFO_AWAITING_APPROVAL,
    
    /// <summary>
    /// Informações comerciais expiradas
    /// </summary>
    ACCOUNT_STATUS_COMMERCIAL_INFO_EXPIRED,
    
    /// <summary>
    /// Informações comerciais expirando em breve
    /// </summary>
    ACCOUNT_STATUS_COMMERCIAL_INFO_EXPIRING_SOON,
    
    /// <summary>
    /// Informações comerciais pendentes
    /// </summary>
    ACCOUNT_STATUS_COMMERCIAL_INFO_PENDING,
    
    /// <summary>
    /// Informações comerciais rejeitadas
    /// </summary>
    ACCOUNT_STATUS_COMMERCIAL_INFO_REJECTED,
    
    /// <summary>
    /// Documento aprovado
    /// </summary>
    ACCOUNT_STATUS_DOCUMENT_APPROVED,
    
    /// <summary>
    /// Documento aguardando aprovação
    /// </summary>
    ACCOUNT_STATUS_DOCUMENT_AWAITING_APPROVAL,
    
    /// <summary>
    /// Documento pendente
    /// </summary>
    ACCOUNT_STATUS_DOCUMENT_PENDING,
    
    /// <summary>
    /// Documento rejeitado
    /// </summary>
    ACCOUNT_STATUS_DOCUMENT_REJECTED,
    
    /// <summary>
    /// Aprovação geral aprovada
    /// </summary>
    ACCOUNT_STATUS_GENERAL_APPROVAL_APPROVED,
    
    /// <summary>
    /// Aprovação geral aguardando aprovação
    /// </summary>
    ACCOUNT_STATUS_GENERAL_APPROVAL_AWAITING_APPROVAL,
    
    /// <summary>
    /// Aprovação geral pendente
    /// </summary>
    ACCOUNT_STATUS_GENERAL_APPROVAL_PENDING,
    
    /// <summary>
    /// Aprovação geral rejeitada
    /// </summary>
    ACCOUNT_STATUS_GENERAL_APPROVAL_REJECTED,
    
    // ========== SUBSCRIPTION EVENTS ==========
    
    /// <summary>
    /// Assinatura criada
    /// </summary>
    SUBSCRIPTION_CREATED,
    
    /// <summary>
    /// Assinatura atualizada
    /// </summary>
    SUBSCRIPTION_UPDATED,
    
    /// <summary>
    /// Assinatura inativada
    /// </summary>
    SUBSCRIPTION_INACTIVATED,
    
    /// <summary>
    /// Assinatura deletada
    /// </summary>
    SUBSCRIPTION_DELETED,
    
    /// <summary>
    /// Split de assinatura desabilitado
    /// </summary>
    SUBSCRIPTION_SPLIT_DISABLED,
    
    /// <summary>
    /// Divergência no split de assinatura bloqueada
    /// </summary>
    SUBSCRIPTION_SPLIT_DIVERGENCE_BLOCK,
    
    /// <summary>
    /// Bloqueio de divergência do split de assinatura finalizado
    /// </summary>
    SUBSCRIPTION_SPLIT_DIVERGENCE_BLOCK_FINISHED,
    
    // ========== CHECKOUT EVENTS ==========
    
    /// <summary>
    /// Checkout criado
    /// </summary>
    CHECKOUT_CREATED,
    
    /// <summary>
    /// Checkout cancelado
    /// </summary>
    CHECKOUT_CANCELED,
    
    /// <summary>
    /// Checkout expirado
    /// </summary>
    CHECKOUT_EXPIRED,
    
    /// <summary>
    /// Checkout pago
    /// </summary>
    CHECKOUT_PAID,
    
    // ========== BALANCE EVENTS ==========
    
    /// <summary>
    /// Valor do saldo bloqueado
    /// </summary>
    BALANCE_VALUE_BLOCKED,
    
    /// <summary>
    /// Valor do saldo desbloqueado
    /// </summary>
    BALANCE_VALUE_UNBLOCKED,
    
    // ========== INTERNAL TRANSFER EVENTS ==========
    
    /// <summary>
    /// Transferência interna - crédito
    /// </summary>
    INTERNAL_TRANSFER_CREDIT,
    
    /// <summary>
    /// Transferência interna - débito
    /// </summary>
    INTERNAL_TRANSFER_DEBIT,
    
    // ========== ACCESS TOKEN EVENTS ==========
    
    /// <summary>
    /// Token de acesso criado
    /// </summary>
    ACCESS_TOKEN_CREATED,
    
    /// <summary>
    /// Token de acesso deletado
    /// </summary>
    ACCESS_TOKEN_DELETED,
    
    /// <summary>
    /// Token de acesso desabilitado
    /// </summary>
    ACCESS_TOKEN_DISABLED,
    
    /// <summary>
    /// Token de acesso habilitado
    /// </summary>
    ACCESS_TOKEN_ENABLED,
    
    /// <summary>
    /// Token de acesso expirado
    /// </summary>
    ACCESS_TOKEN_EXPIRED,
    
    /// <summary>
    /// Token de acesso expirando em breve
    /// </summary>
    ACCESS_TOKEN_EXPIRING_SOON
}



