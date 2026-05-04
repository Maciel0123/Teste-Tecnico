# 🧪 Palindrome API (.NET)

API desenvolvida em .NET para identificar se uma palavra ou frase é um **palíndromo**, utilizando uma arquitetura em camadas baseada em boas práticas como Clean Architecture e princípios SOLID.

---

## 📌 O que é um Palíndromo?

Um palíndromo é uma palavra ou frase que pode ser lida da mesma forma de trás para frente.

**Exemplos:**
- Arara
- Ovo
- Roma me tem amor
- O lobo ama o bolo

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
## 🧠 Regras aplicadas

A validação considera:

- Ignora maiúsculas e minúsculas
- Remove acentos
- Ignora espaços
- Considera apenas letras e números
- Não utiliza métodos prontos como Reverse()
## 🛠️ Tecnologias utilizadas
- .NET 8
- ASP.NET Core Web API
- C#
- Swagger (OpenAPI)
