create PROC dbo.sp_InsertarProducto
(@CodigoProducto varchar(30),
 @NombreProducto varchar(100),
 @Descripcion varchar(500),
 @Existencia int,
 @PrecioCosto smallmoney,
 @PrecioVenta smallmoney
            
)
AS
BEGIN 

if  not exists(select * from Productos p (nolock) where p.CodigoProducto=@CodigoProducto)
  begin 
    insert Productos(CodigoProducto ,
 NombreProducto ,
 Descripcion,
 Existencia ,
 PrecioCosto,
 PrecioVenta)
		     values(@CodigoProducto ,
 @NombreProducto ,
 @Descripcion,
 @Existencia ,
 @PrecioCosto,
 @PrecioVenta)
  end
END		
/*
exec sp_InsertarProducto @CodigoProducto = '546',
					@NombreProducto ='San Salvador' ,
				     @Descripcion ='gduughhg',
				  
				   @Existencia =10 ,
				   @PrecioCosto ='89', 
				   @PrecioVenta ='98'
				    
*/					 