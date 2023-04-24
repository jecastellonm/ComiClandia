@ModelType ComiClandia.Pedido
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Regresar", "Index")
        </div>
    End Using
</div>
