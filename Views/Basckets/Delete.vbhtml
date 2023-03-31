@ModelType Enrollment.Basckets
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Basckets</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Bas_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Bas_Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Bas_Professor)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Bas_Professor)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Bas_Day)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Bas_Day)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Bas_StartTime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Bas_StartTime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Bas_EndTime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Bas_EndTime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Bas_Credit)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Bas_Credit)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Bas_Subject)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Bas_Subject)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Bas_Updated)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Bas_Updated)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Bas_IsValid)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Bas_IsValid)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
