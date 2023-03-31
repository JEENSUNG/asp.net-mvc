@ModelType Enrollment.Times
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
