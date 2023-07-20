--codigo para PhpMyAdmin bd 'rtaller'

-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-07-2023 a las 01:37:54
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `rtaller`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `ID_cliente` int(11) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `telefono` varchar(45) NOT NULL,
  `ciudad` varchar(45) NOT NULL,
  `direccion` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`ID_cliente`, `nombre`, `telefono`, `ciudad`, `direccion`) VALUES
(0, 'admin', 'admin', 'Merida', 'torres'),
(1, 'Sofia', '9981167337', 'Cancun', 'ruta 7'),
(2, 'Abraham', '234455', 'Chetumal', 'kabah'),
(3, 'Elisia', '9912235423', 'Cancun', 'Cerrada Mangos'),
(4, 'Pepe', 'wqe234455', 'Cancun', 'Lombardo'),
(5, 'Diego', '993423421', 'Cancun', 'Luna'),
(6, 'Jafet', '1034322344', 'Merida', 'Palenque'),
(7, 'Alberto', '92842321221', 'Merida', 'Uxmal'),
(8, 'Beto F', '325325422', 'Chetumal', 'calle 40'),
(9, 'Maria', '832262682', 'Cancun', 'Av Bonampak'),
(10, 'Moises', '832233222', 'Guanajuato', 'Primaveras');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mantenimiento`
--

CREATE TABLE `mantenimiento` (
  `NoMantenimiento` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `descripcion` varchar(45) NOT NULL,
  `costo` decimal(10,0) NOT NULL,
  `CLIENTE_ID_cliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `mantenimiento`
--

INSERT INTO `mantenimiento` (`NoMantenimiento`, `fecha`, `descripcion`, `costo`, `CLIENTE_ID_cliente`) VALUES
(0, '0000-00-00', 'aceite y filtros', 600, 0),
(1, '0000-00-00', 'Cambio de balatas', 1000, 1),
(2, '0000-00-00', 'Afinacion Mayor y cambio de chasis', 2500, 1),
(3, '0000-00-00', 'Servicio completo', 4500, 2),
(4, '0000-00-00', 'Servicio completo', 4500, 5),
(5, '0000-00-00', 'Servicio y revision de linea de freno', 5500, 5),
(6, '0000-00-00', 'Revision de linea de freno', 1000, 5),
(7, '0000-00-00', 'Mantenimiento', 1000, 8),
(8, '0000-00-00', 'Pulido', 1500, 3),
(9, '0000-00-00', 'Pulido y encerado', 1750, 9);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vehiculo`
--

CREATE TABLE `vehiculo` (
  `matricula` int(11) NOT NULL,
  `modelo` varchar(45) NOT NULL,
  `marca` varchar(45) NOT NULL,
  `CLIENTE_ID_cliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `vehiculo`
--

INSERT INTO `vehiculo` (`matricula`, `modelo`, `marca`, `CLIENTE_ID_cliente`) VALUES
(1, 'A3 ', 'Audi', 1),
(2, 'Urus', 'Lamborghini', 1),
(3, '911', 'Porsche', 1),
(4, 'Jetta', 'Volkswagen', 4),
(1114, 'Loera', 'Volvo', 2),
(2321, 'X3', 'BMW', 3),
(2342, 'Civic', 'Honda', 9),
(3421, 'Fiesta', 'Ford', 7),
(3423, 'X8', 'BMW', 8),
(8326, 'HRV', 'Honda', 9);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`ID_cliente`);

--
-- Indices de la tabla `mantenimiento`
--
ALTER TABLE `mantenimiento`
  ADD PRIMARY KEY (`NoMantenimiento`),
  ADD KEY `fk_MANTENIMIENTO_CLIENTE1` (`CLIENTE_ID_cliente`);

--
-- Indices de la tabla `vehiculo`
--
ALTER TABLE `vehiculo`
  ADD PRIMARY KEY (`matricula`),
  ADD KEY `fk_VEHICULO_CLIENTE1` (`CLIENTE_ID_cliente`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `mantenimiento`
--
ALTER TABLE `mantenimiento`
  ADD CONSTRAINT `fk_MANTENIMIENTO_CLIENTE1` FOREIGN KEY (`CLIENTE_ID_cliente`) REFERENCES `cliente` (`ID_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `vehiculo`
--
ALTER TABLE `vehiculo`
  ADD CONSTRAINT `fk_VEHICULO_CLIENTE1` FOREIGN KEY (`CLIENTE_ID_cliente`) REFERENCES `cliente` (`ID_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
