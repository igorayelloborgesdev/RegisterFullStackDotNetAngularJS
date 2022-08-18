app.controller("myCtrl", function($scope, $http) {
    $scope.firstName = "Teste";
    $scope.lastName= "1";

    $scope.class = "";

    this.ConsultarSetores = function() {
        $http.get('http://localhost:60490/api/setor').then(function mySuccess(response) {
            console.log(response);
        }, function myError(response) {    

        });
    };
    $scope.Consultar = function () {
        console.log('test');
     }

     $scope.AbrirFecharDropDown = function () {
        console.log('AbrirFecharDropDown');
        $scope.class = $scope.class == "show" ? "" : "show";
     }


    this.ConsultarSetores();



  });