/* La abstracción no es más que un molde o plantilla
para otras clases las cuales tienen cosas en común. 
Ejemplo: en el sistema bancario existen diversos tipos 
de cuentas, todas tienen un número de cuenta, saldo y titular.
Otro ejemplo es el molde para fabricar botellas de embazado, un
mismo molde me puede crear diferentes botellas las cuales se podrían 
utilizar para embazar productos distintos pero con características en común. */



using System;

abstract class Cuenta
{
    protected string numeroCuenta;
    protected double saldo;
    protected Cliente titular;

    public Cuenta(string numeroCuenta, double saldo, Cliente titular)
    {
        this.numeroCuenta = numeroCuenta;
        this.saldo = saldo;
        this.titular = titular;
    }

    public void MostrarSaldo()
    {
       Console.WriteLine($"Saldo: RD$ {saldo}"); 
    }

    public abstract void MostrarTipoCuenta();
}