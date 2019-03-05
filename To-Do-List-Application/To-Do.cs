using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace To_Do_List_Application
{
    class To_Do
    {
        public ObservableCollection<Task> Tasks {get; set;}
        public ObservableCollection<Task> completedTasks {get; set;}

        public To_Do()
        {
            Tasks = new ObservableCollection<Task>();
            completedTasks = new ObservableCollection<Task>();
        }

        public void AddTask(string _taskName, string _taskDesc, string _taskCategory, DateTime _taskTimer)
        {
            Task t = new Task(_taskName,_taskDesc, _taskCategory, _taskTimer);
            Tasks.Add(t);
        }

        public void DeleteTask(int index)
        {
            Tasks.RemoveAt(index);
        }

        public void Priority(int index)
        {
            Task temp;

            temp = Tasks[index];
            Tasks.RemoveAt(index);
            Tasks.Insert(0, temp);
        }

        public void CompletedTasks(int index)
        {
            Task temp = Tasks[index];

            Tasks.RemoveAt(index);

            completedTasks.Add(temp);
        }

        public void Clear()
        {
            completedTasks.Clear();
        }
    }
}
