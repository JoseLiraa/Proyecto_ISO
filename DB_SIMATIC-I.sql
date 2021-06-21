Create Database SIMATIC
Go
Use SIMATIC
Go
Create Table Usuarios
(
NombreUsuario Varchar(100) Primary Key not null,
ClaveUsuario Varchar(100) not null,
Pregunta Varchar(300) not null,
Respuesta Varchar(300) not null,
Correo Varchar(100),
Telefono Varchar(9) not null
Constraint consTelUsuario Check (Telefono Like '[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]')
)

Create Table Roles
(
IDRol Varchar(10) Primary Key,
NombreRol Varchar(50) not null
)
Insert Into Roles Values('Admin', 'Administrador'),
						('Empl', 'Empleado')

Create Table UsuarioRoles
(
IDUsuario Varchar(100) Foreign Key
References Usuarios(NombreUsuario) On Update Cascade On Delete Cascade,
IDRol Varchar(10) Foreign Key
References Roles(IDRol) On Update Cascade On Delete Cascade
)

Create Table Proveedores
(
CodigoProveedor Varchar(30) Primary Key not null,
NombreProveedor Varchar(100) not null,
Telefono Varchar(9) not null
Constraint consTelProveedores Check (Telefono Like '[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'),
Direccion Varchar(500),
Correo Varchar(100)
)
Create Table Productos
(
CodigoProducto Varchar(30) Primary Key not null,
NombreProducto Varchar(100) not null,
Descripcion Varchar(500),
Existencia Int not null,
PrecioCosto SmallMoney not null,
PrecioVenta SmallMoney not null,
)
insert into Productos values('uno','Nombre','Descrip',2,20,40)
select * from Productos
Create Table ProveedoresProductos
(
CodigoProveedor Varchar(30) Foreign Key 
References Proveedores(CodigoProveedor) On Update Cascade On Delete Cascade,
CodigoProductos Varchar(30) Foreign Key
References Productos(CodigoProducto) On Update Cascade On Delete Cascade,
Cantidad Int not null
)

Create Table Clientes
(
NRC Varchar(50) Primary Key,
NombreCliente Varchar(100)not null ,
NIT Varchar(50) not null,
Direccion Varchar(500),
Giro Varchar(50) not null
)

Create Table EncabezadoFactura
(
NumFactura Varchar(30) Primary Key,
NRC Varchar(50) Foreign Key
References Clientes(NRC) On Update Cascade,
FechaVenta	Date,
SubTotal SmallMoney,
Descuento SmallMoney,
Iva	SmallMoney,
Total SmallMoney,
NombreUsuario Varchar(100) Foreign Key
References Usuarios(NombreUsuario) On Update Cascade 
)

create table DetalleFacturaVenta
(
NumFactura Varchar(30) Foreign Key
References EncabezadoFactura(NumFactura),
CodigoProducto Varchar(30) Foreign Key
References Productos(CodigoProducto),
CantidadVenta Int,
Precio Smallmoney,
Costo SmallMoney,
Descuento SmallMoney,
Iva SmallMoney,
Total SmallMoney
)


select * from Clientes;