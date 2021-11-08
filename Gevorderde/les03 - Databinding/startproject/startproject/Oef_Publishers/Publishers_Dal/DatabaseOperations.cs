using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Publishers_Dal
{
    public static class DatabaseOperations
    {
        public static List<Stores> OphalenWinkels()
        {
            using (PublishersEntities publishersEntities = new PublishersEntities())
            {
                return publishersEntities.Stores
                    .OrderBy(x => x.stor_name)
                    .ToList();
            }
        }
        public static List<Stores> OphalenWinkelsOpNaam(string naam)
        {
            using (PublishersEntities publishersEntities = new PublishersEntities())
            {
                return publishersEntities.Stores
                    .Where(x => x.stor_name.Contains(naam))
                    .OrderBy(x => x.stor_name)
                    .ToList();
            }
        }
        public static List<Publishers> OphalenUitgevers()
        {
            using (PublishersEntities publishersEntities = new PublishersEntities())
            {
                return publishersEntities.Publishers
                    .Include(x => x.Titles.Select(sub => sub.TitlesAuthors.Select(sub1 => sub1.Authors)))
                    .OrderBy(x => x.pub_name)
                    .ToList();
            }

        }
    }
}
