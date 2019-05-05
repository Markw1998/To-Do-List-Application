using System;
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
using System.Windows.Shapes;

namespace To_Do_List_Application
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public string[] types = { "Shopping", "School", "Gardening", "Housework", "Work", "Holidays" };

        public EditWindow()
        {
            InitializeComponent();
            categoryCbx.ItemsSource = types;
        }


        //Finished Button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = Owner as MainWindow;

            if (main.taskBox.SelectedItem is Task selectedTask)
            {
                string newName = taskNameBx.Text;
                string category = categoryCbx.SelectedItem.ToString();
                string description = descBox.Text;
                DateTime datePicker = DatePick.SelectedDate.Value;

                selectedTask = new Task(newName, category, description, datePicker);
                To_Do.Tasks.Add(selectedTask);
                this.Close();
            }
            
        }

        //Go Back Button to Close Edit Window
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = Owner as MainWindow;

            Task Selected = main.taskBox.SelectedItem as Task;

            To_Do.Tasks.Add(Selected);

            this.Close();
        }
    }
}
