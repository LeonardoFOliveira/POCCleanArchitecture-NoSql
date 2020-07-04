# POC Clean Architecture + NoSql
Implementeação de uma poc com o intuito de criar uma arquitetura no modelo "Clean Architecture" para .Net Core 3.1 em conjunto com a utilização de um banco de dados NoSQL, no caso MongoDB.

## Passos para a integração com o banco (MongoDB)
É necessário que se tenha a estrutura para o acesso ao banco, sendo assim, a execução dos passos a seguir que garantem isso.

### Instalação MongoDB

1. Como pré-requisito é necessário a instalação do MongoDB. Para isso, deve-se seguir como é orientado em seu site oficial: https://docs.mongodb.com/manual/tutorial/install-mongodb-on-windows/

### Configuração MongoDB

1. Adicionar o caminho em que foi instalado o MongoDB (Ex: "C:\Program Files\MongoDB\Server\4.2\bin") à variável de ambiente do sistema "Path".

2. Criar um diretório para armazenar os dados (Ex: "C:\Users\leona\Desktop\MongoRepo").

3. Abrir um "cmd" e executar o seguinte comando:
   > mongod --dbpath <data_directory_path>
   Em que <data_directory_path> é o caminho do diretório criado no passo anterior.
   Esse comando fará com que "suba" o MongoDB.

4. Abrir um novo "cmd" e executar o seguinte comando:
   > mongo
   Esse comando fará conexão do banco de dados via terminal.

5. Executar o seguinte comando:
   > use POCCleanArchitecture+NoSql
   Esse comando acessará o database apontado na poc, mas o mais importante, criará o mesmo caso ainda não exista.

6. Executar o seguinte comando:
    > db.createCollection('PDIs')
   Esse comando criará a coleção apontada na poc.
      
