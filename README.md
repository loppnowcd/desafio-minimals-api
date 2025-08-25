Exercício do Bootcamp GFT Start #7 da plataforma dio.me.

Essa é uma etapa de Desenvolvimento de APIs, onde desenvolvemos uma API para gerenciamento de veículos.
Feito em conjunto com o professor, desenvolvemos um código está bem estruturado e segue o padrão DDD (Domain-Driven Design), que separa a aplicação em camadas:

-> DTOs (Data Transfer Objects): Classes simples usadas para transferir dados entre a API e o cliente. Ajudam a controlar quais informações são expostas.
-> Dominio/Entidades (Domain/Entities): Representam os objetos do mundo real (ex: Administrador, Veiculo). Eles contêm as propriedades e validações de negócio.
-> Dominio/Interfaces (Domain/Interfaces): Define os contratos (o que os serviços devem fazer), como IAdministradorServico e IVeiculoServico. Isso ajuda a desacoplar o código.
-> Dominio/Servicos (Domain/Services): A camada de lógica de negócio. É aqui que as operações de CRUD (criar, ler, atualizar, deletar) são implementadas, interagindo com o banco de dados.
-> Infraestrutura/Db (Infrastructure/Db): Contém o DbContexto, que é a classe do Entity Framework responsável por gerenciar a conexão com o banco de dados e as entidades.
-> Migrations: Arquivos que gerenciam a criação e atualização do banco de dados.
-> Startup: A classe que configura toda a aplicação, incluindo a injeção de dependências, o CORS (Cross-Origin Resource Sharing) e a autenticação/autorização JWT (JSON Web Token).
-> Program.cs: O ponto de entrada da aplicação, que executa o Startup.

Ao final, ficamos incumbidos de melhorar o que fosse possível.
Eu imaginei que a principal melhoria obvia seria criptografar as senhas cadastradas.

Além disso, após pesquisar um pouco na internet, percebi que seria uma boa ideia tambem:
-> tratamento de erro global
-> paginação completa

Essas foram as minhas melhorias propostas.
