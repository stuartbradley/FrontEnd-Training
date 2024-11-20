using FrontEndTraining.Models;
using Microsoft.AspNetCore.Components;

namespace FrontEnd_Training.Components
{
    public partial class ProjectCard
    {
        [Parameter] public Project Project { get; set; }
    }
}
