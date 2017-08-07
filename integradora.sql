-- --------------------------------------------------------
-- Host:                         localhost
-- Versión del servidor:         5.6.35 - MySQL Community Server (GPL)
-- SO del servidor:              Win32
-- HeidiSQL Versión:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para integradora
CREATE DATABASE IF NOT EXISTS `integradora` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `integradora`;

-- Volcando estructura para tabla integradora.productos
CREATE TABLE IF NOT EXISTS `productos` (
  `Cod_Bar` bigint(20) unsigned NOT NULL COMMENT 'codigo de barras',
  `Nombre` varchar(30) NOT NULL COMMENT 'nombre articulo',
  `Precio` float unsigned NOT NULL COMMENT 'precio',
  `Descripcion` varchar(250) DEFAULT NULL COMMENT 'desc articulos',
  `Imagen` varchar(1000) DEFAULT 'C:\\Users\\monta\\OneDrive\\Documentos\\Visual Studio 2017\\Projects\\Punto_Venta\\ControlInventarioUniversidad\\imagenes\\noima.png' COMMENT 'url de imagen',
  UNIQUE KEY `Index 1` (`Cod_Bar`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla integradora.productos: ~10 rows (aproximadamente)
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
REPLACE INTO `productos` (`Cod_Bar`, `Nombre`, `Precio`, `Descripcion`, `Imagen`) VALUES
	(1010, 'QuitaSed', 10.5, 'la quita?', 'C:\\Users\\monta\\OneDrive\\Documentos\\Visual Studio 2017\\Projects\\Punto_Venta\\ControlInventarioUniversidad\\imagenes\\cuadernoazul.jpg'),
	(7506129430344, 'Cuaderno scribe azul 100 hojas', 15.5, 'cuaderno azul', 'C:\\Users\\monta\\OneDrive\\Documentos\\Visual Studio 2017\\Projects\\Punto_Venta\\ControlInventarioUniversidad\\imagenes\\cuadernoazul.jpg'),
	(7506129430345, 'Cuaderno scribe amarillo 100 h', 15, 'cuaderno amarillo', 'C:\\Users\\monta\\OneDrive\\Documentos\\Visual Studio 2017\\Projects\\Punto_Venta\\ControlInventarioUniversidad\\imagenes\\cuadernoamarillo.jpg'),
	(7506129430346, 'Cuaderno scribe rojo 100 hojas', 20, 'cuaderno rojo', 'C:\\Users\\monta\\OneDrive\\Documentos\\Visual Studio 2017\\Projects\\Punto_Venta\\ControlInventarioUniversidad\\imagenes\\cuadernorojo.jpg'),
	(7506129430347, 'Cuaderno scribe verde 100 hoja', 25, 'cuaderno verde', 'C:\\Users\\monta\\OneDrive\\Documentos\\Visual Studio 2017\\Projects\\Punto_Venta\\ControlInventarioUniversidad\\imagenes\\cuadernoverde.jpg'),
	(7506129430348, 'six-pack Modelo Especial', 30, 'six modelo', 'C:\\Users\\monta\\OneDrive\\Documentos\\Visual Studio 2017\\Projects\\Punto_Venta\\ControlInventarioUniversidad\\imagenes\\sixmodeloesp.jpeg'),
	(7506129430349, 'Six-Pack Noche Buena', 5, 'six noche buena', 'C:\\Users\\monta\\OneDrive\\Documentos\\Visual Studio 2017\\Projects\\Punto_Venta\\ControlInventarioUniversidad\\imagenes\\nochebuena.jpg'),
	(7506129430350, '1 KG Frijol Pinto', 6, 'frijol pinto', 'C:\\Users\\monta\\OneDrive\\Documentos\\Visual Studio 2017\\Projects\\Punto_Venta\\ControlInventarioUniversidad\\imagenes\\frijol.jpg'),
	(7506129430351, '1 KG Arroz Valle Verde', 5, 'arroz blanco', 'C:\\Users\\monta\\OneDrive\\Documentos\\Visual Studio 2017\\Projects\\Punto_Venta\\ControlInventarioUniversidad\\imagenes\\arrozverde.jpg'),
	(7506129430352, '1 KG Frijol Bayo El Paisano', 6, 'frijon bayo', 'C:\\Users\\monta\\OneDrive\\Documentos\\Visual Studio 2017\\Projects\\Punto_Venta\\ControlInventarioUniversidad\\imagenes\\cuadernoazul.jpg');
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;

-- Volcando estructura para tabla integradora.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `tipo_usuario` tinyint(3) unsigned NOT NULL,
  `id_usuario` varchar(50) NOT NULL,
  `pass_usuario` varchar(50) NOT NULL,
  `NOMBRE_USUARIO` varchar(50) NOT NULL,
  `AP_USUARIO` varchar(50) NOT NULL,
  `AM_USUARIO` varchar(50) DEFAULT ' ',
  `MAIL_USUARIO` varchar(50) NOT NULL,
  `FOTO_USUARIO` varchar(1000) NOT NULL DEFAULT 'C:\\Users\\monta\\OneDrive\\Documentos\\Visual Studio 2017\\Projects\\Punto_Venta\\ControlInventarioUniversidad\\imagenes\\noima.png'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla integradora.usuarios: ~6 rows (aproximadamente)
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
REPLACE INTO `usuarios` (`tipo_usuario`, `id_usuario`, `pass_usuario`, `NOMBRE_USUARIO`, `AP_USUARIO`, `AM_USUARIO`, `MAIL_USUARIO`, `FOTO_USUARIO`) VALUES
	(0, 'admin', 'admin', 'Edwin', 'Elias', 'Alvarez', 'admin@sontechs.com', 'C:\\Users\\monta\\OneDrive\\Documentos\\Visual Studio 2017\\Projects\\Punto_Venta\\ControlInventarioUniversidad\\imagenes\\cuadernoazul.jpg'),
	(1, 'cajero', 'cajero', 'Federico', 'Gutierrez', 'Prieto', 'fede@fede.xom', 'C:\\Users\\monta\\OneDrive\\Documentos\\Visual Studio 2017\\Projects\\Punto_Venta\\ControlInventarioUniversidad\\imagenes\\cuadernoazul.jpg'),
	(0, 'benito', 'camelo12', 'Beny', 'Camelo', 'Camelo', 'donbeny@gob.mx', 'C:\\Users\\monta\\OneDrive\\Documentos\\Visual Studio 2017\\Projects\\Punto_Venta\\ControlInventarioUniversidad\\imagenes\\cuadernorojo.jpg'),
	(0, 'pepa', 'lepig12', 'pepa', 'lepig', 'lepig', 'lepig@puerca.com', 'C:\\Users\\monta\\OneDrive\\Documentos\\IMG_20170124_170759.jpg'),
	(1, 'leon', 'leon', 'aaaaa', 'bbbbb', 'bbbbb', 'a@a.com', 'C:\\\\\\\\Users\\\\\\\\monta\\\\\\\\OneDrive\\\\\\\\Documentos\\\\\\\\Visual Studio 2017\\\\\\\\Projects\\\\\\\\Punto_Venta\\\\\\\\ControlInventarioUniversidad\\\\\\\\imagenes\\\\\\\\noima.png'),
	(1, 'lopez', 'rolando', 'lopez dias', 'lola', 'lola', 'loco@barrio.house', 'C:\\Users\\monta\\OneDrive\\Documentos\\Visual Studio 2017\\Projects\\Punto_Venta\\ControlInventarioUniversidad\\imagenes\\noima.png');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;

-- Volcando estructura para tabla integradora.ventas
CREATE TABLE IF NOT EXISTS `ventas` (
  `id_venta` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `fecha_venta` date NOT NULL,
  `hora_venta` time NOT NULL,
  KEY `Índice 1` (`id_venta`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla integradora.ventas: ~17 rows (aproximadamente)
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
REPLACE INTO `ventas` (`id_venta`, `fecha_venta`, `hora_venta`) VALUES
	(1, '2017-07-14', '18:53:46'),
	(2, '2017-08-02', '14:44:27'),
	(3, '2017-08-02', '14:44:54'),
	(4, '2017-08-02', '14:45:00'),
	(5, '2017-08-04', '15:48:24'),
	(6, '2017-08-04', '15:49:21'),
	(7, '2017-08-04', '17:05:09'),
	(8, '2017-08-04', '17:31:30'),
	(9, '2017-08-04', '17:41:16'),
	(10, '2017-08-04', '17:41:45'),
	(11, '2017-08-04', '18:19:27'),
	(12, '2017-08-04', '18:19:50'),
	(13, '2017-08-04', '18:20:04'),
	(14, '2017-08-04', '19:02:06'),
	(15, '2017-08-04', '19:02:25'),
	(16, '2017-08-04', '19:03:38'),
	(17, '2017-08-04', '19:19:07'),
	(18, '2017-08-04', '19:27:34');
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;

-- Volcando estructura para tabla integradora.venta_detalle
CREATE TABLE IF NOT EXISTS `venta_detalle` (
  `id_venta` int(10) unsigned NOT NULL,
  `producto` varchar(50) NOT NULL,
  `total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla integradora.venta_detalle: ~27 rows (aproximadamente)
/*!40000 ALTER TABLE `venta_detalle` DISABLE KEYS */;
REPLACE INTO `venta_detalle` (`id_venta`, `producto`, `total`) VALUES
	(6, 'QuitaSed', 10000),
	(7, 'Cuaderno scribe amarillo 100 h', 15),
	(7, 'Six-Pack Noche Buena', 5),
	(7, '1 KG Frijol Pinto', 6),
	(7, '1 KG Arroz Valle Verde', 5),
	(8, 'QuitaSed', 11),
	(8, 'QuitaSed', 11),
	(8, 'QuitaSed', 11),
	(9, 'QuitaSed', 11),
	(10, 'QuitaSed', 11),
	(10, 'QuitaSed', 63),
	(10, 'QuitaSed', 63),
	(11, 'QuitaSed', 11),
	(12, 'QuitaSed', 11),
	(12, 'QuitaSed', 11),
	(13, 'QuitaSed', 11),
	(14, 'QuitaSed', 11),
	(14, 'QuitaSed', 11),
	(15, 'QuitaSed', 11),
	(15, 'QuitaSed', 21),
	(16, 'QuitaSed', 11),
	(16, 'QuitaSed', 21),
	(17, 'QuitaSed', 11),
	(17, 'QuitaSed', 105),
	(17, 'Cuaderno scribe rojo 100 hojas', 20),
	(17, 'Cuaderno scribe azul 100 hojas', 16),
	(18, 'Six-Pack Noche Buena', 5),
	(18, '1 KG Frijol Pinto', 6),
	(18, '1 KG Arroz Valle Verde', 5),
	(18, 'QuitaSed', 11),
	(18, 'Six-Pack Noche Buena', 50);
/*!40000 ALTER TABLE `venta_detalle` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
