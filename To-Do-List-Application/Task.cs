using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace To_Do_List_Application
{
    class Task
    {
        public string taskName;
        public string taskCategory;
        public string taskDesc;
        public DateTime taskDate;
        public TimePicker timeSelector;


        public Task(string _taskName, string _taskCategory, string _taskDesc, DateTime _taskDate, TimePicker _timeSelector)
        {
            taskName = _taskName;
            taskCategory = _taskCategory;
            taskDesc = _taskDesc;
            taskDate = _taskDate;
            timeSelector = _timeSelector
        }


        public override string ToString()
        {
            return string.Format($"•{taskName}{Environment.NewLine}{taskCategory}{Environment.NewLine}{taskDesc}{Environment.NewLine}{taskDate.ToShortDateString()}{Environment.NewLine}{timeSelector}");
        }
    }
}
