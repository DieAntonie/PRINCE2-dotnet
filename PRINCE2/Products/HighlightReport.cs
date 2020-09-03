using System;
using PRINCE2.UNSORTED;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * A highlight report is used to provide the project board (and possibly other stakeholders) with a summary of the management stage status at intervals defined by them.
     * The project board uses the report to monitor management stage and project progress.
     * The project manager also uses it to advise the project board of any potential problems or areas where the project board could help.
     */
    public class HighlightReport
    {
        #region Composition
            /**
            * The date of the report.
            */
            public DateTime date { get; set; }

            /**
            * The reporting period covered by the highlight report.
            */
            public Period period { get; set; }

            /**
            * An overview of the status of the management stage at this time.
            */
            public StatusSummary statusSummary { get; set; }

            /**
            * Containing:
            *  - Work packages, including those pending authorization, in execution, and completed in the period (if the work packages are being performed by external suppliers, this information may be accompanied by purchase order and invoicing data).
            *  - Products completed in the period.
            *  - Products planned but not started or completed in the period (providing an early warning indicator or potential breach of time tolerance).
            *  - Corrective actions taken during the period.
            */
            public ReportingPeriod thisReportingPeriod { get; set; }

            /**
            * Containing:
            *  - Work packages, including those to be authorized, in execution and to be completed during the next period (if the work packages are being performed by external suppliers, this information may be accompanied by purchase order and invoicing data).
            *  - Products to be completed in the next period.
            *  - Corrective actions to be completed during the next period.
            */
            public ReportingPeriod nextReportingPeriod { get; set; }

            /**
            * How execution of the project and management stage are performing against their tolerances (e.g. cost/time actual and forecast).
            */
            public ProjectManagementStageToleranceStatus projectManagementStageToleranceStatus { get; set; }

            /**
            * Raised, approved/rejected and pending
            */
            public ChangeRequests changeRequests { get; set; }

            /**
            * Summary of actual or potential problems and risks.
            */
            public IssuesRisks issuesRisks { get; set; }

            /**
            * A review of what went well, what went badly, and any recommendations for corporate, programme management or customer consideration.
            * Sourced from the lessons log (see section A.14) or any lessons reports that may exist.
            */
            public Lessons lessons { get; set; }

        #endregion

        #region Derivation

            public HighlightReport() { }

            public HighlightReport(
                ProjectInitiationDocumentation projectInitiationDocumentation,
                CheckpointReport[] checkpointReports,
                IssueRegister issueRegister,
                QualityRegister qualityRegister,
                RiskRegister riskRegister,
                StagePlan stagePlan,
                CommunicationManagementApproach communicationManagementApproach
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria

            /**
             * The level and frequency of progress reporting required by the project board are right for the management stage and/or project.
             */
            public bool ProgressReportingLevelFrequencyProjectBoardRequiresRightForStageProject() => throw new NotImplementedException();

            /**
             * The project manager provides the highlight report at the frequency, and with the content, required by the project board.
             */
            public bool ProjectManagerProvidesHighlightReportAtFrequencyContentRequiredByProjectBoard() => throw new NotImplementedException();

            /**
             * The information is timely, useful, accurate and objective.
             */
            public bool InformationTimelyUsefulAccurateBbjective() => throw new NotImplementedException();

            /**
             * The report highlights any potential problem areas.
             */
            public bool ReportHighlightsPotentialProblemAreas() => throw new NotImplementedException();

        #endregion

        public class StatusSummary { }

        public class ProjectManagementStageToleranceStatus { }

        public class ChangeRequests { }
    }
}