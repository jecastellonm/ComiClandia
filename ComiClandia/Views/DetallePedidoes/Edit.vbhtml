@ModelType ComiClandia.DetallePedido
@Code
  ViewData("Title") = "Edit"
End Code

<h2>Editar</h2>

@Using (Html.BeginForm())
  @Html.AntiForgeryToken()

  @<div class="form-horizontal">
  <h4>DetallePedido</h4>
  <hr />
  @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
  @Html.HiddenFor(Function(model) model.DetallePedidoId)
  @Html.HiddenFor(Function(model) model.FechaAdiciDetaPedido)

  <div class="form-group">
    @Html.LabelFor(Function(model) model.IdProducto, "Producto", htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div class="col-md-10">
      @Html.DropDownList("IdProducto", Nothing, htmlAttributes:=New With {.class = "form-control"})
      @Html.ValidationMessageFor(Function(model) model.IdProducto, "", New With {.class = "text-danger"})
    </div>
  </div>

  <div class="form-group">
    @Html.LabelFor(Function(model) model.IdPedido, "IdPedido", htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div class="col-md-10">
      @Html.DropDownList("IdPedido", Nothing, htmlAttributes:=New With {.class = "form-control"})
      @Html.ValidationMessageFor(Function(model) model.IdPedido, "", New With {.class = "text-danger"})
    </div>
  </div>

  <div class="form-group">
    @Html.LabelFor(Function(model) model.Cantidad, htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div class="col-md-10">
      @Html.EditorFor(Function(model) model.Cantidad, New With {.htmlAttributes = New With {.class = "form-control"}})
      @Html.ValidationMessageFor(Function(model) model.Cantidad, "", New With {.class = "text-danger"})
    </div>
  </div>

  <div class="form-group">
    @Html.LabelFor(Function(model) model.Observaciones, htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div class="col-md-10">
      @Html.EditorFor(Function(model) model.Observaciones, New With {.htmlAttributes = New With {.class = "form-control"}})
      @Html.ValidationMessageFor(Function(model) model.Observaciones, "", New With {.class = "text-danger"})
    </div>
  </div>

  <div class="form-group">
    @Html.LabelFor(Function(model) model.Activo, htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div class="col-md-10">
      @Html.EditorFor(Function(model) model.Activo, New With {.htmlAttributes = New With {.class = "form-control"}})
      @Html.ValidationMessageFor(Function(model) model.Activo, "", New With {.class = "text-danger"})
    </div>
  </div>

  <div class="form-group">
    <div class="col-md-offset-2 col-md-10">
      <input type="submit" value="Save" class="btn btn-default" />
    </div>
  </div>
</div>
End Using

<div>
  @Html.ActionLink("Regresar", "Index")
</div>
<div>
  @Html.ActionLink("Regresar A Pedidos", "Index", "Pedidoes")
</div>
<script src = "~/Scripts/jquery-3.4.1.min.js " ></script>
<script src = "~/Scripts/jquery.validate.min.js" ></script>
<script src = "~/Scripts/jquery.validate.unobtrusive.min.js" ></script>
