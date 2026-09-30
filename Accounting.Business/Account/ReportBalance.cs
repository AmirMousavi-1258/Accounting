using Accounting.DataLayer.Context;
using Accounting.ViewModels.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Business.Account
{
    public class ReportBalance
    {
        public static ReportViewModel ReportForMainForm(int userID)
        {
            ReportViewModel rpVM = new ReportViewModel();
            using(UnitOfWork db = new UnitOfWork())
            {
                DateTime FirstDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime EndDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 01);

                var rc = db.AccountingRepository.get(a=>a.TypeID == 1&&a.DateTime>= FirstDate&&a.DateTime<=EndDate&&a.LoginID == userID).Select(a=>a.Amount).ToList();
                var py = db.AccountingRepository.get(a=>a.TypeID == 2&&a.DateTime>= FirstDate&&a.DateTime<=EndDate&&a.LoginID == userID).Select(a=>a.Amount).ToList();

                rpVM.Recieve = rc.Sum();
                rpVM.Pay = py.Sum();
                rpVM.Total = rc.Sum() - py.Sum();
           
            }
            return rpVM;
        }
    }
}
