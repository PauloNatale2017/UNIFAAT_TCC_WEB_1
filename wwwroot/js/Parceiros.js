var app = angular.module('App', ['blockUI', 'ng-fusioncharts']);
var Obj;
var token = "";
var log = [];
var GoogleMaps;
var data = [];
var mapa;
var marker;
var infowindow;
var urlExternal = "http://localhost:5001/api/";


app.controller("ctlrParceiro", ['$scope', '$http', '$location', '$window', 'blockUI', '$timeout', '$interval',
    function ($scope, $http, $location, $window, blockUI, $timeout, $interval) {

        Obj = $scope;
        $scope.blockUI = blockUI;

        $scope.ParceirosLista = function (IdCadastro) {
            var loginUrlEndPoint = urlExternal + "external/externalparceiros";

            $http.get(loginUrlEndPoint).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("USUARIO OU SENHA INCORRETOS");
                    } else {
                        console.log(response.data);
                        $scope.ParceirosList = response.data;
                    }

                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
            });
        };
        
        $scope.ParceirosLista();

        $scope.SalvarVagasEmpresa = function (Id) {
            var path = window.location.origin;
            var loginUrlEndPoint = urlExternal + "external/externalvagasempresasalvar";

            $scope.IdCadastro = JSON.stringify(Id);

            var request = {
                "Id": $scope.IdCadastro,
                "NomeVaga": document.getElementById("#NomeVaga_" + $scope.IdCadastro).value,
                "AreaAtuacao": document.getElementById("#AreaAtuacao_" + $scope.IdCadastro).value,
                "Cargo": document.getElementById("#Cargo_" + $scope.IdCadastro).value,
                "Descricao": document.getElementById("#Descricao_" + $scope.IdCadastro).value,
                "FaixaSalarial": document.getElementById("#FaixaSalarial_" + $scope.IdCadastro).value,
                "HorarioTrabalho": document.getElementById("#HorarioTrabalho_" + $scope.IdCadastro).value,
                "EmailContato": document.getElementById("#EmailContato_" + $scope.IdCadastro).value,
                
            };

            console.log(request);

            $http.post(loginUrlEndPoint, request).then(function (response)
            {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    } else {                      
                        $window.location.reload();
                    }

                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
            });
        };

        $scope.ListaCadastrada = function (Id) {
            var path = window.location.origin;

            var loginUrlEndPoint = urlExternal + "external/externalvagasempresa";
            $scope.IdCadastro = JSON.stringify(Id);

            var request = { "Id": "" + Id + "" };

            $http.post(loginUrlEndPoint, request).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    } else {
                        $scope.vagasempregoLits = response.data;
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

       
    }
]);