
var app = angular.module('App', ['blockUI', 'ng-fusioncharts']);
var Obj;
var token = "";
var log = [];
var GoogleMaps;
var data = [];



app.controller("CtrlGeo", ['$scope', '$http', '$location', '$window', 'blockUI', '$timeout', '$interval',
    function ($scope, $http, $location, $window, blockUI, $timeout, $interval) {
        
        Obj = $scope;

        $scope.InitialiseMaps = function () {
            var mapOptions = {
                center: new google.maps.LatLng(-15.768466, -47.929459),
                zoom: 8,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            var map = new google.maps.Map(document.getElementById("map_canvas"), mapOptions);
        };

        //var geocoder = new google.maps.Geocoder();

        $scope.GeoEndereco = function () {

            var lat = '';
            var lng = '';

            var address = "Avenida geronimo de camargo, atibaia , são paulo ";

            geocoder.geocode({ 'address': address }, function (results, status) {
                if (status === google.maps.GeocoderStatus.OK) {
                    lat = results[0].geometry.location.lat();
                    lng = results[0].geometry.location.lng();
                } else {
                    alert("Não foi possivel obter localização: " + status);
                }
            });
            alert('Latitude: ' + lat + ' Logitude: ' + lng);

        };
               
        $scope.InitialiseMaps();

        $scope.GeoReferenciaGet = function () {
            $http.get("/api/Users/location").then(function (response) {
                var dados = response.data;
                $scope.dadosPie = dados;
                alert("asasssa");
            });
        };

    

 }]);