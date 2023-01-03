//EJERCICIO 1  WHILE

Console.WriteLine("Ingrese un número");
int numero = Convert.ToInt32(Console.ReadLine());

int max_multiplicador = 10;

int indice = 0;

while (max_multiplicador > indice)
{
    indice++;
    int multiplicacion = indice * numero;

    Console.WriteLine(indice + " x " + numero + " = " + multiplicacion);
}


//EJERCICIO 2 DO WHILE

//Console.WriteLine("Ingrese un número");
//int numero = Convert.ToInt32(Console.ReadLine());
//int contador = 0;


//if (numero > 0)
//{


//    do
//    {
//        contador = 10;
//        numero++;
//        Console.WriteLine(numero.ToString());

//    } while (contador > numero);
//}

//if (numero < 0)
//{


//    do
//    {
//        numero--;
//        contador = -10;
//        Console.WriteLine(numero.ToString());

//    } while (contador < numero);
//}

//if (numero == 0)
//{
//    Console.WriteLine("Número es 0");
//}


// EJERCICIO 3 FOR

//Console.WriteLine("Ingrese ancho");

//int ancho = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Ingrese alto");

//int alto = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("¿Es relleno? Indique si o no");

//string relleno = Console.ReadLine();

//bool rellenar = false;

//if (relleno == "si")
//{
//    rellenar = true;
//}

//Console.WriteLine("¿Repetir Figura? Indique si o no");

//string repetido = Console.ReadLine();

//bool repetir = false;

//if (repetido == "si")
//{
//    repetir = true;
//}


//for (int i = 1; i <= alto; i++)
//{
//    string dibujo = string.Empty;
//    int contador = 0;

//    if (rellenar == true)
//    {
//        while (contador < ancho)
//        {
//            dibujo += "*";
//            contador++;
//        }

//        if (repetir == true)
//        {
//            dibujo += " " + dibujo;
//        }
//    }
//    else
//    {
//        if (i == 1 || i == alto)
//        {
//            while (contador < ancho)
//            {
//                dibujo += "*";
//                contador++;
//            }

//            if (repetir == true)
//            {
//                dibujo += " " + dibujo;
//            }
//        }
//        else
//        {

//            while (contador < ancho)
//            {
//                if (contador == 0 || contador == ancho - 1)
//                {
//                    dibujo += "*";
//                    contador++;
//                }
//                else
//                {
//                    dibujo += " ";
//                    contador++;
//                }

//            }

//            if (repetir == true)
//            {
//                dibujo += " " + dibujo;
//            }
//        }
//    }



//    Console.WriteLine(dibujo);
//}
