# vaivoaCard
Primeiro projeto em C# para cumprir Teste Técnico da VaiVoa

# Objetivos
1) Desenvolver um backend em C# simulando o cadastro de um cliente 
2) Ao cadastrar o cliente, retornar um numero de cartão de crédito + cod. segurança + validade
3) Criar os endpoints para inclusão e consulta dos dados

# Estrutura do projeto
1) Pasta Controllers = Métodos das consultas e inclusão no banco
2) Pasta Data = Definições do Banco de dados e suas Tabelas (utilizado EntityFrameworkCore.InMemory)
3) Pasta Models = Estrutura dos campos do banco e tipo de dados de cada um + função para gerar os dados do cartão (Numero, codigo de segurança e validade)

# Instruções de Uso
No metodo POST /v1/cards mandar apenas o campo "cardEmail", pois os demais serão gerados automaticamente. 
Exemplo de como enviar os dados:
{
  "cardEmail": "geo@geo.com"
}

Obs.: O campo cardEmail esta sendo validado com o mínimo de 6 caracteres, pois não tem como existir um email menor que isso. Ex.: a@b.uk

# Considerações
1) Apesar de conhecer sobre Lógica de programação, nunca tive nenhum contato com a linguagem C#. Então este projeto foi desenvolvido baseado no material didático fornecido pela Vaivoa e por pesquisas na internet.
2) Em um projeto real o ideal seria uma tabela de clientes e outra de cartões fazendo o relacionamento entre elas, onde cada novo registro na tabela de cartões receberia apenas o código unico (id) do seu respectivo cliente. Por falta de tempo e conhecimento na linguagem este projeto foi feito com apenas uma tabela somente para atender os requisitos solicitados no teste.
