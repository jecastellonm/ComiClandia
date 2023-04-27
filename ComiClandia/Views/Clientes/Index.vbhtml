@ModelType IEnumerable(Of ComiClandia.Cliente)
@Code
ViewData("Title") = "Index"
End Code

<h2>Gestion de Clientes</h2>

<p>
    @Html.ActionLink("Crear Nuevo", "Create")
</p>
<table class="table">
  <tr>
    <th>
      @Html.DisplayNameFor(Function(model) model.Nombre)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.Identificacion)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.Direccion)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.Telefono)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.Ciudad)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.Exclusivo)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.Activo)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.DescuentoAutorizado)
    </th>
    <th>
      @Html.DisplayNameFor(Function(model) model.DescuentoActivo)
    </th>
    <th></th>
  </tr>

@For Each item In Model
    @<tr>
  <td align="center">
    @Html.DisplayFor(Function(modelItem) item.Nombre)
  </td>
  <td align="center">
    @Html.DisplayFor(Function(modelItem) item.Identificacion)
  </td>
  <td align="center">
    @Html.DisplayFor(Function(modelItem) item.Direccion)
  </td>
  <td align="center">
    @Html.DisplayFor(Function(modelItem) item.Telefono)
  </td>
  <td align="center">
    @Html.DisplayFor(Function(modelItem) item.Ciudad)
  </td>
  <td align="center">
    @Html.DisplayFor(Function(modelItem) item.Exclusivo)
  </td>
  <td align="center">
    @Html.DisplayFor(Function(modelItem) item.Activo)
  </td>
  <td align="center">
    @Html.DisplayFor(Function(modelItem) item.DescuentoAutorizado)
    @Html.Raw("%")
  </td>
  <td align="center">
    @Html.DisplayFor(Function(modelItem) item.DescuentoActivo)
  </td>
  <td align="center">
    @Html.ActionLink("Editar", "Edit", New With {.id = item.ClienteId}) |
    @*@Html.ActionLink("Details", "Details", New With {.id = item.ClienteId }) |*@
    @Html.ActionLink("Borrar", "Delete", New With {.id = item.ClienteId})
  </td>
</tr>
Next

</table>
