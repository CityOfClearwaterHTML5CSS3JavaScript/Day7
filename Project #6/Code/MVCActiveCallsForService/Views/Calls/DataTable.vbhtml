@ModelType IEnumerable(Of MVCActiveCallsForService.PoliceCall)
@Code
    ViewData("Title") = "DataTable"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

@section styles
    <link href="//cdn.datatables.net/1.10.2/css/jquery.dataTables.css" rel="stylesheet" type="text/css" />
End section

<h2>@ViewData("Title")</h2>

<div class="table-responsive" style="margin-top: 25px">
    <table id="PoliceCalls" class="table table-striped dataTable" cellspacing="0" width="100%">
        <thead>
            <tr>
                <th>@Html.DisplayNameFor(Function(model) model.IncidentNumber)</th>
                @*<th>@Html.DisplayNameFor(Function(model) model.PoliceCallTypeId)</th>*@
                <th>@Html.DisplayNameFor(Function(model) model.CallType.CallType)</th>
                <th>@Html.DisplayNameFor(Function(model) model.StreetAddress)</th>
                <th>@Html.DisplayNameFor(Function(model) model.ResponseTime)</th>
            </tr>
        </thead>

        <tbody>
            @For Each item In Model
                @<tr>
                    <td>@Html.DisplayFor(Function(modelItem) item.IncidentNumber)</td>
                    @*<td>@Html.DisplayFor(Function(modelItem) item.PoliceCallTypeId)</td>*@
                    <td>@Html.DisplayFor(Function(modelItem) item.CallType.CallType)</td>
                    <td>@Html.DisplayFor(Function(modelItem) item.StreetAddress)</td>
                    <td>@Html.DisplayFor(Function(modelItem) item.ResponseTime)</td>
                </tr>
            Next
        </tbody>
    </table>
</div>

@section scripts
<script>
    Modernizr.load([{
        load: "//cdn.datatables.net/1.10.2/js/jquery.dataTables.min.js",
        complete: function () {
            console.info("jquery.dataTables loaded...");

            var typingTimer;
            $(document).ready(function () {
                $('#PoliceCalls').dataTable({
                    "paging": true,
                    "ordering": true,
                    "info": true,
                    "order": [[0, "desc"]],
                    "lengthMenu": [10],
                });
                $("#PoliceCalls_length").hide();
            });
        }
    }]);
</script>
end section