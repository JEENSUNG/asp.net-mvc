@ModelType Enrollment.Times
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Times</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Tim_Day)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tim_Day)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tim_StartTime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tim_StartTime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tim_EndTime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tim_EndTime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tim_Date)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tim_Date)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tim_Updated)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tim_Updated)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tim_IsValid)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tim_IsValid)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Tim_Idx }) |
    @Html.ActionLink("Back to List", "Index")
</p>
