using System;
using PRINCE2.UNSORTED;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * Configuration item records are created only if required by the project’s change control approach.
     * Their purpose is to provide a record of such information as the history, status, version and variant of each configuration item, and any details of important relationships between them.
     * The set of configuration item records for a project is often referred to as a configuration library.
     * The records may be derived from:
     * - The change control approach.
     * - The product breakdown structure.
     * - A stage plan and work package.
     * - The quality register, issue register and risk register.
     * PRINCE2 does not define the composition, format and presentation or quality criteria for this product.
     */
    public class ConfigurationItemRecord {

        #region Composition
            
            public ProjectIdentifier projectIdentifier { get; set; }
            
            public ItemIdentifier itemIdentifier { get; set; }
            
            public CurrentVersion currentVersion { get; set; }
            
            public Title itemTitle { get; set; }
            
            public DateTime dateOfLastStatusChange { get; set; }
            
            public Owner owner { get; set; }

            public Location location { get; set; }

            public CopyHolder[] copyHolders { get; set; }

            public ItemType itemType { get; set; }

            public ItemAttribute[] itemAttributes { get; set; }

            public Stage stage { get; set; }

            public User[] users { get; set; }

            public Status status { get; set; }

            public ProductState productState { get; set; }

            public Variant variant { get; set; }

            public Producer producer { get; set; }

            public DateTime dateAllocatedToTheProducer { get; set; }

            public Source source { get; set; }

            public RelationshipWithOtherItems relationshipWithOtherItems { get; set; }

            public CrossReferences crossReferences { get; set; }

        #endregion

        #region Derivation

            public ConfigurationItemRecord() { }

            public ConfigurationItemRecord(
                ChangeControlApproach changeControlApproach,
                ProductBreakdownStructure productBreakdownStructure,
                StagePlan stagePlan,
                WorkPackage workPackage,
                IssueRegister issueRegister,
                QualityRegister qualityRegister,
                RiskRegister riskRegister
            ) => throw new NotImplementedException();

        #endregion
    }
}