
var app = angular.module('App', ['blockUI', 'ng-fusioncharts']);
var Obj;
var token = "";
var log = [];
var GoogleMaps;
var data = [];

app.controller("CtrlMapsInfracoes", ['$scope', '$http', '$location', '$window', 'blockUI', '$timeout', '$interval',
    function ($scope, $http, $location, $window, blockUI, $timeout, $interval) {

        Obj = $scope;  

        $scope.data = [];

        $scope.InitialiseMaps = function () {
            var mapOptions = {
                center: new google.maps.LatLng(-15.768466, -47.929459),
                zoom: 8,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            var map = new google.maps.Map(document.getElementById("map_canvas"), mapOptions);
            blockUI.stop();
        };

        $scope.InitialiseMaps();

        $scope.CarregaDados = function () {
            
            //$scope.data = {
            //    "label": "Food",
            //    "value": "285040"
            //}, {
            //    "label": "Apparels",
            //    "value": "146330"
            //}, {
            //    "label": "Electronics",
            //    "value": "105070"
            //}, {
            //    "label": "Household",
            //    "value": "49100"
            //};

            $http.get("/api/Users").then(function (response)
            {
              
            });
            //$scope.data = $scope.retorno;

        };

        $scope.CarregaDados();

        $scope.Bairros = {
            chart:
            {
                caption: "USUARIOS CADASTRADOS",
                //subCaption: "Bairros mais afetados pela violencia",
                xAxisName: "Bairros",
                yAxisName: "Ocorrencias",
                numbersuffix: "K",
                theme: "fusion",
                labeldisplay: "AUTO",
                yAxisNameBorderThickness: "10",
                xAxisNameFontSize: "10",
                labelFontSize: "9",
                trendValueFontSize: "9",
                palettecolors: "5d62b5,29c3be,f2726f",
                labelDisplay: "rotate", //auto, wrap, stagger, rotate and none
                useEllipsesWhenOverflow: "0",
                slantLabel: "1",
                showValues: "1",
                rotateValues: "5",
                xAxisNamePadding: "10",
                yAxisNamePadding: "10",
                exportEnabled: "1"
            },
            data: $scope.data
        };

        $scope.ConfigBaseBairros = {
            width: "100%",
            height: "189",
            Type: "pie2d",
            Source: $scope.Bairros
        };

        $scope.GrafiPie1 = function () {
            FusionCharts.ready(function () {
                var chartObj = new FusionCharts({
                    type: 'doughnut2d',
                    renderAt: 'chartPie',
                    width: '100%',
                    height: '189',
                    dataFormat: 'json',
                    dataSource: {
                        "chart": {
                            "caption": "Split of Revenue by Product Categories",
                            "subCaption": "Last year",
                            "numberPrefix": "$",
                            "bgColor": "#ffffff",
                            "startingAngle": "310",
                            "showLegend": "1",
                            "defaultCenterLabel": "Total revenue: $64.08K",
                            "centerLabel": "Revenue from $label: $value",
                            "centerLabelBold": "1",
                            "showTooltip": "0",
                            "decimals": "0",
                            "theme": "fusion"
                        },
                        "data": [{
                            "label": "Food",
                            "value": "28504"
                        }, {
                            "label": "Apparels",
                            "value": "14633"
                        }, {
                            "label": "Electronics",
                            "value": "10507"
                        }, {
                            "label": "Household",
                            "value": "4910"
                        }]
                    }
                });
                chartObj.render();
            });
        };


        $scope.GrafiColumn = function () {
            FusionCharts.ready(function () {
                var chartObj = new FusionCharts({
                    type: 'column2d',
                    renderAt: 'chartColumn',
                    width: '100%',
                    height: '189',
                    dataFormat: 'json',
                    dataSource: {
                        "chart": {
                            "caption": "Monthly revenue for last year",
                            "subCaption": "Harry's SuperMart",
                            "xAxisName": "Month",
                            "yAxisName": "Revenues (In USD)",
                            "numberPrefix": "$",
                            "theme": "fusion"
                        },
                        "data": [{
                            "label": "Jan",
                            "value": "420000"
                        },
                        {
                            "label": "Feb",
                            "value": "810000"
                        },
                        {
                            "label": "Mar",
                            "value": "720000"
                        },
                        {
                            "label": "Apr",
                            "value": "550000"
                        },
                        {
                            "label": "May",
                            "value": "910000"
                        },
                        {
                            "label": "Jun",
                            "value": "510000"
                        },
                        {
                            "label": "Jul",
                            "value": "680000"
                        },
                        {
                            "label": "Aug",
                            "value": "620000"
                        },
                        {
                            "label": "Sep",
                            "value": "610000"
                        },
                        {
                            "label": "Oct",
                            "value": "490000"
                        },
                        {
                            "label": "Nov",
                            "value": "900000"
                        },
                        {
                            "label": "Dec",
                            "value": "730000"
                        }
                        ],
                        "trendlines": [{
                            "line": [{
                                "startvalue": "700000",
                                "valueOnRight": "1",
                                "displayvalue": "Monthly Target"
                            }]
                        }]
                    }
                });
                chartObj.render();
            });
        };

        $scope.GrafiColumn();
        $scope.GrafiPie1();

    }
]);