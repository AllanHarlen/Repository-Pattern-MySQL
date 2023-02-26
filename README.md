Repository Pattern com MySQL
Este projeto é um exemplo de como usar o padrão de repositório com o MySQL em uma aplicação .NET. O padrão de repositório é uma abordagem comum para separar a lógica de acesso aos dados da lógica de negócios da aplicação. O MySQL é um sistema de gerenciamento de banco de dados relacional amplamente utilizado que pode ser usado com o .NET usando o pacote NuGet MySqlConnector.

Pré-requisitos
Visual Studio 2019 ou superior
.NET 6 SDK ou superior
MySQL 8 ou superior
Instalação
Clone este repositório em sua máquina local
Abra o projeto no Visual Studio
Abra o arquivo appsettings.json e configure a conexão com o banco de dados MySQL
Abra o Console do Gerenciador de Pacotes e execute o comando Update-Database para criar o banco de dados e as tabelas
Execute a aplicação usando o Visual Studio
Como usar
A aplicação inclui um exemplo simples de como usar o padrão de repositório com o MySQL. A classe Repository é um exemplo de implementação do padrão de repositório, enquanto as classes Product e Category representam entidades que serão armazenadas no banco de dados.

A classe MySqlConnectionFactory é responsável por criar uma conexão com o banco de dados MySQL usando as configurações definidas no arquivo appsettings.json.

A classe SeedData é usada para preencher o banco de dados com alguns dados de exemplo.

Contribuindo
Contribuições são bem-vindas! Se você tiver alguma sugestão de melhoria ou encontrar algum problema, sinta-se à vontade para abrir uma nova issue ou pull request.

Licença
Este projeto está licenciado sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.
