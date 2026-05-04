# 🧪 Palindrome & Fibonacci API (.NET)

API desenvolvida em .NET para:

- ✔ Identificar se uma palavra ou frase é um **palíndromo**
- ✔ Gerar os **N primeiros elementos da sequência de Fibonacci**

Utilizando arquitetura em camadas baseada em boas práticas como Clean Architecture e princípios SOLID.

---

## 📌 O que é um Palíndromo?

Um palíndromo é uma palavra ou frase que pode ser lida da mesma forma de trás para frente.

**Exemplos:**
- Arara
- Ovo
- Roma me tem amor
- O lobo ama o bolo

---

## 📌 O que é a sequência de Fibonacci?

A sequência de Fibonacci é uma série numérica onde cada número é a soma dos dois anteriores.

**Exemplos:**
- X = 3 → 0, 1, 1
- X = 5 → 0, 1, 1, 2, 3
- X = 7 → 0, 1, 1, 2, 3, 5, 8

---

## 🏗️ Arquitetura do Projeto

O projeto foi estruturado em **camadas**, separando responsabilidades:

Api → Bussines → Domain


### 📦 Api (Camada de Apresentação)
Responsável por:
- Expor endpoints HTTP
- Receber requisições
- Retornar respostas

**Não contém regra de negócio**

---

### 📦 Bussines (Camada de Aplicação)
Responsável por:
- Implementar a lógica de negócio
- Definir interfaces (contratos)
- Orquestrar o fluxo da aplicação

---

### 📦 Domain (Camada de Domínio)
Responsável por:
- Regras puras
- Lógica independente de framework
- Normalização de texto (remoção de acentos, espaços, etc)

---

## 🚀 Como executar o projeto

### Pré-requisitos
- .NET 8+

### Rodar a aplicação

```bash
dotnet run --project Api
```
A API estará disponível em:
```
https://localhost:xxxx/swagger
```
## 🔍 Endpoint

✔ Verificar Palíndromo

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

✔ Gerar sequência de Fibonacci
GET /api/fibonacci?count={numero}

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
## 🛠️ Tecnologias utilizadas
- .NET 8
- ASP.NET Core Web API
- C#
- Swagger (OpenAPI)
