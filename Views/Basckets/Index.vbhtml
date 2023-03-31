@ModelType IEnumerable(Of Enrollment.Basckets)
@Code
    ViewBag.title = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Bas_Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Bas_Professor)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Bas_Day)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Bas_StartTime)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Bas_EndTime)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Bas_Credit)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Bas_Subject)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Bas_Updated)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Bas_IsValid)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Bas_Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Bas_Professor)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Bas_Day)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Bas_StartTime)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Bas_EndTime)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Bas_Credit)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Bas_Subject)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Bas_Updated)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Bas_IsValid)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Bas_Idx }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Bas_Idx }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Bas_Idx })
        </td>
    </tr>
Next

</table>
