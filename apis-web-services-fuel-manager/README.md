# APIs Web Services Fuel Manager

Este projeto é uma API desenvolvida em ASP.NET 8.0 para a gestão do consumo de combustível. A API permite cadastrar e gerenciar informações de usuários, veículos, postos de gasolina e consumo de combustível, facilitando o acompanhamento de gastos e consumo de combustível para veículos.

## Funcionalidades

- **Gestão de Usuários**: Cadastro e gerenciamento de usuários, incluindo Nome, Email e Código.
- **Gestão de Veículos**: Cadastro e gerenciamento de veículos, com informações de Placa, Ano, Modelo e Fabricante.
- **Gestão de Postos de Gasolina**: Cadastro de postos de gasolina com Nome, Endereço e Preço dos combustíveis.
- **Gestão de Consumo de Combustível**: Registro de consumo com informações da Data, Posto, Tipo de Combustível e Valor.

## Tecnologias Utilizadas

- **ASP.NET 8.0**: Framework utilizado para a construção da API.
- **Entity Framework Core**: ORM utilizado para gerenciar o banco de dados.
- **SQL Server**: Banco de dados para armazenar as informações dos usuários, veículos, postos e consumo de combustível.
- **Swagger**: Ferramenta para documentação automática da API.

## Como Executar o Projeto no Visual Studio 2022

### Pré-requisitos

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) com as workloads:
    - ASP.NET e desenvolvimento web
    - Desenvolvimento com .NET Core
- [SQL Server](https://www.microsoft.com/sql-server)
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Passos para Executar

1. **Clone o repositório**:
    Abra o terminal ou o PowerShell e execute o seguinte comando:
    ```bash
    git clone https://github.com/usuario/apis-web-services-fuel-manager.git
    ```

2. **Abra o projeto no Visual Studio 2022**:
    No Visual Studio, selecione **Abrir um projeto ou solução** e navegue até a pasta do projeto que foi clonado.

3. **Configurar as strings de conexão**:
    Atualize as strings de conexão no arquivo `appsettings.json` conforme o banco de dados que você está utilizando (SQL Server ou PostgreSQL).

4. **Restaurar pacotes NuGet**:
    O Visual Studio automaticamente restaurará os pacotes NuGet necessários quando o projeto for aberto.

5. **Executar as migrações do banco de dados**:
    Abra o **Console do Gerenciador de Pacotes** no Visual Studio e execute o seguinte comando para aplicar as migrações do Entity Framework:
    ```bash
    Update-Database
    ```

6. **Iniciar a aplicação**:
    No Visual Studio, clique em **Executar** ou pressione `F5`. A aplicação será iniciada e a interface Swagger estará disponível para visualizar e testar os endpoints da API.

7. **Acessar a documentação Swagger**:
    Quando o projeto estiver em execução, abra o navegador e acesse o Swagger em:
    ```
    http://localhost:{porta}/swagger
    ```

## Estrutura de Endpoints

### Usuários
- **GET /api/usuarios** - Retorna todos os usuários
- **POST /api/usuarios** - Cadastra um novo usuário
- **PUT /api/usuarios/{id}** - Atualiza os dados de um usuário existente
- **DELETE /api/usuarios/{id}** - Exclui um usuário

### Veículos
- **GET /api/veiculos** - Retorna todos os veículos
- **POST /api/veiculos** - Cadastra um novo veículo
- **PUT /api/veiculos/{id}** - Atualiza os dados de um veículo
- **DELETE /api/veiculos/{id}** - Exclui um veículo

### Postos de Gasolina
- **GET /api/postos** - Retorna todos os postos de gasolina
- **POST /api/postos** - Cadastra um novo posto de gasolina
- **PUT /api/postos/{id}** - Atualiza os dados de um posto
- **DELETE /api/postos/{id}** - Exclui um posto

### Consumo
- **GET /api/consumos** - Retorna todos os consumos de combustível
- **POST /api/consumos** - Registra um novo consumo
- **PUT /api/consumos/{id}** - Atualiza os dados de um consumo
- **DELETE /api/consumos/{id}** - Exclui um consumo


## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
