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
        public string taskCategory;
        public string taskDesc;


        public Task(string _taskName, string _taskCategory, string _taskDesc)
        {
            taskName = _taskName;
            taskCategory = _taskCategory;
            taskDesc = _taskDesc;
        }


        public override string ToString()
        {
            return string.Format($"•{taskName}{Environment.NewLine}{taskCategory}{Environment.NewLine}{taskDesc}");
        }
    }
}
