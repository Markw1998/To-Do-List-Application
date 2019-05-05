using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace To_Do_List_Application
{
   public class Task
    {
        public string taskName;
        public string taskCategory;
        public string taskDesc;
        public DateTime taskDate;


        public Task(string _taskName, string _taskCategory, string _taskDesc, DateTime _taskDate)
        {
            taskName = _taskName;
            taskCategory = _taskCategory;
            taskDesc = _taskDesc;
            taskDate = _taskDate;
        }


        public override string ToString()
        {
            return string.Format($"• {taskName}{Environment.NewLine}Category: {taskCategory} {Environment.NewLine}Description: {taskDesc} {Environment.NewLine}Date to be done: {taskDate.ToShortDateString()} {Environment.NewLine}");
        }
    }
}
