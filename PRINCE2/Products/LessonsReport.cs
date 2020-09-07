using System;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * A lessons report may be produced to support the lessons log if more information is required.
     * It can be used to pass on any lessons that can be usefully applied to other projects.
     * The purpose of the report is to provoke action so that the positive lessons become embedded in the organization’s way of working, and so that the organization is able to avoid any negative lessons on future projects.
     * A lessons report can be created at any time in a project and should not necessarily be delayed until the end.
     * Typically it can be included as part of the end stage report and end project report.
     * It may be appropriate (and necessary) for there to be several lessons reports specific to the particular organization (e.g. user, supplier, corporate or programme).
     * The data in the report should be used by the corporate group that is responsible for the quality management system, in order to refine, change and improve the standards.
     * Statistics on how much effort was needed for products can help improve future estimating.
     * A lessons report may be derived from:
     *  - The PID (for the baseline position)
     *  - The lessons log (for identification of lessons)
     *  - The quality register, issue register and risk register (for statistical analysis)
     *  - Quality records (for statistical analysis)
     *  - The communication management approach (for the distribution list).
     * PRINCE2 does not define the composition, format and presentation or quality criteria for this product.
     */
    public class LessonsReport
    {

        #region Derivation

            public LessonsReport() { }

            public LessonsReport(
                ProjectInitiationDocumentation projectInitiationDocumentation,
                LessonsLog lessonsLog,
                IssueRegister issueRegister,
                QualityRegister qualityRegister,
                RiskRegister riskRegister,
                QualityRecords qualityRecords,
                CommunicationManagementApproach communicationManagementApproach
            ) => throw new NotImplementedException();

        #endregion

        public class QualityRecords { }
    }
}