@ModelType IEnumerable(Of MVCActiveCallsForService.PoliceCall)
@Code
    ViewData("Title") = "Active Calls for Service"
End Code

@section styles
    <link href="//cdn.datatables.net/1.10.2/css/jquery.dataTables.css" rel="stylesheet" type="text/css" />
End section

        <h2>@ViewData("Title")</h2>

        <!-- Google Maps -->
        <div style="height: 483px;">
            <div id="map-canvas" style="height:100%"></div>
        </div>

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
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyDROidJDrc31fYjbZVEyK6DjyougRekYHg"></script>
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
                    showGoogleMap();

                    $('#PoliceCalls').on('page.dt search.dt', function () {
                        clearTimeout(typingTimer);
                        typingTimer = setTimeout(function () { showGoogleMap(); }, 2000)
                    });
                });

                var map;
                function showGoogleMap() {
                    var myLatlng = new google.maps.LatLng(27.964321, -82.796403);
                    var mapOptions = {
                        center: myLatlng, //new google.maps.LatLng(-34.397, 150.644),
                        zoom: 13
                    };
                    map = new google.maps.Map(document.getElementById("map-canvas"), mapOptions);

                    styleMap();
                    displayPoliceCalls();
                }

                function styleMap() {
                    var styles = [
                        {
                            stylers: [
                                { hue: "#4d8dc6" },
                                { saturation: -20 }
                            ]
                        }, {
                            featureType: "road",
                            elementType: "geometry",
                            stylers: [
                                { lightness: 100 },
                                { visibility: "simplified" }
                            ]
                        }, {
                            featureType: "road",
                            elementType: "labels",
                            stylers: [
                                { visibility: "on" }
                            ]
                        }
                    ];

                    map.setOptions({ styles: styles });
                }

                function displayPoliceCalls() {
                    var geocoder = new google.maps.Geocoder();
                    var icon = "@Url.Content("~/Content/")" + "siren.png";

                    $("#PoliceCalls tbody tr").each(function (index) {
                        var cells = $("td", this);

                        var incidentNumber = cells[0].textContent;
                        var policeCallType = cells[1].textContent;
                        var address = cells[2].textContent;
                        var responseTime = cells[3].textContent;

                        geocoder.geocode({ 'address': address + " Clearwater, FL" },
                            function (results, status) {
                                if (status == google.maps.GeocoderStatus.OK) {

                                    var myLatlng = results[0].geometry.location;
                                    var marker = new google.maps.Marker({
                                        position: myLatlng,
                                        map: map,
                                        title: policeCallType,
                                        icon: icon
                                    });

                                    var infowindow = new google.maps.InfoWindow({
                                        content: "<strong>" +
                                            policeCallType + "</strong><br>" +
                                            "Incident Number: " + incidentNumber + "<br>" +
                                            "Address: " + address + "<br>" +
                                            "Response Time: " + responseTime,
                                        maxWidth: 200
                                    });
                                    google.maps.event.addListener(marker, 'click', function () {
                                        infowindow.open(map, marker);
                                    });
                                } else console.log(status);
                            }
                        );
                    });
                }
            }
        }]);
    </script>
End Section