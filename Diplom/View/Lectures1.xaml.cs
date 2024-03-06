using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Diplom.View
{
    /// <summary>
    /// Логика взаимодействия для Lectures1.xaml
    /// </summary>
    public partial class Lectures1 : Page
    {
        public Lectures1()
        {
            InitializeComponent();
            // Путь к вашему текстовому файлу
            string filePath = "C:\\Users\\karin\\source\\repos\\Diplom\\Diplom\\Lectures\\Lectures1.txt";

            try
            {
                // Читаем содержимое файла
                string fileContent = File.ReadAllText(filePath);

                // Создаем новый объект FlowDocument
                FlowDocument flowDoc = new FlowDocument();

                // Создаем параграф и добавляем его в документ
                Paragraph paragraph = new Paragraph();
                paragraph.Inlines.Add(new Run(fileContent));
                flowDoc.Blocks.Add(paragraph);

                // Устанавливаем FlowDocument в RichTextBox
                richTextBox.Document = flowDoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
            }
        }
    }
}
