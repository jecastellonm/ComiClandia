@ModelType IEnumerable(Of ComiClandia.Pedido)
@Code
  ViewData("Title") = "Index"
End Code

<h2>Gestion de Pedidos</h2>

<p>
  @Html.ActionLink("Crear Nuevo", "Create")
</p>
<table class="table">
  <tr>
    <th>
      @Html.DisplayNameFor(Function(model) model.FechaPedido)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.FechaModificacionPedido)
    </th>
    <th>
      @Html.DisplayName("Producto")
    </th>
    <th>
      @Html.DisplayName("Cantidad")
    </th>
    <th>
      @Html.DisplayName("Fecha Pedido")
    </th>
    <th>
      @Html.DisplayName("Fecha Modificacion Pedido")
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.Cliente.Nombre)
    </th>
    <th></th>
  </tr>

  @For Each item In Model
    @<tr>
      <td>
        @Html.DisplayFor(Function(modelItem) item.FechaPedido)
      </td>
      <td>
        @Html.DisplayFor(Function(modelItem) item.FechaModificacionPedido)
      </td>
      <td>
        @For Each item2 In item.DetallePedido
          @<p>@Html.DisplayFor(Function(modelItem) item2.Producto.Nombre)</p>
        Next
      </td>
      <td>
        @For Each item2 In item.DetallePedido
          @<p>@Html.DisplayFor(Function(modelItem) item2.Cantidad)</p>
        Next
      </td>
      <td>
        @For Each item2 In item.DetallePedido
          @<p>@Html.DisplayFor(Function(modelItem) item2.FechaAdiciDetaPedido)</p>
        Next
      </td>
      <td>
        @For Each item2 In item.DetallePedido
          @<p>@Html.DisplayFor(Function(modelItem) item2.FechaModifiDetaPedido) </p>
        Next
      </td>
      <td>
        @For Each item2 In item.DetallePedido
          @<p>
            @Html.HiddenFor(Function(modelItem) item2.DetallePedidoId) 
            @Html.ActionLink("Editar", "Edit", "DetallePedidoes", New With {.id = item2.DetallePedidoId}, "")
            @Html.ActionLink("Borrar", "Delete", "DetallePedidoes", New With {.id = item2.DetallePedidoId}, "")
          </p>
          @*@Html.ActionLink("Details", "Details", New With {.id = item.PedidoId }) |*@

        Next
      </td>
      <td>
        @Html.DisplayFor(Function(modelItem) item.Cliente.Nombre)
      </td>
      <td>
        @Html.ActionLink("Editar", "Edit", New With {.id = item.PedidoId}) |
        @*@Html.ActionLink("Details", "Details", New With {.id = item.PedidoId }) |*@
        @Html.ActionLink("Borrar", "Delete", New With {.id = item.PedidoId})
      </td>
    </tr>
  Next

</table>
