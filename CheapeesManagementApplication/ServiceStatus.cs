using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapeesManagementApplication
{
  class ServiceStatus
  {
    String serviceName { get; set; }
    Status status { get; set; }
    String errorMessage { get; set; }
    DateTime lastRun { get; set; }
    DateTime nextRun { get; set; }

    public ServiceStatus()
    {

    }
  }

  enum Status { Success, Error, Disabled, NotYetRun }
}
