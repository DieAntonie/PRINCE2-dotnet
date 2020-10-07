using System;
using PRINCE2.UNSORTED;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * The project product description is a special form of product description that defines what the project must deliver in order to gain acceptance.
     * It is used to:
     * - Gain agreement from the user on the project’s scope and requirements.
     * - Define the customer’s quality expectations.
     * - Define the acceptance criteria, method and responsibilities for the project.
     * The product description for the project product is created in the starting up a project process as part of the initial scoping activity, and is refined during the initiating a project process when creating the project plan.
     * It is subject to formal change control and should be checked at management stage boundaries (during managing a stage boundary) to see if any changes are required.
     * It is used by the closing a project process as part of the verification that the project has delivered what was expected of it, and that the acceptance criteria have been met.
     */
    public class ProjectProductDescription
    {
        #region Composition

            /**
             * Name by which the project is known.
             */
            public Title title { get; set; }

            /**
             * This defines the purpose that the project’s product will fulfil and who will use it.
             * It is helpful in understanding the product’s functions, size, quality, complexity, robustness, etc.
             */
            public Purpose purpose { get; set; }

            /**
             * A description of the major products and/or outcomes to be delivered by the project.
             */
            public Composition composition { get; set; }

            /**
             * What are the source products from which this product is derived?
             * Examples are:
             * - Existing products to be modified.
             * - Design specifications.
             * - A feasibility report.
             * - The project mandate.
             */
            public Derivation derivation { get; set; }

            /**
             * An indication of the skills required to develop the product, or a pointer to which area(s) should supply the development resources.
             */
            public DevelopmentSkillsRequired developmentSkillsRequired { get; set; }

            /**
             * A description of the quality expected of the project’s products and/or outcomes and the standards and processes that will need to be applied to achieve that quality.
             * They will impact on every part of the product development, and thus on time and cost.
             * The quality expectations are captured in discussions with the customer.
             * Where possible, expectations should be prioritized.
             */
            public CustomerQualityExpectations customerQualityExpectations { get; set; }

            /**
             * A prioritized list of criteria that the project’s products and/or outcomes must meet before the customer will accept them.
             * These are measurable definitions of the attributes that must apply to the set of products to be acceptable to key stakeholders and, in particular, the users and the operational and maintenance organizations.
             * Examples are ease of use, ease of support, ease of maintenance, appearance, major functions, development costs, running costs, capacity, availability, reliability, security, accuracy or performance.
             */
            public AcceptanceCriteria acceptanceCriteria { get; set; }

            /**
             * Specification of any tolerances that may apply for the acceptance criteria.
             */
            public QualityTolerance projectLevelQualityTolerance { get; set; }

            /**
             * Statement of the means by which acceptance will be confirmed.
             * This may simply be a case of confirming that all the project’s products and/or outcomes have been approved or may involve describing complex handover arrangements for the project’s products, including any phased handover of the project’s products.
             */
            public AcceptanceMethod acceptanceMethod { get; set; }

            /**
             * Definition of who will be responsible for confirming acceptance.
             */
            public AcceptanceResponsibilities acceptanceResponsibilities { get; set; }

        #endregion

        #region Derivation

            public ProjectProductDescription() { }

            public ProjectProductDescription(
                ProjectMandate projectMandate,
                ScopingWorkshopDiscussionsWithSeniorUserExecutive scopingWorkshopDiscussionsWithSeniorUserExecutive,
                RequestForProposal requestForProposal
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria

            /**
             * The purpose is clear.
             */
            public bool PurposeIsClear() => throw new NotImplementedException();

            /**
             * The composition defines the complete scope of the project.
             */
            public bool CompositionDefinesCompleteScopeOfProject() => throw new NotImplementedException();

            /**
             * The acceptance criteria form the complete list against which the project will be assessed.
             */
            public bool AcceptanceCriteriaFormCompleteListAgainstWhichProjectWillBeAssessed() => throw new NotImplementedException();

            /**
             * The acceptance criteria address the requirements of all the key stakeholders (e.g. operations and maintenance).
             */
            public bool AcceptanceCriteriaAddressesAllStakeholderRequirements() => throw new NotImplementedException();

            /**
             * The project product description defines how the users and the operational and maintenance organizations will assess the acceptability of the finished product(s). It should ensure that:
             * - All criteria are measurable
             * - Each individual criterion is realistic
             * - The criteria are consistent as a set. For example, high quality, early delivery and low cost may not go together
             * - All criteria can be proven within the project life (e.g. the maximum throughput of a water pump) or by proxy measures that provide reasonable indicators as to whether acceptance criteria will be achieved post-project (e.g. a water pump that complies with design and manufacturing standards of reliability)
             */
            public bool ProjectProductDescriptionDefinesHowUsersOperationalMaintenanceOrganizationsWillAssessFinishedProductAcceptability() => throw new NotImplementedException();

            /**
             * The quality expectations have been considered, including:
             * - The characteristics of the key quality requirements (e.g. fast/slow, large/small, national/global)
             * - The elements of the customer’s quality management system that should be used
             * - Any other standards that should be used
             * - The level of customer/staff satisfaction that should be achieved if surveyed.
             */
            public bool QualityExpectationsConsidered() => throw new NotImplementedException();

        #endregion

        public class AcceptanceCriteria { }

        public class AcceptanceMethod { }

        public class AcceptanceResponsibilities { }

        public class ScopingWorkshopDiscussionsWithSeniorUserExecutive { }

        public class RequestForProposal { }

    }
}
