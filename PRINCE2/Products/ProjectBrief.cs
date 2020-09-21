using System;
using PRINCE2.UNSORTED;

namespace PRINCE2.Products
{
    /*
     * Purpose:
     * A project brief is used to provide a full and firm foundation for the initiation of the project and is created in the starting up a project process.
     * In the initiating a project process, the contents of the project brief are extended and refined in the PID, after which the project brief is no longer maintained.
     */
    public class ProjectBrief
    {

        #region Composition
            /**
             * Explains what the project needs to achieve.
             * It should include:
             * - Background.
             * - Project objectives (covering time, cost, quality, scope, benefits and risk performance).
             * - Desired outcomes.
             * - Project scope and exclusions.
             * - Constraints and assumptions.
             * - Project tolerances.
             * - The user(s) and any other known interested parties.
             * - Interfaces.
             */
            public ProjectDefinition projectDefinitions { get; set; }

            /**
             * Reasons why the project is needed and the business option selected.
             * This will later be developed into a detailed business case during the initiating a project process.
             */
            public BusinessCase outlineBusinessCase { get; set; }

            /**
             * Includes the customer’s quality expectations, user acceptance criteria, and operations and maintenance acceptance criteria.
             */
            public ProjectProductDescription projectProductDescription { get; set; }

            /**
             * Defines the choice of solution that will be used within the project to deliver the business option selected from the business case.
             * This will take into consideration the operational environment into which the solution must fit and any tailoring requirements (if known).
             */
            public ProjectApproach projectApproach { get; set; }

            /**
             * A chart showing who will be involved with the project.
             */
            public ProjectManagementTeamStructure projectManagementTeamStructure { get; set; }

            /**
             * These describe the roles of those in the project management team and any other key resources identified at this time.
             */
            public RoleDescriptions roleDescriptions { get; set; }

            /**
             * These include references to any associated documents or products.
             */
            public References references { get; set; }

        #endregion

        #region Derivation

            public ProjectBrief() { }

            public ProjectBrief(
                ProjectMandate projectMandate,
                ProgrammeManagement programmeManagement,
                DiscussionsRegardingCorporateStrategieAndPoliciesStandards discussionsRegardingCorporateStrategieAndPoliciesStandards,
                DiscussionsIfProjectMandateIncomplete discussionsIfProjectMandateIncomplete,
                DiscussionsWithOperationsMaintenanceOrganization discussionsWithOperationsMaintenanceOrganization,
                DiscussionsWithSuppliersRegardingSpecialistDeliveryApproach discussionsWithSuppliersRegardingSpecialistDeliveryApproach,
                LessonsLog lessonsLog
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria

            /**
             * It is brief because its purpose at this point is to provide a firm basis on which to initiate a project.
             * It will later be refined and expanded as part of the PID.
             */
            public bool IsBriefBecauseProvidesFirmBasisToInitiateProject() => throw new NotImplementedException();

            /**
             * It accurately reflects the project mandate and the requirements of the business and the users.
             */
            public bool AccuratelyReflectsProjectMandateAndBusinessUsersRequirements() => throw new NotImplementedException();

            /**
             * The project approach considers a range of solutions, such as:
             * - Bespoke or Off-the-shelf;
             * - Contracted-out or Developed in-house;
             * - Designed from scratch or Modified from an existing product.
             */
            public bool ProjectApproachConsidersAllSolutions() => throw new NotImplementedException();

            /**
             * The project approach selected maximizes the chance of achieving overall success for the project.
             */
            public bool ProjectApproachSelectedMaximizesProjectSuccessChance() => throw new NotImplementedException();

            /**
             * The project objectives and project approaches are consistent with the organization’s social responsibility directive.
             */
            public bool ProjectObjectivesAndProjectApproachesConsistentWithOrganizationsSocialResponsibilityDirective() => throw new NotImplementedException();

            /**
             * The project objectives are specific, measurable, achievable, relevant and time-bound (SMART).
             */
            public bool ProjectObjectivesAreSMART() => throw new NotImplementedException();

        #endregion

        public class References { }

        public class ProgrammeManagement { }

        public class DiscussionsRegardingCorporateStrategieAndPoliciesStandards { }

        public class DiscussionsIfProjectMandateIncomplete { }

        public class DiscussionsWithOperationsMaintenanceOrganization { }

        public class DiscussionsWithSuppliersRegardingSpecialistDeliveryApproach { }

    }
}