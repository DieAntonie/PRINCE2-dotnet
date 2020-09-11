using System;
using PRINCE2.UNSORTED;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * A product description is used to:
     * - Understand the detailed nature, purpose, function and appearance of the product.
     * - Define who will use the product.
     * - Identify the sources of information or supply for the product.
     * - Identify the level of quality required of the product.
     * - Enable identification of activities to produce, review and approve the product.
     * - Define the people or skills required to produce, review and approve the product.
     */
    public class ProductDescription
    {

        #region Composition

            /**
             * Unique key, probably allocated by the change control method and likely to include the project name, item name and version number.
             */
            public Identifier identifier { get; set; }

            /**
             * Name by which the product is known.
             */
            public Title title { get; set; }

            /**
             * This defines the purpose that the product will fulfil and who will use it.
             * Is it a means to an end or an end in itself?
             * It is helpful in understanding the product’s functions, size, quality, complexity, robustness, etc.
             */
            public Purpose purpose { get; set; }

            /**
             * This is a list of the parts of the product.
             * For example, if the product were a report, this would be a list of the expected chapters or sections.
             */
            public Composition composition { get; set; }

            /**
             * What are the source products from which this product is derived?
             * Examples are:
             * - A design is derived from a specification.
             * - A product is bought in from a supplier.
             * - A statement of the expected benefits is obtained from the user.
             * - A product is obtained from another department or team.
             */
            public Derivation derivation { get; set; }

            /**
             * The characteristics of the product;
             * for example, if the product were a report, this would specify whether the report should be a document, presentation slides or an email.
             */
            public FormatPresentation formatPresentation { get; set; }

            /**
             * An indication of the skills required to develop the product or a pointer to which area(s) should supply the development resources.
             * Identification of the actual people may be left until planning the management stage in which the product is to be created.
             */
            public DevelopmentSkillsRequired developmentSkillsRequired { get; set; }

            /**
             * To what quality specification must the product be produced, and what quality measurements will be applied by those inspecting the finished product?
             * This might be a simple reference to one or more common standards that are documented elsewhere, or it might be a full explanation of some yardstick to be applied.
             * If the product is to be developed and approved in different states (e.g. dismantled machinery, moved machinery and reassembled machinery), then the quality criteria should be grouped into those that apply for each state.
             */
            public QualityCriteria qualityCriteria { get; set; }

            /**
             * Details of any range in the quality criteria within which the product would be acceptable.
             */
            public QualityTolerance qualityTolerance { get; set; }

            /**
             * The kinds of quality method (e.g. design verification, pilot, test, inspection or review) that are to be used to check the quality or functionality of the product.
             */
            public QualityMethod qualityMethod { get; set; }

            /**
             * An indication of the skills required to undertake the quality method or a pointer to which area(s) should supply the checking resources.
             * Identification of the actual people may be left until planning the management stage in which the quality inspection is to be done.
             */
            public QualitySkillsRequired qualitySkillsRequired { get; set; }

            /**
             * These define the producer, reviewer(s) and approver(s) for the product.
             */
            public QualityResponsibilities qualityResponsibilities { get; set; }

        #endregion

        #region Derivation

            public ProductDescription() { }

            public ProductDescription(
                ProductBreakdownStructure productBreakdownStructure,
                EndUsers endUsers,
                QualityManagementApproach qualityManagementApproach,
                ChangeControlApproach changeControlApproach
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria

            /**
             * The purpose of the product is clear and is consistent with that of other products.
             */
            public bool ProductPurposeClearConsistentWithOtherProducts() => throw new NotImplementedException();

            /**
             * The product is described to a level of detail that is sufficient to plan and manage its development.
             */
            public bool ProductDescribedSufficientlyToPlanManageDevelopment() => throw new NotImplementedException();

            /**
             * The product description is concise yet sufficient enough to enable the product to be produced, reviewed and approved.
             */
            public bool ProductDescriptionConciseSufficientToEnableProductProductionReviewApproval() => throw new NotImplementedException();

            /**
             * Responsibility for the development of the product is clearly identified.
             */
            public bool ProductDevelopmentResponsibilityClearlyIdentified() => throw new NotImplementedException();

            /**
             * Responsibility for the development of the product is consistent with the roles and responsibilities described in the project management team organization and the quality management approach.
             */
            public bool ProductDevelopmentResponsibilityConsistentWithRolesResponsibilitiesInProjectManagementTeamOrganizationQualityManagementApproach() => throw new NotImplementedException();

            /**
             * The quality criteria are consistent with the project quality standards, standard checklists and acceptance criteria.
             */
            public bool QualityCriteriaConsistentWithProjectQualityStandardsStandardChecklistsAcceptanceCriteria() => throw new NotImplementedException();

            /**
             * The quality criteria can be used to determine when the product is fit for purpose.
             */
            public bool QualityCriteriaUsefulToDetermineWhenProductFitForPurpose() => throw new NotImplementedException();

            /**
             * The types of quality inspection required are able to verify whether the product meets its stated quality criteria.
             */
            public bool QualityInspectionTypesRequiredAbleToVerifyWhetherProductMeetsStatedQualityCriteria() => throw new NotImplementedException();

            /**
             * The senior user(s) confirms that their requirements of the product, as defined in the product description, are accurately described.
             */
            public bool SeniorUsersConfirmsProductRequirementsDefinedInProductDescriptionAreAccuratelyDescribed() => throw new NotImplementedException();

            /**
             * The senior supplier(s) confirms that the requirements of the product, as defined in the product description, can be achieved.
             */
            public bool SeniorSuppliersConfirmsProductRequirementsDefinedInProductDescriptionAreAchievable() => throw new NotImplementedException();

        #endregion

        public class Identifier { }

        public class Title { }

        public class Purpose { }

        public class Composition { }

        public class Derivation { }

        public class FormatPresentation { }

        public class DevelopmentSkillsRequired { }

        public class QualityCriteria { }

        public class QualityTolerance { }

        public class QualityMethod { }

        public class QualitySkillsRequired { }

        public class QualityResponsibilities { }

        public class EndUsers { }

    }
}