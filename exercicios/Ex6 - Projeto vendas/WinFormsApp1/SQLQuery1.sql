CREATE TABLE Fornecedores (
  id_fornecedor INTEGER  NOT NULL   IDENTITY ,
  nome VARCHAR(50)  NOT NULL  ,
  cnpj VARCHAR(18)  NOT NULL  ,
  rua VARCHAR(50)    ,
  numero VARCHAR(5)    ,
  telefone VARCHAR(10)  NOT NULL    ,
PRIMARY KEY(id_fornecedor));





CREATE TABLE Marca (
  id_marca INTEGER  NOT NULL   IDENTITY ,
  nome VARCHAR(50)  NOT NULL  ,
  descricao VARCHAR(100)      ,
PRIMARY KEY(id_marca));





CREATE TABLE Cliente (
  id_cliente INTEGER  NOT NULL  ,
  nome VARCHAR(50)  NOT NULL  ,
  cpf VARCHAR(14)    ,
  cep VARCHAR(9)  NOT NULL  ,
  rua VARCHAR(50)    ,
  numero_casa VARCHAR(5)  NOT NULL  ,
  cidade VARCHAR(30)    ,
  uf VARCHAR(2)  NOT NULL  ,
  telefone VARCHAR(10)  NOT NULL  ,
  dt_nascimento DATE  NOT NULL    ,
PRIMARY KEY(id_cliente));





CREATE TABLE Estado (
  id_uf INTEGER  NOT NULL   IDENTITY ,
  sigla VARCHAR(2)      ,
PRIMARY KEY(id_uf));





CREATE TABLE Vendas (
  id_venda INTEGER  NOT NULL   IDENTITY ,
  quantidade INTEGER    ,
  valor_total DECIMAL(7,2)    ,
  tipo_pagamento VARCHAR(20)    ,
  data_venda DATE    ,
  Cliente_id_cliente INTEGER  NOT NULL    ,
PRIMARY KEY(id_venda)  ,
  FOREIGN KEY(Cliente_id_cliente)
    REFERENCES Cliente(id_cliente));



CREATE INDEX Vendas_FKIndex1 ON Vendas (Cliente_id_cliente);



CREATE INDEX IFK_Rel_01 ON Vendas (Cliente_id_cliente);



CREATE TABLE Produto (
  id_produto INTEGER  NOT NULL   IDENTITY ,
  Fornecedores_id_fornecedor INTEGER  NOT NULL  ,
  Marca_id_marca INTEGER  NOT NULL  ,
  nome VARCHAR(50)  NOT NULL  ,
  quantidade INTEGER  NOT NULL  ,
  valor_unitario DECIMAL(7,2)  NOT NULL  ,
  descricao VARCHAR(200)      ,
PRIMARY KEY(id_produto)    ,
  FOREIGN KEY(Marca_id_marca)
    REFERENCES Marca(id_marca),
  FOREIGN KEY(Fornecedores_id_fornecedor)
    REFERENCES Fornecedores(id_fornecedor));



CREATE INDEX Produto_FKIndex1 ON Produto (Marca_id_marca);

CREATE INDEX Produto_FKIndex2 ON Produto (Fornecedores_id_fornecedor);



CREATE INDEX IFK_Rel_02 ON Produto (Marca_id_marca);

CREATE INDEX IFK_Rel_09 ON Produto (Fornecedores_id_fornecedor);



CREATE TABLE ItensVendas (
  id_itens_vendas INTEGER  NOT NULL   IDENTITY ,
  quantidade INTEGER    ,
  Vendas_id_venda INTEGER  NOT NULL  ,
  Produto_id_produto INTEGER  NOT NULL    ,
PRIMARY KEY(id_itens_vendas)    ,
  FOREIGN KEY(Produto_id_produto)
    REFERENCES Produto(id_produto),
  FOREIGN KEY(Vendas_id_venda)
    REFERENCES Vendas(id_venda));



CREATE INDEX ItensVendas_FKIndex1 ON ItensVendas (Produto_id_produto);

CREATE INDEX ItensVendas_FKIndex2 ON ItensVendas (Vendas_id_venda);



CREATE INDEX IFK_Rel_05 ON ItensVendas (Produto_id_produto);

CREATE INDEX IFK_Rel_10 ON ItensVendas (Vendas_id_venda);




