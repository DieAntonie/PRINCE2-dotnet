using System;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * If required by the project’s change control approach, a product status account is used to provide information about the state of products within defined limits.
     * The limits can vary.
     * For example, the report could cover the entire project, a particular management stage, a particular area of the project or the history of a specific product.
     * It is particularly useful if the project manager wishes to confirm the version number of products.
     * The product status account may be derived from:
     * - Configuration item records.
     * - A stage plan.
     * PRINCE2 does not define the composition, format and presentation or quality criteria for this product.
     */
    public class ProductStatusAccount
    {

        #region Derivation
            
            public ProductStatusAccount() { }

            public ProductStatusAccount(
                ConfigurationItemRecord configurationItemRecord,
                StagePlan stagePlan
            ) => throw new NotImplementedException();

        #endregion

    }
}