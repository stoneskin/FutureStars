using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLayerTests
{
    using DTOs;

    using MockDAL;

    [TestClass]
    public abstract class BusinessServiceTestBase
    {
       protected BusinessServiceTestBase()
       {
           //DTOs.API.IFutureStarDAL dal = new FutureStarMockUpService();
           //this.FutureStarAPI = new BL.FutureStarService(dal);

           this.FutureStarAPI=new MockBL.FutureStarService();

       }

        protected readonly DTOs.API.IFutureStarAPI FutureStarAPI;
       
    }


}
