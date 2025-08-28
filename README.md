# 🚗 Estacionafy

Um sistema de gerenciamento de estacionamento desenvolvido em **C# .NET**, criado do zero como parte de um desafio da [DIO](https://dio.me/users/eduardonascto). O projeto simula o controle de entrada e saída de veículos, cálculo de tarifas e monitoramento do rendimento total.

---

## 📖 Descrição

O **Estacionafy** foi projetado para administrar veículos em um estacionamento. Ele permite:

* Registrar a **entrada** de veículos.
* Registrar a **saída** de veículos, calculando automaticamente o valor devido.
* **Listar** os veículos atualmente estacionados.
* **Configurar** e alterar os preços do estacionamento.
* Consultar o **rendimento total** até o momento.

Este projeto foi construído **sem utilizar o código base sugerido no desafio**, aplicando apenas conceitos de lógica de programação, programação orientada a objetos e boas práticas de organização em C#. Assim, além de atender ao desafio, também demonstra autonomia na solução do problema.

---

## ⚙️ Funcionalidades

* **Adicionar veículo**: solicita a placa e armazena na lista de veículos.
* **Remover veículo**: solicita a placa e o número de horas estacionadas, calcula o valor a pagar e atualiza o rendimento total.
* **Listar veículos**: exibe todos os veículos atualmente estacionados.
* **Gerenciar preços**: configuração do valor inicial e do valor por hora.
* **Estatísticas**:

  * Número de veículos que entraram.
  * Número de veículos que saíram.
  * Veículos ainda estacionados.
  * Rendimento total acumulado.

---

## 🛠️ Estrutura do Projeto

* **Program.cs** → fluxo principal, menu de opções e contadores.
* **VehicleManagement.cs** → CRUD dos veículos.
* **PriceManagement.cs** → configuração e visualização de preços.
* **ParkingCostCalculator.cs** → cálculo do valor a ser pago na saída.
* **Pause.cs** → utilitário para controlar a navegação no console.

---

## 🚀 Tecnologias Utilizadas

* Linguagem: **C#**
* Plataforma: **.NET 6+**
* Paradigma: **Programação Orientada a Objetos (POO)**

---

## 📂 Como Executar

1. Clone o repositório:

```bash
 git clone https://github.com/seu-usuario/estacionafy.git
```

2. Acesse a pasta do projeto:

```bash
 cd estacionafy
```

3. Compile e execute:

```bash
 dotnet run
```

---

## 🧩 Exemplo de Uso

```
Seja bem vindo ao Estacionafy!

1 - Cadastrar ENTRADA de veículo
2 - Cadastrar SAÍDA de veículo
3 - Listar veículos estacionados
4 - Verificar os Preços do Estacionamento
5 - Alterar os Preços do Estacionamento
6 - Verificar Rendimento até o Momento
0 - Encerrar Aplicação
```

Exemplo de saída ao remover veículo:

```
Retirada do veículo Registrada!
Placa: ABC-1234 - Valor total: R$35,00
```

---

## 🎯 Objetivos Atingidos

* Colocar em prática conceitos de **Lógica de Programação**.
* Exercitar **POO em C#** (classes, métodos, encapsulamento).
* Utilizar **listas genéricas (List<T>)** para manipular dados.
* Criar um projeto do zero para consolidar aprendizado.
* Publicar no **GitHub** como parte do portfólio.

---

## 📌 Autor

👤 **[Eduardo Nascimento](https://www.instagram.com/eduardohavenox/)**
🔗 [GitHub](https://github.com/Havenox)
💼 [LinkedIn](https://www.linkedin.com/in/havenox)
🎓 [DIO](https://dio.me/users/eduardonascto)

---
## 🙏 Agradecimentos

Agradeço à DIO pela proposta do desafio e ao professor Leonardo Buta, pelas aulas de C# e .NET que inspiraram este aprendizado.

---

## 🏆 Considerações

Este projeto vai além do desafio da DIO, mostrando que é possível aplicar os requisitos solicitados de maneira independente, com estrutura própria e boas práticas. Um ótimo exemplo de **iniciativa, organização e capacidade de solução de problemas**.
