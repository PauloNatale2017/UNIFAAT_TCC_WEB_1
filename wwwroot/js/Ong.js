
var app = angular.module('App', ['blockUI', 'ng-fusioncharts']);
var Obj;
var token = "";
var urlExternal = "http://localhost:5001/api/";



app.controller("CtrlOng", ['$scope', '$http', '$location', '$window', 'blockUI', '$timeout', '$interval',
    function ($scope, $http, $location, $window, blockUI, $timeout, $interval) {
        
        Obj = $scope;

        $scope.values = [];

        $scope.AdminPerfil = function () {

            var path = window.location.origin;
            var loginUrlEndPoint = urlExternal + "external/externalgerperfillall";

            blockUI.start("CARREGANDO...");

            $http.get(loginUrlEndPoint).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    }
                    else {
                        console.log(response.data);

                        angular.forEach(response.data, function (value, index) {
                            $scope.values.push({ "Descricao": value.NomePerfil, "Id": value.Id });
                            console.log(value);

                        });
                 
                        //$scope.values = response.data;
                    }

                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
            });
            blockUI.stop();

        };


        $scope.ListaFuncionarios = function (id) {

            var path = window.location.origin;
            var loginUrlEndPoint = urlExternal + "external/externalongsfunc?id=" + id;

            blockUI.start("CARREGANDO...");

            $http.post(loginUrlEndPoint).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert(response.data);
                    } else {
                        console.log(response.data);
                        $scope.OngsFuncLogin = response.data;
                    }

                }
                else {
                    alert(response.data);
                }
            }, function (response) {
                alert(response.data);
                $window.location = "http://localhost:5001/Ong/Ong";
            });

            blockUI.stop();
        };

        $scope.BuscaOngsFnc = function () {
           
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

            var path = window.location.origin;
            var loginUrlEndPoint = urlExternal + "external/externalongssave";

            var idusuario = JSON.stringify(Id);

            var acesss = document.getElementById("#PerfilSelec_" + idusuario).value;

            var request = {
                "NomeCompleto": document.getElementById("#NomeCompleto_" + idusuario).value,
                "Cargo": document.getElementById("#Cargo_" + idusuario).value,
                "Email": document.getElementById("#Email_" + idusuario).value,
                "IdOng": document.getElementById("#IdOng_" + idusuario).value,
                "Perfil": acesss               
            };


            $http.post(loginUrlEndPoint, request).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert(response.data);
                    } else {                      
                        $window.location = "http://localhost:5001/Ong/Ong";
                    }

                } else {
                    alert(response.data);
                }
            }, function (response) {
                    alert(response.data);
                    $window.location = "http://localhost:5001/Ong/Ong";
            });
        };

        $scope.EditOng = function (id) {
            $window.location = "http://localhost:5001/Ong/EditOng?id=" + id;            
        };

        $scope.DeleteOng = function (Id) {


            var path = window.location.origin;
            var loginUrlEndPoint = urlExternal + "external/externalongsdelete";

            var idusuario = JSON.stringify(Id);

            var request = { "Id": idusuario };


            $http.post(loginUrlEndPoint, request).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    } else {
                        $window.location = "http://localhost:5001/Ong/Ong";
                    }

                } else {
                    alert("ONG NÂO CADASTRADA");
                }
            });
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
                        $window.location = "http://localhost:5001/GeoReferencia/GeoReferencia";
                    }

                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
            });
        };

        $scope.EmailValida = function (id) {

            var con = id.toString();
            var emailvalue = document.getElementById("#Email_" + con).value;
            if (emailvalue !== "") {
                $scope.EmailValidaFunc(emailvalue);
            } else { $("#emailvalid").text(""); }

        };

        $scope.EmailValidaFunc = function (email) {
            var reg = /^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/;
            
            $("#emailvalid").text("");
            if (reg.test(email)) {
                $("#emailvalid").text("EMAIL VALIDO.");
                $scope.COLOR_TEXT = "text-success";
            }
            else {
                $("#emailvalid").text("EMAIL INVALIDO.");
                $scope.COLOR_TEXT = "text-danger";
            }
        };

        $scope.BuscaOngsFnc();

        $scope.AdminPerfil();

 }]);