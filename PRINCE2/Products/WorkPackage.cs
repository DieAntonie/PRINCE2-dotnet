using System;
using PRINCE2.UNSORTED;

namespace PRINCE2.Products
{
    public class WorkPackage {

        #region Composition

            /*
             * The date of the agreement between the project manager and the team manager/person authorized.
             */
            public DateTime date { get; set; }

            /*
             * The name of the team manager or individual with whom the agreement has been made.
             */
            public PersonAuthorized personAuthorized { get; set; }

            /*
             * A description of the work to be done.
             */
            public WorkPackageDescription workPackageDescription { get; set; }

            /*
             * Any techniques, tools, standards, processes or procedures to be used in the creation of the specialist products.
             */
            public TechniquesProcessesProcedures techniquesProcessesProcedures { get; set; }

            /*
             * Interfaces that must be maintained while developing the products.
             * These may be people providing information or those who need to receive information.
             */
            public DevelopmentInterfaces developmentInterfaces { get; set; }

            /*
             * Identification of any specialist products with which the product(s) in the work package will have to interface during their operational life.
             * These may be other products to be produced by the project, existing products, or those to be produced by other projects (e.g. if the project is part of a programme).
             */
            public OperationsMaintenanceInterfaces operationsMaintenanceInterfaces { get; set; }

            /*
             * A statement of any arrangements that must be made by the producer for:
             * - Version control of the products in the work package.
             * - Obtaining copies of other products or their product descriptions.
             * - Submission of the product to change control.
             * - Any storage or security requirements.
             * - Who, if anyone, needs to be advised of changes in the status of the work package.
             */
            public ChangeControlRequirements MyProperty { get; set; }

            /*
             * Details of the agreements on effort, cost, start and end dates, and key milestones for the work package.
             */
            public JointAgreements jointAgreements { get; set; }

            /*
             * Details of the tolerances for the work package (the tolerances will be for time and cost but may also include scope and risk).
             */
            public Tolerances tolerances { get; set; }

            /*
             * Any constraints (apart from the tolerances) on the work, people to be involved, timings, charges, rules to be followed (e.g. security and safety), etc.
             */
            public Constraints constraints { get; set; }

            /*
             * The expected frequency and content of checkpoint reports.
             */
            public ReportingArrangements reportingArrangements { get; set; }

            /*
             * This refers to the procedure for raising issues and risks.
             */
            public ProblemHandlingEscalation problemHandlingEscalation { get; set; }

            /*
             * Any extracts or references to related documents, specifically:
             * - Stage plan extract
             *   This will be the relevant section of the stage plan for the current management stage or will be a pointer to it.
             * - Product description(s)
             *   This would normally be an attachment of the product description(s) for the products identified in the work package (note that the product description contains the quality methods to be used).
             */
            public ExtractsReferences extractsReferences { get; set; }

            /*
             * The person, role or group who will approve the completed products within the work package, and how the project manager is to be advised of completion of the products and work package.
             */
            public ApprovalMethod approvalMethod { get; set; }

        #endregion

        #region Derivation
            
            public WorkPackage() { }

            public WorkPackage(
                CommercialAgreementsBetweenCustomerAndSupplier commercialAgreementsBetweenCustomerAndSupplier,
                QualityManagementApproach qualityManagementApproach,
                ChangeControlApproach changeControlApproach,
                StagePlan stagePlan
            ) => throw new NotImplementedException();

        #endregion

        #region Quality Criteria

            /*
             * The required work package is clearly defined and understood by the assigned resource.
             */
            public bool RequiredWorkPackageClearlyDefinedAndUnderstoodByAssignedResource() => throw new NotImplementedException();

            /*
             * There is a product description for each required product, with clearly identified and acceptable quality criteria.
             */
            public bool ProductDescriptionForRequiredProductWithIdentifiedQualityCriteria() => throw new NotImplementedException();

            /*
             * The product description(s) matches up with the other work package documentation.
             */
            public bool ProductDescriptionMatchesUpWithWorkPackageDocumentation() => throw new NotImplementedException();

            /*
             * Standards for the work are agreed.
             */
            public bool StandardsForWorkAgreed() => throw new NotImplementedException();

            /*
             * The defined standards are in line with those applied to similar products.
             */
            public bool DefinedStandardsInLineWithThoseAppliedToSimilarProducts() => throw new NotImplementedException();

            /*
             * All necessary interfaces have been defined.
             */
            public bool AllNecessaryInterfacesDefined() => throw new NotImplementedException();

            /*
             * The reporting arrangements include the provision for raising issues and risks.
             */
            public bool ReportingArrangementsIncludeProvisionForRaisingIssuesAndRisks() => throw new NotImplementedException();

            /*
             * There is agreement between the project manager and the recipient on exactly what is to be done.
             */
            public bool AgreementBetweenProjectManagerAndRecipientOnWhatToBeDone() => throw new NotImplementedException();

            /*
             * There is agreement on the constraints, including effort, cost and targets.
             */
            public bool AgreementOnConstraintsIncludingEffortCostAndTargets() => throw new NotImplementedException();

            /*
             * The dates and effort are in line with those shown in the stage plan for the current management stage.
             */
            public bool DatesAndEffortInLineWithThoseShownInStagePlanForCurrentManagementStage() => throw new NotImplementedException();

            /*
             * Reporting arrangements are defined.
             */
            public bool ReportingArrangementsDefined() => throw new NotImplementedException();

            /*
             * Any requirement for independent attendance at, and participation in, quality activities is defined.
             */
            public bool RequirementForIndependentAttendanceAndParticipationInQualityActivitiesDefined() => throw new NotImplementedException();

        #endregion

        public class PersonAuthorized { }

        public class WorkPackageDescription { }

        public class TechniquesProcessesProcedures { }

        public class DevelopmentInterfaces { }

        public class OperationsMaintenanceInterfaces { }

        public class JointAgreements { }

        public class Constraints { }

        public class ReportingArrangements { }

        public class ProblemHandlingEscalation { }

        public class ExtractsReferences { }

        public class ApprovalMethod { }

        public class CommercialAgreementsBetweenCustomerAndSupplier { }
    }
}