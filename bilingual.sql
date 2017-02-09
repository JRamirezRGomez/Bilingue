-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 30-12-2016 a las 03:54:58
-- Versión del servidor: 10.1.10-MariaDB
-- Versión de PHP: 7.0.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bilingual`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumnos`
--

CREATE TABLE `alumnos` (
  `Nombre` char(25) NOT NULL,
  `Apellido_P` char(25) NOT NULL,
  `Apellido_M` char(25) NOT NULL,
  `ID_Alumnos` int(11) NOT NULL,
  `ID_Salon` int(11) NOT NULL,
  `ID_Docentes` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `alumnos`
--

INSERT INTO `alumnos` (`Nombre`, `Apellido_P`, `Apellido_M`, `ID_Alumnos`, `ID_Salon`, `ID_Docentes`) VALUES
('Jaime Adrian', 'Magaña', 'Vargas', 1, 0, 0),
('Jose Raul', 'Gomez', 'Ramirez', 2, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumnos_preguntas`
--

CREATE TABLE `alumnos_preguntas` (
  `ID_Alumno` char(99) NOT NULL,
  `ID_Salon` char(10) NOT NULL,
  `ID_Docente` char(99) NOT NULL,
  `ID_Preguntas` char(250) NOT NULL,
  `ID_Material` char(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `docentes`
--

CREATE TABLE `docentes` (
  `Nombre` char(35) NOT NULL,
  `Apellido_P` char(35) NOT NULL,
  `Apellido_M` char(35) NOT NULL,
  `Contrasena` char(8) NOT NULL,
  `Correo_Eletronico` varchar(30) NOT NULL,
  `ID_Docentes` int(11) NOT NULL,
  `ID_Salon` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `docentes`
--

INSERT INTO `docentes` (`Nombre`, `Apellido_P`, `Apellido_M`, `Contrasena`, `Correo_Eletronico`, `ID_Docentes`, `ID_Salon`) VALUES
('jaime', 'magaña', 'vargas', '123', 'algo', 1, 0),
('jose raul', 'ramirez', 'gomez', '456', 'otracosa', 2, 0),
('alex', 'max', 'steal', '123', 'quecosa', 3, 0),
('Jose Antonio', 'Lopez', 'Tello', '12345', 'Lt2007@Gmail.com', 4, 0),
('jaime', 'magaña', 'vargas', '123', 'ajaime10@hotmail.com', 5, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `preguntas`
--

CREATE TABLE `preguntas` (
  `Imagen` longblob,
  `Pregunta` char(99) NOT NULL,
  `ID_Preguntas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `salon`
--

CREATE TABLE `salon` (
  `Numero` int(11) NOT NULL,
  `ID_Salon` int(11) NOT NULL,
  `ID_Docentes` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `temas`
--

CREATE TABLE `temas` (
  `ID_Material` char(250) NOT NULL,
  `ID_Docente` char(99) NOT NULL,
  `VerbToBe` char(250) DEFAULT NULL,
  `DoWhile` char(250) DEFAULT NULL,
  `Gramatica` char(99) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `alumnos`
--
ALTER TABLE `alumnos`
  ADD PRIMARY KEY (`ID_Alumnos`),
  ADD KEY `FK_Salon` (`ID_Salon`),
  ADD KEY `FK_Docentes` (`ID_Docentes`);

--
-- Indices de la tabla `alumnos_preguntas`
--
ALTER TABLE `alumnos_preguntas`
  ADD PRIMARY KEY (`ID_Alumno`,`ID_Salon`,`ID_Docente`,`ID_Preguntas`,`ID_Material`);

--
-- Indices de la tabla `docentes`
--
ALTER TABLE `docentes`
  ADD PRIMARY KEY (`ID_Docentes`),
  ADD KEY `FK_Salon` (`ID_Salon`);

--
-- Indices de la tabla `preguntas`
--
ALTER TABLE `preguntas`
  ADD PRIMARY KEY (`ID_Preguntas`);

--
-- Indices de la tabla `salon`
--
ALTER TABLE `salon`
  ADD PRIMARY KEY (`ID_Salon`),
  ADD KEY `FK_Docentes` (`ID_Docentes`);

--
-- Indices de la tabla `temas`
--
ALTER TABLE `temas`
  ADD PRIMARY KEY (`ID_Material`,`ID_Docente`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `alumnos`
--
ALTER TABLE `alumnos`
  MODIFY `ID_Alumnos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `docentes`
--
ALTER TABLE `docentes`
  MODIFY `ID_Docentes` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `preguntas`
--
ALTER TABLE `preguntas`
  MODIFY `ID_Preguntas` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `salon`
--
ALTER TABLE `salon`
  MODIFY `ID_Salon` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
