CREATE TABLE [dbo].[Cliente](
	[ClienteId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Identificacion] [varchar](20) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
	[Ciudad] [varchar](20) NOT NULL,
	[Exclusivo] [bit] NOT NULL,
	[Activo] [bit] NOT NULL,
	[DescuentoAutorizado] [tinyint] NULL,
	[DescuentoActivo] [bit] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DetallePedido](
	[DetallePedidoId] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[IdPedido] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[TotalDetalleP] [int] NOT NULL,
	[FechaAdiciDetaPedido] [datetime] NOT NULL,
	[FechaModifiDetaPedido] [datetime] NULL,
	[Observaciones] [varchar](500) NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_DetallePedido] PRIMARY KEY CLUSTERED 
(
	[DetallePedidoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Pedido](
	[PedidoId] [int] IDENTITY(1,1) NOT NULL,
	[FechaPedido] [datetime] NOT NULL,
	[FechaModificacionPedido] [datetime] NULL,
	[IdCliente] [int] NOT NULL,
	[EstadoPedido] [tinyint] NOT NULL,
	[IdTipoPedido] [int] NOT NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[PedidoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Producto](
	[ProductoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Stock] [int] NOT NULL,
	[Valor] [int] NOT NULL,
	[Departamento] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[ProductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedido_Pedido_IdPedido] FOREIGN KEY([IdPedido])
REFERENCES [dbo].[Pedido] ([PedidoId])
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [FK_DetallePedido_Pedido_IdPedido]
GO

ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedido_Producto_IdProducto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([ProductoID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [FK_DetallePedido_Producto_IdProducto]
GO

ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Cliente_IdCliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([ClienteId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Cliente_IdCliente]
GO
