using System;
using System.Collections.Generic;

namespace ChangeReturnLib
{
    public static class ChangeUtility
    {
        public static Dictionary<CoinsEnum, int> GetChange(decimal difference){
            var changes = new Dictionary<CoinsEnum, int>();
            changes.Add(CoinsEnum.Penny, 0);
            changes.Add(CoinsEnum.Nickel, 0);
            changes.Add(CoinsEnum.Dime, 0);
            changes.Add(CoinsEnum.Quarter, 0);
            changes.Add(CoinsEnum.Dollar, 0);

            Calculatedifference(difference, ref changes);

            return changes;
        }

        private static void Calculatedifference(decimal difference, ref Dictionary<CoinsEnum, int> changes)
        {
            UsCurrencyCoin coins = new UsCurrencyCoin();
            while (difference > 0)
                {
                    if ((difference - coins.GetDollar()) >= 0)
                    {
                        difference -=  coins.GetDollar();
                        changes[CoinsEnum.Dollar] += 1;
                        continue;
                    }
                    else if ((difference - coins.GetQuarter()) >= 0)
                    {
                        difference -=  coins.GetQuarter();
                        changes[CoinsEnum.Quarter] += 1;
                        continue;
                    }
                    else if ((difference - coins.GetDime()) >= 0)
                    {
                        difference -=  coins.GetDime();
                        changes[CoinsEnum.Dime] += 1;
                        continue;
                    }
                    else if ((difference - coins.GetNickel()) >= 0)
                    {
                        difference -=  coins.GetNickel();
                        changes[CoinsEnum.Nickel] += 1;
                        continue;
                    }
                    else if ((difference - coins.GetPenny()) >= 0)
                    {
                        difference -=  coins.GetPenny();
                        changes[CoinsEnum.Penny] += 1;
                        continue;
                    }else{
                        break;
                    }
                }
        }
    }
}