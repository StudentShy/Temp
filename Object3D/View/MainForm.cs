using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список фигур
        /// </summary>
        private List<Object3D> figureList = new List<Object3D>();

        public MainForm ( )
        {
            InitializeComponent ( );
            comboBoxType.SelectedIndex = 3;
        }

        /// <summary>
        /// Меню Выхода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выходToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Close ( );
        }

        /// <summary>
        /// Метод заполнения таблицы dataGridView1 данными из списка
        /// </summary>
        private void FillDataGridCards ( List<Object3D> cardList )
        {
            // Очистка таблицы
            dataGridView1.Rows.Clear ( );
            if ( cardList == null || cardList.Count == 0 ) return;

            // Цикл по всему списку
            foreach ( var item in cardList )
            {
                int i = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[i];
                String type = item.GetType().Name;
                switch ( type )
                {
                    case nameof ( Sphere ):// Сфера
                        row.Cells[0].Value = "Сфера";

                        break;
                    case nameof ( Pyramid ):// Пирамида
                        row.Cells[0].Value = "Пирамида";
                        break;
                    case nameof ( Parallelepiped ):// Параллелепипед
                        row.Cells[0].Value = "Параллелепипед";
                        break;
                }
                row.Cells[1].Value = item.Info ( );
                row.Cells[2].Value = item.Volume ( );
            }
            dataGridView1.Update ( );
        }

        /// <summary>
        /// Меню Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            if ( figureList == null ) figureList = new List<Object3D> ( );
            if ( figureList.Count < 1 )
            {
                MessageBox.Show ( @"Список пуст!" );
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                RestoreDirectory = true,
                DefaultExt = "fig",
                Filter = @"Фигуры (*.fig)|*.fig"
            };

            if ( saveFileDialog.ShowDialog ( ) == DialogResult.OK )
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    FileStream writerFileStream =
                        new FileStream(saveFileDialog.FileName, FileMode.Create);
                    formatter.Serialize ( writerFileStream, figureList );
                    writerFileStream.Close ( );
                }
                catch ( Exception )
                {
                    MessageBox.Show ( @"Ошибка записи в файл!" );
                    return;
                }
            }
            else
            {
                return;
            }
            MessageBox.Show ( @"Данные сохранены!" );
        }

        /// <summary>
        /// Меню Загрузить
        /// </summary>
        /// <param name="sender">Объект</param>
        /// <param name="e">Параметры</param>
        private void загрузитьToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            if ( figureList == null ) figureList = new List<Object3D> ( );
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                RestoreDirectory = true,
                DefaultExt = "fig",
                Filter = @"Фигуры (*.fig)|*.fig"
            };

            if ( openFileDialog1.ShowDialog ( ) == DialogResult.OK )
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    FileStream readerFileStream =
                        new FileStream(openFileDialog1.FileName, FileMode.Open);
                    if ( figureList.Count != 0 ) figureList.Clear ( );
                    figureList =
                        ( List<Object3D> ) formatter.Deserialize ( readerFileStream );
                    readerFileStream.Close ( );
                }
                catch ( Exception )
                {
                    MessageBox.Show ( @"Ошибка чтения файла!" );
                    return;
                }
            }
            else
            {
                return;
            }

            FillDataGridCards ( figureList );
            MessageBox.Show ( @"Данные зангружены!" );
        }

        /// <summary>
        /// Кнопка Удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_remove_Click ( object sender, EventArgs e )
        {
            if ( figureList.Count == 0 )
            {
                MessageBox.Show ( @"Список пуст!", @"Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error );
                return;
            }
            if ( dataGridView1.SelectedRows.Count == 0 )
            {
                MessageBox.Show ( @"Выберите запись для удаления!", @"Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error );
                return;
            }
            int index = dataGridView1.SelectedRows[0].Index;
            var result =
                MessageBox.Show(@"Вы уверены, что хотите удалить эту запись?",
                    @"Удаление записи",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
            if ( result == DialogResult.No )
            {
                return;
            }
            figureList.RemoveAt ( index );
            dataGridView1.Rows.Remove ( dataGridView1.SelectedRows[0] );
        }

        /// <summary>
        /// Кнопка Сброс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click ( object sender, EventArgs e )
        {
            textBoxParam.Text = String.Empty;
            comboBoxType.SelectedIndex = 3;
            FillDataGridCards ( figureList );
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
        /// Кнопка Найти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click ( object sender, EventArgs e )
        {
            if ( figureList == null || figureList.Count == 0 )
            {
                MessageBox.Show ( @"Ничего не найдено!" );
                return;
            }

            List<Object3D> searchList = null;

            // Поиск по типу фигуры
            switch ( comboBoxType.SelectedIndex )
            {
                case 0:// Сфера
                    searchList = figureList.FindAll (
                        r => r.GetType ( ).Name == nameof ( Sphere ) );
                    break;
                case 1:// Пирамида
                    searchList = figureList.FindAll (
                        r => r.GetType ( ).Name == nameof ( Pyramid ) );
                    break;
                case 2:// Параллеллепипед
                    searchList = figureList.FindAll (
                        r => r.GetType ( ).Name == nameof ( Parallelepiped ) );
                    break;
                case 3:// Любая фигура
                    searchList = new List<Object3D> ( figureList );
                    break;
            }

            // Проверка по объему
            if ( textBoxParam.Text != String.Empty )
            {
                float param = ( float ) Double.Parse ( textBoxParam.Text );
                searchList = searchList != null ? searchList.FindAll (
                    r => r.Volume() >= param ) : null;
            }

            if ( searchList.Count < 1 )
                MessageBox.Show ( "Ничего не найдено!" );

            FillDataGridCards ( searchList );
        }

        /// <summary>
        /// Кнопка Добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_add_Click ( object sender, EventArgs e )
        {
            FormAdd formadd = new FormAdd();
            formadd.ShowDialog ( );
            if ( formadd.Figure != null )
            {
                Object3D temp = formadd.Figure;
                figureList.Add ( temp );
                FillDataGridCards ( figureList );
            }
        }

        /// <summary>
        /// Кнопка Изменить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_edit_Click ( object sender, EventArgs e )
        {
            if ( figureList.Count == 0 )
            {
                MessageBox.Show ( @"Список пуст!", @"Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error );
                return;
            }
            if ( dataGridView1.SelectedRows.Count == 0 )
            {
                MessageBox.Show ( @"Выберите запись!", @"Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error );
                return;
            }

            // Индекс объекта
            int index = dataGridView1.SelectedRows[0].Index;

            FormAdd formadd = new FormAdd(figureList[index]);
            formadd.ShowDialog ( );
            if ( formadd.Figure != null )
            {
                Object3D temp = formadd.Figure;
                figureList[index] = temp;
                FillDataGridCards ( figureList );
            }
        }
    }
}
