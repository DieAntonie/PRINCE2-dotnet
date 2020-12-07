using System;
using PRINCE2.UNSORTED;
using static PRINCE2.Products.Approach;

namespace PRINCE2.Products
{
    public class RiskManagementApproach
    {

        #region Composition

            /*
             * States the purpose, objectives and scope, and identifies who is responsible for the approach.
             */
            public Introduction introduction { get; set; }

            /*
             * Describes (or refers to) the risk management process or procedure to be used.
             * Any variance from corporate, programme management or customer standards should be highlighted, together with a justification for the variance.
             * The process or procedure must describe how:
             * - Risks are identified and assessed.
             * - Risk responses are planned and implemented.
             * - Risk management activities are communicated.
             */
            public RiskManagementProcessProcedure riskManagementProcessProcedure { get; set; }

            /*
             * Refers to any risk management systems or tools to be used, and any preference for techniques which may be used for each step in the risk management procedure.
             */
            public ToolsTechniques toolsTechniques { get; set; }

            /*
             * Defines the composition and format of the risk register and any other risk records to be used by the project.
             */
            public Records records { get; set; }

            /*
             * Describes any risk management reports that are to be produced, including their purpose, timing and recipients.
             */
            public Reporting reporting { get; set; }

            /*
             * States when formal risk management activities are to be undertaken (e.g. at the end of management stages).
             */
            public RiskManagementActivitiesTiming riskManagementActivitiesTiming { get; set; }

            /*
             * Defines the roles and responsibilities for risk management activities.
             */
            public RolesResponsibilities rolesResponsibilities { get; set; }

            /*
             * Defines the scales for estimating probability and impact for the project to ensure that the scales for cost and time (for instance) are relevant to the cost and timeframe of the project.
             * These may be shown in the form of probability impact grids giving the criteria for each level within the scale (e.g. for ‘very high’, ‘high’, ‘medium’, ‘low’ and ‘very low’).
             */
            public Scales scales { get; set; }

            /*
             * Provides guidance on how proximity for risk events is to be assessed.
             * Proximity reflects the fact that risks will occur at particular times and the severity of their impact will vary according to when they occur.
             * Typical proximity categories will be: imminent, within the management stage, within the project, beyond the project.
             */
            public Proximity proximity { get; set; }

            /*
             * Defines the risk categories to be used (if at all).
             * These may be derived from a risk breakdown structure or prompt list.
             * If no risks have been recorded against a category, this may suggest that the risk identification has not been as thorough as it should have been.
             */
            public RiskCategories riskCategories { get; set; }

            /*
             * Defines the risk response categories to be used, which themselves depend on whether a risk is a perceived threat or an opportunity.
             */
            public RiskResponseCategories riskResponseCategories { get; set; }

            /*
             * Defines any indicators to be used to track critical aspects of the project so that if certain predefined levels are reached corrective action will be triggered.
             * They will be selected for their relevance to the project objectives.
             */
            public EarlyWarningIndicators earlyWarningIndicators { get; set; }

            /*
             * Defines the threshold levels of risk exposure which, when exceeded, require the risk to be escalated to the next level of management.
             * (For example, a project-level risk tolerance could be set as any risk that, should it occur, would result in loss of trading.
             * Such risks would need to be escalated to corporate, programme management or the customer.)
             * The risk tolerance should define the risk expectations of corporate, programme management or customer and the project board.
             */
            public RiskTolerance riskTolerance { get; set; }

            /*
             * Describes whether a risk budget is to be established and, if so, how it will be used.
             */
            public RiskBudget riskBudget { get; set; }

        #endregion

        #region Derivation
            public RiskManagementApproach() { }

            public RiskManagementApproach(
                ProjectBrief projectBrief,
                BusinessCase businessCase,
                CorporateRiskManagementGuides corporateRiskManagementGuides
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria

            /*
             * Responsibilities are clear and understood by both customer and supplier.
             */
            public bool ResponsibilitiesClearAndUnderstoodByCustomerAndSupplier() => throw new NotImplementedException();

            /*
             * The risk management procedure is clearly documented and can be understood by all parties.
             */
            public bool RiskManagementProcedureClearlyDocumentedAndUnderstoodByAll() => throw new NotImplementedException();

            /*
             * Scales, expected value and proximity definitions are clear and unambiguous.
             */
            public bool ScalesExpectedValueAndProximityDefinitionsClearAndUnambiguous() => throw new NotImplementedException();

            /*
             * The chosen scales are appropriate for the level of control required.
             */
            public bool ChosenScalesAreAppropriateForLevelOfControlRequired() => throw new NotImplementedException();

            /*
             * Risk reporting requirements are fully defined.
             */
            public bool RiskReportingRequirementsFullyDefined() => throw new NotImplementedException();

        #endregion

        public class RiskManagementProcessProcedure { }

        public class RiskManagementActivitiesTiming : ActivitiesTiming { }

        public class Scales { }

        public class Proximity { }

        public class RiskCategories { }

        public class RiskResponseCategories { }

        public class EarlyWarningIndicators { }

        public class RiskTolerance { }

        public class RiskBudget { }
    }
}