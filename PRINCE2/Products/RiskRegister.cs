using System;
using PRINCE2.UNSORTED;
using static PRINCE2.Products.ProductDescription;

namespace PRINCE2.Products
{
    public class RiskRegister
    {
        #region Composition

            /*
             * Provides a unique reference for every risk entered into the risk register.
             * It will typically be a numeric or alphanumeric value.
             */
            public RiskIdentifier riskIdentifier { get; set; }

            /*
             * The person who raised the risk.
             */
            public RiskAuthor riskAuthor { get; set; }

            /*
             * The date the risk was identified.
             */
            public DateTime dateRegistered { get; set; }

            /*
             * The type of risk in terms of the project’s chosen categories (e.g. schedule, quality, legal).
             */
            public RiskCategory riskCategory { get; set; }

            /*
             * Describes the risk in terms of the cause, event (threat or opportunity) and effect (in words of the impact).
             */
            public RiskDescription riskDescription { get; set; }

            /*
             * It is helpful to estimate the inherent values (pre-response action) and residual values (postresponse action).
             * These should be recorded in accordance with the project’s chosen scales.
             */
            public ProbabilityImpactAndExpectedValue probabilityImpactAndExpectedValue { get; set; }

            /*
             * This would typically state how close to the present time the risk event is anticipated to happen (e.g. imminent, within the management stage, within the project, beyond the project).
             * Proximity should be recorded in accordance with the project’s chosen scales.
             */
            public Proximity proximity { get; set; }

            /*
             * How the project will treat the risk in terms of the project’s chosen categories.
             * For example:
             * - For threats: avoid, reduce, transfer, share, accept, prepare contingent plans.
             * - For opportunities: exploit, enhance, transfer, share, accept, prepare contingent plans
             */
            public RiskResponseCategories riskResponseCategories { get; set; }

            /*
             * Actions to be taken to resolve the risk.
             * These actions should be aligned with the chosen response categories.
             * Note that more than one risk response may apply to a risk.
             */
            public RiskResponse riskResponse { get; set; }

            /*
             * Typically described in terms of whether the risk is active or closed.
             */
            public RiskStatus riskStatus { get; set; }

            /*
             * The person responsible for managing the risk (there should be only one risk owner per risk).
             */
            public RiskOwner riskOwner { get; set; }

            /*
             * The person(s) who will implement the action(s) described in the risk response.
             * This may or may not be the same person as the risk owner.
             */
            public RiskActionee riskActionee { get; set; }

        #endregion


        #region Derivation
            
            public RiskRegister() { }

        #endregion

        #region Quality Criteria
            /*
             * The status indicates whether action has been taken.
             */
            public bool StatusIndicatesWhetherActionTaken() => throw new NotImplementedException();

            /*
             * Risks are uniquely identified, including information about which product they refer to.
             */
            public bool RisksUniquelyIdentifiedIncludingInformationAboutProductTheyReferTo() => throw new NotImplementedException();

            /*
             * Access to the risk register is controlled.
             */
            public bool AccessToRiskRegisterControlled() => throw new NotImplementedException();

            /*
             * The risk register is kept in a safe place.
             */
            public bool RiskRegisterKeptInSafePlace() => throw new NotImplementedException();

        #endregion

        public class RiskIdentifier : Identifier { }

        public class RiskAuthor { }

        public class RiskCategory { }

        public class RiskDescription { }

        public class ProbabilityImpactAndExpectedValue { }

        public class RiskResponse { }

        public class RiskStatus { }

        public class RiskOwner { }

        public class RiskActionee { }
    }
}