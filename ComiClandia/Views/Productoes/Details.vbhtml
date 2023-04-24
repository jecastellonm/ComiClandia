@ModelType ComiClandia.Producto
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Producto</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Descripcion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Descripcion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Stock)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Stock)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Valor)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Valor)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Departamento)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Departamento)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Editar", "Edit", New With {.id = Model.ProductoID}) |
    @Html.ActionLink("Back to List", "Index")
</p>
