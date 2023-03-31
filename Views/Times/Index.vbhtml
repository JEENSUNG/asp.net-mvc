@ModelType IEnumerable(Of Enrollment.Times)
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
            @Html.DisplayNameFor(Function(model) model.Tim_Day)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tim_StartTime)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tim_EndTime)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tim_Date)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tim_Updated)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tim_IsValid)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tim_Day)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tim_StartTime)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tim_EndTime)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tim_Date)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tim_Updated)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tim_IsValid)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Tim_Idx }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Tim_Idx }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Tim_Idx })
        </td>
    </tr>
Next

</table>
