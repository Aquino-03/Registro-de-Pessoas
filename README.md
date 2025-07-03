# Registro de Pessoas Físicas e Jurídicas em C#

Este projeto é um sistema de cadastro em C#, feito no console, para registrar, editar, listar e excluir pessoas físicas (com CPF) e jurídicas (com CNPJ). O objetivo é praticar conceitos de programação orientada a objetos (POO), validação de dados e organização de código.

## 🎯 Funcionalidades implementadas
✅ Cadastro de pessoas físicas e jurídicas  
✅ Validação de CPF (11 dígitos) e CNPJ (14 dígitos)  
✅ Menu interativo com loop para múltiplas operações  
✅ Listagem separada de pessoas físicas e jurídicas  
✅ Edição de registros existentes (busca por CPF/CNPJ)  
✅ Exclusão de registros (busca por CPF/CNPJ)  
✅ Uso de listas dinâmicas (`List<T>`) em vez de arrays fixos  
✅ Classes separadas para pessoa física e jurídica  
✅ Override de métodos com `virtual` e `override`

## 🛠️ Habilidades demonstradas
- **POO (Programação Orientada a Objetos)**  
  - Criação de classes base e derivadas
  - Herança entre `people` e `Pjuridica`
  - Polimorfismo com `exibirDados()`
- **Tratamento de dados e validação**  
  - Verificação do tamanho de CPF e CNPJ
  - Mensagens de erro personalizadas
- **Fluxo de controle com menu interativo**  
  - Uso de `switch-case` para gerenciar operações
  - Loop principal para manter o programa rodando
- **Coleções genéricas**  
  - Uso de `List<people>` e `List<Pjuridica>` para armazenar dados dinamicamente
- **Separação de responsabilidades**  
  - Código dividido em múltiplos arquivos: `Program.cs`, `Pessoa.cs` e `PessoaJuridica.cs`
- **Tratamento de exceções**  
  - `try-catch` para validar entradas numéricas

## 📂 Estrutura do projeto
Projeto
├── Program.cs
├── Pessoa.cs
└── PessoaJuridica.cs

## 🚀 Como executar
1. Abra o projeto em uma IDE como Visual Studio ou VS Code.
2. Compile e execute `Program.cs`.
3. Use o menu interativo para cadastrar, listar, editar ou excluir registros.
