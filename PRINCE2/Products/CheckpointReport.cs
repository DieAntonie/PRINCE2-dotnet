using System;
using PRINCE2.UNSORTED;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * A checkpoint report is used to report, at a frequency defined in the work package, the status of the work package.
     */
    public partial class CheckpointReport
    {

        #region Composition

            /**
            * The date of the checkpoint.
            */
            public DateTime date { get; set; }

            /**
            * The reporting period covered by the checkpoint report.
            */
            public Period period { get; set; }

            /**
            * The outstanding items from previous reports (e.g. action items completed or unresolved issues).
            */
            public FollowUps followUps { get; set; }

            /**
            * The products being developed by the team during the reporting period.
            * The products completed by the team during the reporting period.
            * Quality management activities carried out during the period.
            * Lessons identified.
            */
            public ThisReportingPeriod thisReportingPeriod { get; set; }

            /**
            * The products being developed by the team in the next reporting period.
            * The products planned to be completed by the team in the next reporting period.
            * Quality management activities planned for the next reporting period.
            */
            public NextReportingPeriod nextReportingPeriod { get; set; }

            /**
            * How execution of the work package is performing against its tolerances (e.g. cost/time/scope actual and forecast).
            */
            public WorkPackageToleranceStatus workPackageToleranceStatus { get; set; }

            /**
            * An update on issues and risks associated with the work package.
            */
            public IssuesRisks issuesRisks { get; set; }

        #endregion

        #region Derivation

            public CheckpointReport() { }

            public CheckpointReport(
                WorkPackage workPackage,
                TeamPlanActual teamPlanActual,
                CheckpointReport previousCheckpointReport
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria

            /**
             * The report is prepared at the frequency required by the project manager.
             */
            public bool ReportPreparedAtFrequencyRequired() => throw new NotImplementedException();

            /**
             * The level and frequency of progress assessment is right for the management stage and/or work package.
             */
            public bool ProgressAssessmentLevelFrequencyRightForWorkPackage() => throw new NotImplementedException();

            /**
             * The information is timely, useful, objective and accurate.
             */
            public bool InformationTimelyUsefulObjectiveAccurate() => throw new NotImplementedException();

            /**
             * Every product in the work package, for that period, is covered by the report.
             */
            public bool ReportCoversEveryProductInWorkPackageForPeriod() => throw new NotImplementedException();

            /**
             * The report includes an update on any unresolved issues from the previous report.
             */
            public bool IncludesUpdateOnPreviousReportUnresolvedIssues() => throw new NotImplementedException();

        #endregion

        public class FollowUps { }

        public class WorkPackageToleranceStatus { }

        public class TeamPlanActual { }
    }
}