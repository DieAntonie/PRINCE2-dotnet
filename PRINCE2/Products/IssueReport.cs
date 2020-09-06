using System;
using static PRINCE2.Products.IssueRegister;

namespace PRINCE2.Products
{
    /**
    * Purpose:
    * An issue report is a report containing the description, impact assessment and recommendations for a request for change, off-specification or a problem/concern.
    * It is created only for those issues that need to be handled formally.
    * The report is initially created when capturing the issue, and updated both after the issue has been examined and when proposals are identified for issue resolution.
    * The issue report is later amended further in order to record what option was decided upon, and finally updated when the implementation has been verified and the issue is closed.
    */
    public class IssueReport
    {
        #region Composition

            /**
             * As shown in the issue register (provides a unique reference for every issue report).
             */
            public IssueIdentifier issueIdentifier { get; set; }

            /**
             * Defines the type of issue being recorded, namely:
             * - Request for change.
             * - Off-specification.
             * - Problem/Concern.
             */
            public IssueType issueType { get; set; }

            /**
             * The date on which the issue was originally raised.
             */
            public DateTime dateRaised { get; set; }

            /**
             * The name of the individual or team who raised the issue.
             */
            public RaisedBy raisedBy { get; set; }

            /**
             * The name of the individual or team who created the issue report.
             */
            public IssueReportAuthor issueReportAuthor { get; set; }

            /**
             * Describes the issue in terms of its cause and impact.
             */
            public IssueDescription issueDescription { get; set; }

            /**
             * A detailed analysis of the likely impact of the issue.
             * This may include, for example, a list of products impacted.
             */
            public ImpactAnalysis impactAnalysis { get; set; }

            /**
             * A description of what the project manager believes should be done to resolve the issue (and why).
             */
            public Recommendation recommendation { get; set; }

            /**
             * This should be given in terms of the project’s chosen scale.
             * It should be re-evaluated after impact analysis.
             */
            public Priority priority { get; set; }

            /**
             * This should be given in terms of the project’s chosen scale.
             * Severity will indicate what level of management is required to make a decision on the issue.
             */
            public Severity severity { get; set; }

            /**
             * The decision made (accept, reject, defer or grant concession).
             */
            public Decision decision { get; set; }

            /**
             * A record of who made the decision.
             */
            public ApprovedBy approvedBy { get; set; }

            /**
             * The date of the decision.
             */
            public DateTime decisionDate { get; set; }

            /**
             * The date that the issue was closed.
             */
            public DateTime closureDate { get; set; }

        #endregion

        #region Derivation
            public IssueReport() { }

            public IssueReport(
                HighlightReport[] highlightReports,
                CheckpointReport[] checkpointReports,
                EndStageReport[] endStageReports,
                StagePlan stagePlan,
                UsersSuplierTeams usersSuplierTeams,
                QualityControlApplication qualityControlApplication,
                ProcessObservationExperience processObservationExperience,
                LessonsLog lessonsLog,
                QualityRegister qualityRegister,
                RiskRegister riskRegister,
                WorkPackage[] completedWorkPackages
            ) => throw new NotImplementedException();
        #endregion

        #region Quality Criteria

            /**
             * The issue stated is clear and unambiguous.
             */
            public bool IssueStatedClearUnambiguous() => throw new NotImplementedException();

            /**
             * A detailed impact analysis has occurred.
             */
            public bool DetailedImpactAnalysisOccurred() => throw new NotImplementedException();

            /**
             * All implications have been considered.
             */
            public bool AllImplicationsConsidered() => throw new NotImplementedException();

            /**
             * The issue has been examined for its effect on the tolerances.
             */
            public bool IssueExaminedForEffectOnTolerances() => throw new NotImplementedException();

            /**
             * The issue has been correctly registered in the issue register.
             */
            public bool IssueCorrectlyRegisteredInIssueRegister() => throw new NotImplementedException();

            /**
             * Decisions are accurately and unambiguously described.
             */
            public bool DecisionsAccuratelyUnambiguouslyDescribed() => throw new NotImplementedException();

        #endregion

        public class ImpactAnalysis { }

        public class Recommendation { }

        public class Decision { }

        public class ApprovedBy { }

        public class UsersSuplierTeams
        {
        }

        public class QualityControlApplication
        {
        }

        public class ProcessObservationExperience
        {
        }
    }
}