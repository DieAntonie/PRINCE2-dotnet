using System;
using PRINCE2.UNSORTED;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * A quality register is used to summarize all the quality management activities that are planned or have taken place, and provides information for the end stage reports and end project report.
     * Its purpose is to:
     * - Issue a unique reference for each quality activity.
     * - Act as a pointer to the quality records for a product.
     * - Act as a summary of the number and type of quality activities undertaken.
     */
    public class QualityRegister
    {
        #region Composition
            /*
             * Provides a unique reference for every quality activity entered into the quality register.
             * It will typically be a numeric or alphanumeric value.
             */
            public QualityIdentifier qualityIdentifier { get; set; }

            /*
             * Unique identifier(s) for the product(s) that the quality activity relates to.
             */
            public ProductIdentifiers productIdentifiers { get; set; }

            /*
             * The name(s) by which the product(s) is known.
             */
            public ProductTitles productTitles { get; set; }

            /*
             * The method employed for the quality activity (e.g. pilot, quality review, audit, etc.).
             */
            public Method method { get; set; }

            /*
             * The person or team responsible for the quality management activities (e.g. auditor or, for quality reviews, presenter, reviewer(s), chair, administrator).
             */
            public RolesResponsibilities rolesResponsibilities { get; set; }

            /*
             * Planned, forecast and actual dates for:
             * - The quality activity.
             * - Sign-off that the quality activity is complete.
             */
            public Dates dates { get; set; }

            /*
             * The result of the quality activity.
             * If a product fails a quality review, then any reassessment should be listed as a separate entry in the register, as the original quality activity has been completed (in deciding that the result is a ‘fail’).
             */
            public Result result { get; set; }

            /*
             * The quality inspection documentation, such as a test plan or the details of any actions required to correct errors and omissions of the products being inspected.
             */
            public QualityRecords qualityRecords { get; set; }

        #endregion

        #region Derivation

            public QualityRegister() { }

        #endregion

        #region Quality Criteria

            /**
             * A procedure is in place that will ensure that every quality activity is entered on the quality register.
             */
            public bool ProcedureInPlaceToEnsureEveryQualityActivityEnteredOnQualityRegister() => throw new NotImplementedException();
            /**
             * Responsibility for the quality register has been allocated.
             */
            public bool ResponsibilityForQualityRegisterAllocated() => throw new NotImplementedException();
            /**
             * Actions are clearly described and assigned.
             */
            public bool ActionsClearlyDescribedAndAssigned() => throw new NotImplementedException();
            /**
             * Entries are uniquely identified, including to which product they refer.
             */
            public bool EntriesUniquelyIdentifiedIncludingToWhichProductTheyRefer() => throw new NotImplementedException();
            /**
             * Access to the quality register is controlled.
             */
            public bool AccessToQualityRegisterControlled() => throw new NotImplementedException();
            /**
             * The quality register is kept in a safe place.
             */
            public bool QualityRegisterKeptInSafePlace() => throw new NotImplementedException();
            /**
             * All quality activities are at an appropriate level of control.
             */
            public bool QualityActivitiesAtAppropriateLevelOfControl() => throw new NotImplementedException();

        #endregion

        public class QualityIdentifier { }

        public class ProductIdentifiers
        {
        }

        public class ProductTitles
        {
        }

        public class Method
        {
        }

        public class Dates
        {
        }

        public class Result
        {
        }
    }
}