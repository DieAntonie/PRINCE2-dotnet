using System;
using PRINCE2.UNSORTED;

namespace PRINCE2.Products
{
    /**
     * Purpose:
     * A daily log may be used to record informal issues, required actions or significant events not captured by other PRINCE2 registers or logs.
     * It can act as the project diary for the project manager.
     * It can also be used as a repository for issues and risks during the "starting up a project" process if the other registers have not been set up.
     * There may be more than one daily log as team managers may elect to have one for their work packages, separate from the project manager’s daily log.
     * Entries are made when the project manager or team manager feels it is appropriate to log some event.
     * Often entries are based on thoughts, conversations and observations.
     * PRINCE2 does not define the composition, format and presentation or quality criteria for this product.
     */
    public class DailyLog
    {

        #region Composition

            public ProjectName projectName { get; set; } 

            public DailyLogScope dailyLogScope { get; set; }

            public DateTime dateOfEntry { get; set; }

            public LogItem ProblemActionEventOrComment { get; set; }

            public PersonResponsible personResponsible { get; set; }

            public DateTime targetDate { get; set; }

            public Result[] results { get; set; }

        #endregion    

    }
}