using System;

namespace Seccion1
{
    class Program
    {
        static void Main(string[] args)
        {   
            short a =32767; //de -32768 a 32767
            int b = 2147483647; //de -2147483648 a 2147483647
            long c = -9223372036854775808;// -9223372036854775808 de a 9223372036584775807
            float d = 1231.51f;//almacena numeros y decimales solo hasta 7 digitos al final debe colocarse una f
            double e =  1231.51d;//Nospermite almacenar numeros y deicmales hasta 16 digitos al final debe colocarse una d
            decimal f = 1231.51m;//es el mas preciso de todos almacena de 29 digitos al final debe colocarse una m
            char g = 'a'; //char representa un digito nadamas
            string h = "palabra"; //representa varios caracteres
            bool exito = false;//booleanos representan verdadero o falso
            bool vida = true;

            Console.WriteLine("Hello World!"+" "+a+" "+b+" "+c+" "+d+" "+e+" "+f+" "+g+" "+h+" "+exito+" "+vida);

            //Operaciones con numeros 
            int uno = 50;
            int dos = 40;
            double tres = 20.5;

            //operaciones guardadas en variables
            int suma = uno +dos;
            int resta = uno-dos;
            int mutiplicacion = uno*dos;
            double sumadecimal = dos +tres;
            double divicion = (uno *1.0)/dos; //mulplicamos la variable "a" por 1.0 para volverla decimal y ya con esto resolvemos el que nos devulva los decimales de la divicion
            int residuo = uno%dos; //el residuo nos devuelve la diferencia que ya entre dos numeros

            //mostramos los resultado en consola
            Console.WriteLine("suma:"+" "+suma+" \n"+"resta:"+c+" "+resta+" \n"+"multiplicacion:"+" "+mutiplicacion+" \n"+"sumadecimal:"+" "+sumadecimal+" \n"+"divicion:"+" "+divicion+" \n"+"residuo:"+" "+residuo+" \n");
            
            //operaciones con cadenas
            //los tipos string solo se puede sumar entre ellos o con aquellos de tipo numerico
            string pa = "hola";
            string la = "mundo";
            Console.WriteLine(pa+" "+la+1);



            /**convertir un tipo de dato a otro
             */
             string numero = "20";
             int numeroconvertido = int.Parse(numero);
             int resultado = numeroconvertido +10;
             Console.WriteLine(resultado);


             //para convertir un tipo entero s string usamos 
             // ToString()

             int num = 10;
             string cadenanueva = num.ToString();
             Console.WriteLine(cadenanueva);

             /* programa para ingresar dos numeros
              sumarlos y 
              mostrar el resultado*/
              Console.WriteLine("Ingresa el primer numero a sumar: ");
              string n1 = Console.ReadLine();
              int numParseado = int.Parse(n1);

              Console.WriteLine("Ingresa el segundo numero a sumar: ");
              string n2 = Console.ReadLine();
              int num2Parseado = int.Parse(n2);

              int sumNumeros = numParseado+num2Parseado;
              Console.WriteLine("El resultado de la suma es: "+sumNumeros);
              Console.ReadLine();

              /*Ejercicio que nos permita calcular el area de un triangulo */
    }
    }
}
