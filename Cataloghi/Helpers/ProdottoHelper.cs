using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Helpers
{
    public class ProdottoHelper
    {
        public string Path;

        public ProdottoHelper(string path)
        {
            Path = path;
        }
        public void AddProdotto(Prodotto prodotto)
        {
            var result = $"{prodotto.IdProdotto};{prodotto.NomeProdotto};{prodotto.QntInMagazzino}";
            using (var stream = new StreamWriter(Path, true))
            {
                stream.WriteLine(result);
            }
        }

        public List<Prodotto> DisplayProdotto()
        {

            var prodottoL = new List<Prodotto>();
            using (var stream = new StreamReader(Path))
            {
                var header = "IDProdotto;Nome;QuantitàMagazzino";

                var firstLine = stream.ReadLine();
                if (!firstLine.Equals(header))
                    throw new Exception("File non conforme!");
               
                while (!stream.EndOfStream)
                {
                    var row = stream.ReadLine();
                    var splitted = row.Split(";");

                    var prodotto = new Prodotto
                    {
                        IdProdotto = splitted[0],
                        NomeProdotto = splitted[1],
                        QntInMagazzino = splitted[2]
                    };

                    prodottoL.Add(prodotto);
                }

                return prodottoL;
            }
        }


    }
}