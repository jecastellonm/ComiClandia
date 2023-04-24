
-- =============================================================
-- Autor:			JAVIER CASTELLON
-- Fecha Creacion:	23 ABril 2023
-- Descripcion:		Adiciona o edita un registro tabla Pedido
-- =============================================================
CREATE PROCEDURE [dbo].[CreateEditPedido](
	@PedidoId INT = 0,
	@IdCliente INT
)
AS
BEGIN
	IF (@PedidoId = 0 or @PedidoId is null)
		BEGIN
			INSERT INTO Pedido(FechaPedido, IdCliente)
			SELECT GETDATE(), @IdCliente
			SELECT @PedidoId = SCOPE_IDENTITY()
		END
	ELSE
		BEGIN
			UPDATE Pedido SET
				FechaModificacionPedido = GETDATE(), 
				IdCliente = @IdCliente 
			WHERE PedidoId = @PedidoId
			SELECT * FROM Pedido WITH(NOLOCK)
				WHERE PedidoId = @PedidoId
		END
END
GO


