using System;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * The purpose of the issue register is to capture and maintain information on all the issues that are being formally managed.
     * The issue register should be monitored by the project manager on a regular basis.
     */
    public class IssueRegister
    {

        #region Composition

            /**
             * Provides a unique reference for every issue entered into the issue register.
             * It will typically be a numeric or alphanumeric value.
             */
            public IssueIdentifier issueIdentifier { get; set; }

            /**
             * Defines the type of issue being recorded, namely:
             *  - Request for change.
             *  - Off-specification.
             *  - Problem/Concern.
             */
            public IssueType issueType { get; set; }

            /**
             * The date on which the issue was originally raised.
             */
            public DateTime dateRaised { get; set; }

            /**
             * The name of the individual or team who raised the issue.
             */
            public RaisedBy raisedBy { get; set; }

            /**
             * The name of the individual or team who created the issue report.
             */
            public IssueReportAuthor issueReportAuthor { get; set; }

            /**
             * Describes the issue, its cause and impact.
             */
            public IssueDescription issueDescription { get; set; }

            /**
             * This should be given in terms of the project’s chosen categories.
             * Priority should be re-evaluated after impact analysis.
             */
            public Priority priority { get; set; }

            /**
             * This should be given in terms of the project’s chosen scale.
             * Severity will indicate what level of management is required to make a decision on the issue.
             */
            public Severity severity { get; set; }

            /**
             * The current status of the issue and the date of the last update.
             */
            public Status status { get; set; }

            /**
             * The date the issue was closed.
             */
            public DateTime closureDate { get; set; }

        #endregion

        #region Derivation

            public IssueRegister() { }

        #endregion

        #region Quality Criteria

            /**
             * The status indicates whether action has been taken.
             */
            public bool StatusIndicatesWhetherActionTaken() => throw new NotImplementedException();

            /**
             * The issues are uniquely identified, including information about which product they refer to.
             */
            public bool IssuesUniquelyIdentifiedIncludingWhichProductReference() => throw new NotImplementedException();

            /**
             * A process is defined by which the issue register is to be updated.
             */
            public bool IssueRegisterUpdateProcessDefined() => throw new NotImplementedException();

            /**
             * Entries on the issue register that, upon examination, are in fact risks, are transferred to the risk register and the entries annotated accordingly.
             */
            public bool IssueRegisterEntriesThatAreRisksTransferredToRiskRegister() => throw new NotImplementedException();

            /**
             * Access to the issue register is controlled and the register is kept in a safe place.
             */
            public bool IssueRegisterAccessControlled() => throw new NotImplementedException();

        #endregion

        public class IssueIdentifier { }

        public class IssueType { }

        public class RaisedBy { }

        public class IssueReportAuthor { }

        public class IssueDescription { }

        public class Priority { }

        public class Severity { }

        public class Status { }
    }
}