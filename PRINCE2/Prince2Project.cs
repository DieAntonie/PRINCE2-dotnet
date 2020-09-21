using System;
using PRINCE2.Products;
using PRINCE2.UNSORTED;

namespace PRINCE2
{
    public class Prince2Project
    {
        ProjectBrief projectBrief;
        LessonsLog lessonsLog;
        public AppointedExecutivesAndProjectManager AppointExecutivesAndProjectManager(ProjectMandate projectMandate)
        {
            projectBrief = new ProjectBrief()
            {
                roleDescriptions = new RoleDescriptions()
                {
                    ExecutiveRoleDescription = projectMandate.Executive,
                    ProjectManagerRoleDescription = projectMandate.ProjectManager
                }
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

        public void CapturePreviousLessons(LessonsReport lessonsReport)
        {
            lessonsLog = new LessonsLog();
        }

        public LessonsLog LessonsLog()
        {
            return lessonsLog;
        }

        public AppointedProjectManagementTeam DesignAndAppointProjectTeam(ProjectBrief mockProjectBrief, LessonsLog lessonsLog)
        {
            throw new NotImplementedException();
        }
    }

    public class AppointedProjectManagementTeam
    {
    }

    public class AppointedExecutivesAndProjectManager
    {
        public string Executive { get; set; }
        public string ProjectManager { get; set; }
    }
}