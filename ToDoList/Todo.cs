using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Todo {
    [Required(ErrorMessage = "Title is required.")]
    public string Title { get; set; }

    [StringLength(500, ErrorMessage = "Description is too long.")]
    public string Description { get; set; }

    [Required]
    public TodoStatus Status { get; set; }
    
    [Required]
    public TodoPriority Priority { get; set; }

}

public enum TodoStatus {
    Pending, 
    OnGoing,
    Closed
}

public enum TodoPriority {
    Minor,
    Major,
    Urgent
}