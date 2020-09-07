using System;
using PRINCE2.UNSORTED;
using static PRINCE2.Products.IssueRegister;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * The lessons log is a project repository for lessons that apply to this project or future projects.
     * Some lessons may originate from other projects and should be captured on the lessons log for input to the project’s approaches and plans.
     * Some lessons may originate from within the project, where new experience (both good and bad) can be passed on to others.
     */
    public class LessonsLog
    {

        #region Composition

            /**
             * Defines the type of lesson being recorded, namely:
             *  - Project (to be applied to this project).
             *  - Corporate, programme management or the customer (to be passed on to corporate, programme management or the customer).
             *  - Both project and corporate, programme management or the customer.
             */
            public LessonType lessonType { get; set; }

            /**
             * The detail may include:
             *  - Event.
             *  - Effect (e.g. positive/negative financial impact).
             *  - Causes/Trigger.
             *  - Whether there were any early warning indicators.
             *  - Recommendations.
             *  - Whether it was previously identified as a risk (threat or opportunity).
             */
            public LessonDetail lessonDetail { get; set; }

            /**
             * The date on which the lesson was originally logged.
             */
            public DateTime dateLogged { get; set; }

            /**
             * The name of the person or team who raised the lesson.
             */
            public LoggedBy loggedBy { get; set; }

            /**
             * In terms of the project’s chosen categories.
             */
            public Priority priority { get; set; }

        #endregion

        #region Derivation
            
            public LessonsLog() { }

            public LessonsLog(
                Lessons lessons,
                ProjectMandate projectMandate,
                ProjectBrief projectBrief,
                DailyLog dailyLog,
                IssueRegister issueRegister,
                QualityRegister qualityRegister,
                RiskRegister riskRegister,
                CheckpointReport[] checkpointReports,
                HighlightReport[] highlightReports,
                WorkPackage[] completedWorkPackages,
                StagePlan stagePlan,
                ProjectProcessesObservationExperience projectProcessesObservationExperience
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria

            /**
            * The status indicates whether action has been taken.
            */
            public bool StatusIndicatesActionTaken() => throw new NotImplementedException();

            /**
            * Lessons are uniquely identified, including to which product they refer.
            */
            public bool LessonsUniquelyIdentifiedProductReference() => throw new NotImplementedException();

            /**
            * A process is defined by which the lessons log is to be updated.
            */
            public bool LessonsLogUpdatedProcessDefined() => throw new NotImplementedException();

            /**
            * Access to the lessons log is controlled.
            */
            public bool LessonsLogAccessControlled() => throw new NotImplementedException();

            /**
            * The lessons log is kept in a safe place.
            */
            public bool LessonsLogKeptSafe() => throw new NotImplementedException();

        #endregion

        public class LessonType { }

        public class LessonDetail { }

        public class LoggedBy { }

        public class ProjectProcessesObservationExperience { }

    }
}
