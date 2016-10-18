CREATE TABLE rol (
  idrol INT NOT NULL,
  nombre VARCHAR(45) NOT NULL,
  PRIMARY KEY (idrol))


CREATE TABLE usuario (
  idusuario INT NOT NULL,
  idrol INT NOT NULL,
  nombreusuario VARCHAR(45) NOT NULL,
  contrasena VARCHAR(12) NOT NULL,
  PRIMARY KEY (idusuario),
  CONSTRAINT idrol
    FOREIGN KEY (idrol)
    REFERENCES rol (idrol))


CREATE TABLE cliente (
  idcliente INT NOT NULL,
  nombrecliente VARCHAR(45) NOT NULL,
  PRIMARY KEY (idcliente),
  INDEX idusuario_idx (idusuario ASC),


CREATE TABLE inventario (
  idinventario INT NOT NULL,
  idcliente INT NOT NULL,
  nombreinventario VARCHAR(45) NOT NULL,
  PRIMARY KEY (idinventario),
  CONSTRAINT idcliente
    FOREIGN KEY (idcliente)
    REFERENCES cliente (idcliente))


CREATE TABLE reciboEntrada (
  idreciboentrada INT NOT NULL,
  idinventario INT NOT NULL,
  fecha DATE NOT NULL,
  calidad VARCHAR(45) NOT NULL,
  cantidadsacos INT NOT NULL,
  cliente VARCHAR(25) NOT NULL,
  pesototalsacos FLOAT NULL,
  contrato VARCHAR(45) NULL,
  guia VARCHAR(45) NULL,
  placa VARCHAR(45) NULL,
  ubicacion INT NULL,
  pesotarimasvacias FLOAT NULL,
  pesobruto FLOAT NULL,
  pesoneto FLOAT NOT NULL,
  observaciones VARCHAR(300) NULL,
  PRIMARY KEY (idreciboentrada),
  CONSTRAINT idinventarioentrada
    FOREIGN KEY (idinventario)
    REFERENCES inventario (idinventario))


CREATE TABLE reciboSalida (
  idrecibosalida INT NOT NULL,
  idinventario INT NOT NULL,
  fecha DATE NOT NULL,
  cliente VARCHAR(45) NOT NULL,
  calidad VARCHAR(45) NOT NULL,
  cantidadsacos INT NULL,
  contrato VARCHAR(45) NULL,
  guia VARCHAR(45) NULL,
  placa VARCHAR(45) NULL,
  ubicacion VARCHAR(45) NULL,
  pesotarimasvacias FLOAT NULL,
  pesobruto FLOAT NULL,
  tarasacos FLOAT NULL,
  pesoneto FLOAT NULL,
  tiposaco VARCHAR(45) NULL,
  observaciones VARCHAR(45) NULL,
  PRIMARY KEY (idrecibosalida),
  CONSTRAINT idinventariosalida
    FOREIGN KEY (idinventario)
    REFERENCES inventario (idinventario))

CREATE TABLE ordenTrabajo (
  idordentrabajo INT NOT NULL,
  idinventario INT NOT NULL,
  cliente VARCHAR(45) NOT NULL,
  fecha DATE NOT NULL,
  cantidadsacos INT NULL,
  pesototal FLOAT NULL,
  observaciones VARCHAR(45) NULL,
  PRIMARY KEY (idordentrabajo),
  CONSTRAINT idinventarioorden
    FOREIGN KEY (idinventario)
    REFERENCES inventario (idinventario))

CREATE TABLE ordenOrigen (
  idordenorigen INT NOT NULL,
  tipoelemento VARCHAR(45) NOT NULL,
  idordentrabajo INT NOT NULL,
  calidad VARCHAR(45) NOT NULL,
  cantidadsacos INT NULL,
  pesoneto FLOAT NULL,
  PRIMARY KEY (idordenorigen, tipoelemento),
  CONSTRAINT idordentrabajo
    FOREIGN KEY (idordentrabajo)
    REFERENCES ordenTrabajo (idordentrabajo))


CREATE TABLE ordenResultado (
  idordenresultados INT NOT NULL,
  tipoelemento VARCHAR(45) NOT NULL,
  idordentrabajo INT NOT NULL,
  calidad VARCHAR(45) NOT NULL,
  cantidadsacos INT NULL,
  pesoneto FLOAT NULL,
  PRIMARY KEY (idordenresultados, tipoelemento),
  CONSTRAINT idordentrabajoresultado
    FOREIGN KEY (idordentrabajo)
    REFERENCES ordenTrabajo (idordentrabajo))


CREATE TABLE entradaTarima (
  idtarimaentrada INT NOT NULL,
  idreciboentrada INT NOT NULL,
  preso FLOAT NOT NULL,
  PRIMARY KEY (idtarimaentrada),
  CONSTRAINT idreciboentradatarima
    FOREIGN KEY (idreciboentrada)
    REFERENCES reciboEntrada (idreciboentrada))


CREATE TABLE salidaTarima (
  idtarimaSalida INT NOT NULL,
  idrecibosalida INT NOT NULL,
  peso FLOAT NOT NULL,
  PRIMARY KEY (idtarimaSalida),
  CONSTRAINT idrecibosalidatarima
    FOREIGN KEY (idrecibosalida)
    REFERENCES reciboSalida (idrecibosalida))


CREATE TABLE reciboEntradaSacos (
  idreciboentradasacos INT NOT NULL,
  idreciboentrada INT NOT NULL,
  cantidad INT NOT NULL,
  tipo VARCHAR(45) NOT NULL,
  tara FLOAT NOT NULL,
  PRIMARY KEY (idreciboentradasacos),
  CONSTRAINT idreciboentradasacos
    FOREIGN KEY (idreciboentrada)
    REFERENCES reciboEntrada (idreciboentrada))


CREATE TABLE reciboSalidaSacos (
  idrecibosalidasacos INT NOT NULL,
  idrecibosalida INT NOT NULL,
  cantidad INT NOT NULL,
  tipo VARCHAR(45) NOT NULL,
  tara FLOAT NOT NULL,
  PRIMARY KEY (idrecibosalidasacos),
  CONSTRAINT idrecibosalidasacos
    FOREIGN KEY (idrecibosalida)
    REFERENCES reciboSalida (idrecibosalida))


CREATE TABLE reciboSalidaOrigen (
  idrecibosalidaorigin INT NOT NULL,
  tipoelemento INT NOT NULL,
  idrecibosalida INT NOT NULL,
  calidad VARCHAR(45) NOT NULL,
  cantidadsacos INT NULL,
  pesoneto FLOAT NULL,
  PRIMARY KEY (idrecibosalidaorigin, tipoelemento),
  CONSTRAINT idrecibosalida
    FOREIGN KEY (idrecibosalidaorigin)
    REFERENCES reciboSalida (idrecibosalida))


CREATE TABLE proceso (
  idproceso INT NOT NULL,
  PRIMARY KEY (idproceso))

