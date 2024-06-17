using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TodoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void AddTodoButton_Click(Object sender, RoutedEventArgs e)
        {

            string todoText = TodoInput.Text;

            if (!string.IsNullOrEmpty(todoText))
            {

                /*TextBlock todoItem = new TextBlock();
                todoItem.Text = todoText;*/
                //other way

                TextBlock todoItem = new TextBlock
                {
                    Text = todoText,
                    Margin = new Thickness(10),
                    Foreground = new SolidColorBrush(Colors.White),
                };

                TodoList.Children.Add(todoItem);

                TodoInput.Clear();
            }
            else
            {
                MessageBox.Show("Enter Something");
            }

        }
    }
}