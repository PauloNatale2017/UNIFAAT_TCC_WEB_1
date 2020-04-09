

var app = angular.module('App', ['blockUI', 'ng-fusioncharts']);
var Obj;


app.controller("ctrlPerfil", ['$rootScope', '$scope', '$http', '$location', '$window', 'blockUI', '$timeout', '$filter', '$interval',
    function ($rootScope, $scope, $http, $location, $window, blockUI, $timeout, $filter, $interval, $q) {


        vm = this;
        Obj = $scope;
        path = window.location.origin;

        //    { "EmailUser": "paulo000natale@gmail.com", "Password": "777", "Id": 7, "CreateDate": null, "UpdateDate": null },
        //    { "EmailUser": "paulo000natale@gmail.com", "Password": "777", "Id": 8, "CreateDate": null, "UpdateDate": null },
        //    { "EmailUser": "paulo000natale@gmail.com", "Password": "123456", "Id": 9, "CreateDate": null, "UpdateDate": null },
        //    { "EmailUser": "paulo_ace_1000@hotmail.com", "Password": "82929262", "Id": 10, "CreateDate": null, "UpdateDate": null },
        //    { "EmailUser": "paulo000natale@gmail.com", "Password": "82929262", "Id": 11, "CreateDate": null, "UpdateDate": null },
        //    { "EmailUser": "paulo000natale@gmail.com", "Password": "123456", "Id": 12, "CreateDate": null, "UpdateDate": null }];

        $scope.Perfils = [{ "PerfilNome": "ADMIN","Id":"1"}];


        $scope.values = [];
        $scope.Logins =   function () {
            $http.get("/api/Perfil/getall")
                .then(function (request) {
                    var dados = request.data;
                    $scope.values = dados
                                    
                }).catch(function (response) {
                    console.log(response);
                })
                .finally(function () {
                    blockUI.stop();
                });
        };
        $scope.Logins();

        $scope.values2 = [];
        $scope.Perfis = function () {
            $http.get("/api/Perfil/getperfilall")
                .then(function (request) {
                    var dados = request.data;
                    $scope.values2 = dados;

                }).catch(function (response) {
                    console.log(response);
                })
                .finally(function () {
                    blockUI.stop();
                });

        };
        $scope.Perfis();

        $scope.perfilvinculo = function () {

            var entityPerfil = {
                IdUsuario: $scope.selectedPerfils,
                IdPerfil: $scope.selectedLogins,
                IdSistema: "1"
            };

            $http.post("/api/Perfil/createperfilvinculo", JSON.stringify(entityPerfil)).then(function (response) {
                if (response.data === "OK") {

                    var url = $window.location;
                    $window.location = "https://localhost:5001/Perfil/Perfil";
                }
            });
        };

        //$scope.Logins();


    }]);