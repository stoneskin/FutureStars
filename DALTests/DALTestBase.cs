namespace DALTests
{
    using DTOs.API;

    using DAL;

    public  class APITestBase
    {
      public APITestBase()
        {
            this.FutureStarDAL = DALAPI.FutureStarDAL;
        }

        protected IFutureStarDAL FutureStarDAL;
       // protected IFutureStarAPI FutureStarAPI;
    }
}
