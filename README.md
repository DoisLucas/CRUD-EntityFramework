# CRUD-EntityFramework

**CRUD:** (Create, Read, Update e Delete) são as quatro operações básicas utilizadas em bases de dados relacionais (RDBMS) ou em interface para utilizadores para criação, consulta, atualização e destruição de dados. 

**EntityFramework:** O Microsoft Entity Framework é uma ferramenta de mapeamento objeto relacional (ORM – Object Relational Management), que permite aos desenvolvedores trabalhar com classes (entidades) que correspondem a tabelas em um banco de dados, tornando transparente o acesso a estes dados e principalmente, eliminando a necessidade de escrever código de banco de dados (SELECT, INSERT, UPDATE, DELETE) na aplicação. Com o Entity Framework os desenvolvedores manipulam os dados através de classes que são mapeadas com as tabelas do banco de dados, sendo assim, o acesso e manipulação destes dados fica mais simples, pois o desenvolvedor já trabalha naturalmente com objetos, propriedades e coleções no seu desenvolvimento.

**Tipos de Mapeamento do Entity Framework:** 

***Model First:*** Ou seja, primeiro você cria o modelo e depois o banco de dados.

***DataBase First:*** Quando você ja possui uma base de dados existente, assim o Entity Framework irá fazer o mapeamento de todas as tabelas do seu banco de dados para o modelo.

***Code First:*** Neste modelo você cria todas as classes no código, sem o designer visual, e depois o banco de dados é criado baseado nas classes.

<p align="center">

<img src="https://i-msdn.sec.s-msft.com/dynimg/IC583491.png" width="30%" height="30%"/>

</p>

<br>

**MODELO LÓGICO DO BANCO GERADO AUTOMATICAMENTE PELO EF:**


<p align="center">

<img src="https://i-msdn.sec.s-msft.com/dynimg/IC583491.png" width="30%" height="30%"/>

</p>
