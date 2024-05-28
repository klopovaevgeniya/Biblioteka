using System.Windows;
using System.Windows.Controls;
using SerBibliotek;

namespace prac8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Получаем текст из TextBlock
            string text = textBlock.Text;

            // Сериализуем текст
            Ser.Serialize(text, "textdata.xml");
            MessageBox.Show("Текст успешно сериализован!");

            // Десериализуем текст
            if (System.IO.File.Exists("textdata.xml"))
            {
                string deserializedText = Ser.Deserialize<string>("textdata.xml");
                MessageBox.Show($"Текст успешно десериализован:\n{deserializedText}");
            }
            else
            {
                MessageBox.Show("Файл данных для десериализации не найден!");
            }
        }
    }
}
