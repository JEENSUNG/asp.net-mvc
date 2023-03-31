@ModelType Enrollment.Courses
@Code
    ViewBag.title = "Create"
End Code

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
    <h4>강의 등록</h4>
    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    <div class="form-group">
        @Html.LabelFor(Function(model) model.Cor_Name, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Cor_Name, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.Cor_Name, "", New With {.class = "text-danger"})
        </div>
    </div>
    <br />

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Cor_Professor, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Cor_Professor, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.Cor_Professor, "", New With {.class = "text-danger"})
        </div>
    </div>
    <br />

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Cor_Day, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Cor_Day, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.Cor_Day, "", New With {.class = "text-danger"})
        </div>
    </div>
    <br />

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Cor_StartTime, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Cor_StartTime, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.Cor_StartTime, "", New With {.class = "text-danger"})
        </div>
    </div>
    <br />

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Cor_EndTime, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Cor_EndTime, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.Cor_EndTime, "", New With {.class = "text-danger"})
        </div>
    </div>
    <br />

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Cor_Number, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Cor_Number, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.Cor_Number, "", New With {.class = "text-danger"})
        </div>
    </div>
    <br />

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Cor_Description, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Cor_Description, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.Cor_Description, "", New With {.class = "text-danger"})
        </div>
    </div>
    <br />

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Cor_Credit, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Cor_Credit, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.Cor_Credit, "", New With {.class = "text-danger"})
        </div>
    </div>
    <br />
     
    <div class="form-group">
        @Html.LabelFor(Function(x) Model.Cor_Subject, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-5">
            @Html.DropDownListFor(Function(x) x.Cor_Subject, New SelectList(ViewBag.List), htmlAttributes:=New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(x) x.Cor_Subject, "", New With {.class = "text-danger"})
        </div>
    </div>
    <div Class="form-group">
        <div Class="col-md-offset-2 col-md-10">
            <input type = "submit" value="Create" Class="btn btn-default" />
        </div>
    </div>
</div>
End Using

                <div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
