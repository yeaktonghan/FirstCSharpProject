using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Task
    {
        public int taskId;
        public string description;
        public bool isCompleted;

        public Task(int taskId, string description, bool isCompleted)
        {
            this.taskId = taskId;
            this.description = description;
            this.isCompleted = isCompleted;
        }


    }
}

