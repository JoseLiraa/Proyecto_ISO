SELECT        dbo.Roles.NombreRol AS 'Roles', dbo.Usuarios.NombreUsuario, dbo.Usuarios.ClaveUsuario, dbo.Usuarios.Pregunta, dbo.Usuarios.Respuesta, dbo.Usuarios.Correo, dbo.Usuarios.Telefono
FROM            dbo.Roles INNER JOIN
                         dbo.UsuarioRoles ON dbo.Roles.IdRol = dbo.UsuarioRoles.IdRol INNER JOIN
                         dbo.Usuarios ON dbo.UsuarioRoles.IdUsuario = dbo.Usuarios.NombreUsuario


Select * from Usuarios