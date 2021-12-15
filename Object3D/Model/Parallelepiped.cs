using System;

namespace Model
{
    [Serializable]
    /// <summary>
    /// Класс Параллелепипед
    /// </summary>
    public class Parallelepiped : Object3D
    {
        /// <summary>
        /// Длина параллелепипеда
        /// </summary>
        protected float parametr2;

        /// <summary>
        /// Ширина параллелепипеда
        /// </summary>
        protected float parametr3;

        /// <summary>
        /// Длина параллелепипеда
        /// </summary>
        public float Length
        {
            get => parametr2;
            set
            {
                if ( IsCorrectValue ( "Length of the parallelepiped", value ) )
                    parametr2 = value;
            }
        }

        /// <summary>
        /// Высота параллелепипеда
        /// </summary>
        public float Height
        {
            get => Parametr1;
            set
            {
                if ( IsCorrectValue ( "Height of the parallelepiped", value ) )
                    parametr1 = value;
            }
        }

        /// <summary>
        /// Ширина параллелепипеда
        /// </summary>
        public float Width
        {
            get => parametr3;
            set
            {
                if ( IsCorrectValue ( "Width of the parallelepiped", value ) )
                    parametr3 = value;
            }
        }

        /// <summary>
        /// Вычислить объем параллелепипеда
        /// </summary>
        /// <returns>Объем параллелепипеда</returns>
        public override float Volume ( )
        {
            return Parametr1 * parametr3 * parametr2;
        }

        /// <summary>
        /// Метод возвращает информацию о параллелепипеде в виде строки
        /// </summary>
        /// <returns>Информация о параллелепипеде</returns>
        public override string ToString ( )
        {
            return "Объект -Параллелепипед; " + Info ( ) +
                   " ; объем = " + Volume ( );
        }

        /// <summary>
        /// Метод возвращает параметры объекта в виде строки
        /// </summary>
        /// <returns>Параметры объекта</returns>
        public override string Info ( )
        {
            return "высота = " + Parametr1 +
                   " ; длина = " + parametr2 +
                   " ; ширина = " + parametr3;
        }
    }
}