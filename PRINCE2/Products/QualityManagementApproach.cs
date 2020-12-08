using System;
using PRINCE2.UNSORTED;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * A quality management approach describes how quality will be managed on the project.
     * This includes the specific processes, procedures, techniques, standards and responsibilities to be applied.
     */
    public partial class QualityManagementApproach : Approach
    {
        #region Composition

            /**
             * A description of (or reference to) the quality management procedure to be used.
             * Any variance from corporate, programme management or customer quality standards should be highlighted, together with a justification for the variance.
             * The process or procedure should cover:
             * - Quality planning.
             * - Quality control:
             *   The project’s approach to quality control activities.
             *   This may include:
             *   - Quality standards.
             *   - Templates and forms to be employed (e.g. product description(s), quality register).
             *   - Definitions of types of quality methods (e.g. inspection, pilot).
             *   - Metrics to be employed in support of quality control.
             * - Project assurance:
             *   The project’s approach to project assurance activities.
             *   This may include:
             *   - Responsibilities of the project board.
             *   - Compliance audits.
             *   - Corporate, programme management or customer reviews.
             */
            public QualityManagementProcessProcedure qualityManagementProcessProcedure { get; set; }

            /**
             * States when formal quality management activities are to be undertaken (e.g. during audits, when this may involve reference to the quality register).
             */
            public QualityManagementActivitiesTiming qualityManagementActivitiesTiming { get; set; }

        #endregion

        #region Derivation
            public QualityManagementApproach() {}

            public QualityManagementApproach(
                ProjectBoard projectBoard,
                ProjectBrief projectBrief,
                OrganizationalStandards organizationalStandards,
                SupplierCustomerQualityManagementSystems supplierCustomerQualityManagementSystems,
                ChangeControlRequirements changeControlRequirements,
                CorporateStrategies corporateStrategies,
                FacilitatedWorkshopsInformalDiscussions facilitatedWorkshopsInformalDiscussions
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria
            /*
             * The approach clearly defines ways in which the customer’s quality expectations will be met.
             */
            public bool ApproachClearlyDefinesWaysWhichCustomersQualityExpectationsWillBeMet() => throw new NotImplementedException();

            /*
             * The defined ways are sufficient to achieve the required quality.
             */
            public bool DefinedWaysSufficientToAchieveRequiredQuality() => throw new NotImplementedException();

            /*
             * Responsibilities for quality are defined up to a level that is independent of the project and project manager.
             */
            public bool QualityResponsibilitiesDefinedUpToLevelIndependentOfProjectAndProjectManager() => throw new NotImplementedException();

            /*
             * The approach conforms to the supplier’s and customer’s quality management systems.
             */
            public bool ApproachConformsToSupplierCustomerQqualityManagementSystems() => throw new NotImplementedException();

            /*
             * The approach conforms to the corporate, programme management or customer quality policy.
             */
            public bool ApproachConformsToCorporateQualityPolicy() => throw new NotImplementedException();

            /*
             * The approaches to assuring quality for the project are appropriate in the light of the standards selected.
             */
            public bool ApproachesToAssuringQualityForProjectAreAppropriateInLightOfStandardsSelected() => throw new NotImplementedException();

        #endregion
        public class QualityManagementProcessProcedure { }

        public class QualityManagementActivitiesTiming : ActivitiesTiming { }

        public class ProjectBoard { }

        public class OrganizationalStandards { }

        public class SupplierCustomerQualityManagementSystems { }

        public class CorporateStrategies { }
    }
}