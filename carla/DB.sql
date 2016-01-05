CREATE DATABASE `databasecarla` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `databasecarla`;

CREATE TABLE `carroecambio` (
  `codcec` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nomecarro` varchar(20) DEFAULT NULL,
  `placacarro` varchar(7) DEFAULT NULL,
  `corcarro` varchar(20) DEFAULT NULL,
  `anocarro` varchar(4) DEFAULT NULL,
  `motorcarro` varchar(20) DEFAULT NULL,
  `codclifk` int(11) DEFAULT NULL,
  PRIMARY KEY (`codcec`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `clientes` (
  `codcli` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nomecli` varchar(80) NOT NULL,
  `cpfcli` varchar(11) NOT NULL,
  `tel1cli` varchar(11) NOT NULL,
  `tel2cli` varchar(11) DEFAULT NULL,
  `tel3cli` varchar(11) DEFAULT NULL,
  `tel4cli` varchar(11) DEFAULT NULL,
  `ufcli` varchar(2) NOT NULL,
  `cidadecli` varchar(50) NOT NULL,
  `bairrocli` varchar(40) NOT NULL,
  `tipodelogradourocli` varchar(15) NOT NULL,
  `enderecocli` varchar(50) NOT NULL,
  `numerocli` varchar(6) NOT NULL,
  `complementocli` varchar(20) NOT NULL,
  `cepcli` varchar(8) NOT NULL,
  `emailcli` varchar(50) DEFAULT NULL,
  `datacriacaocli` date NOT NULL,
  PRIMARY KEY (`codcli`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `compraeproduto` (
  `codcompeprod` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `codprodfk` int(11) NOT NULL,
  `codcompfk` int(11) NOT NULL,
  `quantidade` int(11) NOT NULL,
  `desconto` float NOT NULL,
  PRIMARY KEY (`codcompeprod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `compras` (
  `codcomp` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `datacomp` date NOT NULL,
  `fornecedorcomp` varchar(40) NOT NULL,
  `nfcomp` varchar(20) NOT NULL,
  PRIMARY KEY (`codcomp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `orcamentoeos` (
  `codorcamento` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `quilometragem` varchar(15) DEFAULT NULL,
  `dataorcamento` date DEFAULT NULL,
  `aprovacaoorcamento` varchar(5) DEFAULT NULL,
  `dataos` date DEFAULT NULL,
  `previsaodatadeentrega` date DEFAULT NULL,
  PRIMARY KEY (`codorcamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `orcamentoeoseestoque` (
  `codoose` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `codorcamentofk` int(11) NOT NULL,
  `codprodfk` int(11) NOT NULL,
  PRIMARY KEY (`codoose`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


CREATE TABLE `orcamentoeoseestoque` (
  `codoose` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `codorcamentofk` int(11) NOT NULL,
  `codprodfk` int(11) NOT NULL,
  PRIMARY KEY (`codoose`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `produtoestoque` (
  `codprod` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `descricaoprod` varchar(60) DEFAULT NULL,
  `quantidadeestoque` int(11) NOT NULL,
  `valorcompra` float NOT NULL,
  `porcentagemlucro` float NOT NULL,
  `valorvenda` float NOT NULL,
  `ncm` varchar(40) NOT NULL,
  PRIMARY KEY (`codprod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `usuario` (
  `codusuario` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `tipousuario` varchar(20) NOT NULL,
  `nomeusuario` varchar(40) NOT NULL,
  `loginusuario` varchar(25) NOT NULL,
  `senhausuario` varchar(20) NOT NULL,
  `perguntasecreta` varchar(60) NOT NULL,
  `respostasecreta` varchar(60) NOT NULL,
  PRIMARY KEY (`codusuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
