using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using PersoGeek.WcfService.Objects;

namespace PersoGeek.WcfService.Services
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IBookServiceRestful" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IBookServiceRestful
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
          ResponseFormat = WebMessageFormat.Xml,
          UriTemplate = "/HelloWorld?id={value}")]
        string HelloWorld(int value);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "GetBookList/")]
        List<BookData> GetBookList();

        [OperationContract]
        [WebInvoke(Method = "GET",
         ResponseFormat = WebMessageFormat.Xml,
         UriTemplate = "/Find?id={keyword}")]
        List<BookData> Find(string keyword);
    }
}
