using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllDrivetrainBusiness:ReadAllBusiness<Drivetrain>
    {
        public ReadAllDrivetrainBusiness(ReadAllRepo<Drivetrain> inRepo, Response<List<Drivetrain>> inNewResponse) : base(inRepo, inNewResponse)
        {
        }
    }
}