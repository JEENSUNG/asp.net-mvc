@ModelType Enrollment.Members
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
