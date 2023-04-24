@ModelType ComiClandia.DetallePedido
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Regresar", "Index")
        </div>
    End Using
</div>
