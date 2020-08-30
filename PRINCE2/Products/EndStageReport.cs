using System;
using PRINCE2.UNSORTED;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * An end stage report is used to give a summary of progress to date, the overall project situation, and sufficient information to ask for a project board decision on what to do next with the project.
     * The project board uses the information in the end stage report in tandem with the next stage plan to decide what action to take with the project; for example, authorize the next stage, amend the project scope or stop the project.
     */
    public class EndStageReport : EndReport
    {

        #region Composition

            /**
            * Review of how the specific management stage performed against its planned targets and tolerances for time, cost, quality, scope, benefits and risk.
            */
            public ManagementStageObjectivesReview managementStageObjectivesReview { get; set; }

            /**
            * Summary of the current set of issues and risks affecting the project.
            */
            public IssuesRisks issuesRisks { get; set; }

            /**
            * The project manager’s forecast for the project and next management stage against planned targets and tolerances for time, cost, quality, scope, benefits and risk.
            */
            public Forecast forecast { get; set; }

        #endregion

        #region Derivation
            
            public EndStageReport() { }

            public EndStageReport(
                StagePlan stagePlan, // current management stage plan and actuals
                ProjectPlan projectPlan, // project plan
                BenefitsManagementApproach benefitsManagementApproach, // benefits management approach
                IssueRegister issueRegister,
                QualityRegister qualityRegister,
                RiskRegister riskRegister, // risk register, quality register and issue register
                ExceptionReport exceptionReport, // exception report (if applicable)
                LessonsLog lessonsLog, // lessons log
                WorkPackage[] workPackages, // completed/slipped work packages
                BusinessCase businessCase// updated business case.
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria

            /***
             * The report clearly shows management stage performance against the plan.
             */
            public bool ClearlyShowsStagePerformanceAgainstPlan() => throw new NotImplementedException();

        #endregion

        public class ManagementStageObjectivesReview { }

        public class Forecast { }
    }
}