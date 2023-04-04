using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahinbey.Siramatik.Services
{
    public class ApplicationServiceSettings
    {
        public static void RegisterAllService()
        {
            IOCContainer.Register<ITableService>(() => new TableService());
            IOCContainer.Register<IUserService>(() => new UserService());
            IOCContainer.Register<ITicketService>(() => new TicketService());
        }
    }
}
