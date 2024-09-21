# APIs Web Services Fuel Manager

Este projeto � uma API desenvolvida em ASP.NET 8.0 para a gest�o do consumo de combust�vel. A API permite cadastrar e gerenciar informa��es de usu�rios, ve�culos, postos de gasolina e consumo de combust�vel, facilitando o acompanhamento de gastos e consumo de combust�vel para ve�culos.

## Funcionalidades

- **Gest�o de Usu�rios**: Cadastro e gerenciamento de usu�rios, incluindo Nome, Email e C�digo.
- **Gest�o de Ve�culos**: Cadastro e gerenciamento de ve�culos, com informa��es de Placa, Ano, Modelo e Fabricante.
- **Gest�o de Postos de Gasolina**: Cadastro de postos de gasolina com Nome, Endere�o e Pre�o dos combust�veis.
- **Gest�o de Consumo de Combust�vel**: Registro de consumo com informa��es da Data, Posto, Tipo de Combust�vel e Valor.

## Tecnologias Utilizadas

- **ASP.NET 8.0**: Framework utilizado para a constru��o da API.
- **Entity Framework Core**: ORM utilizado para gerenciar o banco de dados.
- **SQL Server**: Banco de dados para armazenar as informa��es dos usu�rios, ve�culos, postos e consumo de combust�vel.
- **Swagger**: Ferramenta para documenta��o autom�tica da API.

## Como Executar o Projeto no Visual Studio 2022

### Pr�-requisitos

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) com as workloads:
    - ASP.NET e desenvolvimento web
    - Desenvolvimento com .NET Core
- [SQL Server](https://www.microsoft.com/sql-server)
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Passos para Executar

1. **Clone o reposit�rio**:
    Abra o terminal ou o PowerShell e execute o seguinte comando:
    ```bash
    git clone https://github.com/usuario/apis-web-services-fuel-manager.git
    ```

2. **Abra o projeto no Visual Studio 2022**:
    No Visual Studio, selecione **Abrir um projeto ou solu��o** e navegue at� a pasta do projeto que foi clonado.

3. **Configurar as strings de conex�o**:
    Atualize as strings de conex�o no arquivo `appsettings.json` conforme o banco de dados que voc� est� utilizando (SQL Server ou PostgreSQL).

4. **Restaurar pacotes NuGet**:
    O Visual Studio automaticamente restaurar� os pacotes NuGet necess�rios quando o projeto for aberto.

5. **Executar as migra��es do banco de dados**:
    Abra o **Console do Gerenciador de Pacotes** no Visual Studio e execute o seguinte comando para aplicar as migra��es do Entity Framework:
    ```bash
    Update-Database
    ```

6. **Iniciar a aplica��o**:
    No Visual Studio, clique em **Executar** ou pressione `F5`. A aplica��o ser� iniciada e a interface Swagger estar� dispon�vel para visualizar e testar os endpoints da API.

7. **Acessar a documenta��o Swagger**:
    Quando o projeto estiver em execu��o, abra o navegador e acesse o Swagger em:
    ```
    http://localhost:{porta}/swagger
    ```

## Estrutura de Endpoints

### Usu�rios
- **GET /api/usuarios** - Retorna todos os usu�rios
- **POST /api/usuarios** - Cadastra um novo usu�rio
- **PUT /api/usuarios/{id}** - Atualiza os dados de um usu�rio existente
- **DELETE /api/usuarios/{id}** - Exclui um usu�rio

### Ve�culos
- **GET /api/veiculos** - Retorna todos os ve�culos
- **POST /api/veiculos** - Cadastra um novo ve�culo
- **PUT /api/veiculos/{id}** - Atualiza os dados de um ve�culo
- **DELETE /api/veiculos/{id}** - Exclui um ve�culo

### Postos de Gasolina
- **GET /api/postos** - Retorna todos os postos de gasolina
- **POST /api/postos** - Cadastra um novo posto de gasolina
- **PUT /api/postos/{id}** - Atualiza os dados de um posto
- **DELETE /api/postos/{id}** - Exclui um posto

### Consumo
- **GET /api/consumos** - Retorna todos os consumos de combust�vel
- **POST /api/consumos** - Registra um novo consumo
- **PUT /api/consumos/{id}** - Atualiza os dados de um consumo
- **DELETE /api/consumos/{id}** - Exclui um consumo


## Licen�a

Este projeto est� licenciado sob a [MIT License](LICENSE).
