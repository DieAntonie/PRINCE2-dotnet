using System;
using PRINCE2.UNSORTED;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * The purpose of the PID is to define the project, in order to form the basis for its management and an assessment of its overall success.
     * The PID gives the direction and scope of the project and (along with the stage plan) forms the ‘contract’ between the project manager and the project board.
     * 
     * The three primary uses of the PID are to:
     * - Ensure that the project has a sound basis before asking the project board to make any major commitment to the project.
     * - Act as a base document against which the project board and project manager can assess progress, issues and ongoing viability questions.
     * - Provide a single source of reference about the project so that people joining the ‘temporary organization’ can quickly and easily find out what the project is about, and how it is being managed.
     * 
     * The PID is a living product in that it should always reflect the current status, plans and controls of the project.
     * Its component products will need to be updated and re-baselined, as necessary, at the end of each management stage, to reflect the current status of its constituent parts.
     * The version of the PID that was used to gain authorization for the project is preserved as the basis against which performance will later be assessed when closing the project.
     */
    public class ProjectInitiationDocumentation
    {
        
        #region Composition

            /**
             * Explains what the project needs to achieve.
             * It should include:
             * - Background.
             * - Project objectives and desired outcomes.
             * - Project scope and exclusions.
             * - Constraints and assumptions.
             * - The user(s) and any other known interested parties.
             * - Interfaces
             */
            public ProjectDefinition MyProperty { get; set; }

            /**
             * Defines the choice of solution that will be used in the project to deliver the business option selected from the business case, taking into consideration the operational environment into which the solution must fit.
             */
            public ProjectApproach projectApproach { get; set; }

            /**
             * Describes the justification for the project based on estimated costs, risks and benefits.
             */
            public BusinessCase businessCase { get; set; }

            /**
             * A chart showing who will be involved with the project.
             */
            public ProjectManagementTeamStructure projectManagementTeamStructure { get; set; }

            /**
             * These describe the roles of those in the project management team and any other key resources.
             */
            public RoleDescriptions roleDescriptions { get; set; }

            /**
             * Describes the quality techniques and standards to be applied, and the responsibilities for achieving the required quality levels.
             * Where the project is subject to the commissioning organization’s quality management policies/strategies, the PID should make reference to them rather than duplicate them.
             * Where the project is not subject to the commissioning organization’s quality management policies/strategies, appropriate strategies/approaches should be documented.
             */
            public QualityManagementApproach qualityManagementApproach { get; set; }

            /**
             * Describes how and by whom the project’s products will be controlled and protected.
             * Where the project is subject to the commissioning organization’s change control policies/strategies, the PID should make reference to them rather than duplicate them.
             * Where the project is not subject to the commissioning organization’s change control policies/strategies, appropriate strategies/approaches should be documented.
             */
            public ChangeControlApproach changeControlApproach { get; set; }

            /**
             * Describes the specific risk management techniques and standards to be applied, and the responsibilities for achieving an effective risk management procedure.
             * Where the project is subject to the commissioning organization’s risk management policies/strategies, the PID should refer to rather than duplicate them.
             * Where the project is not subject to the commissioning organization’s risk management policies/strategies, appropriate strategies/approaches should be documented.
             */
            public RiskManagementApproach riskManagementApproach { get; set; }

            /**
             * Defines the parties interested in the project and the means and frequency of communication between them and the project.
             * Where the project is subject to the commissioning organization’s communication management policies/strategies, the PID should make reference to them rather than duplicate them.
             * Where the project is not subject to the commissioning organization’s communication management policies/strategies, appropriate strategies/approaches should be documented.
             */
            public CommunicationManagementApproach communicationManagementApproach { get; set; }

            /**
             * Describes how and when the project’s objectives are to be achieved, by showing the major products, activities and resources required on the project.
             * It provides a baseline against which to monitor the project’s progress, management stage by management stage.
             */
            public ProjectPlan projectPlan { get; set; }

            /**
             * Summarizes the project-level controls such as management stage boundaries, agreed tolerances, monitoring and reporting.
             */
            public ProjectControls projectControls { get; set; }

            /**
             * A summary of how PRINCE2 will be tailored for the project.
             */
            public TailoringPRINCE2 tailoringPRINCE2 { get; set; }

        #endregion

        #region Derivation
            public ProjectInitiationDocumentation() { }

            public ProjectInitiationDocumentation(
                ProjectBrief projectBrief,
                BusinessUserSupplierDiscussions businessUserSupplierDiscussions
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria
            /**
             * The PID correctly represents the project.
             */
            public bool PIDCorrectlyRepresentsProject() => throw new NotImplementedException();

            /**
             * It shows a viable, achievable project that is in line with corporate, programme management or customer strategies or overall programme needs.
             */
            public bool ShowsViableAchievableProjectInLineWithCorporateStrategiesOrProgrammeNeeds() => throw new NotImplementedException();

            /**
             * The project management team structure is complete, with names and titles.
             * All the roles have been considered and are backed up by agreed role descriptions.
             * The relationships and lines of authority are clear.
             * If necessary, the project management team structure shows to whom the project board reports.
             */
            public bool ProjectManagementTeamStructureComplete() => throw new NotImplementedException();

            /**
             * It clearly shows a control, reporting and direction regime that can be implemented, appropriate to the scale, risk and importance of the project to corporate, programme management or the customer.
             */
            public bool ClearlyShowsControlReportingDirectionRegimeCanImplementAppropriateToScaleRiskImportanceOfProjectToCorporate() => throw new NotImplementedException();

            /**
             * The controls cover the needs of the project board, project manager and team managers and satisfy any delegated assurance requirements.
             */
            public bool ControlsCoverNeedsOfProjectBoardProjectManagerTeamManagersAndSatisfyDelegatedAssuranceRequirements() => throw new NotImplementedException();

            /**
             * It is clear who will administer each control.
             */
            public bool ClearWhoAdministersEachControl() => throw new NotImplementedException();

            /**
             * The project objectives and approaches are consistent with the organization’s social responsibility directive, and the project controls are adequate to ensure that the project remains compliant with such a directive.
             */
            public bool ProjectObjectivesApproachesConsistentWithOrganizationsSocialResponsibilityDirectiveAndProjectControlsAdequateToEnsureProjectRemainsCompliantWithDirective() => throw new NotImplementedException();

            /**
             * Consideration has been given to the format of the PID.
             * For small projects a single document is appropriate.
             * For large projects, it is more appropriate for the PID to be a collection of stand-alone documents.
             * The volatility of each element of the PID should be used to assess whether it should be stand-alone (e.g. elements that are likely to change frequently are best separated out).
             */
            public bool ConsiderationGivenToPIDFormat() => throw new NotImplementedException();

        #endregion

        public class ProjectControls { }

        public class TailoringPRINCE2 { }

        public class BusinessUserSupplierDiscussions
        {
        }
    }
}