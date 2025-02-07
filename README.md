# Order Service (Faturamento) - Em desenvolvimento
Este microserviço gerencia o processamento de pedidos, integração com o estoque e comunicação via RabbitMQ.
##
## 🚀 Tecnologias Utilizadas
.NET 8 <br>
RabbitMQ <br>
MySQL <br>
Entity Framework Core <br>
Docker<br>
##
## 📌 Funcionalidades
Criar Pedido: Recebe pedidos via API e publica mensagens no RabbitMQ.<br>
Validar Estoque: Consulta o Microserviço de Produtos para verificar a disponibilidade.<br>
Atualizar Estoque: Envia uma solicitação ao Microserviço de Produtos para reduzir a quantidade disponível.<br>
Confirmar Pedido: Atualiza o status do pedido e armazena no histórico.<br>
Histórico de Pedidos: Permite consultar pedidos já processados.<br>
