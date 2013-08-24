namespace DTOs
{
    using System.Collections.Generic;

    using DTOs.Model;

    public class  ProjectsResponse:BasicResponse
    {
        public List<Project> Projects { get; set; }
    }
}