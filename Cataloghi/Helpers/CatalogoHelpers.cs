using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Data;

namespace Helpers
{
    public class CatalogoHelpers
    {
        public string Path;

        public CatalogoHelpers(string path)
        {
            Path = path;
        }
        public void AddCatalogo(Catalogo catalogo)
        {
            var result = $"{catalogo.IdCatalogo};{catalogo.NomeCatalogo};{catalogo.IdProdotto};{catalogo.Prezzo}";
            using (var stream = new StreamWriter(Path, true))
            {
                stream.WriteLine(result);
            }
        }

        public List<Catalogo> DisplayCatalogo()
        {

            var catalogoL = new List<Catalogo>();
            using (var stream = new StreamReader(Path))
            {
                var header = "IdCatalogo;NomeCatalogo;IdProdotto;Prezzo";

                var firstLine = stream.ReadLine();
                if (!firstLine.Equals(header))
                    throw new Exception("File non conforme!");

                while (!stream.EndOfStream)
                {
                    var row = stream.ReadLine();
                    var splitted = row.Split(";");

                    var catalogo = new Catalogo
                    {
                        IdCatalogo = splitted[0],
                        NomeCatalogo = splitted[1],
                        IdProdotto = splitted[2],
                        Prezzo = splitted[3]
                    };

                    catalogoL.Add(catalogo);
                }

                return catalogoL;
            }
        }


    }
}