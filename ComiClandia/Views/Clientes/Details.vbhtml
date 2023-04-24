@ModelType ComiClandia.Cliente
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Cliente</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Identificacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Identificacion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Direccion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Direccion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Telefono)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Telefono)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Ciudad)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Ciudad)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Exclusivo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Exclusivo)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Editar", "Edit", New With {.id = Model.ClienteId}) |
    @Html.ActionLink("Regresar", "Index")
</p>
