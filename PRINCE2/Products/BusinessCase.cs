using System;
using PRINCE2.Roles;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * A business case is used to document the business justification for undertaking a project, based on the estimated costs (of development, implementation and incremental ongoing operations and maintenance costs) against the anticipated benefits to be gained and offset by any associated risks.
     * It should outline how and when the anticipated benefits can be measured.
     * The outline business case is developed in the starting up a project process and refined by the initiating a project process.
     * The directing a project process covers the approval and reaffirmation of the business case.
     * The business case is used by the controlling a stage process when assessing impacts of issues and risks.
     * It is reviewed and updated at the end of each management stage by the managing a stage boundary process, and at the end of the project by the closing a project process.
     */
    public class BusinessCase
    {
        #region Composition
            /**
             * Highlights the key points in the business case, which should include important benefits and the return on investment.
             */
            public ExecutiveSummary executiveSummary { get; set; }

            /**
             * Defines the reasons for undertaking the project and explains how the project will enable the achievement of corporate, programme management or customer strategies and objectives.
             */
            public Reasons reasons { get; set; }

            /**
             * Analysis and reasoned recommendation for the base business options of do nothing, do the minimum or do something.
             * ‘Do nothing’ should always be the starting option to act as the basis for quantifying the other options.
             * The difference between ‘do nothing’ and ‘do the minimum’ or ‘do something’ is the benefit that the investment will buy.
             * The analysis of each option provides the project board and the project’s stakeholders with sufficient information to judge which option presents the best value for the organization.
             * It provides the answer to the question: for this level of investment, are the anticipated benefits more desirable, viable and achievable than the other options available?
             * The business case for the chosen option should be continually assessed for desirability, viability and achievability as any new risks and/or changes may make one of the other options more justifiable.
             */
            public BusinessOptions businessOptions { get; set; }

            /**
             * These result from the desired outcomes to be achieved through the use of the project outputs.
             * The benefits are expressed in measurable terms against the situation as it exists prior to the project.
             * Benefits should be both qualitative and quantitative.
             * They should be aligned with corporate, programme management or customer benefits.
             * Tolerances should be set for each benefit and for the aggregated benefit.
             * Any benefits realization requirements should be stated.
             * The quantification of benefits enables benefits tolerances to be set (e.g. a 10–15 per cent increase in sales) and the measurability of the benefits ensures that they can be proven.
             * If the project includes benefits that cannot be proven, then it is impossible to judge whether the project:
             *  - Has been a success.
             *  - Has provided value for money.
             *  - Should be (or have been) initiated.
             * There are many ways to verify the expected benefits.
             * For example, sensitivity analysis can be used to determine whether the business case is heavily dependent on a specific benefit.
             * If it is, this may affect project planning, monitoring and control activities, and risk management, as steps would need to be taken to protect that specific benefit.
             */
            public ExpectedBenefits expectedBenefits { get; set; }

            /**
             * The impact of one or more outcomes of the project might be perceived as negative by one or more stakeholders.
             * Dis-benefits are actual consequences of an activity whereas, by definition, a risk is uncertain and may never materialize.
             * For example, a decision to merge two elements of an organization onto a new site may have benefits (e.g. better joint working), costs (e.g. expanding one of the two sites) and dis-benefits (e.g. drop in productivity during the merger).
             * Dis-benefits need to be valued and incorporated into the investment appraisal.
             */
            public ExpectedDisbenefits expectedDisbenefits { get; set; }

            /**
             * The period over which the project will run (summary of the project plan) and the period over which the benefits will be realized.
             * This information is subsequently used to help timing decisions when planning (project plan, stage plan and benefits management approach).
             */
            public Timescale timescale { get; set; }

            /**
             * A summary of the project costs (taken from the project plan), the ongoing operations and maintenance costs and their funding arrangements.
             */
            public Costs costs { get; set; }

            /**
             * Compares the aggregated benefits and disbenefits with the project costs (extracted from the project plan) and ongoing incremental operations and maintenance costs.
             * The analysis may use techniques such as cash-flow statement, return on investment, net present value, internal rate of return and payback period.
             * The objective is to be able to define the value of a project as an investment.
             * The investment appraisal should address how the project will be funded.
             */
            public InvestmentAppraisal investmentAppraisal { get; set; }

            /**
             * Gives a summary of the key risks associated with the project, together with the likely impact and plans should they occur.
             */
            public MajorRisks majorRisks { get; set; }

        #endregion

        #region Derivation
            public BusinessCase() { }

            public BusinessCase(
                ProjectMandate projectMandate,
                ProjectBrief projectBrief,
                ProjectPlan projectPlan,
                SeniorUser[] seniorUsers,
                Executive executive,
                RiskRegister riskRegister,
                IssueRegister issueRegister
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria
            
            /**
             * The reasons for the project must be consistent with the corporate, programme management or customer strategies.
             */
            public bool ReasonsConsistentWithCorporateStrategies () => throw new NotImplementedException();

            /**
             * The project plan must be aligned with the business case.
             */
            public bool ProjectPlanAlignedWithBusinessCase() => throw new NotImplementedException();

            /**
             * The benefits are clearly identified and justified.
             */
            public bool BenefitsClearlyIdentifiedJustified() => throw new NotImplementedException();

            /**
             * How the benefits will be realized must be clear.
             */
            public bool BenefitsRealizationClear() => throw new NotImplementedException();
            
            /**
             * What defines a successful outcome is described.
             */
            public bool SuccessfulOutcomeDefinitionDescribed() => throw new NotImplementedException();

            /**
             * The preferred business option is stated, along with the reasons why.
             * Where external procurement is required, the preferred sourcing option is stated, and why.
             */
            public bool PreferredBuisnessOptionStatedWithReasons() => throw new NotImplementedException();

            /**
             * How any necessary funding will be obtained is described.
             */
            public bool NecessaryFundingObtainmentDescribed() => throw new NotImplementedException();

            /**
             * The business case includes non-financial, as well as financial, criteria.
             */
            public bool IncludesCriteria() => throw new NotImplementedException();

            /**
             * The business case includes operations and maintenance costs and risks, as well as project costs and risks.
             */
            public bool IncludesOperationsMaintenaceProjectCostsRisks() => throw new NotImplementedException();

            /**
             * The business case conforms to organizational accounting standards (e.g. break-even analysis and cash-flow conventions).
             */
            public bool ConformsToAccountingStandards() => throw new NotImplementedException();

            /**
             * The major risks faced by the project are explicitly stated, together with any proposed responses.
             */
            public bool MajorRisksExplicitlyStatedProposedResponses() => throw new NotImplementedException();

        #endregion

        public class ExecutiveSummary { }

        public class Reasons { }

        public class BusinessOptions { }

        public class ExpectedBenefits { }

        public class ExpectedDisbenefits { }

        public class Timescale { }

        public class Costs { }

        public class InvestmentAppraisal { }

        public class MajorRisks { }
    }
}