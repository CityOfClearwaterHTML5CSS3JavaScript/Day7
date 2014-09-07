@ModelType Helpers

<h3>Basic HTML Helpers</h3>
<table class="table">
    <tr>
        <td>Html.TextBox</td>
        <td>
            @Html.TextBox("TextBox1", "This is a TextBox")
        </td>
    </tr>
    <tr>
        <td>Html.TextArea</td>
        <td>
            @Html.TextArea("TextArea1", "This is a TextArea", 5, 15, Nothing)
        </td>
    </tr>
    <tr>
        <td>Html.Password</td>
        <td>
            @Html.Password("Password1", "secret")
        </td>
    </tr>
    <tr>
        <td>Html.Hidden</td>
        <td>
            @Html.Hidden("Hidden1", "This is Hidden")
        </td>
    </tr>
    <tr>
        <td>Html.CheckBox</td>
        <td>
            Check Me @Html.CheckBox("CheckBox1", False)
        </td>
    </tr>
    <tr>
        <td>Html.RadioButton</td>
        <td>
            Red @Html.RadioButton("RadioButton1", "Red", True)
            Green @Html.RadioButton("RadioButton1", "Green")
            Blue @Html.RadioButton("RadioButton1", "Blue")
        </td>
    </tr>
    <tr>
        <td>Html.DropDownList</td>
        <td>
            @Html.DropDownList("DropDownList1", 
                               New MultiSelectList(New String() {"Red", "Green", "Blue"}))
        </td>
    </tr>
    <tr>
        <td>Html.ListBox</td>
        <td>
            @Html.ListBox("ListBox1",
                               New MultiSelectList(New String() {"Red", "Green", "Blue"}))
        </td>
    </tr>
</table>

<h3>Strongly Typed HTML Helpers</h3>
<table class="table">
    <tr>
        <td>Html.TextBoxFor</td>
        <td>
            @Html.TextBoxFor(Function(model) model.Name)
        </td>
    </tr>
    <tr>
        <td>Html.TextAreaFor</td>
        <td>
            @Html.TextAreaFor(Function(model) model.Name, 5, 15, Nothing)
        </td>
    </tr>
    <tr>
        <td>Html.PasswordFor</td>
        <td>
            @Html.PasswordFor(Function(model) model.Name)
        </td>
    </tr>
    <tr>
        <td>Html.HiddenFor</td>
        <td>
            @Html.HiddenFor(Function(model) model.Name)
        </td>
    </tr>
    <tr>
        <td>Html.CheckBoxFor</td>
        <td>
            Veteran @Html.CheckBoxFor(Function(model) model.Veteran)
        </td>
    </tr>
    <tr>
        <td>Html.RadioButtonFor</td>
        <td>
            Yes @Html.RadioButtonFor(Function(model) model.Veteran, "True")
            No @Html.RadioButtonFor(Function(model) model.Veteran, "False")
        </td>
    </tr>
    <tr>
        <td>Html.DropDownListFor</td>
        <td>
            @Html.DropDownListFor(Function(model) model.Veteran,
                                  New SelectList(New String() {"False", "True"}))
        </td>
    </tr>
    <tr>
        <td>Html.ListBoxFor</td>
        <td>
            @Html.ListBoxFor(Function(model) model.Interests,
                               New MultiSelectList(New String() {"Shopping", "Beer", "Chess", "Bowling"}))
        </td>
    </tr>
</table>


<h3>Non-Templated Strongly Typed HTML Helpers</h3>
<table class="table">
    <tr>
        <td>Html.DisplayName</td>
        <td>
            @Html.DisplayName("Name")
        </td>
    </tr>
    <tr>
        <td>Html.DisplayText</td>
        <td>
            @Html.DisplayText("Name")
        </td>
    </tr>

    <tr>
        <td>Html.DisplayNameFor</td>
        <td>
            @Html.DisplayNameFor(Function(model) model.Name)
        </td>
    </tr>
    <tr>
        <td>Html.DisplayTextFor</td>
        <td>
            @Html.DisplayTextFor(Function(model) model.Name)
        </td>
    </tr>
</table>


<h3>Templated Strongly Typed HTML Helpers</h3>
<table class="table">
    <tr>
        <td>Html.Display</td>
        <td>
            @Html.Display("Name")
        </td>
    </tr>
    <tr>
        <td>Html.Label</td>
        <td>
            @Html.Label("Name")
        </td>
    </tr>
    <tr>
        <td>Html.Editor</td>
        <td>
            @Html.Editor("Name")
        </td>
    </tr>

    <tr>
        <td>Html.DisplayFor</td>
        <td>
            @Html.DisplayFor(Function(model) model.Name)
        </td>
    </tr>
    <tr>
        <td>Html.LabelFor</td>
        <td>
            @Html.LabelFor(Function(model) model.Name)
        </td>
    </tr>
    <tr>
        <td>Html.EditorFor</td>
        <td>
            @Html.EditorFor(Function(model) model.Name)
        </td>
    </tr>
</table>
