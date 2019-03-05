using Xceed.Wpf.Toolkit;
using System.Windows;
using System;


namespace To_Do_List_Application
{
    public partial class MainWindow : Window
    {

        public string[] types = {"Shopping","School","Gardening","Housework","Work","Holidays" };
        To_Do myToDoList = new To_Do();


        public MainWindow()
        {
            InitializeComponent();
            taskBox.ItemsSource = myToDoList.Tasks;
            typeCbx.ItemsSource = types;
            typeCbx.SelectedIndex = 0;

        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = inputTxt.Text;
            string type = typeCbx.SelectedItem.ToString();
            string desc = descBox.Text;
            DateTime date = DateSelector.SelectedDate.Value;


            myToDoList.AddTask(input,type,desc, date);
            taskBox.Items.Refresh();

        }

        private void priorityBtn_Click(object sender, RoutedEventArgs e)
        {
            if (taskBox.SelectedIndex == -1)
            {
                System.Windows.MessageBox.Show("Please select an Item first!");
            }
            else
            {
                myToDoList.Priority(taskBox.SelectedIndex);
            }
            
        }

        private void delBtn_Click(object sender, RoutedEventArgs e)
        {

            if (taskBox.SelectedIndex == -1)
            {
                System.Windows.MessageBox.Show("Please select an Item first!");
            }
            else
            {
                myToDoList.DeleteTask(taskBox.SelectedIndex);
            }

            
        }

        private void compBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
