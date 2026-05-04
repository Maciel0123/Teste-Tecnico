# 🧪 Teste Técnico

API desenvolvida em .NET para:

- ✔ Identificar se uma palavra ou frase é um **palíndromo**
- ✔ Gerar os **N primeiros elementos da sequência de Fibonacci**
- ✔ Normalizar textos “gritados”, reduzindo excesso de `!` e `?`
- ✔ Cadastrar **orçamentos de oficina mecânica**

Utilizando arquitetura em camadas baseada em boas práticas como Clean Architecture e princípios SOLID.

---

## 📌 Funcionalidades

### 🔹 Palíndromo
Verifica se um texto é igual ao seu inverso.

### 🔹 Fibonacci
Gera uma sequência numérica baseada na soma dos dois valores anteriores.

### 🔹 Normalização de Texto
Remove excesso de pontuação de textos “gritados”.

### 🔹 Orçamento
Permite cadastrar um orçamento com múltiplos itens e cálculo automático do total.

---

## 🏗️ Arquitetura do Projeto

O projeto foi estruturado em **camadas**, separando responsabilidades:

├── Api<br/>
├── Bussines<br/>
├── Domain<br/>
├── Models<br/>
└── PalindromeSolution.sln<br/>


### 📦 Api (Apresentação)
- Exposição de endpoints HTTP
- Validação de entrada
- Retorno de respostas (JSON)

---

### 📦 Bussines (Aplicação)
- Regras de negócio
- Serviços
- Orquestração dos fluxos

---

### 📦 Domain (Domínio)
- Regras puras
- Lógicas independentes de framework

---

### 📦 Models (Contratos)
- DTOs de entrada e saída
- Compartilhado entre Api e Bussines
- Evita acoplamento entre camadas

---

## 🚀 Como executar

### Pré-requisitos
- .NET 10+

### Rodar aplicação

```bash
dotnet run --project Api
```
A API estará disponível em:
```
https://localhost:5254/swagger
```
## 🔍 Endpoint

### ✔ Verificar Palíndromo

```
GET /api/palindrome/check?text={texto}
```

📥 Exemplo de requisição

```
/api/palindrome/check?text=Roma me tem amor
```
📤 Resposta
```
{
  "input": "Roma me tem amor",
  "isPalindrome": true
}
```

### ✔ Gerar sequência de Fibonacci
```
GET /api/fibonacci?count={numero}
```
📥 Exemplo:
```
/api/fibonacci?count=7
```
📤 Resposta:
```
{
  "count": 7,
  "sequence": [0, 1, 1, 2, 3, 5, 8]
}
```

### ✔ Normalizar texto gritado
```
GET /api/textnormalizer/normalize?text={texto}
```
📥 Exemplo:
```
/api/textnormalizer/normalize?text=O que???!!!!! Não acredito!!!
```
📤 Resposta:
```
{
  "input": "O que???!!!!! Não acredito!!!",
  "normalized": "O que?! Não acredito!"
}
```

### ✔ Criar Orçamento
```
POST /api/orcamento
```
📥 Exemplo do JSON:
```
{
  "clienteId": 10,
  "veiculoId": 25,
  "itens": [
    {
      "descricao": "Troca de óleo",
      "quantidade": 1,
      "valorUnitario": 120.00
    },
    {
      "descricao": "Filtro de óleo",
      "quantidade": 1,
      "valorUnitario": 45.00
    }
  ]
}
```
📤 Resposta:
```
{
  "clienteId": 10,
  "veiculoId": 25,
  "status": "Aberto",
  "valorTotal": 165.00,
  "dataCriacao": "2026-05-04T12:00:00",
  "itens": [
    {
      "descricao": "Troca de óleo",
      "quantidade": 1,
      "valorUnitario": 120.00,
      "valorTotal": 120.00
    },
    {
      "descricao": "Filtro de óleo",
      "quantidade": 1,
      "valorUnitario": 45.00,
      "valorTotal": 45.00
    }
  ]
}
```

## 🧠 Regras aplicadas

Palíndromo:

- Ignora maiúsculas e minúsculas
- Remove acentos
- Ignora espaços
- Considera apenas letras e números
- Não utiliza métodos prontos como Reverse()

Fibonacci:
- Geração iterativa (melhor performance)
- Complexidade O(n)
- Não utiliza recursão

Texto gritado:
- Reduz sequências repetidas de ? para apenas ?
- Reduz sequências repetidas de ! para apenas !
- Quando houver ? e ! juntos, normaliza para ?!
- Mantém o restante do texto original

Orçamento
- clienteId obrigatório
- veiculoId obrigatório
- Deve possuir pelo menos 1 item
- Item:
  - descrição obrigatória
  - quantidade > 0
  - valorUnitario > 0
- Total calculado automaticamente

## 💡 Diferenciais
- Arquitetura em camadas (baixo acoplamento)
- Separação de responsabilidades
- Código testável e escalável
- Uso de DTOs compartilhados (Models)

## 🛠️ Tecnologias utilizadas
- .NET 10
- ASP.NET Core Web API
- C#
- Swagger (OpenAPI)
