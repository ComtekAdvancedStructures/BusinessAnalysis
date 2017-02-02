using System;
using System.Data.Entity;
using BusinessAnalysis.DataAccess;
using BusinessAnalysis.Model;
using Comtek;

namespace BusinessAnalysis.BusinessLogic
{
    public class ProjectBusinessLogic : BaseBusinessLogic<BusinessAnalysisDbContext> 
    {
        private const string AppName = "BusinessAnalysis";
        private readonly Guid userGuid;

        public ProjectBusinessLogic(BusinessAnalysisDbContext context, string appName) : base(context, AppName)
        {
        }
    }
}