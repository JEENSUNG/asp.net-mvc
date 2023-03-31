@ModelType Enrollment.Members
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Members</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Mem_MemberName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Mem_MemberName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Mem_Password)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Mem_Password)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Mem_Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Mem_Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Mem_Major)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Mem_Major)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Mem_Email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Mem_Email)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Mem_Date)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Mem_Date)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Mem_Role)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Mem_Role)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Mem_Credit)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Mem_Credit)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Mem_Grade)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Mem_Grade)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Mem_StudentIdx)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Mem_StudentIdx)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Mem_Gender)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Mem_Gender)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Mem_Age)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Mem_Age)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Mem_Updated)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Mem_Updated)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Mem_IsValid)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Mem_IsValid)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Mem_Idx }) |
    @Html.ActionLink("Back to List", "Index")
</p>
