@ModelType IEnumerable(Of ComiClandia.DetallePedido)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cantidad)
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
            @Html.DisplayNameFor(Function(model) model.Producto.Nombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cantidad)
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
            @Html.DisplayFor(Function(modelItem) item.Producto.Nombre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.DetallePedidoId }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.DetallePedidoId }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.DetallePedidoId })
        </td>
    </tr>
Next

</table>
