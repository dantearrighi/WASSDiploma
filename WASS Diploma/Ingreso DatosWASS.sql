drop database WASSTD

create database WASSTD

use WASSTD

insert into Usuarios values
('Pablo Gil', 'p', 'gil.a.pablo@gmail.com', 1, 'p'),
('Jorge Lopez', 'x','jogelopez@gmail.com',2,'x'),
('Federico Aguirre', 'f','aguirre.federico.alejandro@gmail.com',1,'f')

insert into Grupos values
('Administrador'),
('Usuario')

insert into UsuariosGrupos values
(1,1),
(2,1),
(2,2)

insert into Modulos values
('Seguridad'),
('Auditorias'),
('Personas'),
('Contabilidad'),
('Tramites'),
('Estadísticas'),
('Ayuda')

insert into Permisos values
('Alta'),
('Baja'),
('Modifica'),
('Consulta')

insert into Formularios values
('FrmPerfiles','Gestion de Perfiles',1),
('FrmGrupos', 'Gestion de Grupos',1),
('FrmUsuarios','Gestion de Usuarios',1),
('FrmAuditorias','Gestion de Auditorías',2),
('FrmPersonas','Gestion de Personas',3),
('FrmCuotas', 'Gestion de Cuotas',4),
('FrmRecibos', 'Gestion de Recibos',4),
('FrmManual','Manual de usuario',7)



insert into Perfiles values
(1,1,1),
(1,2,1),
(1,3,1),
(1,4,1),
(1,1,2),
(1,2,2),
(1,3,2),
(1,4,2),
(1,1,3),
(1,1,4),
(1,1,5),
(1,1,6),
(1,2,5),
(1,2,6),
(1,3,6),
(1,3,5),
(1,1,7),
(1,1,8)

insert into Provincias values
('Santa Fe'),
('Buenos Aires'),
('Cordoba'),
('Corrientes'),
('Entre Rios'),
('Santa Fe'),
('Catamarca'),
('Chaco'),
('Chubut'),
('Formosa'),
('Jujuy'),
('La Pampa'),
('La Rioja'),
('Mendoza'),
('Misiones'),
('Neuquen'),
('Rio Negro'),
('Salta'),
('San Juan'),
('San Luis'),
('Santa Cruz'),
('Santiago del Estero'),
('Tucuman'),
('Tierra del Fuego')

insert into Localidades values
('Rosario',2000,1),
('Aaron Castellanos',6106,1),
('Acebal',2109,1),
('Albarellos',2101,1),
('Alvear',2126,1),
('Arteaga',2187,1),
('Andino',2214,1),
('Casilda',2170,1),
('Abasto',1903,2),
('Abel',6450,2),
('Acevedo',2717,2),
('Acassuso',1640,2),
('Barrio el Once',1884,2),
('Berutti',6424,2),
('Bolivar',6550,2),
('Boulogne',1609,2),
('Burzaco',1852,2),
('Adrogue',1846,2)

insert into Tipos_Documentos values
('DNI'),
('LC'),
('PASAPORTE')

insert into Estados values
('Habilitado'),
('No Habilitado'),
('Baja')





insert into Alteradores values
(0.005,10,120)

insert into Tipos_Movimientos values
('Deudor'),
('Acreedor')

insert into CtasCtes values
(0,01868923),
(0,02254345),
(0,03354657),
(0,04354657),
(0,05897675),
(0,06832890),
(0,07821356),
(0,08821311),
(0,09822312),
(0,10321313),
(0,11821314),
(0,12821315),
(0,13821316),
(0,14821317),
(0,15821318)



ALTER TABLE Personas ALTER COLUMN fecha_nacimiento DATETIME2  

ALTER TABLE Movimientos ALTER COLUMN fecha DATETIME2


--DELETE FROM Comprobantes_Boleta
--DELETE FROM Comprobantes_Factura
--DELETE FROM Cuotas_Anual
--DELETE FROM Cuotas_Bimensual
--DELETE FROM Cuotas
--DELETE FROM Movimientos
--DELETE FROM Comprobantes

--DELETE FROM Liquidaciones

--DELETE FROM Auditorias_Cuotas
--DELETE FROM Videos
