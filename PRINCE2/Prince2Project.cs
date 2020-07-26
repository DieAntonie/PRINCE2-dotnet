using System;
using PRINCE2.Products;

namespace PRINCE2
{
    public class Prince2Project
    {
        ProjectBrief projectBrief;
        public AppointedExecutivesAndProjectManager AppointExecutivesAndProjectManager(ProjectMandate projectMandate)
        {
            projectBrief = new ProjectBrief()
            {
                ExecutiveRoleDescription = projectMandate.Executive,
                ProjectManagerRoleDescription = projectMandate.ProjectManager
            };
            return new AppointedExecutivesAndProjectManager()
            {
                Executive = projectMandate.Executive,
                ProjectManager = projectMandate.ProjectManager
            };
        }

        public DailyLog DailyLog()
        {
            return new DailyLog();
        }

        public ProjectBrief ProjectBrief()
        {
            return projectBrief;
        }
    }

    public class AppointedExecutivesAndProjectManager
    {
        public string Executive { get; set; }
        public string ProjectManager { get; set; }
    }
}