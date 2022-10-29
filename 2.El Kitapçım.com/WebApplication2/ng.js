var app = angular.module("modul", ["ngRoute"]);



app.config(function ($routeProvider) {
    $routeProvider
        .when("/Anasayfa", {
            templateUrl: "index.html",
            controller: "KullaniciİslemleriCtrl"
        })
        .when("/kullanicilistesi", {
            templateUrl: "KulaniciListesi.html",
            controller: "KullaniciİslemleriCtrl"
        })
        .when("/kullaniciekle", {
            templateUrl: "KullaniciEkle.html",
            controller: "TumKullanicilarCtrl"
        })

});


app.controller("AnasayfaCtrl", function ($scope) {

});

app.controller("KullaniciİslemleriCtrl", function ($scope, $http) {
    $scope.deneme = "asd";
    $http.get("").then(function (response) {
        $scope.Kullanici = response.data;
    });

});
app.controller("TumKullanicilarCtrl", function ($scope) {

});
app.controller("KullaniciSilCtrl", function ($scope) {

});