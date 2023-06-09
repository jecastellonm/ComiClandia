﻿@ModelType ComiClandia.Cliente
@Code
  ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
  <h4>Cliente</h4>
  <hr />
  @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
  @Html.HiddenFor(Function(model) model.ClienteId)

  <div class="form-group">
    @Html.LabelFor(Function(model) model.Nombre, htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div class="col-md-10">
      @Html.EditorFor(Function(model) model.Nombre, New With {.htmlAttributes = New With {.class = "form-control"}})
      @Html.ValidationMessageFor(Function(model) model.Nombre, "", New With {.class = "text-danger"})
    </div>
  </div>

  <div class="form-group">
    @Html.LabelFor(Function(model) model.Identificacion, htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div class="col-md-10">
      @Html.EditorFor(Function(model) model.Identificacion, New With {.htmlAttributes = New With {.class = "form-control"}})
      @Html.ValidationMessageFor(Function(model) model.Identificacion, "", New With {.class = "text-danger"})
    </div>
  </div>

  <div class="form-group">
    @Html.LabelFor(Function(model) model.Direccion, htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div class="col-md-10">
      @Html.EditorFor(Function(model) model.Direccion, New With {.htmlAttributes = New With {.class = "form-control"}})
      @Html.ValidationMessageFor(Function(model) model.Direccion, "", New With {.class = "text-danger"})
    </div>
  </div>

  <div class="form-group">
    @Html.LabelFor(Function(model) model.Telefono, htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div class="col-md-10">
      @Html.EditorFor(Function(model) model.Telefono, New With {.htmlAttributes = New With {.class = "form-control"}})
      @Html.ValidationMessageFor(Function(model) model.Telefono, "", New With {.class = "text-danger"})
    </div>
  </div>

  <div class="form-group">
    @Html.LabelFor(Function(model) model.Ciudad, htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div class="col-md-10">
      @Html.EditorFor(Function(model) model.Ciudad, New With {.htmlAttributes = New With {.class = "form-control"}})
      @Html.ValidationMessageFor(Function(model) model.Ciudad, "", New With {.class = "text-danger"})
    </div>
  </div>

  <div class="form-group">
    @Html.LabelFor(Function(model) model.Exclusivo, htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div class="col-md-10">
      <div class="checkbox">
        @Html.EditorFor(Function(model) model.Exclusivo)
        @Html.ValidationMessageFor(Function(model) model.Exclusivo, "", New With {.class = "text-danger"})
      </div>
    </div>
  </div>

  <div class="form-group">
    @Html.LabelFor(Function(model) model.DescuentoAutorizado, htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div class="col-md-10">
      <div class="checkbox">
        @Html.EditorFor(Function(model) model.DescuentoAutorizado)
        @Html.ValidationMessageFor(Function(model) model.DescuentoAutorizado, "", New With {.class = "text-danger"})
      </div>
    </div>
  </div>

  <div class="form-group">
    @Html.LabelFor(Function(model) model.DescuentoActivo, htmlAttributes:=New With {.class = "control-label col-md-2"})
    <div class="col-md-10">
      <div class="checkbox">
        @Html.EditorFor(Function(model) model.DescuentoActivo)
        @Html.ValidationMessageFor(Function(model) model.DescuentoActivo, "", New With {.class = "text-danger"})
      </div>
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
<script src="~/Scripts/jquery-3.4.1.min.js "></script>
<script src="~/Scripts/jquery.validate.min.js"></script>
<script src="~/Scripts/jquery.validate.unobtrusive.min.js"></script>
