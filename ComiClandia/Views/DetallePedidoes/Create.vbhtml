@ModelType ComiClandia.DetallePedido
@Code
  ViewData("Title") = "Create"
End Code

<h2>Crear</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
  <h4>DetallePedido</h4>  
  <hr />
  @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

  @*<div class="form-group">
    @Html.LabelFor(Function(model) model.Pedido.PedidoId, "IdPedido", htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div class="col-md-10">
      @Html.DropDownList("IdPedido", Nothing, htmlAttributes:=New With {.class = "form-control"})
      @Html.ValidationMessageFor(Function(model) model.Pedido.PedidoId, "", New With {.class = "text-danger"})
    </div>
  </div>*@

  <div class="form-group">
    @Html.LabelFor(Function(model) model.IdProducto, "IdProducto", htmlAttributes:=New With {.class = "control-label col-md-2"})
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

  @*<div class="form-group">
      @Html.LabelFor(Function(model) model.FechaAdiciDetaPedido, htmlAttributes:=New With {.class = "control-label col-md-2"})
      <div class="col-md-10">
        @Html.EditorFor(Function(model) model.FechaAdiciDetaPedido, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.FechaAdiciDetaPedido, "", New With {.class = "text-danger"})
      </div>
    </div>

    <div class="form-group">
      @Html.LabelFor(Function(model) model.FechaModifiDetaPedido, htmlAttributes:=New With {.class = "control-label col-md-2"})
      <div class="col-md-10">
        @Html.EditorFor(Function(model) model.FechaModifiDetaPedido, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.FechaModifiDetaPedido, "", New With {.class = "text-danger"})
      </div>
    </div>*@

  <div class="form-group">
    <div class="col-md-offset-2 col-md-10">
      <input type="submit" value="Create" class="btn btn-default" />
    </div>
  </div>
</div>
End Using

<div>
    @Html.ActionLink("Regresar", "Index")
</div>
<script src="~/Scripts/jquery-3.4.1.min.js"></script>
<script src="~/Scripts/jquery.validate.min.js"></script>
<script src="~/Scripts/jquery.validate.unobtrusive.min.js"></script>
