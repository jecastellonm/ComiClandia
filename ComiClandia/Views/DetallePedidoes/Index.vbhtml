@ModelType IEnumerable(Of ComiClandia.DetallePedido)
@Code
ViewData("Title") = "Index"
End Code

<h2>Gestion Detalle Pedidos</h2>

<p>
    @Html.ActionLink("Crear Nuevo", "Create")
</p>
<table class="table">
  <tr>
    <th>
      @Html.DisplayNameFor(Function(model) model.Producto.Nombre)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.Cantidad)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.TotalDetalleP)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.FechaAdiciDetaPedido)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.FechaModifiDetaPedido)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.Pedido.PedidoId)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.Observaciones)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.Activo)
    </th>
    <th></th>
  </tr>

@For Each item In Model
    @<tr>
  <td>
    @Html.DisplayFor(Function(modelItem) item.Producto.Nombre)
  </td>
  <td>
    @Html.DisplayFor(Function(modelItem) item.Cantidad)
  </td>
  <td>
    @Html.DisplayFor(Function(modelItem) item.TotalDetalleP)
  </td>
  <td>
    @Html.DisplayFor(Function(modelItem) item.FechaAdiciDetaPedido)
  </td>
  <td>
    @Html.DisplayFor(Function(modelItem) item.FechaModifiDetaPedido)
  </td>
  <td>
    @Html.DisplayFor(Function(modelItem) item.Pedido.PedidoId)
  </td>
  <td>
    @Html.DisplayFor(Function(modelItem) item.Observaciones)
  </td>
  <td>
    @Html.DisplayFor(Function(modelItem) item.Activo)
  </td>
  <td>
    @Html.ActionLink("Editar", "Edit", New With {.id = item.DetallePedidoId}) |
    @*@Html.ActionLink("Details", "Details", New With {.id = item.DetallePedidoId }) |*@
    @Html.ActionLink("Borrar", "Delete", New With {.id = item.DetallePedidoId})
  </td>
</tr>
Next

</table>
