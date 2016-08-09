USE [Login]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[spr_IngresarUsuarios]
		@Nombres = N'asdf',
		@Apellidos = N'asfasf',
		@Telefono = N'54564',
		@Correo = N'asas@as.com',
		@Usuario = N'as5',
		@Contraseña = N'sa5'

SELECT	@return_value as 'Return Value'

GO
