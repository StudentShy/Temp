using System;

namespace Model
{
    [Serializable]
    /// <summary>
    /// Класс Сфера
    /// </summary>
    public class Sphere : Object3D
    {
        /// <summary>
        /// Радиус сферы
        /// </summary>
        public float Radius
        {
            get => Parametr1;
            set
            {
                if ( IsCorrectValue ( "Sphere radius", value ) )
                    parametr1 = value;
            }
        }

        /// <summary>
        /// Вычислить объем сферы
        /// </summary>
        /// <returns>Объем сферы</returns>
        public override float Volume ( )
        {
            return ( float ) ( 4.0 * Math.PI * Math.Pow ( this.Parametr1, 3 ) / 3.0 );
        }

        /// <summary>
        /// Метод возвращает информацию об сфере в виде строки
        /// </summary>
        /// <returns>Информация об сфере</returns>
        public override string ToString ( )
        {
            return "Объект - сфера; " + Info ( ) +
                " ; объем = " + Volume ( );
        }

        /// <summary>
        /// Метод возвращает параметры объекта в виде строки
        /// </summary>
        /// <returns>Параметры объекта</returns>
        public override string Info ( )
        {
            return "радиус = " + Parametr1;
        }
    }
}