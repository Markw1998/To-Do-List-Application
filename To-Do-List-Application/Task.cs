using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List_Application
{
    class Task
    {
        public string taskName;
        public bool taskPriortiy;
        public string taskCategory;


        public Task(string _taskName, bool _taskPriority, string _taskCategory)
        {
            taskName = _taskName;
            taskCategory = _taskCategory;
            taskPriortiy = _taskPriority;
        }


        public override string ToString()
        {
            return string.Format($"•{taskName}{Environment.NewLine}{taskCategory}");
        }
    }
}
