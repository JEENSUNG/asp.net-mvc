@ModelType Enrollment.Courses
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Courses</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Cor_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cor_Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Cor_Professor)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cor_Professor)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Cor_Day)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cor_Day)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Cor_StartTime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cor_StartTime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Cor_EndTime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cor_EndTime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Cor_Number)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cor_Number)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Cor_Date)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cor_Date)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Cor_Description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cor_Description)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Cor_Credit)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cor_Credit)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Cor_Subject)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cor_Subject)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Cor_Updated)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cor_Updated)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Cor_IsValid)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cor_IsValid)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Cor_Idx }) |
    @Html.ActionLink("Back to List", "Index")
</p>
