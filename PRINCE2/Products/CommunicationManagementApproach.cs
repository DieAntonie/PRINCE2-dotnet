using System;

namespace PRINCE2.Products
{

    /**
     * A communication management approach contains a description of the means and frequency of communication with parties both internal and external to the project.
     * It facilitates engagement with stakeholders through the establishment of a controlled and bidirectional flow of information.
     */
    public class CommunicationManagementApproach : Approach
    {

        #region Composition

            /**
             * Describes (or refers to) any communication methods to be used.
             * Any variance from corporate, programme management or customer standards should be highlighted, together with a justification for the variance.
             */
            public CommunicationProcedure communicationProcedure { get; set; }

            /**
             * States when formal communication activities are to be undertaken (e.g. at the end of a management stage), including performance audits of the communication methods.
             */
            public CommunicationActivitiesTiming communicationActivitiesTiming { get; set; }

            /**
             * Consists of:
             *  - Identification of the interested party (which may include accounts staff, user forum, internal audit, corporate, programme management or customer quality assurance, competitors, etc.)
             *  - Current relationship
             *  - Desired relationship
             *  - Interfaces
             *  - Key messages
             */
            public StakeholderAnalysis stakeholderAnalysis { get; set; }

            /**
             * Consists of:
             *  - Information required to be provided from the project
             *  - Information required to be provided to the project
             *  - Information provider and recipient
             *  - Frequency of communication
             *  - Means of communication
             *  - Format of the communication
             */
            public InformationNeedsForInterestedParty informationNeedsForInterestedParty { get; set; }

        #endregion

        #region Derivation

            public CommunicationManagementApproach() { }

            public CommunicationManagementApproach(
                CorporateCommunicationsPolicies corporateCommunicationsPolicies,
                InformationManagementStrategy informationManagementStrategy,
                ProjectInitiationDocumentation projectInitiationDocumentation,
                StakeholderFacilitatedWorkshopsInformalDiscussions stakeholderFacilitatedWorkshopsInformalDiscussions,
                StakeholderAnalysis stakeholderAnalysis
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria

            /**
             * All stakeholders have been identified and consulted with regard to their communication requirements.
             */
            public bool StakeholderCommunicationRequirementsIdentifiedConsulted() => throw new NotImplementedException();
 
            /**
             * There is agreement from all stakeholders about the content, frequency and method of communication.
             */
            public bool StakeholderAgreementAboutCommunicationContentFrequencyMethod() => throw new NotImplementedException();

            /**
             * A common standard for communication has been considered.
             */
            public bool CommonCommunicationStandardConsidered() => throw new NotImplementedException();

            /**
             * The time, effort and resources required to carry out the identified communications have been allowed for in stage plans.
             */
            public bool StagePlansAllowesIdentifiedCommunicationsRequiredTimeEffortResources() => throw new NotImplementedException();

            /**
             * The formality and frequency of communication is reasonable for the project’s importance and complexity.
             */
            public bool ReasonableCommunicationFormalityFrequencyForProjectImportanceComplexity() => throw new NotImplementedException();

            /**
             * For projects that are part of a programme, the lines of communication, and the reporting structure between the project and programme, have been made clear in the communication management approach.
             */
            public bool LinesOfCommunicationReportingStructureMadeClear() => throw new NotImplementedException();

            /**
             * The communication management approach incorporates corporate, programme management or customer communications facilities where appropriate (e.g. using the marketing communications department for distributing project bulletins).
             */
            public bool AppropriatlyIncorporatesCorporateCommunicationsFacilities() => throw new NotImplementedException();

        #endregion

        public class CommunicationProcedure { }

        public class CommunicationActivitiesTiming : ActivitiesTiming { }

        public class StakeholderAnalysis { }

        public class InformationNeedsForInterestedParty { }

        public class CorporateCommunicationsPolicies { }

        public class InformationManagementStrategy { }

        public class StakeholderFacilitatedWorkshopsInformalDiscussions { }
    }
}