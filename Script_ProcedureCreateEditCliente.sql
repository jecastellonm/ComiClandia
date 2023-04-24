-- =============================================================
-- Autor:			JAVIER CASTELLON
-- Fecha Creacion:	23 ABril 2023
-- Descripcion:		Adiciona o edita un registro tabla Cliente
-- =============================================================
CREATE PROCEDURE [dbo].[CreateEditCliente](
	@ClienteId INT = 0,
	@Nombre VARCHAR(50), 
	@Identificacion VARCHAR(20), 
	@Direccion VARCHAR(50), 
	@Telefono VARCHAR(20), 
	@Ciudad VARCHAR(20)
)
AS
BEGIN
	IF (@ClienteId = 0 or @ClienteId is null)
		BEGIN
		INSERT INTO Cliente(Nombre, Identificacion, Direccion, Telefono, Ciudad)
		SELECT @Nombre, @Identificacion, @Direccion, @Telefono, @Ciudad
		SELECT @ClienteId =SCOPE_IDENTITY()
		END
	ELSE
		BEGIN
			UPDATE Cliente SET
				Nombre = @Nombre, 
				Identificacion = @Identificacion, 
				Direccion = @Direccion, 
				Telefono = @Telefono, 
				Ciudad = @Ciudad
			WHERE ClienteId = @ClienteId
			SELECT * FROM Cliente WITH(NOLOCK)
				WHERE ClienteId = @ClienteId
		END
END
GO


