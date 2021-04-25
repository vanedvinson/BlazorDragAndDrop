using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDragAndDrop.Shared
{
    public class TaskModel
    {
        public int ID { get; set; }
        public TaskStatuses Status { get; set; }
        public string Detail { get; set; }
        public DateTime UpdatedTime { get; set; }

    }

    public enum TaskStatuses
    {
        Todo,
        Started,
        Completed,
    }
}
