namespace PRINCE2.Products

{
    public abstract class Approach
    {

        #region Composition
            /**
             * States the purpose, objectives and scope, and identifies who is responsible for the approach.
             */
            public Introduction introduction { get; set; }

            /**
             * ChangeControlApproach:
             * Refers to any systems or tools to be used and any preference for techniques that may be used for each step in the issue management and change control procedure.
             *
             * CommunicationManagementApproach:
             * Refers to any communication tools to be used, and any preference for techniques that may be used, for each step in the communication process.
             *
             * QualityManagementApproach:
             * Refers to any quality management systems or tools to be used, and any preference for techniques which may be used for each step in the quality management procedure.
             */
            public ToolsTechniques toolsTechniques { get; set; }

            /**
             * ChangeControlApproach:
             * Defines the composition and format of the issue register.
             *
             * CommunicationManagementApproach:
             * Defines what communication records will be required and where they will be stored (e.g. logging of external correspondence).
             *
             * QualityManagementApproach:
             * Definition of what quality records will be required and where they will be stored, including the composition and format of the quality register.
             */
            public Records records { get; set; }

            /**
             * ChangeControlApproach:
             * Describes the composition and format of the reports that are to be produced, their purpose, timing and chosen recipients.
             * This should include reviewing the performance of the procedures.
             *
             * CommunicationManagementApproach:
             * Describes any reports on the communication process that are to be produced, including their purpose, timing and recipients (e.g. performance indicators).
             *
             * QualityManagementApproach:
             * Describes any quality management reports, including their purpose, timing and recipients.
             */
            public Reporting reporting { get; set; }

            /**
             * ChangeControlApproach:
             * States when formal activities (e.g. reviews or audits) are to be undertaken.
             *
             * CommunicationManagementApproach:
             * States when formal communication activities are to be undertaken (e.g. at the end of a management stage), including performance audits of the communication methods.
             *
             * QualityManagementApproach:
             * States when formal quality management activities are to be undertaken (e.g. during audits, when this may involve reference to the quality register).
             */
            public ActivitiesTiming activitiesTiming { get; set; }

            /**
             * ChangeControlApproach:
             * Describes who will be responsible for what aspects of the procedures, including any corporate, programme management or customer roles involved with the change control of the project’s products.
             * Describes whether a change authority and/or change budget will be established.
             *
             * CommunicationManagementApproach:
             * Describes who will be responsible for what aspects of the communication process, including any corporate, programme management or customer roles involved with communication.
             *
             * QualityManagementApproach:
             * Defines the roles and responsibilities for quality management activities, including those with quality responsibilities from corporate, programme management or the customer.
             */
            public RolesResponsibilities rolesResponsibilities { get; set; }

        #endregion

        public class Introduction { }

        public class ToolsTechniques { }

        public class Records { }

        public class Reporting { }

        public class RolesResponsibilities { }

        public class ActivitiesTiming { }
    }
}