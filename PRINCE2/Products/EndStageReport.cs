using System;
using PRINCE2.UNSORTED;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * An end stage report is used to give a summary of progress to date, the overall project situation, and sufficient information to ask for a project board decision on what to do next with the project.
     * The project board uses the information in the end stage report in tandem with the next stage plan to decide what action to take with the project; for example, authorize the next stage, amend the project scope or stop the project.
     */
    public partial class EndStageReport
    {

        #region Composition

            /**
             * Summarizes the management stage performance.
             */
            public ProjectManagerReport projectManagerReport { get; set; }

            /**
             * Summarizes the validity of the project’s business case, including:
             *  - Benefits achieved to date.
             *  - Residual benefits expected (remaining management stages and post-project).
             *  - Expected net benefits.
             *  - Deviations from approved business case.
             *  - Aggregated risk exposure.
             */
            public ReviewOfBusinessCase reviewOfBusinessCase { get; set; }

            /**
             * Review of how the project has performed to date against its planned targets and tolerances for time, cost, quality, scope, benefits and risk.
             * Evaluates the effectiveness of the project’s approaches and controls.
             */
            public ReviewOfProjectObjectives reviewOfProjectObjectives { get; set; }

            /**
            * Review of how the specific management stage performed against its planned targets and tolerances for time, cost, quality, scope, benefits and risk.
            */
            public ReviewOfManagementStageObjectives reviewOfManagementStageObjectives { get; set; }

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

            /**
            * Summary of the current set of issues and risks affecting the project.
            */
            public IssuesAndRisks issuesAndRisks { get; set; }

            /**
            * The project manager’s forecast for the project and next management stage against planned targets and tolerances for time, cost, quality, scope, benefits and risk.
            */
            public Forecast forecast { get; set; }

        #endregion

        #region Derivation
            
            public EndStageReport() { }

            public EndStageReport(
                StagePlan stagePlan,
                ProjectPlan projectPlan,
                BenefitsManagementApproach benefitsManagementApproach,
                IssueRegister issueRegister,
                QualityRegister qualityRegister,
                RiskRegister riskRegister,
                ExceptionReport exceptionReport,
                LessonsLog lessonsLog,
                WorkPackage[] workPackages,
                BusinessCase businessCase
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria

            /***
             * The report clearly shows management stage performance against the plan.
             */
            public bool ClearlyShowsStagePerformanceAgainstPlan() => throw new NotImplementedException();

            /**
             * Any abnormal situations are described, together with their impact.
             */
            public bool AbnormalSituationsDescribedWithImpact() => throw new NotImplementedException();

            /**
             * Any appointed project assurance roles should agree with the report.
             */
            public bool ProjectAssuranceAgree() => throw new NotImplementedException();

        #endregion
    }
}