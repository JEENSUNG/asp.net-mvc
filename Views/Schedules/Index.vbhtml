@ModelType IEnumerable(Of Enrollment.Schedules)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Sch_Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Sch_Professor)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Sch_Day)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Sch_StartTime)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Sch_EndTime)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Sch_Credit)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Sch_Subject)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Sch_Updated)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Sch_IsValid)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Sch_Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Sch_Professor)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Sch_Day)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Sch_StartTime)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Sch_EndTime)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Sch_Credit)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Sch_Subject)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Sch_Updated)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Sch_IsValid)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Sch_Idx }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Sch_Idx }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Sch_Idx })
        </td>
    </tr>
Next

</table>
