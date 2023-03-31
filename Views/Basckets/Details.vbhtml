@ModelType Enrollment.Basckets
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Bas_Idx }) |
    @Html.ActionLink("Back to List", "Index")
</p>
