using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoardLibrary
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? DifLevel { get; set; }
        //public List<PersonModel> AssignedTo { get; set; }
        [ForeignKey("ProjectModelId")]
        public int? ProjectModelId { get; set; }

        public string? Deadline { get; set; }

        public virtual ProjectModel? ProjectModel { get; set; }

        public virtual ICollection<PersonModel>? PersonModels { get; set; }
    }
}
//        public TaskModel()
//        { 
//        }

//        public TaskModel(string title, string difLevel, List<PersonModel> assignedTo, string deadline, ProjectModel project)
//        {
//            Title = title;
//            DifLevel = difLevel;
//            AssignedTo = assignedTo;
//            Deadline = deadline;
//            Project = project;
//        }


//    }
//}
