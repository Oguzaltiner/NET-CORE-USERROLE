using CORE.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Utilities.Business
{
    public class BusinessRules
    {
        //logics iş kuralı
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
