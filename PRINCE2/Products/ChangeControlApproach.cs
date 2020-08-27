using System;
using PRINCE2.UNSORTED;
using static PRINCE2.Products.ProjectProductDescription;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * A change control approach is used to identify, assess and control any potential and approved changes to the project baselines.
     * It describes the procedures, techniques and standards to be applied and the responsibilities for achieving an effective issue management and change control procedure.
     */
    public class ChangeControlApproach : Approach
    {

        #region Composition

            /**
             * Describes (or refers to) the issue management and change control procedure to be used.
             * Any variance from corporate, programme management or customer standards should be highlighted, together with a justification for the variances.
             * The procedure should cover activities such as capturing issues, assessing their impact, proposing actions, deciding on actions, and implementing actions.
             */
            public IssueManagementChangeControlProcedure issueManagementChangeControlProcedure { get; set; }

            /**
            * States when formal activities (e.g. reviews or audits) are to be undertaken.
            */
            public IssueManagementChangeControlIssueActivitiesTiming issueManagementChangeControlIssueActivitiesTiming { get; set; }

            /**
             * Describes the scales for prioritizing requests for change and off-specifications and for determining the level of management that can make decisions on the severity of an issue.
             */
            public PrioritySeverityScales prioritySeverityScales { get; set; }

        #endregion
        
        #region Derivation
            
            public ChangeControlApproach() { }

            public ChangeControlApproach(
                CustomerQualityExpectations customerQualityExpectations,
                ChangeControlToolsSystems changeControlToolsSystems,
                CorporateQualityManagementStrategyInformationManagementStrategy corporateQualityManagementStrategyInformationManagementStrategy,
                QualityManagementSystem usersQualityManagementSystem,
                QualityManagementSystem suppliersQualityManagementSystem,
                ProjectProductEnvironmentSpecialNeeds projectProductEnvironmentSpecialNeeds,
                ProjectManagementTeamStructure projectManagementTeamStructure,
                FacilitatedWorkshopsInformalDiscussions facilitatedWorkshopsInformalDiscussions
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria

            /**
             * Responsibilities are clear and understood by both user and supplier.
             */
            public bool ResponsibilitiesClearUnderstoodByUserSupplier() => throw new NotImplementedException();
            
            /*
             * The issue management and change control procedure is clearly documented and can be understood by all parties.
             */
            public bool IssueManagementChangeControlProcedureClearlyDocumentedUnderstood() => throw new NotImplementedException();
            
            /**
             * The chosen change control approach is appropriate for the size and nature of the project.
             */
            public bool ChangeControlApproachAppropriateForProjectSizeNature() => throw new NotImplementedException();

            /**
             * Scales are clear and unambiguous.
             */
            public bool ScalesClearUnambiguous() => throw new NotImplementedException();

            /**
             * The scales are appropriate for the level of control required.
             */
            public bool ScalesAppropriateForControlLevelRequired() => throw new NotImplementedException();

            /**
             * Reporting requirements are fully defined.
             */
            public bool ReportingRequirementsFullyDefined() => throw new NotImplementedException();

            /**
             * Resources are in place to administer the chosen method of change control.
             */
            public bool ResourcesInPlaceToAdministerChosenChangeControlMethod() => throw new NotImplementedException();

        #endregion

        public class IssueManagementChangeControlProcedure { }

        public class IssueManagementChangeControlIssueActivitiesTiming: ActivitiesTiming { }

        public class PrioritySeverityScales { }

        public class ChangeControlToolsSystems { }

        public class CorporateQualityManagementStrategyInformationManagementStrategy { }

        public class ProjectProductEnvironmentSpecialNeeds { }
    }
}