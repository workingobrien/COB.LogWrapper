using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace COB.LogWrapper
{
   public static class Logger
   {
      private static readonly ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

      public static ILog Log
      {
         get { return _log; }
      }

      public static void LogException(Exception ex)
      {
         _log.Error(ex.Message, ex);
      }

   }
}
