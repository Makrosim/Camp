
var map;

function initMap()
{
    var myLatlng = { lat: 50, lng: 36.28 };

    map = new google.maps.Map(document.getElementById('map'),
        {
        center: myLatlng,
        zoom: 8
    });
}
