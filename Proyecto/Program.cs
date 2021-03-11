using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proyecto {
    class Program
    { 
        static void Main(string[] args)
        {
            try
            {
                int opciones = 0;
                Console.WriteLine("Opciones: \n[1]Operaciones Basicas \n[2]Calculo de Edades \n[3]Contador y acomulador\n[4]Acomulador con Bandera\n[5]Insercion de nombres con arreglo\n[6]Determinacion de numeros pares\n[7]Salir del Programa");
                Console.WriteLine("Escoja una opcion: ");
                opciones = int.Parse(Console.ReadLine());
                switch (opciones) {
                    case 1:
                        Console.WriteLine("Vas a realizar una operacion basica");
                        Console.WriteLine();
                        int op;
                        Console.WriteLine("[1]Suma\n[2]Resta\n[3]Multiplicacion\n[4]Division");
                        op = int.Parse(Console.ReadLine());
                        switch (op)
                        {
                            case 1:
                                int numeroSuma1 = 0, numeroSuma2 = 0, resultadoSuma = 0;
                                Console.WriteLine("Digite un numero para sumar");
                                numeroSuma1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Digite un segundo numero para sumar");
                                numeroSuma2 = int.Parse(Console.ReadLine());
                                resultadoSuma = numeroSuma1 + numeroSuma2;
                                Console.WriteLine("El resultado de la suma es de: " + resultadoSuma);
                                break;
                            case 2:
                                int numeroResta1 = 0, numeroResta2 = 0, resultadoResta = 0;
                                Console.WriteLine("Digite un numero para restar");
                                numeroResta1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Digite un segundo numero para restar");
                                numeroResta2 = int.Parse(Console.ReadLine());
                                resultadoResta = numeroResta1 - numeroResta2;
                                Console.WriteLine("El resultado de la resta es de: " + resultadoResta);
                                break;
                            case 3:
                                int numeroMultiplicacion1 = 0, numeroMultiplicacion2 = 0, resultadoMultiplicacion = 0;
                                Console.WriteLine("Digite un numero para multiplicar");
                                numeroMultiplicacion1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Digite un segundo numero para multiplicar");
                                numeroMultiplicacion2 = int.Parse(Console.ReadLine());
                                resultadoResta = numeroMultiplicacion1 * numeroMultiplicacion2;
                                Console.WriteLine("El resultado de la Multiplicacion es de: " + resultadoMultiplicacion);
                                break;
                            case 4:
                                int numeroDivision1 = 0, numeroDivision2 = 0, resultadoDivision = 0;
                                Console.WriteLine("Digite un numero dividendo");
                                numeroMultiplicacion1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Digite un numero divisor");
                                numeroMultiplicacion2 = int.Parse(Console.ReadLine());
                                resultadoResta = numeroDivision1 / numeroDivision2;
                                Console.WriteLine("El resultado de la Division es de: " + resultadoDivision);
                                break;
                            default:
                                Console.WriteLine("Opcion no valida");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case 2:
                        int edad = 0;
                        int opcion = 1;
                        do
                        {
                            Console.WriteLine("Ingrese la edad");
                            edad = int.Parse(Console.ReadLine());
                            if (edad >= 18 && edad <= 35)
                            {
                                Console.WriteLine("La persona es un adulta Joven");
                            }
                            else if (edad > 35 && edad <= 61)
                            {
                                Console.WriteLine("La persona es adulta");
                            }
                            else if (edad > 61)
                            {
                                Console.WriteLine("La persona es de la tercera edad");
                            } else
                            {
                                Console.WriteLine("La persona es menor de edad");
                            }

                            Console.WriteLine("Quieres calcular mas edades, si desea salir presione 0");
                            opcion = int.Parse(Console.ReadLine());

                        } while (opcion != 0);
                        Environment.Exit(0);


                        break;
                    case 3:
                        int contador = 0;
                        int acomulador = 0;
                        int contadoResta=0;
                        int[] ultimosValores = new int[15];
                        while (contador <= 10)
                        {
                            Console.WriteLine("El valor del contador es: "+contador);
                            Console.WriteLine("El valor del acomulador es: "+acomulador);
                            //contadoResta = contador-1;
                          //  Console.WriteLine(ultimosValores[contador]+""+ultimosValores[contadoResta]);
                            contador++;
                        }

                        break;








                    default:
                        Console.WriteLine("Opcion no valida");
                        Console.ReadKey();
                        break;
                }












                //
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrio un error en la ejecucion del Programa");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
