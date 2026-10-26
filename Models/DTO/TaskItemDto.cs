
namespace TaskManager.Models.DTO
{
    public class TaskItemDto
    {
        public int Id {get; set;}
        public string Title {get; set;} = "";
        public bool IsComplete {get; set;}
    }
}