using System;
using PRINCE2.UNSORTED;

namespace PRINCE2.Products
{
    public abstract partial class EndReport
    {
        #region Composition

            /**
             * End Project Report:
             * Summarizes the project’s performance
             *
             * End Stage Report:
             * Summarizes the management stage performance.
             */
            public ProjectManagerReport projectManagerReport { get; set; }

            /**
             * End Project Report:
             * Summarizes the validity of the project’s business case, including:
             *  - Benefits achieved to date.
             *  - Residual benefits expected (post-project).
             *  - Expected net benefits.
             *  - Deviations from the approved business case.
             *
             * End Stage Report:
             * Summarizes the validity of the project’s business case, including:
             *  - Benefits achieved to date.
             *  - Residual benefits expected (remaining management stages and post-project).
             *  - Expected net benefits.
             *  - Deviations from approved business case.
             *  - Aggregated risk exposure.
             */
            public BusinessCaseReview businessCaseReview { get; set; }

            /**
             * Evaluates the effectiveness of the project’s approaches and controls.
             *
             * End Project Report:
             * Review of how the project performed against its planned targets and tolerances for time, cost, quality, scope, benefits and risk.
             *
             * End Stage Report:
             * Review of how the project has performed to date against its planned targets and tolerances for time, cost, quality, scope, benefits and risk.
             */
            public ProjectObjectivesReview projectObjectivesReview { get; set; }

            /**
             * In particular, provides recognition for good performance.
             */
            public TeamPerformanceReview teamPerformanceReview { get; set; }

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
            public ProductsReview productsReview { get; set; }

            /**
            * A review of what went well, what went badly, and any recommendations for corporate, programme management or customer consideration (and if the project was prematurely closed, then the reasons should be explained).
            * Sourced from the lessons log (see section A.14) or any lessons reports that may exist
            */
            public Lessons lessons { get; set; }

        #endregion

        #region Quality Criteria

            /**
             * Any abnormal situations are described, together with their impact.
             */
            public virtual bool AbnormalSituationsDescribedWithImpact() => throw new NotImplementedException();

            /**
             * Any appointed project assurance roles should agree with the report.
             */
            public virtual bool ProjectAssuranceAgree() => throw new NotImplementedException();

        #endregion

        public class ProjectManagerReport { }

        public class BusinessCaseReview { }

        public class ProjectObjectivesReview { }

        public class TeamPerformanceReview { }

        public class ProductsReview { }

    }

}