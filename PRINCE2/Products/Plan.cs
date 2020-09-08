using System;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * A plan provides a statement of how and when objectives are to be achieved, by showing the major products, activities and resources required for the scope of the plan.
     * In PRINCE2, there are three levels of plan:
     *  - Project,
     *  - Stage
     *  - Team.
     *
     * Team plans are optional and may not need to follow the same composition as a project plan or stage plan.
     * An exception plan is created at the same level as the plan that it is replacing.
     * A project plan provides the business case with planned costs, and it identifies the management stages and other major control points.
     * It is used by the project board as a baseline against which to monitor project progress.
     *
     * Stage plans cover the products, resources, activities and controls specific to the management stage and are used as a baseline against which to monitor management stage progress.
     *
     * Team plans (if used) could comprise just a schedule appended to the work package(s) assigned to the team manager.
     *
     * A plan should cover not just the activities to create products but also the activities to manage product creation, including activities for assurance, quality management, risk management, change control, communication and any other project controls required.
     */
    public class Plan
    {
        
        #region Composition

            /**
             * A brief description of what the plan encompasses (i.e. project, stage, team, exception) and the planning approach.
             */
            public PlanDescription planDescription { get; set; }

            /**
             * Any fundamental aspects that must be in place, and remain in place, for the plan to succeed.
             */
            public PlanPrerequisites planPrerequisites { get; set; }

            /**
             * Dependencies that may influence the plan.
             */
            public ExternalDependencies externalDependencies { get; set; }

            /**
             * Assumptions upon which the plan is based.
             */
            public PlanningAssumptions planningAssumptions { get; set; }

            /**
             * A description of the approaches to be used.
             */
            public DeliveryApproaches deliveryApproaches { get; set; }

            /**
             * Details of relevant lessons from previous similar projects, which have been reviewed and accommodated within this plan.
             */
            public LessonsIncorporated lessonsIncorporated { get; set; }

            /**
             * Details of how the plan will be monitored and controlled.
             */
            public MonitoringControl monitoringControl { get; set; }

            /**
             * Time and cost budgets, including provisions for risks and changes.
             */
            public Budgets budgets { get; set; }

            /**
             * Time, cost and scope tolerances for the level of plan (which may also include more specific management-stage- or team-level risk tolerances).
             */
            public Tolerances tolerances { get; set; }

            /**
             * Descriptions of the products within the scope of the plan (for the project plan this will include the project’s product;
             * for the stage plan this will be the management stage products;
             * and for a team plan this should be a reference to the work package assigned).
             * Quality tolerances will be defined in each product description.
             */
            public ProductDescription[] productDescriptions { get; set; }

            /**
             * This may include graphical representations as:
             *  - A Gantt or bar chart
             *  - A product breakdown structure (see Appendix D for examples)
             *  - A product flow diagram (see Appendix D for an example)
             *  - An activity network
             *  - A table of resource requirements, by resource type (e.g. four engineers, one test manager, one business analyst)
             *  - A table of requested/assigned specific resources, by name (e.g. Nikki, Jay, Francesca).
             */
            public Schedule schedule { get; set; }

        #endregion

        #region Derivation
            public Plan() { }

            public Plan(
                ProjectBrief projectBrief,
                QualityManagementApproach qualityManagementApproach,
                RiskManagementApproach riskManagementApproach,
                CommunicationManagementApproach communicationManagementApproach,
                ChangeControlApproach changeControlApproach,
                ResourceAvailability resourceAvailability,
                RegistersLogs registersLogs
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria

            /**
             * The plan is achievable.
             */
            public bool PlanAchievable() => throw new NotImplementedException();

            /**
            * Estimates are based on consultation with those responsible for the people who will undertake the work, and/or historical data.
            */
            public bool EstimatesBasedOnConsultationWithPeopleWhoUndertakeWorkHistoricalData() => throw new NotImplementedException();

            /**
             * Team managers agree that their part of the plan is achievable.
             */
            public bool TeamManagersAgreeTheirPartAchievable() => throw new NotImplementedException();

            /**
             * It is planned to an appropriate level of detail (not too much, not too little).
             */
            public bool AppropriateLevelOfDetailPlanned() => throw new NotImplementedException();

            /**
             * The plan conforms to required corporate, programme management or customer standards.
             */
            public bool PlanConformsToCorporateStandards() => throw new NotImplementedException();

            /**
             * The plan incorporates lessons from previous projects.
             */
            public bool PlanIncorporatesPreviousProjectsLessons () => throw new NotImplementedException();

            /**
             * The plan incorporates any legal requirements.
             */
            public bool PlanIncorporatesLegalRequirements() => throw new NotImplementedException();

            /**
             * The plan covers management and control activities (such as quality) as well as the activities to create the products in scope.
             */
            public bool PlanCoversManagementControlActivities() => throw new NotImplementedException();

            /**
             * The plan supports the quality management approach, change control approach, risk management approach, communication management approach and project approach.
             */
            public bool PlanSpportsQualityManagementChangeControlRiskManagementCommunicationManagementProjectApproach() => throw new NotImplementedException();

            /**
             * The plan supports the management controls defined in the PID.
             */
            public bool PlanSupportsManagementControlsInPID() => throw new NotImplementedException();

        #endregion

        public class PlanDescription { }

        public class PlanPrerequisites { }

        public class ExternalDependencies { }

        public class PlanningAssumptions { }

        public class DeliveryApproaches { }

        public class LessonsIncorporated { }

        public class MonitoringControl { }

        public class Budgets { }

        public class Tolerances { }

        public class Schedule { }

        public class ResourceAvailability { }

        public class RegistersLogs { }
    }

    public class ProjectPlan : Plan { }

    public class StagePlan : Plan { }
}