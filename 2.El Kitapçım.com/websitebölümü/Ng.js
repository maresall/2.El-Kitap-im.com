var app = angular.module("2.ElKitap", ["ngRoute"]);
app.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "main.html"
        })
        .when("/Login", {
            templateUrl: "Login.html",
            controller: "LoginController"
        })
        .when("/green", {
            templateUrl: "green.htm"
        })
        .when("/blue", {
            templateUrl: "blue.htm"
        });
    .when("/blue", {
        templateUrl: "blue.htm"
    });
    .when("/blue", {
        templateUrl: "blue.htm"
    });

    var app = angular.module("myApp", ["ngRoute"]);
app.config(function($routeProvider) {
    $routeProvider
    .when("/", {
        templateUrl : "main.htm"
    })
    .when("/red", {
        templateUrl : "red.htm"
    })
    .when("/green", {
        templateUrl : "green.htm"
    })
    .when("/blue", {
        templateUrl : "blue.htm"
    });
});

    app.controller('LoginController', function ($scope, $http) {

        $http.get("https://localhost:44303/api/Kullanicilar/KullanicilariGetir")
            .then(function (response) {
                $scope.kullaniciListele = response.data;
            });

        $scope.kullanicikayit = function (kuladsoyad, kulmail, kulsifre, kultelofon, kuladres, kuldogum) {

            kulVeri = {

                AdSoyad: kuladsoyad,
                Mail: kulmail,
                Sifre: kulsifre,
                Telefon: kultelofon,
                Adres: kuladres,
                DogumTarihi: kuldogum
            }


            $http.get("https://localhost:44303/api/Kullan%C4%B1c%C4%B1lar/Kullan%C4%B1c%C4%B1Ekle", kulVeri)
                .then(function (response) {
                    $scope.kullaniciListele = response.data;
                });


        }
    });

});