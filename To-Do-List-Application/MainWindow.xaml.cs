using System.Windows;
using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.IO;

namespace To_Do_List_Application
{

    public partial class MainWindow : Window, INotifyPropertyChanged

    {
        public string[] types = { "Shopping", "School", "Gardening", "Housework", "Work", "Holidays" };
        To_Do myToDoList = new To_Do();

        private int _NoOfTasks;

        public int NoOfTasks
        {
            get
            {
                return _NoOfTasks;
            }
            set
            {
                _NoOfTasks = value;
                RaisePropertyChanged("NoOfTasks");

            }
        }

        //Event Handler for INotify
        public event PropertyChangedEventHandler PropertyChanged;


        //INotify Method
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            taskBox.ItemsSource = To_Do.Tasks;
            Completedbx.ItemsSource = myToDoList.completedTasks;
            typeCbx.ItemsSource = types;
            tasksFinishedTxt.Text = NoOfTasks.ToString();
            typeCbx.SelectedIndex = 0;

        }


        //Add Button
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = inputTxt.Text;
            string type = typeCbx.SelectedItem.ToString();
            string desc = descBox.Text;
            DateTime date = DateSelector.SelectedDate.Value;

            myToDoList.AddTask(input, type, desc, date);


            inputTxt.Clear();
            descBox.Clear();
            typeCbx.SelectedIndex = 0;
            DateSelector.Text = string.Empty;

            taskBox.Items.Refresh();

        }


        //Prioritise Button
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

        //Delete Button
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


        //Completed Button
        private void compBtn_Click(object sender, RoutedEventArgs e)
        {

            int index = taskBox.SelectedIndex;

            if (index >= 0)
            {
                myToDoList.CompletedTasks(index);
                Completedbx.Items.Refresh();
                NoOfTasks++;

                tasksFinishedTxt.Text = NoOfTasks.ToString();
            }
        }


        //Clear Button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myToDoList.Clear();
        }


        //Edit Button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Task temp = taskBox.SelectedItem as Task;

            EditWindow editWindow = new EditWindow();
            editWindow.Owner = this;

            if (temp != null)
            {

                editWindow.taskNameBx.Text = temp.taskName;
                editWindow.categoryCbx.SelectedValue = temp.taskCategory;
                editWindow.descBox.Text = temp.taskDesc;
                editWindow.DatePick.SelectedDate = temp.taskDate;

                editWindow.ShowDialog();
                To_Do.Tasks.Remove(temp);
            }
            else
            {
                System.Windows.MessageBox.Show("Please select a task first!");
            }
        }

        //Write To JSON Method
        private void JsonWrite()
        {
            using (StreamWriter file = File.CreateText(@".\test.json"))
            {
                string output = JsonConvert.SerializeObject(To_Do.Tasks, Formatting.Indented);

                file.Write(output);

                System.Windows.MessageBox.Show("Saved!");
            }

        }

        //Save Button
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            JsonWrite();
        }
    }
}
