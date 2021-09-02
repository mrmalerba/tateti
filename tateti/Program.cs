using System;

namespace tateti
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cuadros = {"-","-","-","-","-","-","-","-","-"};

            Console.WriteLine($"Usas la X! elejí uno de los siguiente cuadros: \n\n    a   b   c \n\n      :   :   \n 1    :   :   \n      :   :   \n   -----------\n      :   :   \n 2    :   :   \n      :   :   \n   -----------\n      :   :   \n 3    :   :   \n      :   :   ");
            
            //Esta asquerosidad cicla los turnos del jugador y la computadora, al final del turno del jugador y la computadora chequea si existe alguna combinacion ganadora y le avisa al jugador.
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Que columna?(a, b, c): ");
                string columna = Console.ReadLine();

                if (columna == "a" || columna == "b" || columna == "c")
                {
                        Console.WriteLine("Que linea?(1, 2, 3, etc): ");
                        string linea = Console.ReadLine();

                        if (linea == "1" || linea == "2" || linea == "3") // una vez que cheque la seleccion de columnas y lineas son correctas, chequea las combinaciones y si ya fueron elejidas previamente, si no cambia el item del array por una X.
                        {
                            if (columna == "a" && linea == "1") 
                            {
                                if (cuadros[0] == "X" || cuadros[0] == "O")
                                {
                                    Console.WriteLine("El cuadro ya esta siendo utilizado! Elejí otro!");
                                    i--;
                                }
                                else
                                {
                                    cuadros[0] = "X";
                                }
                            }
                            else if (columna == "b" && linea == "1")
                            {
                                if (cuadros[1] == "X" || cuadros[1] == "O")
                                {
                                    Console.WriteLine("El cuadro ya esta siendo utilizado! Elejí otro!");
                                    i--;
                                }
                                else
                                {
                                    cuadros[1] = "X";
                                }
                            }
                            else if (columna == "c" && linea == "1")
                            {
                                if (cuadros[2] == "X" || cuadros[2] == "O")
                                {
                                    Console.WriteLine("El cuadro ya esta siendo utilizado! Elejí otro!");
                                    i--;
                                }
                                else
                                {
                                    cuadros[2] = "X";
                                }
                            }
                            else if (columna == "a" && linea == "2")
                            {
                                if (cuadros[3] == "X" || cuadros[3] == "O")
                                {
                                    Console.WriteLine("El cuadro ya esta siendo utilizado! Elejí otro!");
                                    i--;
                                }
                                else
                                {
                                    cuadros[3] = "X";
                                }
                            }
                            else if (columna == "b" && linea == "2")
                            {
                                if (cuadros[4] == "X" || cuadros[4] == "O")
                                {
                                    Console.WriteLine("El cuadro ya esta siendo utilizado! Elejí otro!");
                                    i--;
                                }
                                else
                                {
                                    cuadros[4] = "X";
                                }
                            }
                            else if (columna == "c" && linea == "2")
                            {
                                if (cuadros[5] == "X" || cuadros[5] == "O")
                                {
                                    Console.WriteLine("El cuadro ya esta siendo utilizado! Elejí otro!");
                                    i--;
                                }
                                else
                                {
                                    cuadros[5] = "X";
                                }
                            }
                            else if (columna == "a" && linea == "3")
                            {
                                if (cuadros[6] == "X" || cuadros[6] == "O")
                                {
                                    Console.WriteLine("El cuadro ya esta siendo utilizado! Elejí otro!");
                                    i--;
                                }
                                else
                                {
                                    cuadros[6] = "X";
                                }
                            }
                            else if (columna == "b" && linea == "3")
                            {
                                if (cuadros[7] == "X" || cuadros[7] == "O")
                                {
                                    Console.WriteLine("El cuadro ya esta siendo utilizado! Elejí otro!");
                                    i--;
                                }
                                else
                                {
                                    cuadros[7] = "X";
                                }
                            }
                            else if (columna == "c" && linea == "3")
                            {
                                if (cuadros[8] == "X" || cuadros[8] == "O")
                                {
                                    Console.WriteLine("El cuadro ya esta siendo utilizado! Elejí otro!");
                                    i--;
                                }
                                else
                                {
                                    cuadros[8] = "X";
                                }
                            }
                            Console.WriteLine($"\nElejiste {columna}-{linea}!: \n\n    a   b   c \n\n      :   :   \n 1  {cuadros[0]} : {cuadros[1]} : {cuadros[2]} \n      :   :   \n   -----------\n      :   :   \n 2  {cuadros[3]} : {cuadros[4]} : {cuadros[5]} \n      :   :   \n   -----------\n      :   :   \n 3  {cuadros[6]} : {cuadros[7]} : {cuadros[8]} \n      :   :   ");
                        
                            if ((cuadros[0] == "X" && cuadros[1] == "X" && cuadros[2] == "X") || (cuadros[3] == "X" && cuadros[4] == "X" && cuadros[5] == "X") || (cuadros[6] == "X" && cuadros[7] == "X" && cuadros[8] == "X") || (cuadros[0] == "X" && cuadros[3] == "X" && cuadros[6] == "X") || (cuadros[1] == "X" && cuadros[4] == "X" && cuadros[7] == "X") || (cuadros[2] == "X" && cuadros[5] == "X" && cuadros[8] == "X") || (cuadros[6] == "X" && cuadros[4] == "X" && cuadros[2] == "X") || (cuadros[0] == "X" && cuadros[4] == "X" && cuadros[8] == "X"))
                        {
                            Console.WriteLine("Ganaste!");
                            Console.WriteLine("Presiona enter para terminar!");
                            Console.ReadLine();
                            break;
                            }
                       
                        for (int a = 0; a < 1; a++) // El siguiente codigo permite la seleccion randomizado de alguna de los items del array y si ya esta elejido elije otro y lo cambia por una O.
                        {
                            Random seleccionCompu = new Random();
                            int seleccion = seleccionCompu.Next(9);

                            if (cuadros[seleccion] == "X" || cuadros[seleccion] == "O")
                            {
                                a--;
                            }
                            else
                            {
                                cuadros[seleccion] = "O";
                                Console.WriteLine($"LA compu elijio!:  \n\n    a   b   c \n\n      :   :   \n 1  {cuadros[0]} : {cuadros[1]} : {cuadros[2]} \n      :   :   \n   -----------\n      :   :   \n 2  {cuadros[3]} : {cuadros[4]} : {cuadros[5]} \n      :   :   \n   -----------\n      :   :   \n 3  {cuadros[6]} : {cuadros[7]} : {cuadros[8]} \n      :   :   ");
                            }
                        }
                        
                        if ((cuadros[0] == "O" && cuadros[1] == "O" && cuadros[2] == "O") || (cuadros[3] == "O" && cuadros[4] == "O" && cuadros[5] == "O") || (cuadros[6] == "O" && cuadros[7] == "O" && cuadros[8] == "O") || (cuadros[0] == "O" && cuadros[3] == "O" && cuadros[6] == "O") || (cuadros[1] == "O" && cuadros[4] == "O" && cuadros[7] == "O") || (cuadros[2] == "O" && cuadros[5] == "O" && cuadros[8] == "O") || (cuadros[6] == "O" && cuadros[4] == "O" && cuadros[2] == "O") || (cuadros[0] == "O" && cuadros[4] == "O" && cuadros[8] == "O"))
                        {
                            Console.WriteLine("Perdiste!");
                            Console.WriteLine("Presiona enter para terminar!");
                            Console.ReadLine();
                            break;
                        }
                        }
                        else
                        {
                            Console.WriteLine("Numero de Linea ingresado incorrecto, por favor volver a ingresar");
                            i--;
                        }
                    
                }
                else
                {
                    Console.WriteLine("El caracter ingresado es incorrecto, por favor volver a ingresar");
                    i--;
                }
               
            }
        }
    }
}
