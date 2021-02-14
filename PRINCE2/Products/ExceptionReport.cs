using System;
using PRINCE2.UNSORTED;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * An exception report is produced when a stage plan or project plan is forecast to exceed tolerance levels set.
     * It is prepared by the project manager in order to inform the project board of the situation, and to offer options and recommendations for the way to proceed.
     */
    public partial class ExceptionReport {

        #region Composition

            /**
            * An overview of the exception being reported.
            */
            public ExceptionTitle exceptionTitle { get; set; }

            /**
            * A description of the cause of a deviation from the current plan.
            */
            public CauseOfTheException causeOfTheException { get; set; }

            /**
            * What the implications are if the deviation is not addressed for:
            * - the project.
            * - corporate, programme management or the customer.
            */
            public ConsequencesOfTheDeviation consequencesOfTheDeviation { get; set; }

            /**
            * What options are available to address the deviation and the effect of each option on the business case, risks and tolerances.
            */
            public Options options { get; set; }

            /**
            * Of the available options, which is recommended, and why?
            */
            public Recommendation recommendation { get; set; }

            /**
            * What can be learned from the exception, on this project or future projects?
            */
            public Lessons lessons { get; set; }        

        #endregion

        #region Derivation

            public ExceptionReport() {}

            public ExceptionReport(
                Plan plan,
                IssueRegister issueRegister,
                QualityRegister qualityRegister,
                RiskRegister riskRegister,
                HighlightReport highlightReport,
                IssueReport issueReport,
                CheckpointReport checkpointReport,
                ProjectBoardAdvice projectBoardAdvice
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria

            /**
             * The current plan must accurately show the status of time and cost performance.
             */
            public bool PlanAccuratelyShowsTimeCostPerformanceStatus() => throw new NotImplementedException();

            /**
             * The reason(s) for the deviation must be stated, the exception clearly analysed, and any impacts assessed and fully described.
             */
            public bool DeviationReasonsStatedExceptionAnalysedImpactsAssessedFullyDescribed() => throw new NotImplementedException();

            /**
             * The implications for the business case have been considered and the impact on the overall project plan has been calculated.
             */
            public bool BusinessCaseImplicationsConsideredProjectPlanImpactCalculated() => throw new NotImplementedException();

            /**
             * Options are analysed (including any risks associated with them) and recommendations are made for the most appropriate way to proceed.
             */
            public bool OptionsAnalysedProceedingRecommendationsMade() => throw new NotImplementedException();

            /**
             * The exception report is given in a timely and appropriate manner.
             */
            public bool ExceptionReportGivenTimelyAppropriate() => throw new NotImplementedException();

        #endregion
    }
}
