

var app = angular.module('App', ['blockUI', 'ng-fusioncharts']);
var Obj;
var token = "";
var log = [];
var GoogleMaps;
var data = [];


app.controller("ctrlPerfil", ['$scope', '$http', '$location', '$window', 'blockUI', '$timeout', '$interval',
    function ($scope, $http, $location, $window, blockUI, $timeout, $interval) {

        Obj = $scope; 
       
        $scope.values = [];

        //    { "EmailUser": "paulo000natale@gmail.com", "Password": "777", "Id": 7, "CreateDate": null, "UpdateDate": null },
        //    { "EmailUser": "paulo000natale@gmail.com", "Password": "777", "Id": 8, "CreateDate": null, "UpdateDate": null },
        //    { "EmailUser": "paulo000natale@gmail.com", "Password": "123456", "Id": 9, "CreateDate": null, "UpdateDate": null },
        //    { "EmailUser": "paulo_ace_1000@hotmail.com", "Password": "82929262", "Id": 10, "CreateDate": null, "UpdateDate": null },
        //    { "EmailUser": "paulo000natale@gmail.com", "Password": "82929262", "Id": 11, "CreateDate": null, "UpdateDate": null },
        //    { "EmailUser": "paulo000natale@gmail.com", "Password": "123456", "Id": 12, "CreateDate": null, "UpdateDate": null }];

        $scope.Perfils = [
            { "PerfilNome": "ADMIN","Id":"1"}
           ];

     

        $scope.Logins = function () {
            $http.get("/api/Perfil/getall").then(function (request) {
                $scope.clientes.push({ "EmailUser": "paulo000natale@gmail.com", "Password": "777", "Id": 7, "CreateDate": null, "UpdateDate": null });
                console.log(request.data);
            });
        };
        $scope.Logins();

        $scope.Perfis = function () {
            $http.get("/api/Perfil/getall").then(function (request) {
                $scope.values = request.data;
            });
        };


        $scope.SubMitCreate = function () {

            var dados = {
                HOME: $scope.HOME === undefined ? "HOME_ON" : "HOME_OFF",
                MAPS: $scope.MAPS === undefined ? "MAPS_ON" : "MAPS_OFF",
                NOTIFICACAO: $scope.NOTIFICACAO === undefined ? "NOTIFICACAO_ON" : "NOTIFICACAO_OFF",
                RELATORIOS: $scope.RELATORIOS === undefined ? "RELATORIOS_ON" : "RELATORIOS_OFF",
                ABERTURA_BOS: $scope.ABERTURA_BOS === undefined ? "ABERTURA_BOS_ON" : "ABERTURA_BOS_OFF",
                EDITAR: $scope.EDITAR === undefined ? "EDITAR_ON" : "EDITAR_OFF",
                CRIAR: $scope.CRIAR === undefined ? "CRIAR_ON" : "CRIAR_OFF",
                PESQUISA: $scope.PESQUISA === undefined ? "ACAO_FULL_ON" : "ACAO_FULL_OFF",
                ACAO_FULL: $scope.ACAO_FULL === undefined ? "ACAO_FULL_0N" : "ACAO_FULL_OFF",
                ACESSO_TOTAL: $scope.ACESSO_TOTAL === undefined ? "ACESSO_TOTAL_ON" : "ACESSO_TOTAL_OFF",
                NOME_PERFIL: $scope.NomePerfil,
                SISTEMA: $scope.LISTA_DROP
            };

            $http.post("/api/Perfil/createperfil", JSON.stringify(dados)).then(function (response) {
                if (response.data === "OK") {

                    var url = $window.location;
                    $window.location = "https://localhost:5001/Perfil/Perfil";
                }
            });
        };

        //$scope.Usuarios();


    }]);