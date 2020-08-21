using System;
using PRINCE2.UNSORTED;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * A benefits management approach defines the benefits management actions and benefits reviews that will be put in place to ensure that the project’s outcomes are achieved and confirm that the project’s benefits are realized.
     * If the project is part of a programme, the benefits management approach may be contained within the programme benefits realization plan and executed at the programme level.
     * Post-project, the benefits management approach is maintained and executed by corporate, programme management or the customer.
     */
    public class BenefitsManagementApproach
    {
        #region Composition

            /** 
            * The scope of the benefits management approach covering what benefits are to be managed and measured.
            */
            public BenefitsScope benefitsScope { get; set; }

            /** 
            * Who is accountable for the expected benefits.
            */
            public BenefitsAccountability benefitsAccountability { get; set; }

            /** 
            * What management actions are required in order to ensure that the project’s outcomes are achieved.
            */
            public BenefitsManagementsActions benefitsManagementsActions { get; set; }

            /** 
            * How to measure achievement of expected benefits, and when they can be measured.
            */
            public BenefitsMeasurementDetails benefitsMeasurementDetails { get; set; }

            /** 
            * What resources are needed.
            */
            public BenefitsResources benefitsResources { get; set; }

            /** 
            * Baseline measures from which the improvements will be calculated.
            */
            public BenefitsBaselineMeasurements benefitsBaselineMeasurements { get; set; }

            /** 
            * How the performance of the project’s product will be reviewed.
            */
            public BenefitsReviews benefitsReviews { get; set; }

        #endregion

        #region Derivation

            public BenefitsManagementApproach() { }

            public BenefitsManagementApproach(
                BusinessCase businessCase,
                ProjectProductDescription projectProductDescription,
                BenefitsManagementApproach programmeBenefitsManagementApproach,
                PerformanceMonitoringFunction performanceMonitoringFunction
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria

            /** 
            * It covers all benefits stated in the business case.
            */
            public bool CoversAllBenefits() => throw new NotImplementedException();

            /** 
            * The benefits are measurable and baseline measures have been recorded.
            */
            public bool AllBenefitsMeasurable() => throw new NotImplementedException();

            /** 
            * It describes suitable timing for measurement of benefits, together with reasons for the timing.
            */
            public bool SuitableTimingForBenefitsMeasurement() => throw new NotImplementedException();

            /** 
            * It identifies the skills or individuals who will be needed to carry out the measurements.
            */
            public bool SkillsIdentifiedToCarryOutMeasurements() => throw new NotImplementedException();

            /** 
            * The effort and cost to undertake the benefits reviews are realistic when compared with the value of the anticipated benefits.
            */
            public bool BenefitsReviewsJustified() => throw new NotImplementedException();

            /** 
            * Consideration is given to whether dis-benefits should be measured and reviewed.
            */
            public bool DisBenefitsConsidered() => throw new NotImplementedException();

        #endregion

        public class BenefitsManagementsActions { }

        public class BenefitsScope { }

        public class BenefitsAccountability { }

        public class BenefitsMeasurementDetails { }

        public class BenefitsResources { }

        public class BenefitsBaselineMeasurements { }

        public class BenefitsReviews { }
    }
}