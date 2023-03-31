@ModelType IEnumerable(Of Enrollment.Members)
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
            @Html.DisplayNameFor(Function(model) model.Mem_MemberName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Mem_Password)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Mem_Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Mem_Major)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Mem_Email)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Mem_Date)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Mem_Role)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Mem_Credit)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Mem_Grade)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Mem_StudentIdx)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Mem_Gender)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Mem_Age)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Mem_Updated)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Mem_IsValid)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Mem_MemberName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Mem_Password)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Mem_Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Mem_Major)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Mem_Email)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Mem_Date)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Mem_Role)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Mem_Credit)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Mem_Grade)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Mem_StudentIdx)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Mem_Gender)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Mem_Age)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Mem_Updated)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Mem_IsValid)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Mem_Idx }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Mem_Idx }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Mem_Idx })
        </td>
    </tr>
Next

</table>
