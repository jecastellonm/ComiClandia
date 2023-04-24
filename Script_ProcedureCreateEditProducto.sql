
-- =============================================================
-- Autor:			JAVIER CASTELLON
-- Fecha Creacion:	23 ABril 2023
-- Descripcion:		Adiciona o edita un registro tabla Producto
-- =============================================================
CREATE PROCEDURE [dbo].[CreateEditProducto](
	@ProductoId INT = 0,
	@Nombre VARCHAR(20),
	@Descripcion VARCHAR(50),
	@Stock INT, 
	@Valor INT, 
	@Departamento INT
)
AS
BEGIN
	IF (@ProductoId = 0 or @ProductoId is null)
		BEGIN
		INSERT INTO Producto(Nombre, Descripcion, Stock, Valor, Departamento)
		SELECT @Nombre, @Descripcion, @Stock, @Valor, @Departamento
		SELECT @ProductoId =SCOPE_IDENTITY()
		END
	ELSE
		BEGIN
			UPDATE Producto SET
				Nombre = @Nombre, 
				Descripcion = @Descripcion, 
				Stock = @Stock, 
				Valor = @Valor, 
				Departamento = @Departamento
			WHERE ProductoId = @ProductoId
			SELECT * FROM Producto WITH(NOLOCK)
				WHERE ProductoId = @ProductoId
		END
END
GO


