using System;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioA[] lista = new UsuarioA[15];
            UsuarioA usuario = new UsuarioA(null,null,0);
            LPeliculas[] ListaA = new LPeliculas[15];
            LPeliculas peliculas = new LPeliculas(null,null,null,null);
            Nregistro Nregistro = new Nregistro(null,null,0);
            Nregistro[] lista3 = new Nregistro[30];
            string[] listaprueba = new string[10];
            int contadorN = 0;          
            int resultado = 0;
            int operaciones = 0;
            int numero = 1 ;
            int valor = 0;
            int contar = 0;
            int Numeros = 1;
            int suma = 0;
            System.Console.WriteLine("* Universidad Mariano Galvez de Guatemala *");
            System.Console.WriteLine("*  Segundo examen parcila prgramacion  1  *");
            System.Console.WriteLine("******************************");
            System.Console.WriteLine("******************************");
            System.Console.WriteLine("*---------necFlis------------*");
            while(resultado!=3){
            System.Console.WriteLine("******************************");
            System.Console.WriteLine("* Elija una de las opciones  *");
            System.Console.WriteLine("* 1. Clientes                *");
            System.Console.WriteLine("* 2. Peliculas               * ");
            System.Console.WriteLine("* 3. Salir                   *");
            System.Console.WriteLine("******************************");

            resultado=Convert.ToInt32(Console.ReadLine());
            switch(resultado){
                case 1:
                    while(operaciones!=4){
                        System.Console.WriteLine("**********************************");
                        System.Console.WriteLine("*    Usuarios de necFlis         *");
                        System.Console.WriteLine("* Escoja una de las opciones     *");
                        System.Console.WriteLine("* 1. Ver listado de los usuarios *");
                        System.Console.WriteLine("* 2. Crear usuario               *");     
                        System.Console.WriteLine("* 3. Selecionar usuario          *");
                        System.Console.WriteLine("* 4. Salir                       *");
                        System.Console.WriteLine("**********************************");

                        operaciones=Convert.ToInt32(Console.ReadLine());
                        switch(operaciones){
                            case 1:   
                                System.Console.WriteLine("******************************");
                                System.Console.WriteLine("*   Lista de los Usuarios    *");
                    
                                for (int i = 0; i < contadorN; i++)
                                {
                                    usuario = lista[i];
                                    System.Console.WriteLine(" "+numero +" . " + usuario.nombre);
                                    numero++;
                                }
                                numero= 1;
                                System.Console.WriteLine("******************************");

                            break;
                            case 2:
                                usuario = new UsuarioA();
                                lista[contadorN] = usuario;
                                contadorN++;                   
                            break;

                            case 3:
                                System.Console.WriteLine("********************************************");
                                System.Console.WriteLine("* Ingresar el numero del usuario que desee *");
                                int valor1 = Int32.Parse(Console.ReadLine());
                                UsuarioA usuario1 = lista[valor1 -1];
                                System.Console.WriteLine("*     Informacion general del usuario      *");
                                System.Console.WriteLine("**  **");
                                System.Console.WriteLine("* Nombre:                                  *"+ usuario1.nombre);
                                System.Console.WriteLine("* Direccion:                               *" + usuario1.direccion);
                                System.Console.WriteLine("* Edad:                                    *" + usuario1.edad);
                                System.Console.WriteLine("********************************************");

                                while(true){
                                System.Console.WriteLine("*******************************");
                                System.Console.WriteLine("* Escoja la opcione que desee *");
                                System.Console.WriteLine("* 1. Playlist                 *");
                                System.Console.WriteLine("* 2. Agregar pelicula         *");
                                System.Console.WriteLine("* 3. Atras                    *");
                                System.Console.WriteLine("*******************************");
                                int indice = Int32.Parse(Console.ReadLine());
                                


                                if (indice ==1){
                                    for (int i = 0; i < suma; i++)
                                    {
                                    string valores = Nregistro.lista[i];
                                    System.Console.WriteLine( Numeros +"**  **" + valores);
                                    Numeros++;
                                    }
                                    Numeros = 1;
                                    
                                }
                                if (indice ==2){
                                    while(true){
                                    System.Console.WriteLine("*****************************************");
                                    System.Console.WriteLine("*       Listado de Peliculas            *");
                                    for (int i = 0; i < contar; i++)
                                    {
                                        peliculas = ListaA[i];
                                        System.Console.WriteLine( Numeros +"**  **" + peliculas.nombre);
                                        Numeros++;
                                    }
                                    Numeros = 1;
                                    System.Console.WriteLine("*****************************************");
    
                                    System.Console.WriteLine("* Escoja la pelicula que quiera agregar *");
                                    int escojer = Int32.Parse(Console.ReadLine());
                                    if(escojer==0){

                                        Nregistro = new Nregistro(usuario1.nombre,listaprueba);
                                        break;
                                        
                                    }
                                    
                                    else{
                                        peliculas = ListaA[escojer-1];
                                        string peli = peliculas.nombre; 
                                        Nregistro =new Nregistro(usuario1.nombre,peli,suma);
                                        lista3[suma] = Nregistro;
                                        suma++;

                                    }

                                    for (int i = 0; i < suma; i++)
                                    {
                                        Nregistro=lista3[i];
                                        listaprueba[i] = Nregistro.peliculas_usuario;
                                    }

                                    }

                                }
                                if (indice ==3){
                                    break;
                                }
                                else{
                                    System.Console.WriteLine("* Escoja una de las opciones *");
                                }
                                }


                            break; 
                            case 4:
                                System.Console.WriteLine("    * Gracias ingresar a necFlis  *");
                            break;                   
                            default:
                                System.Console.WriteLine("    * Escoja una de las opciones  *");
                            break;
                            }
                    }

                    break;
                case 2:
                    while(valor!=3){
                        System.Console.WriteLine("******************************");
                        System.Console.WriteLine("*        Peliculas           *");
                        System.Console.WriteLine("* Escoja una de las opciones *");
                        System.Console.WriteLine("* 1. Ver una pelicula        *");
                        System.Console.WriteLine("* 2. Agregar una pelicula    *");
                        System.Console.WriteLine("* 3. Salir                   *");
                        System.Console.WriteLine("******************************");

                        valor = Int32.Parse(Console.ReadLine());
                        switch(valor){
                            case 1: 
                            System.Console.WriteLine("******************************");
                            System.Console.WriteLine("*     Lista de peliculas     *");
                                for (int i = 0; i < contar; i++)
                                {
                                    peliculas = ListaA[i];
                                    System.Console.WriteLine( Numeros +"**  **" + peliculas.nombre);
                                    Numeros++;
                                }
                                Numeros = 1;
                            break;

                            case 2:
                                peliculas = new LPeliculas();
                                ListaA[contar] = peliculas;
                                contar++; 
                            break;

                            case 3:
                                System.Console.WriteLine("* Gracias por ingresar a necFlis  *");
                            break;
                            default:
                                System.Console.WriteLine("* Escoja una de las opciones      *");
                            break;
                        }
                    }
                    break;
                case 3:

                    System.Console.WriteLine("* Gracias por utilizar el sistema necFLis                    *");
                    System.Console.WriteLine("* Osman Josue Cordero Bonilla 0907-20-6641                   * ");
                    System.Console.WriteLine("* Un programador materializa lo que otros simplemente sueñan *");

                    break;
                default:
                    System.Console.WriteLine("*           Escoja una de las opciones        *");

                    break;
                }
            }
        }
    }

    class UsuarioA{
        public string nombre;
        public string direccion;
        public int edad;

        public UsuarioA(string nombre, string direccion, int edad){
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
        }
        public UsuarioA(){
            System.Console.WriteLine("***************************************");
            System.Console.WriteLine("* Escriba el nombre del nuevo usuario *");
            nombre = Console.ReadLine();
                                            
            System.Console.WriteLine("* Escriba la direcion del usuario     *");
            direccion = Console.ReadLine();

            System.Console.WriteLine("* Escriba la edad del usuario         *");
            edad=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("***************************************");

        }
    }
    class LPeliculas{
        public string nombre;
        public string tipo;
        public string genero;
        public string sinopsis;
        public LPeliculas(string nombre, string tipo, string genero, string sinopsis){
            this.nombre = nombre;
            this.tipo = tipo;
            this.genero = genero;
            this.sinopsis = sinopsis;
        }

        public LPeliculas(){
            System.Console.WriteLine("* Escriba el nombre de la pelicula    *");
            nombre = Console.ReadLine();
            System.Console.WriteLine("* Escoja si es:                       *");
            System.Console.WriteLine("* Serie                               *");
            System.Console.WriteLine("* Pelicula                            *");
            tipo = Console.ReadLine();
            System.Console.WriteLine("* escoja el genero de la pelicula     *");
            System.Console.WriteLine("* Drama                               *");
            System.Console.WriteLine("* Comedia                             *");
            System.Console.WriteLine("* Terror                              *");
            System.Console.WriteLine("* Suspenso                            *");
            genero =Console.ReadLine();
            System.Console.WriteLine("* Escriba una sinopsis de la pelicula *");
            System.Console.WriteLine("********************************************");
            sinopsis = Console.ReadLine();

        }
    }

    class Nregistro{
        public string nombre_usuario;

        public string peliculas_usuario;

        public int cantidad;

        public string[] lista;
        public Nregistro(string nombre_usuario, string peliculas_usuario, int cantidad){
            this.nombre_usuario = nombre_usuario;
            this.peliculas_usuario =  peliculas_usuario;       
            this.cantidad = cantidad;     
        }

        public Nregistro(string nombre_usuario,string[] lista){
            this.nombre_usuario = nombre_usuario;
            this.lista = lista;
        }
        
    }
}
