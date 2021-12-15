using System;

namespace Model
{
    [Serializable]
    /// <summary>
    /// Класс Пирамида
    /// </summary>
    public class Pyramid : Object3D
    {
        /// <summary>
        /// Площадь основания пирамиды
        /// </summary>
        protected float parametr2;

        /// <summary>
        /// Высота пирамиды
        /// </summary>
        public float Height
        {
            get => Parametr1;
            set
            {
                if ( IsCorrectValue ( "Pyramid height", value ) )
                    parametr1 = value;
            }
        }

        /// <summary>
        /// Площадь основания пирамиды
        /// </summary>
        public float BaseArea
        {
            get => parametr2;
            set
            {
                if ( IsCorrectValue ( "Pyramid base area", value ) )
                    parametr2 = value;
            }
        }

        /// <summary>
        /// Вычислить объем пирамиды
        /// </summary>
        /// <returns>Объем пирамиды</returns>
        public override float Volume ( )
        {
            return Parametr1 * parametr2 / 3.0f;
        }

        /// <summary>
        /// Метод возвращает информацию об пирамиде в виде строки
        /// </summary>
        /// <returns>Информация об пирамиде</returns>
        public override string ToString ( )
        {
            return "Объект - пирамида; " + Info ( ) +
                   " ; объем = " + Volume ( );
        }

        /// <summary>
        /// Метод возвращает параметры объекта в виде строки
        /// </summary>
        /// <returns>Параметры объекта</returns>
        public override string Info ( )
        {
            return "высота = " + Parametr1 +
            " ; площадь основания = " + parametr2;
        }
    }
}