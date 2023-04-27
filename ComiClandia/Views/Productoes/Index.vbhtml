@ModelType IEnumerable(Of ComiClandia.Producto)
@Code
  ViewData("Title") = "Index"
End Code

<h2>Gestion de Productos</h2>

<p>
  @Html.ActionLink("Crear Nuevo", "Create")
</p>
<table class="table">
  <tr>
    <th>
      @Html.DisplayNameFor(Function(model) model.Nombre)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.Descripcion)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.Stock)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.Valor)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.Departamento)
    </th>
    <th></th>
  </tr>

  @For Each item In Model
    @<tr>
      <td align="center">
        @Html.DisplayFor(Function(modelItem) item.Nombre)
      </td>
      <td align="center">
        @Html.DisplayFor(Function(modelItem) item.Descripcion)
      </td>
      <td align="center">
        @Html.DisplayFor(Function(modelItem) item.Stock)
      </td>
      <td align="center">
        @Code
          Dim Valor As Integer = item.Valor
        End Code
        @*@Html.DisplayFor(Function(modelItem) item.Valor)*@
        @Valor.ToString("$ #,#")
      </td>
      <td align="center">
        @Html.DisplayFor(Function(modelItem) item.Departamento)
      </td>
      <td align="center">
        @Html.ActionLink("Editar", "Edit", New With {.id = item.ProductoID}) |
        @*@Html.ActionLink("Details", "Details", New With {.id = item.ProductoID}) |*@
        @Html.ActionLink("Borrar", "Delete", New With {.id = item.ProductoID})
      </td>
    </tr>
  Next

</table>
