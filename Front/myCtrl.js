app.controller("myCtrl", function($scope, $http) {
    $scope.firstName = "Teste";
    $scope.lastName= "1";



    $scope.class = "";
    $scope.cargosList = [];
    $scope.cargoSelecionadoNome = "";
    $scope.cpf = "";
    $scope.cpfExcluir = "00000000001";//TESTE
    $scope.id = 21;//TESTE
    $scope.responseObjDadosPessoaisList = [];
    $scope.responseObjDadosPessoais = {};
    $scope.paginacaoId = 0;


    this.ConsultarSetores = function() {
        $http.get('http://localhost:60490/api/setor').then(function mySuccess(response) {            
            $scope.cargosList = response.data.responseObjList;            
        }, function myError(response) {    
            console.log(response);
        });
    };

    $scope.ConsultarTodos = function() {
        $http.get('http://localhost:60490/api/cadastro/todos/' + $scope.paginacaoId).then(function mySuccess(response) {                        
            $scope.responseObjDadosPessoaisList = response.data.responseObjDadosPessoaisList;
        }, function myError(response) {    
            console.log(response);
        });
    };

    $scope.ConsultarPorCPF = function() {
        $http.get('http://localhost:60490/api/cadastro/porCPF/' + $scope.cpf).then(function mySuccess(response) {                                    
            $scope.responseObjDadosPessoais = response.data.responseObjDadosPessoais;            
        }, function myError(response) {    
            console.log(response);
        });
    };

    $scope.ConsultarPorId = function() {
        $http.get('http://localhost:60490/api/cadastro/porId/' + $scope.id).then(function mySuccess(response) {
            $scope.responseObjDadosPessoais = response.data.responseObjDadosPessoais;            
        }, function myError(response) {    
            console.log(response);
        });
    };

    $scope.Excluir = function() {
        $http.delete('http://localhost:60490/api/cadastro/excluirPorCPF/' + $scope.cpfExcluir).then(function mySuccess(response) {
            $scope.ConsultarTodos();
        }, function myError(response) {    
            console.log(response);
        });
    };

    $scope.Cadastrar = function() {
        $http.post('http://localhost:60490/api/cadastro/Cadastrar/').then(function mySuccess(response) {
            
        }, function myError(response) {    
            console.log(response);
        });
    };

    $scope.Consultar = function () {                
        if($scope.cpf.length != 11)
        {
            $scope.ConsultarTodos();
        }
        else
        {
            $scope.ConsultarPorCPF();
        }        
     }

     $scope.AbrirFecharDropDown = function () {        
        $scope.class = $scope.class == "show" ? "" : "show";
     }

     $scope.SelecionarCargo = function (id) {
        $scope.cargoSelecionadoNome = $scope.cargosList[id].Descricao;
        console.log($scope.cargosList[id].Descricao);
        $scope.AbrirFecharDropDown()
     }


    this.ConsultarSetores();



  });