# 📅 CadastroEventos

Aplicativo mobile desenvolvido com **.NET MAUI e C#**, com o objetivo de cadastrar eventos e apresentar um resumo das informações, incluindo o cálculo automático da duração e do custo total.

## 🎯 Objetivo do Projeto

Desenvolver um aplicativo para facilitar o cadastro e o gerenciamento das informações básicas de eventos, permitindo visualizar os dados cadastrados e calcular automaticamente o custo total com base no número de participantes.

## 🚀 Funcionalidades

### 1. Cadastro de Eventos
- Nome do evento;
- Data de início;
- Data de término;
- Número de participantes;
- Local do evento;
- Custo por participante.

### 2. Resumo do Evento
- Exibição dos dados cadastrados;
- Cálculo automático da duração do evento em dias;
- Cálculo automático do custo total.

## 🧮 Cálculos do Sistema

**Duração do evento:**

A duração é calculada considerando a data inicial e a data final, incluindo os dois dias.

**Custo total:**

Custo total = Número de participantes × Custo por participante.

Exemplo:

- Participantes: 20
- Custo por participante: R$ 50,00
- Custo total: R$ 1.000,00

## 🛠️ Tecnologias Utilizadas

- C#
- .NET MAUI
- .NET 10
- XAML
- Visual Studio 2026
- BindingContext
- INotifyPropertyChanged

## 📂 Estrutura do Projeto

```text
CadastroEventos/
│
├── Models/
│   └── Evento.cs
│
├── ViewModels/
│   └── EventoViewModel.cs
│
├── Views/
│   ├── CadastroEventoPage.xaml
│   ├── CadastroEventoPage.xaml.cs
│   ├── ResumoEventoPage.xaml
│   └── ResumoEventoPage.xaml.cs
│
├── App.xaml
├── App.xaml.cs
├── MauiProgram.cs
└── README.md
```

## ▶️ Como Executar o Projeto

1. Faça o download ou clone este repositório.
2. Abra o projeto no Visual Studio 2026.
3. Certifique-se de possuir o .NET 10 SDK e as ferramentas de desenvolvimento .NET MAUI instaladas.
4. Abra a solução `CadastroEventos.sln`.
5. Aguarde a restauração dos pacotes.
6. Selecione o dispositivo ou emulador desejado.
7. Clique em Executar.

## 📱 Telas do Aplicativo

O aplicativo possui duas telas principais:

- **Cadastro de Eventos:** formulário para inserir as informações do evento.
- **Resumo do Evento:** apresentação dos dados cadastrados e dos cálculos realizados.

## 📚 Aprendizados

Durante o desenvolvimento deste projeto, são trabalhados conceitos como:

- Programação orientada a objetos;
- Criação de interfaces com XAML;
- Data Binding;
- BindingContext;
- Organização de Models, ViewModels e Views;
- Navegação entre páginas;
- Manipulação de datas;
- Operações matemáticas e cálculos automáticos.

## 👩‍💻 Desenvolvido por

Gabriella Rodrigues

Projeto acadêmico desenvolvido utilizando C# e .NET MAUI.
