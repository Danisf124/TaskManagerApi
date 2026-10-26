

using System.Runtime.CompilerServices;

namespace TaskManager.Models
{
    public class TaskItem
    {
        public int Id {get; set;}
        public string Title {get; set;} = "";
        public bool IsComplete {get; set;}
        
        public int UserId {get; set;}
        public User User {get; set;} = null! ;
    }
}