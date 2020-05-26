var app = angular.module('App', ['blockUI', 'ng-fusioncharts']);
var Obj;
var token = "";
var log = [];
var GoogleMaps;
var data = [];
var mapa;
var marker;
var infowindow;
var urlExternal = "https://localhost:5001/api/";



app.controller("VitimasCompleto", ['$scope', '$http', '$location', '$window', 'blockUI', '$timeout', '$interval',
    function ($scope, $http, $location, $window, blockUI, $timeout, $interval) {

        Obj = $scope;
       

        //$scope.TOTALGERAL = "187";
        //$scope.VagaNome = "AUXILIAR DE INFERMAGEM";
        //$scope.ValorSalario = "de 1.589.30 a 2.500,00";
        //$scope.Descricao = "A Korn Ferry está assessorando uma Instituição da área médica, que visa contratar: AUXILIAR DE ENFERMAGEM sintomas, executar tratamentos especificamente prescritos ou de rotina, além de outras atividades de enfermagem leitura, para subsídio de diagnóstico; ";
        //$scope.TotaDeVagas = "6";

        blockUI.start();

        $scope.SalvarComplemento = function (IdUsuario) {
            var path = window.location.origin;
            var model = {
                "UsuarioId": IdUsuario
            };

            $http.post(path+"api/vitimas/cadastrocomplementar", model).then(function () {

            });

        };

        $scope.Enviar = function (idVaga, IdUsuario, Email) { 

            var path = window.location.origin;

            var model = {
                "VagaId": idVaga,
                "UsuarioId": IdUsuario,
                "Email": Email
            };

            $http.post("Home/EnviarEmail", model).then(function () {

            });

            alert("CANDIDATURA ENVIADA COM SUCESSO");
        };

        $scope.CadastroBasicos = function () {  
            var path = window.location.origin;
            var loginUrlEndPoint = path + "/api/vitimas/cadastrosbasicos";
            $http.get(loginUrlEndPoint).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    } else {
                        $scope.CadastroBasico = response.data;
                        $scope.TOTALCADASTRADOINCOM = response.data.length;
                        console.log(response.data);
                        blockUI.stop();
                    }

                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
            });
        };

        $scope.GetVagas = function () {
          
            var loginUrlEndPoint = urlExternal + "external/externalvagas";

            $http.get(loginUrlEndPoint).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                           alert("USUARIO OU SENHA INCORRETOS");
                    } else {
                        $scope.DadosVagas = response.data;
                        $scope.TotaDeVagas = response.data.length;
                        console.log(response.data);
                    }

                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
            });
        };

        $scope.CadastroBasicos();

    }
]);