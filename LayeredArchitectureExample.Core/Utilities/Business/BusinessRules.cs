using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitectureExample.Core.Utilities.Results;

namespace LayeredArchitectureExample.Core.Utilities.Business
{
   public class BusinessRules
   {
       public static IResult Run(params IResult[] logics)
       {
           foreach (var logic in logics)
           {
               if (!logic.Success)
               {
                   return logic;
               }

           }
           return null;
       }
   }
}
