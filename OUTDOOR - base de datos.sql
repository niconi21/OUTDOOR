CREATE DATABASE OUTDOOR;
USE OUTDOOR;

CREATE TABLE Jugador(id_jugador INT PRIMARY KEY IDENTITY(0,1) NOT NULL,
					 usuario VARCHAR(45) NOT NULL,
					 clave VARCHAR(45) NOT NULL,
					 nombre VARCHAR(45) NOT NULL,
					 apepat VARCHAR(45) NOT NULL,
					 apemat VARCHAR(45) NOT NULL);

CREATE TABLE Estadistica(id_estadistica INT PRIMARY KEY IDENTITY(0,1) NOT NULL,
						 id_jugador INT NOT NULL CONSTRAINT fk_idJugador_tiene_estadistica REFERENCES Jugador,
						 disparos INT NOT NULL,
						 segundos INT NOT NULL,
						 puntaje INT NOT NULL,
						 vida INT NOT NULL);


CREATE TABLE EstadoPartida(id_estadoPartida INT PRIMARY KEY IDENTITY(0,1) NOT NULL,
						   id_jugador INT NOT NULL CONSTRAINT fk_idJugador_tiene_EstadoPartida REFERENCES Jugador,
						   posicionObjetivoX INT NOT NULL,
						   posicionObjetivoY INT NOT NULL,
						   posicionJugadorX INT NOT NULL,
						   posicionJugadorY INT NOT NULL,
						   vidaObjetivo INT NOT NULL,
						   vidaJugador INT NOT NULL,
						   disparos INT NOT NULL,
						   segundos INT NOT NULL,
						   puntaje INT NOT NULL,
						   interrumpida INT NOT NULL);
			
