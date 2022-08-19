app.controller("myCtrl", function($scope, $http) {
    $scope.firstName = "Teste";
    $scope.lastName= "1";



    $scope.class = "";
    $scope.cargosList = [];
    $scope.cargoSelecionadoNome = "";
    $scope.cpf = "";        
    $scope.responseObjDadosPessoaisList = [];
    $scope.responseObjDadosPessoais = {};
    $scope.funcionarioSelecionado = 0;    
    $scope.isLoading = false;
    $scope.id = 0;    
    $scope.paginacaoId = 0;

    // $scope.requestObject = {//TESTE
    //     Nome_Completo: "Claudio", 
    //     Nome_Social: "Taffarel",
    //     RG: "000000001",
    //     CPF: "00000000001",
    //     Data_Nascimento: "1960-03-01",
    //     Descricao: "Meio - Campo",
    //     Salario: 10000.00,
    //     Data_Inicio: "2012-02-21",
    //     Data_Encerramento: null,
    //     setor: 1,
    //     Logradouro: "Av Paulista",
    //     Numero: "123",
    //     Cidade: "São Paulo",
    //     Cep: "01234567",
    //     Complemento: null,
    //     Estado: "SP",
    //     Ddd: "11",
    //     Celular: "987654321",
    //     Residencial: null
    // }

    $scope.requestObject = {
        Nome_Completo: null, 
        Nome_Social: null,
        RG: null,
        CPF: null,
        Data_Nascimento: null,
        Descricao: null,
        Salario: 0.0,
        Data_Inicio: null,
        Data_Encerramento: null,
        setor: 0,
        Logradouro: null,
        Numero: null,
        Cidade: null,
        Cep: null,
        Complemento: null,
        Estado: null,
        Ddd: null,
        Celular: null,
        Residencial: null
    }

    $scope.requestObjectRESET = {
        Nome_Completo: null, 
        Nome_Social: null,
        RG: null,
        CPF: null,
        Data_Nascimento: null,
        Descricao: null,
        Salario: 0.0,
        Data_Inicio: null,
        Data_Encerramento: null,
        setor: 0,
        Logradouro: null,
        Numero: null,
        Cidade: null,
        Cep: null,
        Complemento: null,
        Estado: null,
        Ddd: null,
        Celular: null,
        Residencial: null
    }


    this.ConsultarSetores = function() {
        $scope.isLoading = true;
        $http.get('http://localhost:60490/api/setor').then(function mySuccess(response) {            
            $scope.cargosList = response.data.responseObjList;                                                                                
            $scope.isLoading = false;
        }, function myError(response) {    
            console.log(response);
            $scope.isLoading = false;
        });
    };


    $scope.ConsultarTodos = function() {
        $scope.isLoading = true;
        $http.get('http://localhost:60490/api/cadastro/todos/' + $scope.paginacaoId).then(function mySuccess(response) {                        
            $scope.responseObjDadosPessoaisList = response.data.responseObjDadosPessoaisList;
            $scope.SelecionarFuncionarioPadrao();
            $scope.MostrarDetalheFuncionario($scope.responseObjDadosPessoaisList[0]);
            $scope.isLoading = false;
        }, function myError(response) {    
            console.log(response);
            $scope.isLoading = false;
        });
    };

    $scope.ConsultarPorCPF = function() {
        $scope.isLoading = true;
        $http.get('http://localhost:60490/api/cadastro/porCPF/' + $scope.cpf).then(function mySuccess(response) {                                    
            $scope.responseObjDadosPessoais = response.data.responseObjDadosPessoais;            
            $scope.MostrarDetalheFuncionario($scope.responseObjDadosPessoais);
            $scope.isLoading = false;
        }, function myError(response) {    
            console.log(response);
            $scope.isLoading = false;
        });
    };

    $scope.ConsultarPorId = function() {
        $scope.isLoading = true;
        $http.get('http://localhost:60490/api/cadastro/porId/' + $scope.id).then(function mySuccess(response) {
            $scope.responseObjDadosPessoais = response.data.responseObjDadosPessoais;            
            $scope.isLoading = false;
        }, function myError(response) {    
            console.log(response);
            $scope.isLoading = false;
        });
    };

    $scope.Excluir = function(cpfExcluir) {
        $scope.isLoading = true;
        $http.delete('http://localhost:60490/api/cadastro/excluirPorCPF/' + cpfExcluir).then(function mySuccess(response) {
            $scope.ConsultarTodos();
            $scope.isLoading = false;
        }, function myError(response) {    
            console.log(response);
            $scope.isLoading = false;
        });
    };

    $scope.Cadastrar = function() {
        $scope.isLoading = true;
        $http.post('http://localhost:60490/api/cadastro/Cadastrar/', $scope.requestObject).then(function mySuccess(response) {
            $scope.ConsultarTodos();   
            $scope.isLoading = false;         
        }, function myError(response) {    
            console.log(response);
            $scope.isLoading = false;
        });
    };

    $scope.Alterar = function() {
        $scope.isLoading = true;
        $http.put('http://localhost:60490/api/cadastro/Alterar/', $scope.requestObject).then(function mySuccess(response) {
            $scope.ConsultarTodos();            
            $scope.isLoading = false;
        }, function myError(response) {    
            console.log(response);
            $scope.isLoading = false;
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
        $scope.requestObject.Id = id + 1;
        $scope.requestObject.setor = id + 1;
        $scope.AbrirFecharDropDown()
     }

     $scope.SelecionarFuncionario = function (id)
     {
        $scope.funcionarioSelecionado = id;        
     }

     $scope.SelecionarFuncionarioPadrao = function ()
     {
         if($scope.responseObjDadosPessoaisList.length > 0)
         {
            $scope.funcionarioSelecionado = $scope.responseObjDadosPessoaisList[0].Id;
         }        
     }
     
     $scope.ExcluirFuncionario = function (cpf)
     {
        $scope.Excluir(cpf);
     }

     $scope.MostrarDetalheFuncionario = function (responseObjDadosPessoais)
     {
        $scope.SelecionarFuncionario(responseObjDadosPessoais.Id);

        $scope.requestObject.CPF = responseObjDadosPessoais.CPF;
        $scope.requestObject.Data_Nascimento = responseObjDadosPessoais.Data_Nascimento;
        $scope.requestObject.Id = responseObjDadosPessoais.Id;
        $scope.requestObject.Nome_Completo = responseObjDadosPessoais.Nome_Completo;
        $scope.requestObject.Nome_Social = responseObjDadosPessoais.Nome_Social;
        $scope.requestObject.RG = responseObjDadosPessoais.RG;

        $scope.requestObject.Data_Encerramento = responseObjDadosPessoais.cargo.Data_Encerramento;
        $scope.requestObject.Data_Inicio = responseObjDadosPessoais.cargo.Data_Inicio;
        $scope.requestObject.Descricao = responseObjDadosPessoais.cargo.Descricao;
        $scope.requestObject.Id = responseObjDadosPessoais.cargo.setorRef.Id;
        $scope.requestObject.Salario = responseObjDadosPessoais.cargo.Salario;
        $scope.requestObject.setor = responseObjDadosPessoais.cargo.setorRef.Id;
        $scope.cargoSelecionadoNome = $scope.cargosList[responseObjDadosPessoais.cargo.setorRef.Id - 1].Descricao;

        $scope.requestObject.Cep = responseObjDadosPessoais.endereco.Cep;
        $scope.requestObject.Cidade = responseObjDadosPessoais.endereco.Cidade;
        $scope.requestObject.Complemento = responseObjDadosPessoais.endereco.Complemento;
        $scope.requestObject.Estado = responseObjDadosPessoais.endereco.Estado;
        $scope.requestObject.Logradouro = responseObjDadosPessoais.endereco.Logradouro;
        $scope.requestObject.Numero = responseObjDadosPessoais.endereco.Numero;

        $scope.requestObject.Celular = responseObjDadosPessoais.telefones.Celular;
        $scope.requestObject.Ddd = responseObjDadosPessoais.telefones.Ddd;
        $scope.requestObject.Residencial = responseObjDadosPessoais.telefones.Residencial;
     }

    this.ConsultarSetores();



  });