using System;
using PRINCE2.UNSORTED;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * An end project report is used during project closure to review how the project performed against the version of the PID used to authorize it.
     * It also allows the passing on of:
     * - Any lessons that can be usefully applied to other projects.
     * - Details of unfinished work, ongoing risks or potential product modifications to the group charged with future support of the project’s products in their operational life.
     */
    public class EndProjectReport
    {

        #region Composition

            /**
             * Summarizes the project’s performance
             */
            public ProjectManagerReport projectManagerReport { get; set; }

            /**
             * Summarizes the validity of the project’s business case, including:
             *  - Benefits achieved to date.
             *  - Residual benefits expected (post-project).
             *  - Expected net benefits.
             *  - Deviations from the approved business case.
             */
            public ReviewOfBusinessCase reviewOfBusinessCase { get; set; }

            /**
             * Review of how the project performed against its planned targets and tolerances for time, cost, quality, scope, benefits and risk.
             * Evaluates the effectiveness of the project’s approaches and controls.
             */
            public ReviewOfProjectObjectives reviewOfProjectObjectives { get; set; }

            /**
             * In particular, provides recognition for good performance.
             */
            public ReviewOfTeamPerformance reviewOfTeamPerformance { get; set; }

            /**
            * Consists of:
            * - Quality records:
            *     Listing the quality activities planned and completed.
            * - Approval records:
            *     Listing the products and their requisite approvals.
            * - Off-specifications:
            *     Listing any missing products or products that do not meet the original requirements, and confirmation of any concessions granted.
            * - Project product handover:
            *     Confirmation (in the form of acceptance records) by the customer that operations and maintenance functions are ready to receive the project’s product.
                  Confirmation  by the customer that operations and maintenance functions are ready to receive the release.
            * - Summary of follow-on action recommendations:
            *     Request for project board advice about who should receive each recommended action.
            *     The recommended actions are related to unfinished work, ongoing issues and risks, and any other activities needed to take the products to the next phase of their life.
            */
            public ReviewOfProducts reviewOfProducts { get; set; }

            /**
            * A review of what went well, what went badly, and any recommendations for corporate, programme management or customer consideration (and if the project was prematurely closed, then the reasons should be explained).
            * Sourced from the lessons log (see section A.14) or any lessons reports that may exist
            */
            public Lessons lessons { get; set; }

        #endregion

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
             * Any abnormal situations are described, together with their impact.
             */
            public bool AbnormalSituationsDescribedWithImpact() => throw new NotImplementedException();

            /**
             * At the end of the project, all issues should either be closed or become the subject of a follow-on action recommendation.
             */
            public bool IssuesClosedOrFollowOnActionRecommendationSubjectAtProjectEnd() => throw new NotImplementedException();

            /**
             * Any available useful documentation or evidence should accompany the follow-on action recommendation(s).
             */
            public bool DocumentationEvidenceAccompanyFollowOnActionRecommendation() => throw new NotImplementedException();

            /**
             * Any appointed project assurance roles should agree with the report.
             */
            public virtual bool ProjectAssuranceAgree() => throw new NotImplementedException();

        #endregion
    }
}