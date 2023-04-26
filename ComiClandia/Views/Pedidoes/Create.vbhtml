@ModelType ComiClandia.Pedido
@Code
  ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using (Html.BeginForm())
  @Html.AntiForgeryToken()

  @<div class="form-horizontal">
  <h4>Pedido</h4>
  <hr />
  @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
  @*<div class="form-group">
      @Html.LabelFor(Function(model) model.FechaPedido, htmlAttributes:=New With {.class = "control-label col-md-2"})
      <div class="col-md-10">
        @Html.EditorFor(Function(model) model.FechaPedido, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.FechaPedido, "", New With {.class = "text-danger"})
      </div>
    </div>*@

  @*<div class="form-group">
    @Html.LabelFor(Function(model) model.FechaModificacionPedido, htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div class="col-md-10">
      @Html.EditorFor(Function(model) model.FechaModificacionPedido, New With {.htmlAttributes = New With {.class = "form-control"}})
      @Html.ValidationMessageFor(Function(model) model.FechaModificacionPedido, "", New With {.class = "text-danger"})
    </div>
  </div>*@

  <div class="form-group">
    @Html.LabelFor(Function(model) model.IdCliente, "Cliente", htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div class="col-md-10">
      @Html.DropDownList("IdCliente", Nothing, htmlAttributes:=New With {.class = "form-control"})
      @Html.ValidationMessageFor(Function(model) model.IdCliente, "", New With {.class = "text-danger"})
    </div>
  </div>

  <div Class="form-group">
    @Html.Label("Estado Pedido (1 Pendiente, 2 Alistando, 3 Entregado, 4 En Cobro, 5 Pagado)", htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div Class="col-md-10">
      @Html.EditorFor(Function(model) model.EstadoPedido, New With {.htmlAttributes = New With {.class = "form-control"}})
      @Html.ValidationMessageFor(Function(model) model.EstadoPedido, "", New With {.class = "text-danger"})
    </div>
  </div>

  <div Class="form-group">
    @Html.Label("Tipo Pedido (1 Entrega Inmediata, 2 Domicilio, Retiro en TIenda)", htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div Class="col-md-10">
      @Html.EditorFor(Function(model) model.EstadoPedido, New With {.htmlAttributes = New With {.class = "form-control"}})
      @Html.ValidationMessageFor(Function(model) model.EstadoPedido, "", New With {.class = "text-danger"})
    </div>
  </div>

  <div Class="form-group">
    @Html.Label("Observaciones", "Observaciones", htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div Class="col-md-10">
      @Html.Editor("Observaciones", New With {.htmlAttributes = New With {.class = "form-control"}})
      @Html.ValidationMessage("Observaciones", "", New With {.class = "text-danger"})
    </div>
  </div>

  <div Class="form-group">
    @Html.Label("Activo", "Activo", htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div Class="col-md-10">
      @Html.Editor("Activo", New With {.htmlAttributes = New With {.class = "form-control"}})
      @Html.ValidationMessage("Activo", "", New With {.class = "text-danger"})
    </div>
  </div>


  <div class="form-group">
    @Html.Label("IdProducto", "Producto", htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div Class="col-md-10">
      @*@For Each item In Model.DetallePedido*@
      @Html.DropDownList("IdProducto", Nothing, htmlAttributes:=New With {.class = "form-control"})
      @*@Html.ValidationMessageFor(Function(model) item.IdProducto, "", New With {.class = "text-danger"})*@
      @*Next*@
    </div>
  </div>
  <div Class="form-group">
    @Html.Label("Cantidad", "Cantidad", htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div Class="col-md-10">
      @*@For Each item In Model.DetallePedido*@
      @Html.Editor("Cantidad", New With {.htmlAttributes = New With {.class = "form-control"}})
      @*@Html.ValidationMessageFor(Function(model) item.Cantidad, "", New With {.class = "text-danger"})*@
      @*Next*@
    </div>
  </div>

  <div Class="form-group">
    <div Class="col-md-offset-2 col-md-10">
      <input type="submit" value="Create" Class="btn btn-default" />
    </div>
  </div>
</div>
End Using

<div>
  @Html.ActionLink("Regresar", "Index")
</div>
<Script src="~/Scripts/jquery-3.4.1.min.js"></Script>
<Script src="~/Scripts/jquery.validate.min.js"></Script>
<Script src="~/Scripts/jquery.validate.unobtrusive.min.js"></Script>
