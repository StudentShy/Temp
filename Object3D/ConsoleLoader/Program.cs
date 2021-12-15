using System;
using Model;

namespace ConsoleLoader
{
    class Program
    {
        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args">Аргументы командной строки</param>
        static void Main ( string[] args )
        {
            Console.WriteLine ( "Объекты в пространстве." );

            Console.WriteLine ( "\nСфера:" );
            Object3D object3D = new Sphere();
            DataInput ( ref object3D, 0 );
            Console.WriteLine ( object3D.ToString ( ) );

            Console.WriteLine ( "\nПирамида:" );
            object3D = new Pyramid ( );
            DataInput ( ref object3D, 1 );
            DataInput ( ref object3D, 2 );
            Console.WriteLine ( object3D.ToString ( ) );


            Console.WriteLine ( "\nПараллелепипед:" );
            object3D = new Parallelepiped ( );
            DataInput ( ref object3D, 3 );
            DataInput ( ref object3D, 4 );
            DataInput ( ref object3D, 5 );
            Console.WriteLine ( object3D.ToString ( ) );

            Console.ReadKey ( );

        }

        /// <summary>
        /// Ввод действительного числа
        /// </summary>
        /// <param name="message">Сообщение о вводимом параметре</param>
        /// <returns>Введенное число</returns>
        private static float InputFloat ( String message )
        {
            bool isCorrectInput = false;
            float result = 0;

            while ( !isCorrectInput )
            {
                Console.Write ( message );
                try
                {
                    result = ( float ) Double.Parse ( Console.ReadLine ( ) );
                    isCorrectInput = true;
                }
                catch ( Exception exception )
                {
                    Console.Write ( exception.Message + "\n" );
                    isCorrectInput = false;
                }
            }

            return result;
        }

        /// <summary>
        /// Ввод данных класса Object3D 
        /// </summary>
        /// <param name="object3D">Ссылка на абстрактный класс Object3D</param>
        /// <param name="param">Вводимый параметр(
        /// 0-радиус сферы, 1-высота пирамиды, 2- площадь основания пирамиды,
        /// 3-высота параллелепипеда, 4-ширина параллелепипеда,
        /// 5-длина параллелепипеда)</param>
        public static void DataInput ( ref Object3D object3D, int param )
        {
            bool isCorrectInput = false;

            while ( !isCorrectInput )
            {
                try
                {
                    switch ( param )
                    {
                        case 0:// сфера
                            if ( object3D.GetType ( ).Name == nameof ( Sphere ) )
                                ( ( Sphere ) object3D ).Radius = InputFloat (
                                "Введите радиус сферы :" );
                            break;
                        case 1:// высота пирамиды
                            if ( object3D.GetType ( ).Name == nameof ( Pyramid ) )
                            {
                                ( ( Pyramid ) object3D ).Height = InputFloat (
                                    "Введите высоту пирпмиды :" );
                            }
                            break;
                        case 2:// площадь основания пирамиды
                            if ( object3D.GetType ( ).Name == nameof ( Pyramid ) )
                            {
                                ( ( Pyramid ) object3D ).BaseArea = InputFloat (
                                    "Введите площадь основания пирамиды :" );
                            }
                            break;
                        case 3:// высота параллелепипеда
                            if ( object3D.GetType ( ).Name == nameof ( Parallelepiped ) )
                            {
                                ( ( Parallelepiped ) object3D ).Height = InputFloat (
                                    "Введите высоту параллелепипеда :" );
                            }
                            break;
                        case 4:// ширина параллелепипеда
                            if ( object3D.GetType ( ).Name == nameof ( Parallelepiped ) )
                            {

                                ( ( Parallelepiped ) object3D ).Width = InputFloat (
                                    "Введите ширину параллелепипеда :" );
                            }
                            break;
                        case 5:// длина параллелепипеда
                            if ( object3D.GetType ( ).Name == nameof ( Parallelepiped ) )
                            {
                                ( ( Parallelepiped ) object3D ).Length = InputFloat (
                                    "Введите длину параллелепипеда :" );
                            }
                            break;
                    }

                    isCorrectInput = true;
                }
                catch ( Exception exception )
                {
                    Console.Write ( exception.Message + "\n" );
                    isCorrectInput = false;
                }
            }
        }
    }
}
