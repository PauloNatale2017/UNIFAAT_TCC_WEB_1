

var app = angular.module('App', ['blockUI']);
var Obj;


app.controller("ctrlPerfil", ['$rootScope', '$scope', '$http', '$location', '$window', 'blockUI', '$timeout', '$filter', '$interval',
    function ($rootScope, $scope, $http, $location, $window, blockUI, $timeout, $filter, $interval, $q) {


        vm = this;
        Obj = $scope;
        path = window.location.origin;



        $scope.values = [];
        $scope.Logins =   function () {
            $http.get("/api/Perfil/getall")
                .then(function (request)
                {
                    console.log(request.data);
                    var dados = request.data;
                    $scope.values = dados;                                    
                }).catch(function (response)
                {
                    console.log(response);
                })
                .finally(function ()
                {
                    blockUI.stop();
                });
        };
        $scope.Logins();

        $scope.click = function () {
            alert("hhhhhhhhhhhhhhhhhhhh");
        };

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
                    $window.location = "http://localhost:5001/Perfil/Perfil";
                }
            });
        };

        $scope.createperfil = function () {

            var PerfilDados = {
                HOME: ($scope.HOME === true ? "HOME_ON" : "HOME_OFF") + "&" +
                      ($scope.USUARIOS === true ? "USUARIOS_ON" : "USUARIOS_OFF") + "&" +
                      ($scope.RELATORIOS === true ? "RELATORIOS_ON" : "RELATORIOS_OFF") + "&" +
                      ($scope.CHAT === true ? "CHAT_ON" : "CHAT_OFF") + "&" +
                      ($scope.AUTOMACAO === true ? "AUTOMACAO_ON" : "AUTOMACAO_OFF") + "&" +
                      ($scope.VAGAS_DISPONIVEIS === true ? "VAGAS_ON" : "VAGAS_OFF") + "&" +
                      ($scope.OCORRENCIAS === true ? "OCORRENCIAS_ON" : "OCORRENCIAS_OFF") + "&" +
                      ($scope.ALERTAS === true ? "NOTIFICACAO_ON" : "NOTIFICACAO_OFF"),

                //USUARIOS: $scope.USUARIOS === true ? "USUARIOS_ON" : "USUARIOS_OFF",
                //RELATORIOS: $scope.RELATORIOS === true ? "RELATORIOS_ON" : "RELATORIOS_OFF",
                //CHAT: $scope.CHAT === true ? "CHAT_ON" : "CHAT_OFF",
                //AUTOMACAO: $scope.AUTOMACAO === true ? "AUTOMACAO_ON" : "AUTOMACAO_OFF",               
                //VAGAS: $scope.VAGAS === true ? "VAGAS_ON" : "VAGAS_OFF",
                //OCORRENCIAS: $scope.OCORRENCIAS === true ? "OCORRENCIAS_ON" : "OCORRENCIAS_OFF",
                //ALERTAS: $scope.ALERTAS === true ? "NOTIFICACAO_ON" : "NOTIFICACAO_OFF",               

                CRIAR: $scope.CRIAR === true ? "CRIAR_ON" : "CRIAR_OFF",
                EDITAR: $scope.EDITAR === true ? "EDITAR_ON" : "EDITAR_OFF",
                PESQUISA: $scope.PESQUISA === true ? "PESQUISA_ON" : "PESQUISA_OFF",
               
                NOME_PERFIL: $scope.NomePerfil,

                ACAO_FULL: $scope.ACAO_FULL === true ? "ACAO_FULL_ON" : "ACAO_FULL_OFF",
                ACESSO_TOTAL: $scope.ACESSO_TOTAL === true ? "ACESSO_TOTAL_ON" : "ACESSO_TOTAL_OFF",

                SISTEMA: "1"
            };
            

            $http.post("/api/Perfil/createperfil", JSON.stringify(PerfilDados)).then(function (response) {

                if (response.data === "OK") {
                    var url = $window.location;
                    $window.location = "http://localhost:5001/Perfil/Perfil";
                }
            });
        };

        //$scope.Logins();


    }]);