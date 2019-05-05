using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace To_Do_List_Application
{
   public class To_Do 
    {
        public static ObservableCollection<Task> Tasks {get; set;}
        public ObservableCollection<Task> completedTasks {get; set;}
        Model1Container db = new Model1Container();

        // Constructor
        public To_Do()
        {
            Tasks = new ObservableCollection<Task>();
            completedTasks = new ObservableCollection<Task>();
        }

        //Add Task Method to Database and Observable Collection
        public void AddTask(string _taskName, string _taskDesc, string _taskCategory, DateTime _taskTimer)
        {
            Task t = new Task(_taskName,_taskDesc, _taskCategory, _taskTimer);
            Tasks.Add(t);

            //Database Add
            TasksDB tl = new TasksDB()
            {
                TaskName = _taskName,
                Description = _taskDesc,
                Category = _taskCategory,
                DueDate = _taskTimer
            };
            db.TasksDBs.Add(tl);
            db.SaveChanges();
        }

        //Delete Task Method
        public void DeleteTask(int index)
        {
            Tasks.RemoveAt(index);
        }

        //Prioritise Task Method
        public void Priority(int index)
        {
            Task temp;

            temp = Tasks[index];
            Tasks.RemoveAt(index);
            Tasks.Insert(0, temp);
        }

        //Completed Tasks Method
        public void CompletedTasks(int index)
        {
            Task temp = Tasks[index];

            Tasks.RemoveAt(index);

            completedTasks.Add(temp);
        }

        //Clear Method
        public void Clear()
        {
            completedTasks.Clear();
        }

    }
}
