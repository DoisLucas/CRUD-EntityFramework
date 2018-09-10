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

**TABELAS SQL:**

```SQL
CREATE TABLE public.tab_categoria
(
  cod_categoria SERIAL NOT NULL,
  desc_categoria character varying(150) NOT NULL,
  CONSTRAINT tab_categoria_pkey PRIMARY KEY (cod_categoria),
  CONSTRAINT tab_categoria_desc_categoria_key UNIQUE (desc_categoria)
)
```
```SQL
CREATE TABLE public.tab_diretor
(
  cod_diretor SERIAL NOT NULL,
  nome_diretor character varying(250) NOT NULL,
  CONSTRAINT tab_diretor_pkey PRIMARY KEY (cod_diretor)
)
```

```SQL
CREATE TABLE public.tab_filme
(
  cod_filme SERIAL NOT NULL,
  nome_filme character varying(250) NOT NULL,
  data_filme date NOT NULL,
  cod_categoria integer NOT NULL,
  CONSTRAINT tab_filme_pkey PRIMARY KEY (cod_filme),
  CONSTRAINT tab_filme_cod_categoria_fkey FOREIGN KEY (cod_categoria)
      REFERENCES public.tab_categoria (cod_categoria) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
```

```SQL
CREATE TABLE public.tab_filme_diretor
(
  cod_filme integer NOT NULL,
  cod_diretor integer NOT NULL,
  CONSTRAINT tab_filme_diretor_pkey PRIMARY KEY (cod_filme, cod_diretor),
  CONSTRAINT tab_filme_diretor_cod_diretor_fkey FOREIGN KEY (cod_diretor)
      REFERENCES public.tab_diretor (cod_diretor) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT tab_filme_diretor_cod_filme_fkey FOREIGN KEY (cod_filme)
      REFERENCES public.tab_filme (cod_filme) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
```

**MODELO LÓGICO:**

<p align="center">

<img src="https://github.com/DoisLucas/CRUD-ADO.NET/blob/master/resources/modelo.PNG?raw=true" width="150%" height="150%"/>

</p>
