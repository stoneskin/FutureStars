using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FutureStarWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate = "Data/{id}")]
        string GetData(string id);

        [OperationContract]
        [WebGet(UriTemplate = "Json/Data/{id}", ResponseFormat = WebMessageFormat.Json)]
        string GetDataJson(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "Update/value/{value}/name/{name}",Method = "GET")]
        string UpdateData(string value,string name);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
//http://stackoverflow.com/questions/7943554/how-to-send-custom-object-to-wcf-rest-service-in-browser-based-url
/*
 [DataContract( Namespace = "urn:brandon.michael.hunter/ws/2010/01", 
               Name = "Resolution" )]
public class Resolution
{
    [DataMember( IsRequired = true, Name = "Name" )]
    public string Name     { get; set; } 

    [DataMember( IsRequired = true, Name = "Rank" )]
    public int Rank { get; set; }

    [DataMember( IsRequired = true, Name = "SerialNumber" )]
    public int SerialNumber { get; set; } 

    [DataMember( IsRequired = false, Name = "Id" )]
    public int Id { get; set; } 
}

[OperationContract]
[WebInvoke(Method = "PUT",
           RequestFormat=WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "new")]
public Resolution CreateNewResolution(Resolution r)
{
    // your logic here
    r.Id = System.Guid.NewGuid();
    return r;
}
 */