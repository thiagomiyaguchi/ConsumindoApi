# Projeto de Consumo de API em C#

Este projeto em C# obtém informações de endereço a partir de um CEP fornecido pelo usuário. A aplicação utiliza a API de consulta de CEP VIACEP para obter dados detalhados sobre o endereço correspondente.

## Funcionalidades

1. **Consulta de CEP:** O usuário fornece um CEP como entrada, e a aplicação realiza uma requisição à API de consulta de CEP para obter informações detalhadas sobre o endereço correspondente.

2. **Deserialização JSON:** Os dados obtidos da API são serializados em formato JSON, e o projeto utiliza um deserializador para extrair as informações relevantes do endereço.

## Como Utilizar

### Requisitos

- Certifique-se de ter o ambiente de desenvolvimento C# instalado.
- Clone o repositório para o seu ambiente local.

### Compilação e Execução

1. Abra o projeto em sua IDE de preferência.
2. Compile e execute o projeto.
3. A aplicação solicitará que você insira um CEP. Digite o CEP desejado e pressione Enter.

### Visualização dos Resultados

Os dados do endereço associado ao CEP fornecido serão exibidos na tela.

## Estrutura do Projeto

O projeto está estruturado da seguinte forma:

- **Program.cs:** Contém a lógica principal do programa, incluindo a interação com o usuário e a chamada à API.
- **Dados.cs:** Classe responsável por processar os dados retornados.

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues, propor melhorias ou enviar pull requests.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).


