@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewData("Title") = "Map"
End Code

<h2>@ViewData("Title")</h2>

<div style="height: 483px;">
    <div id="map-canvas" style="height:100%">

    </div>
</div>

<table id="PoliceCalls" class="table table-striped dataTable" cellspacing="0" width="100%">
    <thead>
        <tr>
            <th>Incident Number</th>

            <th>Description</th>
            <th>Street Address</th>
            <th>Response Time</th>
        </tr>
    </thead>

    <tbody>
        <tr>
            <td>090614-00121</td>

            <td>BURGLARY</td>
            <td>14400 BLOCK 49TH ST N&#160;</td>
            <td>7:37 AM</td>
        </tr>
        <tr>
            <td>090614-00137</td>

            <td>SUSPICIOUS VEHICLE</td>
            <td>1500 BLOCK OAKWOOD ST&#160;</td>
            <td>8:21 AM</td>
        </tr>
        <tr>
            <td>090614-00138</td>

            <td>DIRECTED PATROL</td>
            <td>400 BLOCK E EAST SHORE DR&#160;</td>
            <td>8:25 AM</td>
        </tr>
        <tr>
            <td>090614-00140</td>

            <td>PROPERTY FOUND/LOST</td>
            <td>1400 BLOCK GULF TO BAY BLVD&#160;</td>
            <td>8:29 AM</td>
        </tr>
        <tr>
            <td>090614-00143</td>

            <td>THEFT</td>
            <td>1400 BLOCK MONTE CARLO DR&#160;</td>
            <td>8:50 AM</td>
        </tr>
        <tr>
            <td>090614-00144</td>

            <td>MISSING PERSON</td>
            <td>1000 BLOCK SPENCER AVE&#160;</td>
            <td>8:54 AM</td>
        </tr>
        <tr>
            <td>090614-00147</td>

            <td>TRAFFIC STOP</td>
            <td>24600 BLOCK US HIGHWAY 19 N&#160;</td>
            <td>8:57 AM</td>
        </tr>
    </tbody>
</table>

@section scripts
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyDROidJDrc31fYjbZVEyK6DjyougRekYHg"></script>
    <script>
        google.maps.event.addDomListener(window, 'load', showGoogleMap());

        var map;
        function showGoogleMap() {
            var myLatlng = new google.maps.LatLng(27.964321, -82.796403);
            var mapOptions = {
                center: myLatlng,
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
    </script>
end section