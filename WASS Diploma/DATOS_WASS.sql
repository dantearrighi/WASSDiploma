
use WASSTD

insert into Usuarios values
('Dante Arrighi', 'd', 'dantearrighi@gmail.com', 1, 'd'),
('Adrian Molinero', 'a','adigmo@gmail.com',2,'a'),
('Administrador del Sistema', '0DPiKuNIrrVmD8IUCuw1hQxNqZc=', 'dantearrighi@gmail.com',1,'admin')

insert into Grupos values
('Administrador'),
('Usuario')

insert into UsuariosGrupos values (3,1)
(1,1),
(2,1),
(3,1)



insert into Modulos values
('Seguridad'),
('Auditorias'),
('Personas'),
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
('FrmManual','Manual de usuario',6)



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
(1,3,5)

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
('PASAPORTE'),
('LE')

insert into Estados values
('Habilitado'),
('No Habilitado'),
('Baja')


