
var app = angular.module('App', ['blockUI', 'ng-fusioncharts']);
var Obj;
var token = "";
var urlExternal = "https://localhost:5001/api/";


app.controller("CtrlOng", ['$scope', '$http', '$location', '$window', 'blockUI', '$timeout', '$interval',
    function ($scope, $http, $location, $window, blockUI, $timeout, $interval) {
        
        Obj = $scope;

        //blockUI.start("....CARREGANDO INFORMAÇÕES....");

        $scope.BuscaOngsFnc = function () {
            //
            var path = window.location.origin;
            var loginUrlEndPoint = urlExternal + "external/externalongs";

            blockUI.start("CARREGANDO...");

            $http.get(loginUrlEndPoint).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    }
                    else {
                        console.log(response.data);
                        $scope.OngsFunc = response.data;
                    }

                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
            });
            blockUI.stop();
        };

        $scope.SalvaOngsFnc = function (Id) {

        };

        $scope.EditOng = function (id) {
            $window.location = "https://localhost:5001/Ong/EditOng?id=" + id;            
        };

        $scope.CadastroBasicos = function () {
            var path = window.location.origin;
            var loginUrlEndPoint = path + "/api/vitimas/cadastrosvitima";
            blockUI.start("CARREGANDO...");

            $http.get(loginUrlEndPoint).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    }
                    else {
                        console.log(response.data.vitimabasic);
                        $scope.basic = response.data.vitimabasic;
                       
                    }

                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
            });
            blockUI.stop();
        };

        $scope.GeoReferenciaGet = function () {

            var data = {
                "endereco": $("#Geo_Complemento").val()
            };

            $http.post("/api/Users/location?endereco=" + $("#Geo_Complemento").val()).then(function (response) {
                var dados = response.data;
                $scope.dadosPie = dados;               
            });
        };

        $scope.SalvarGeoReferencia = function () {
            var path = window.location.origin;
            var loginUrlEndPoint = urlExternal + "external/externalcadastrogeo";


            var request = {
                "IdUsuario": document.getElementById("idusuario").value,
                "Endereco": document.getElementById("endereco").value,
                "CEP": document.getElementById("cep").value,
                "Complemento": document.getElementById("complemento").value,
                "Lat": document.getElementById("Geo_Lat").value,
                "Long": document.getElementById("long").value               
            };
            
            $http.post(loginUrlEndPoint, request).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    } else {
                      
                        blockUI.stop();
                        $window.location = "https://localhost:5001/GeoReferencia/GeoReferencia";
                    }

                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
            });
        };

        $scope.BuscaOngsFnc();

 }]);