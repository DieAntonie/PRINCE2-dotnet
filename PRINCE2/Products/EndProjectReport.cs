using System;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * An end project report is used during project closure to review how the project performed against the version of the PID used to authorize it.
     * It also allows the passing on of:
     * - Any lessons that can be usefully applied to other projects.
     * - Details of unfinished work, ongoing risks or potential product modifications to the group charged with future support of the project’s products in their operational life.
     */
    public class EndProjectReport : EndReport
    {

        #region Derivation
            public EndProjectReport() { }

            public EndProjectReport(
                ProjectInitiationDocumentation projectInitiationDocumentation,
                BusinessCase businessCase,
                ProjectPlan projectPlan,
                BenefitsManagementApproach benefitsManagementApproach,
                IssueRegister issueRegister,
                QualityRegister qualityRegister,
                RiskRegister riskRegister,
                LessonsLog lessonsLog,
                EndStageReport endStageReport
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria

            /**
             * At the end of the project, all issues should either be closed or become the subject of a follow-on action recommendation.
             */
            public bool IssuesClosedOrFollowOnActionRecommendationSubjectAtProjectEnd() => throw new NotImplementedException();

            /**
             * Any available useful documentation or evidence should accompany the follow-on action recommendation(s).
             */
            public bool DocumentationEvidenceAccompanyFollowOnActionRecommendation() => throw new NotImplementedException();

        #endregion
    }
}