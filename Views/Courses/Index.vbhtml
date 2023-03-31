@ModelType IEnumerable(Of Enrollment.Courses)
@Code
    ViewBag.title = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
    @Using Html.BeginForm("Index", "Courses", FormMethod.Get)
        @<p> 
        Professor : @Html.DropDownList("professor", "All")
        Title : @Html.TextBox("keyword")<br/>
        <input type="submit" value="Filter" />
    </p>
    End Using
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cor_Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cor_Professor)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cor_Day)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cor_StartTime)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cor_EndTime)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cor_Number)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cor_Date)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cor_Description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cor_Credit)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cor_Subject)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cor_Updated)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cor_IsValid)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cor_Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cor_Professor)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cor_Day)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cor_StartTime)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cor_EndTime)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cor_Number)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cor_Date)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cor_Description)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cor_Credit)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cor_Subject)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cor_Updated)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cor_IsValid)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Cor_Idx}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Cor_Idx}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Cor_Idx})
        </td>
    </tr>
Next

</table>
