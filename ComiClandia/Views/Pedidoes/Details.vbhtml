@ModelType ComiClandia.Pedido
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Pedido</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.FechaPedido)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FechaPedido)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FechaModificacionPedido)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FechaModificacionPedido)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Cliente.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cliente.Nombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Editar", "Edit", New With {.id = Model.PedidoId}) |
    @Html.ActionLink("Regresar", "Index")
</p>
