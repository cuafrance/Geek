using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PersoGeek.WcfService.DataAccess;
using PersoGeek.WcfService.Objects;

namespace PersoGeek.WcfService.Services
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "BookServiceRestful" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez BookServiceRestful.svc ou BookServiceRestful.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class BookServiceRestful : IBookServiceRestful
    {
        readonly IBookRepository _bookRepo;

        public BookServiceRestful()
        {
            _bookRepo = new BookRepository();
        }
        public string HelloWorld(int value)
        {
            return $"You are connected to BookService and you entered " + value.ToString();
        }

        public List<BookData> GetBookList()
        {
            return _bookRepo.Find();
        }

        public List<BookData> Find(string keyword)
        {
            return _bookRepo.Find(keyword);
        }
    }
}
