@ModelType Enrollment.Schedules
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Schedules</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Sch_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Sch_Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Sch_Professor)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Sch_Professor)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Sch_Day)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Sch_Day)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Sch_StartTime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Sch_StartTime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Sch_EndTime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Sch_EndTime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Sch_Credit)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Sch_Credit)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Sch_Subject)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Sch_Subject)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Sch_Updated)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Sch_Updated)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Sch_IsValid)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Sch_IsValid)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Sch_Idx }) |
    @Html.ActionLink("Back to List", "Index")
</p>
