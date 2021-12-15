using System;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class FormAdd : Form
    {

        /// <summary>
        /// Ссылка на абстрактный класс Model.Object3D
        /// </summary>
        public Object3D Figure = null;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="figure">Объект редактирования</param>
        public FormAdd ( Object3D figure = null )
        {
            InitializeComponent ( );

            // Скопировать данные в форму
            if ( figure != null )
            {
                switch ( figure.GetType ( ).Name )
                {
                    case nameof ( Sphere ):// Сфера
                        comboBoxType.SelectedIndex = 0;
                        textBoxParam1.Text =
                            ( ( Sphere ) figure ).Radius.ToString ( );
                        break;
                    case nameof ( Pyramid ):// Пирамида
                        comboBoxType.SelectedIndex = 1;
                        textBoxParam1.Text =
                            ( ( Pyramid ) figure ).Height.ToString ( );
                        textBoxParam2.Text =
                            ( ( Pyramid ) figure ).BaseArea.ToString ( );
                        break;
                    case nameof ( Parallelepiped ):// Параллелепипед
                        comboBoxType.SelectedIndex = 2;
                        textBoxParam1.Text =
                            ( ( Parallelepiped ) figure ).Height.ToString ( );
                        textBoxParam2.Text =
                            ( ( Parallelepiped ) figure ).Length.ToString ( );
                        textBoxParam2.Text =
                            ( ( Parallelepiped ) figure ).Width.ToString ( );
                        break;
                }
            }
            comboBoxType.SelectedIndex = 0;
#if !DEBUG
            buttonRandom.Visible = false;
#endif
        }

        /// <summary>
        /// Выбран тип фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxType_SelectedIndexChanged
            ( object sender, EventArgs e )
        {
            switch ( comboBoxType.SelectedIndex )
            {
                case 0:// Сфера
                    textBoxParam2.Enabled = false;
                    textBoxParam3.Enabled = false;
                    label8.Text = "Радиус";
                    label3.Text = "Недоступно";
                    label4.Text = "Недоступно";
                    break;
                case 1:// Пирамида
                    textBoxParam2.Enabled = true;
                    textBoxParam3.Enabled = false;
                    label8.Text = "Высота";
                    label3.Text = "Площадь основания";
                    label4.Text = "Недоступно";
                    break;
                case 2:// Параллеллепипед
                    textBoxParam2.Enabled = true;
                    textBoxParam3.Enabled = true;
                    label8.Text = "Высота";
                    label3.Text = "Длина";
                    label4.Text = "Ширина";
                    break;
            }
        }

        /// <summary>
        /// Кнопка Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCansel_Click ( object sender, EventArgs e )
        {
            Figure = null;
            Close ( );
        }

        /// <summary>
        /// Кнопка Random
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRandom_Click ( object sender, EventArgs e )
        {
            Random rnd = new Random();

            // Случайная фигура
            comboBoxType.SelectedIndex = rnd.Next ( 3 );

            // Случайный первый параметр
            textBoxParam1.Text =
                ( ( rnd.Next ( 1000 ) + 1 ) / 10.0 ).ToString ( );

            // Случайный второй параметр
            textBoxParam2.Text =
                ( ( rnd.Next ( 1000 ) + 1 ) / 10.0 ).ToString ( );

            // Случайный третий параметр
            textBoxParam3.Text =
                ( ( rnd.Next ( 1000 ) + 1 ) / 10.0 ).ToString ( );
        }

        /// <summary>
        /// Нажата клавиша при вводе в текстовое поле
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            // Можно вводить цыфры, запятую и Backspace
            if ( Char.IsNumber ( e.KeyChar ) |
                 e.KeyChar == '\b' | e.KeyChar == ',' ) return;
            e.Handled = true;
        }

        /// <summary>
        /// Метод преобразования строки в тип float
        /// </summary>
        /// <param name="str">строка</param>
        /// <param name="value">результат</param>
        /// <returns>true, если преобразование удачно</returns>
        private bool StringToFloat ( String str, ref float value )
        {
            if ( String.IsNullOrWhiteSpace ( str ) ) return false;

            try
            {
                value = ( float ) Double.Parse ( str );
            }
            catch ( Exception exception )
            {
                MessageBox.Show ( @"Вы ввели не число!", @"Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error );
                return false;
            }

            return true;
        }

        /// <summary>
        /// Проверка введеннных данных
        /// </summary>
        /// <returns>true, если введенные данные корректны</returns>
        private bool CkeckData ( )
        {
            float param = -1.0f;

            if ( !StringToFloat ( textBoxParam1.Text, ref param ) )
            {
                MessageBox.Show ( @"Введите действительное число больше нуля!",
                    @"Ошибка", MessageBoxButtons.OK );
                textBoxParam1.Focus ( );
                return false;
            }

            if ( comboBoxType.SelectedIndex >= 1 )
            {
                if ( !StringToFloat ( textBoxParam2.Text, ref param ) )
                {
                    textBoxParam2.Focus ( );
                    return false;
                }
            }

            if ( comboBoxType.SelectedIndex >= 2 )
            {
                if ( !StringToFloat ( textBoxParam3.Text, ref param ) )
                {
                    textBoxParam3.Focus ( );
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Кнопка Ок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonОк_Click ( object sender, EventArgs e )
        {
            if ( CkeckData ( ) )
            {
                switch ( comboBoxType.SelectedIndex )
                {
                    case 0:// Сфера
                        Figure = new Sphere ( );
                        ( ( Sphere ) Figure ).Radius =
                            ( float ) Double.Parse ( textBoxParam1.Text );
                        break;
                    case 1:// Пирамида
                        Figure = new Pyramid ( );
                        ( ( Pyramid ) Figure ).Height =
                            ( float ) Double.Parse ( textBoxParam1.Text );
                        ( ( Pyramid ) Figure ).BaseArea =
                            ( float ) Double.Parse ( textBoxParam2.Text );
                        break;
                    case 2:// Параллеллепипед
                        Figure = new Parallelepiped ( );
                        ( ( Parallelepiped ) Figure ).Height =
                            ( float ) Double.Parse ( textBoxParam1.Text );
                        ( ( Parallelepiped ) Figure ).Length =
                            ( float ) Double.Parse ( textBoxParam2.Text );
                        ( ( Parallelepiped ) Figure ).Width =
                            ( float ) Double.Parse ( textBoxParam3.Text );
                        break;
                }
                Close ( );
            }
        }
    }
}
