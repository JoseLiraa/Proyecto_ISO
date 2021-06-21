create PROC dbo.sp_InsertarUsuarios
(@NombreUsuario varchar(100),
 @ClaveUsuario varchar(100),
 @Pregunta varchar(300),
 @Respuesta varchar(300),
 @Correo varchar(100),
 @Telefono varchar(9)
            
)
AS
BEGIN 

if  not exists(select * from Usuarios u (nolock) where u.NombreUsuario=@NombreUsuario)
  begin 
    insert Usuarios(NombreUsuario ,
					 ClaveUsuario,
					 Pregunta,
					 Respuesta,
					 Correo,
					Telefono)
		     values(@NombreUsuario ,
					@ClaveUsuario,
					 @Pregunta,
					 @Respuesta ,
					 @Correo,
					 @Telefono)
  end
END		
/*
exec sp_InsertarUsuarios @NombreUsuario = '546',
					@ClaveUsuario ='San Salvador' ,
				     @Pregunta ='gduughhg',
				  
				   @Respuesta =10 ,
				   @Correo ='89', 
				   @Telefono ='98'
				    
*/					 