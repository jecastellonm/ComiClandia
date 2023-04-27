@ModelType IEnumerable(Of ComiClandia.Pedido)
@Code
  ViewData("Title") = "Index"
End Code
<h2>Gestion de Pedidos</h2>

<p>
  @Html.ActionLink("Crear Nuevo", "Create")
</p>
<table cellpadding="1px" style="line-height:80%" border="1px" align="center">
  border-spacing: 0px
  <tr>
    <th align="center">
      @Html.DisplayName("Numero Pedido")
    </th>
    <th>
      @Html.DisplayName("Fecha Pedido")
    </th>
    <th>
      @Html.DisplayName("Fecha Modificacion Pedido")
    </th>
    <th>
      @Html.DisplayName("Estado Pedido")
    </th>
    <th>
      @Html.DisplayName("Producto")
    </th>
    <th>
      @Html.DisplayName("Cantidad")
    </th>
    <th>
      @Html.DisplayName("Fecha Detalle Pedido")
    </th>
    <th>
      @Html.DisplayName("Fecha Modificacion Detalle Pedido")
    </th>
    <th></th>
    <th>
      @Html.DisplayNameFor(Function(model) model.Cliente.Nombre)
    </th>
    <th>
      @Html.DisplayName("Total Pedido")
    </th>
    <th></th>
  </tr>

  @For Each item In Model
    @<tr>
      <td align="center" height="1px">
        @Html.DisplayFor(Function(modelItem) item.PedidoId)
      </td>
      <td align="center">
        @Html.DisplayFor(Function(modelItem) item.FechaPedido)
      </td>
      <td align="center">
        @Html.DisplayFor(Function(modelItem) item.FechaModificacionPedido)
      </td>
      <td align="center">
        @Html.DisplayFor(Function(modelItem) item.EstadoPedido)
      </td>
      <td align="center">
        @For Each item2 In item.DetallePedido
          @Html.DisplayFor(Function(modelItem) item2.Producto.Nombre) @<br> @<br>
        Next
      </td>
      <td align="center">
        @Code
          Dim TotalPedido As Integer = 0
        End Code
        @For Each item2 In item.DetallePedido
          @Html.DisplayFor(Function(modelItem) item2.Cantidad) @<br> @<br>
          @Code
            TotalPedido = TotalPedido + item2.Producto.Valor * item2.Cantidad
          End Code
        Next
      </td>
      <td align="center">
        @For Each item2 In item.DetallePedido
          @Html.DisplayFor(Function(modelItem) item2.FechaAdiciDetaPedido) @<br> @<br>
        Next
      </td>
      <td align="center">
        @For Each item2 In item.DetallePedido
          @If IsDBNull(item2.FechaModifiDetaPedido) Or IsNothing(item2.FechaModifiDetaPedido) Then
            @<p> <br> </p>
          Else
            @<p>@Html.DisplayFor(Function(modelItem) item2.FechaModifiDetaPedido) </p>
          End If
        Next
      </td>
      <td align="center">
        @For Each item2 In item.DetallePedido
          @Html.HiddenFor(Function(modelItem) item2.DetallePedidoId)
          @Html.ActionLink("Editar", "Edit", "DetallePedidoes", New With {.id = item2.DetallePedidoId}, "") @Html.Raw("&nbsp")
          @Html.ActionLink("Borrar", "Delete", "DetallePedidoes", New With {.id = item2.DetallePedidoId}, "") @<br>
          @<br>
          @*@Html.ActionLink("Details", "Details", New With {.id = item.PedidoId }) |*@
        Next
      </td>
      <td align="center">
        @Html.DisplayFor(Function(modelItem) item.Cliente.Nombre)
      </td>
      <td align="center" nowrap>
        <p><strong>@TotalPedido.ToString("$ #,#")</strong></p>
      </td>
      <td align="center">
        @Html.ActionLink("Editar", "Edit", New With {.id = item.PedidoId}) |
        @*@Html.ActionLink("Details", "Details", New With {.id = item.PedidoId }) |*@
        @Html.ActionLink("Borrar", "Delete", New With {.id = item.PedidoId})
      </td>
    </tr>
  Next

</table>
