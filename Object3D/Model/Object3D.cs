using System;

namespace Model
{
    [Serializable]
    /// <summary>
    /// Абстрактный класс Фигура в пространстве
    /// </summary>
    public abstract class Object3D
    {
        /// <summary>
        /// Параметр объекта
        /// </summary>
        protected float parametr1;

        /// <summary>
        /// Параметр объекта
        /// </summary>
        public float Parametr1 => parametr1;

        /// <summary>
        /// Проверка на корректность значения параметра
        /// </summary>
        /// <param name="paramName">Имя параметра</param>
        /// <param name="value">Значение параметра</param>
        /// <returns>true, если параметр имеет корректное значение</returns>
        public bool IsCorrectValue ( string paramName, float value )
        {
            if ( string.IsNullOrEmpty ( paramName ) )
                throw new ArgumentException (
                    "Название параметра не может быть пустым.",
                     paramName );

            if ( value <= 0.0f )
                throw new ArgumentException (
                    "Значение должно быть больше нуля.",
                     paramName );


            return true;
        }

        /// <summary>
        /// Метод возвращает информацию об объекте в виде строки
        /// </summary>
        /// <returns>Информация об объекте</returns>
        public override string ToString ( )
        {
            return string.Empty;
        }

        /// <summary>
        /// Метод возвращает параметры объекта в виде строки
        /// </summary>
        /// <returns>Параметры объекта</returns>
        public virtual string Info ( )
        {
            return string.Empty;
        }

        /// <summary>
        /// Вычислить объем фигуры
        /// </summary>
        /// <returns>Объем фигуры</returns>
        public virtual float Volume ( )
        {
            return 0.0f;
        }
    }
}