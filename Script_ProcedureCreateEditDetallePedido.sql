
-- =============================================================
-- Autor:			JAVIER CASTELLON
-- Fecha Creacion:	23 ABril 2023
-- Descripcion:		Adiciona o edita un registro tabla DetallePedido
-- =============================================================
CREATE PROCEDURE [dbo].[CreateEditDetallePedido](
	@DetallePedidoId INT = 0,
	@IdProducto INT, 
	@IdPedido INT, 
	@Cantidad INT
)
AS
BEGIN
	IF (@DetallePedidoId = 0 or @DetallePedidoId is null)
		BEGIN
		INSERT INTO DetallePedido(IdProducto, IdPedido, Cantidad, FechaAdiciDetaPedido)
		SELECT @IdProducto, @IdPedido, @Cantidad, GETDATE()
		SELECT @DetallePedidoId =SCOPE_IDENTITY()
		END
	ELSE
		BEGIN
			UPDATE DetallePedido SET
				IdProducto = @IdProducto, 
				IdPedido = @IdPedido, 
				Cantidad= @Cantidad, 
				FechaModifiDetaPedido = GETDATE()
			WHERE DetallePedidoId = @DetallePedidoId
			SELECT * FROM DetallePedido WITH(NOLOCK)
				WHERE DetallePedidoId = @DetallePedidoId
		END
END
GO


