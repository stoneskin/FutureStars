using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    using DTOs;
    using DTOs.API;

    public enum DataSource
    {
        Mockup,

        DB
    };
    public static class DALAPI
    {
        private static IFutureStarDAL futureStarDAL;
        public static IFutureStarDAL FutureStarDAL
        {
            get
            {
                return futureStarDAL ?? (
                    futureStarDAL = GetInstance()
                    );
            }
        }

        private static IFutureStarDAL GetInstance()
        {
            //if (System.Configuration.ConfigurationManager.AppSettings["UseMock"].Equals(
            //    "true", StringComparison.CurrentCultureIgnoreCase))
            //{
            //    return new FutureStarMockUpService();
            //}
            return new FutrueStarDBService();
        }
    }
}


