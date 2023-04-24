@ModelType ComiClandia.DetallePedido
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>DetallePedido</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Cantidad)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cantidad)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FechaAdiciDetaPedido)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FechaAdiciDetaPedido)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FechaModifiDetaPedido)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FechaModifiDetaPedido)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Pedido.PedidoId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Pedido.PedidoId)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Producto.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Producto.Nombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.DetallePedidoId }) |
    @Html.ActionLink("Regresar", "Index")
</p>
