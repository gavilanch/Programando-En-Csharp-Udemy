// See https://aka.ms/new-console-template for more information

using Comando.Comandos;
using Comando.Modelos;
using Comando.Servicios;

var repo = new RepositorioCuentas();
var servicio = new ServicioCuentas(repo);
repo.Guardar(new Cuenta { Titular = "Felipe", Saldo = 100m });
repo.Guardar(new Cuenta { Titular = "Claudia", Saldo = 50m });

var invocador = new Invocador();

Console.WriteLine("Estatus inicial");
repo.EscribirEnConsola();

Console.WriteLine("Transfiriendo 10$ a Felipe");
var comandoDepositarAFelipe = new ComandoDepositar(servicio, "Felipe", 10m);
invocador.Ejecutar(comandoDepositarAFelipe);
repo.EscribirEnConsola();

Console.WriteLine("Deshaciendo última operación");
invocador.Deshacer();
repo.EscribirEnConsola();

Console.WriteLine("Rehaciendo la última operación");
invocador.Rehacer();
repo.EscribirEnConsola();


Console.WriteLine("Retiro de 15$ a Claudia");
var comandoRetirarClaudia = new ComandoRetirar(servicio, "Claudia", 15m);
invocador.Ejecutar(comandoRetirarClaudia);
repo.EscribirEnConsola();
