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
        $scope.blockUI = blockUI;

        $scope.COMPL_POR = 0;

       

        $scope.SalvarComplemento = function (IdUsuario)
        {
            var path = window.location.origin;    

            var request = {
                "IdCadastroBasico": IdUsuario,

                "Profissao": document.getElementById("#Profissao_"+IdUsuario).value,
                "RendaPessoal": document.getElementById("#RendaPessoal_"+IdUsuario).value,
                "RendaFamiliar": document.getElementById("#RendaFamiliar_" + IdUsuario).value,

                "drogaslicitasSIM": document.getElementById("#drogaslicitasSIM_" + IdUsuario).value,
                "drogaslicitasNAO": document.getElementById("#drogaslicitasNAO_" + IdUsuario).value,

                "QualdrogaDescri1": document.getElementById("#QualdrogaDescri1_"+IdUsuario).value,               
                "QualdrogaDescri2": document.getElementById("#QualdrogaDescri2_" + IdUsuario).value,

                "Possuifilhos": document.getElementById("#Possuifilhos_"+IdUsuario).value,
                "Qtdo": document.getElementById("#Qtdo_" + IdUsuario).value,

                "Idoso": document.getElementById("#Idoso_"+IdUsuario).value,
                "Quantidade": document.getElementById("#Quantidade_" + IdUsuario).value              
            };

            $http.post(path + "/api/vitimas/cadastrocomplementar", request).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    } else {   

                        var stylodoc = document.getElementById("#BTN_COMPLEMENTAR_" + IdUsuario);
                        stylodoc.style.backgroundColor = "green";
                        stylodoc.style.color = "white";
                        stylodoc.style.border = "green";
                       
                        

                        blockUI.stop();
                    }

                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
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

        $scope.SalvarOcorrencias = function (IdUsuario) {
            var path = window.location.origin;

            var request = {
                "IdCadastroBasico": IdUsuario,
                "TipoViolencia": document.getElementById("#TipoViolencia_" + IdUsuario).value,
                "DiaOcorrido": document.getElementById("#DiaOcorrido_" + IdUsuario).value,
                "LocalOcorrido": document.getElementById("#LocalOcorrido_" + IdUsuario).value,
                "Testemunha": document.getElementById("#Testemunha_" + IdUsuario).value,
                //"UsodeDrogasIlicitas": document.getElementById("#UsodeDrogasIlicitas_" + IdUsuario).value,
                //"UsodeDrograsLicitas": document.getElementById("#UsodeDrograsLicitas_" + IdUsuario).value,
                "VinculocomAgressor": document.getElementById("#VinculocomAgressor_" + IdUsuario).value,
                //"BOSIM": document.getElementById("#BOSIM_" + IdUsuario).value,
                //"BONAO": document.getElementById("#BONAO_" + IdUsuario).value,
                "NumeroBO": document.getElementById("#NumeroBO_" + IdUsuario).value
            };

            $http.post(path + "/api/vitimas/cadastroocorrencias", request).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    } else {

                        var stylodoc = document.getElementById("#BTN_OCORRENCIA_" + IdUsuario);
                        stylodoc.style.backgroundColor = "green";
                        stylodoc.style.color = "white";
                        stylodoc.style.border = "green";



                        blockUI.stop();
                    }

                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
            });
        };

        $scope.SalvarFilhos = function (IdUsuario) {
            var path = window.location.origin;

            var request = {
                "IdCadastroBasico": IdUsuario,
                "Nomefilho": document.getElementById("#Nomefilho_" + IdUsuario).value,
                "Escolaondeestuda": document.getElementById("#Escolaondeestuda_" + IdUsuario).value,
                "DataNascimento": document.getElementById("#DataNascimento_" + IdUsuario).value,
                "Enderecoescola": document.getElementById("#Enderecoescola_" + IdUsuario).value,
                "Qualnecessidade": document.getElementById("#Qualnecessidade_" + IdUsuario).value
            };

            $http.post(path + "/api/vitimas/cadastrofilhos", request).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    } else {

                        var stylodoc = document.getElementById("#BTN_FILHOS_" + IdUsuario);
                        stylodoc.style.backgroundColor = "green";
                        stylodoc.style.color = "white";
                        stylodoc.style.border = "green";
                        document.getElementById("#SPA_FILHOSPOR_" + $scope.basic[i].Id).innerText = "100";
                        blockUI.stop();
                    }

                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
            });
        };

        $scope.BuscaFilhos = function (id) {

            var path = window.location.origin;

            var request = { "IdCadastroBasico": "" + id + ""  };

            $http.post(path + "/api/vitimas/buscafilhos", request).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    } else {
                        console.log("filhos");
                        console.log(response.data);
                        $scope.filhosLits = response.data;

                        for (var i = 0; i < response.data.length; i++) {
                            var stylodoc = document.getElementById("#BTN_FILHOS_" + response.data[i].IdCadastroBasico);
                            stylodoc.style.backgroundColor = "green";
                            stylodoc.style.color = "white";
                            stylodoc.style.border = "green";
                            $scope.SPA_FILHOSPOR_ = 100;
                            break;
                        }

                        blockUI.stop();
                    }
                                        
                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
            });
        };

        $scope.BuscaIdoso = function (id) {

            var path = window.location.origin;

            var request = { "IdCadastroBasico": "" + id + "" };

            $http.post(path + "/api/vitimas/buscaidoso", request).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    } else {
                        $scope.IdososLits = response.data;

                        for (var i = 0; i < response.data.length; i++) {
                            var stylodoc = document.getElementById("#BTN_IDOSOS_" + response.data[i].IdCadastroBasico);
                            stylodoc.style.backgroundColor = "green";
                            stylodoc.style.color = "white";
                            stylodoc.style.border = "green";
                            $scope.SPA_FILHOSPOR_ = 100;
                            break;
                        }
                        console.log(response.data);
                        blockUI.stop();
                    }

                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
            });
        };

        $scope.SalvarIdoso = function (IdUsuario) {
            var path = window.location.origin;

            var request = {
                "IdCadastroBasico": IdUsuario,
                "Nomoidoso": document.getElementById("#Nomoidoso_" + IdUsuario).value,
                "DataNascimento": document.getElementById("#DataNascimento_" + IdUsuario).value,
                "Qual": document.getElementById("#Qual_" + IdUsuario).value
            };

            $http.post(path + "/api/vitimas/cadastroidoso", request).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    } else {

                        var stylodoc = document.getElementById("#BTN_IDOSOS_" + IdUsuario);
                        stylodoc.style.backgroundColor = "green";
                        stylodoc.style.color = "white";
                        stylodoc.style.border = "green";
                        document.getElementById("#SPA_IDOSOPOR_" + $scope.basic[i].Id).innerText = "100";
                        blockUI.stop();
                    }

                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
            });
        };

      

        $scope.CadastroBasicos = function () {  
            var path = window.location.origin;
            var loginUrlEndPoint = path + "/api/vitimas/cadastrosbasicos";
            blockUI.start("CARREGANDO...");

            $http.get(loginUrlEndPoint).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    }
                    else
                    {

                        $scope.basic = response.data.vitimabasic;
                        $scope.complementar = response.data.complementar;
                        $scope.ocorrencias = response.data.ocorrencias;
                        $scope.filhos = response.data.filhos;
                        $scope.Idoso = response.data.Idoso;
                        $scope.sos = response.data.sos;
                        

                        $scope.CadastroBasico = $scope.basic;
                        $scope.TOTALCADASTRADOINCOM = $scope.basic.length;

                        setTimeout(function () {
                            for (var i = 0; i < $scope.basic.length; i++) {
                              
                                var retornoFilter = $scope.complementar.filter(function (values) { return values.IdCadastroBasico === $scope.basic[i].Id; });

                                if (retornoFilter.length > 0) {                               
                                    var stylodoc = document.getElementById("#BTN_COMPLEMENTAR_" + $scope.basic[i].Id);
                                        stylodoc.style.backgroundColor = "green";
                                        stylodoc.style.color = "white";
                                    stylodoc.style.border = "green";      
                     
                                    document.getElementById("#SPA_COMPLPOR_" + $scope.basic[i].Id).innerText = "100";
                                   
                               }
                            }
                            $scope.blockUI.stop();                            
                        }, 3000);

                        setTimeout(function () {
                            for (var i = 0; i < $scope.basic.length; i++) {

                                var retornoFilter = $scope.ocorrencias.filter(function (values) { return values.IdCadastroBasico === $scope.basic[i].Id; });

                                if (retornoFilter.length > 0) {
                                    var stylodoc = document.getElementById("#BTN_OCORRENCIA_" + $scope.basic[i].Id);
                                    stylodoc.style.backgroundColor = "green";
                                    stylodoc.style.color = "white";
                                    stylodoc.style.border = "green";
                                    document.getElementById("#SPA_OCORRENCIAPOR_" + $scope.basic[i].Id).innerText = "100";

                                }
                            }
                            $scope.blockUI.stop();
                        }, 3000);

                        setTimeout(function () {
                            for (var i = 0; i < $scope.basic.length; i++) {

                                var retornoFilter = $scope.filhos.filter(function (values) { return values.IdCadastroBasico === $scope.basic[i].Id; });

                                if (retornoFilter.length > 0) {
                                    var stylodoc = document.getElementById("#BTN_FILHOS_" + $scope.basic[i].Id);
                                    stylodoc.style.backgroundColor = "green";
                                    stylodoc.style.color = "white";
                                    stylodoc.style.border = "green";
                                    document.getElementById("#SPA_FILHOSPOR_" + $scope.basic[i].Id).innerText = "100";                                    

                                }
                            }
                            $scope.blockUI.stop();
                        }, 3000);   

                        setTimeout(function () {
                            for (var i = 0; i < $scope.basic.length; i++) {

                                var retornoFilter = $scope.Idoso.filter(function (values) { return values.IdCadastroBasico === $scope.basic[i].Id; });

                                if (retornoFilter.length > 0) {
                                    var stylodoc = document.getElementById("#BTN_IDOSOS_" + $scope.basic[i].Id);
                                    stylodoc.style.backgroundColor = "green";
                                    stylodoc.style.color = "white";
                                    stylodoc.style.border = "green";
                                    document.getElementById("#SPA_IDOSOPOR_" + $scope.basic[i].Id).innerText = "100";
                                }
                            }
                            $scope.blockUI.stop();
                        }, 3000);   
                        
                        setTimeout(function () {
                            for (var i = 0; i < $scope.basic.length; i++) {

                                var retornoFilter = $scope.sos.filter(function (values) { return values.IdCadastroBasico === $scope.basic[i].Id; });

                                if (retornoFilter.length > 0) {
                                    var stylodoc = document.getElementById("#BTN_SOS_" + $scope.basic[i].Id);
                                    stylodoc.style.backgroundColor = "green";
                                    stylodoc.style.color = "white";
                                    stylodoc.style.border = "green";
                                    document.getElementById("#SPA_SOSPOR_" + $scope.basic[i].Id).innerText = "100";
                                }
                            }
                            $scope.blockUI.stop();
                        }, 3000);


                        console.log(response.data);
                       
                    }

                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
            });
            blockUI.stop();
        };

        $scope.Buscaomplementar = function (id) {

            var path = window.location.origin;

            var request = {
                "IdCadastroBasico": "" + id + ""
            };

            $http.post(path + "/api/vitimas/buscacomplementar", request).then(function (response) {
            if (response.status === 200) {
                if (response.data === "null") {
                    alert("RETORNO DO REQUEST NULL");
                } else {
                    $scope.Complementar = response.data;  

                    var stylodoc = document.getElementById("#BTN_COMPLEMENTAR_" + response.data.IdCadastroBasico);
                    stylodoc.style.backgroundColor = "green";
                    stylodoc.style.color = "white";
                    stylodoc.style.border = "green";
                    $scope.COMPL_POR = 100;

                    var IdUsuario = response.data.IdCadastroBasico;

                    document.getElementById("#Profissao_" + IdUsuario).value = response.data.Profissao;
                    document.getElementById("#RendaPessoal_" + IdUsuario).value = response.data.RendaPessoal;
                    document.getElementById("#RendaFamiliar_" + IdUsuario).value = response.data.RendaFamiliar;
                    document.getElementById("#drogaslicitasSIM_" + IdUsuario).value = response.data.drogaslicitasSIM;
                    document.getElementById("#drogaslicitasNAO_" + IdUsuario).value = response.data.drogaslicitasNAO;
                    document.getElementById("#QualdrogaDescri1_" + IdUsuario).value = response.data.QualdrogaDescri1;
                    document.getElementById("#QualdrogaDescri2_" + IdUsuario).value = response.data.QualdrogaDescri2;
                    document.getElementById("#Possuifilhos_" + IdUsuario).value = (response.data.PossuifilhosSIM === "1" ? "1" : "0");
                    document.getElementById("#Qtdo_" + IdUsuario).value = response.data.Qtdo;
                    document.getElementById("#Idoso_" + IdUsuario).value = (response.data.IdosoSIM ==="1"?"1":"0");
                    document.getElementById("#Quantidade_" + IdUsuario).value = response.data.Quantidade;

                    console.log(response.data);
                    blockUI.stop();
                }

            } else {
                alert("USUARIO NÂO AUTHENTICADO");
            }
            });
        };

        $scope.BuscaOcorrencias = function (id) {

            var path = window.location.origin;

            var request = {
                "IdCadastroBasico": "" + id + ""
            };

            $http.post(path + "/api/vitimas/buscaocorrencias", request).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    } else {
                        $scope.Complementar = response.data;
                        var IdUsuario = response.data.IdCadastroBasico;

                        var stylodoc = document.getElementById("#SPA_OCORRENCIAPOR_" + IdUsuario);
                        stylodoc.style.backgroundColor = "green";
                        stylodoc.style.color = "white";
                        stylodoc.style.border = "green";
                        document.getElementById("#SPA_OCORRENCIAPOR_" + IdUsuario).innerText = "100";

                      

                        document.getElementById("#TipoViolencia_" + IdUsuario).value = response.data.TipoViolencia;
                        document.getElementById("#DiaOcorrido_" + IdUsuario).value = response.data.DiaOcorrido;
                        document.getElementById("#LocalOcorrido_" + IdUsuario).value = response.data.LocalOcorrido;
                        document.getElementById("#Testemunha_" + IdUsuario).value = response.data.Testemunha;
                        document.getElementById("#VinculocomAgressor_" + IdUsuario).value = response.data.VinculocomAgressor;
                        document.getElementById("#NumeroBO_" + IdUsuario).value = response.data.NumeroBO;

                        console.log(response.data);
                        blockUI.stop();
                    }

                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
            });
        };

        $scope.SalvarSOS = function (IdUsuario) {
            var path = window.location.origin;

            var request = {
                "IdCadastroBasico": IdUsuario,
                "NomeSOS": document.getElementById("#NomeSOS_" + IdUsuario).value,
                "NumeroCelular": document.getElementById("#NumeroCelular_" + IdUsuario).value,
                "Vinculo": document.getElementById("#Vinculo_" + IdUsuario).value
            };

            $http.post(path + "/api/vitimas/cadastrosos", request).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    } else {

                        var stylodoc = document.getElementById("#BTN_SOS_" + IdUsuario);
                        stylodoc.style.backgroundColor = "green";
                        stylodoc.style.color = "white";
                        stylodoc.style.border = "green";
                        document.getElementById("#SPA_SOSPOR_" + $scope.basic[i].Id).innerText = "100";
                        blockUI.stop();
                    }

                } else {
                    alert("USUARIO NÂO AUTHENTICADO");
                }
            });
        };

        $scope.BuscaSOS = function (IdUsuario) {
            var path = window.location.origin;

            var request = { "IdCadastroBasico": "" + IdUsuario + "" };

            $http.post(path + "/api/vitimas/buscasos", request).then(function (response) {
                if (response.status === 200) {
                    if (response.data === "null") {
                        alert("RETORNO DO REQUEST NULL");
                    } else {
                        $scope.SOSLits = response.data;

                        for (var i = 0; i < response.data.length; i++) {
                            var stylodoc = document.getElementById("#BTN_SOS_" + response.data[i].IdCadastroBasico);
                            stylodoc.style.backgroundColor = "green";
                            stylodoc.style.color = "white";
                            stylodoc.style.border = "green";                         
                            break;
                        }
                       
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