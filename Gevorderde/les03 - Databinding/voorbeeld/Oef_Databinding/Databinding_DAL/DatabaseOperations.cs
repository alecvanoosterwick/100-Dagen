using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Databinding_DAL
{
    public static class DatabaseOperations
    {
        public static List<Klant> OphalenKlantenOrders()
        {
            using (VerkoopbeheerEntities entities = new VerkoopbeheerEntities())
            {
                var query = entities.Klanten
                              .Include("Orders")
                              .OrderBy(x => x.Bedrijf);
                //var query = entities.Klanten
                //              .Include(x=> x.Orders)
                //              .OrderBy(x => x.Bedrijf);
                return query.ToList();
            }
        }

        public static List<Klant> OphalenKlantenOrdersOrderlijnen()
        {
            using (VerkoopbeheerEntities entities = new VerkoopbeheerEntities())
            {
                var query = entities.Klanten
                              .Include("Orders.Orderlijnen")
                              .OrderBy(x => x.Bedrijf);
                //var query = entities.Klanten
                //            .Include(x=> x.Orders.Select(sub=> sub.Orderlijnen))
                //            .OrderBy(x => x.Bedrijf);
                return query.ToList();
            }
        }

        public static List<Klant> OphalenKlantenOrdersOrderlijnenProduct()
        {
            using (VerkoopbeheerEntities entities = new VerkoopbeheerEntities())
            {
                var query = entities.Klanten
                              .Include("Orders.Orderlijnen.Product")
                              .OrderBy(x => x.Bedrijf);
                //var query = entities.Klanten
                //             .Include(x => x.Orders.Select(sub => sub.Orderlijnen.Select(sub2 => sub2.Product)))
                //             .OrderBy(x => x.Bedrijf);
                return query.ToList();
            }
        }

        public static List<Klant> OphalenKlantenOrdersOrderlijnenProductWerknemers()
        {
            using (VerkoopbeheerEntities entities = new VerkoopbeheerEntities())
            {
                var query = entities.Klanten
                              .Include("Orders.Orderlijnen.Product")
                              .Include("Orders.Werknemer")
                              .OrderBy(x => x.Bedrijf);
                //var query = entities.Klanten
                //              .Include(x => x.Orders.Select(sub => sub.Orderlijnen.Select(sub2 => sub2.Product)))
                //              .Include(x => x.Orders.Select(sub => sub.Werknemer))
                //              .OrderBy(x => x.Bedrijf);
                return query.ToList();
            }
        }

        public static List<Order> OphalenOrders()
        {
            using (VerkoopbeheerEntities entities = new VerkoopbeheerEntities())
            {
                var query = entities.Orders
                            .Include("Klant")
                            .Include("Werknemer");
                //var query = entities.Orders
                //            .Include(x => x.Klant)
                //            .Include(x => x.Werknemer);
                return query.ToList();


                //return entities.Orders
                //    .Include(x => x.Orderlijnen)
                //    .GroupBy(x => new { x.OrderID, x.Klantnummer })
                //    .Select(x => new
                //    {
                //        ID = x.Key.OrderID,
                //        Titel = x.Key.Klantnummer,
                //        AantalAlbums = x.Sum(y => y.ID)
                //        AantalAlbums = x.Average(y => y.Orderlijnen.Select(z => z.Productnummer)).
                //        GemiddeldeWaardering = x.Albums.Average()
                //    })
                //    .OrderBy(x => x.Titel)
                //    .ToList();


            }
        }

        public static Order OphalenOrderViaOrderID(int orderID)
        {
            using (VerkoopbeheerEntities entities = new VerkoopbeheerEntities())
            {

                var query = entities.Orders
                            .Include(x => x.Orderlijnen)
                            .Include(x => x.Klant)
                            .Include(x => x.Werknemer)
                            .Where(x => x.OrderID == orderID);
                return query.SingleOrDefault();
            }
        }

        public static List<Orderlijn> OphalenOrderlijnenViaOrderID(int orderID)
        {
            using (VerkoopbeheerEntities entities = new VerkoopbeheerEntities())
            {
                var query = entities.Orderlijnen
                            .Include(x => x.Product)
                            .Where(x => x.OrderID == orderID);
                return query.ToList();
            }
        }

        public static List<Product> OphalenProducten()
        {
            using (VerkoopbeheerEntities entities = new VerkoopbeheerEntities())
            {
                var query = entities.Producten;
                return query.ToList();
            }
        }

        public static int ToevoegenOrderlijn(Orderlijn orderlijn)
        {
            try
            {
                using (VerkoopbeheerEntities entities = new VerkoopbeheerEntities())
                {
                    entities.Orderlijnen.Add(orderlijn);
                    return entities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                FileOperations.FoutLoggen(ex);
                return 0;
            }
        }

        public static int AanpassenOrderlijn(Orderlijn orderlijn)
        {
            try
            {
                using (VerkoopbeheerEntities entities = new VerkoopbeheerEntities())
                {
                    entities.Entry(orderlijn).State = EntityState.Modified;
                    return entities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                FileOperations.FoutLoggen(ex);
                return 0;
            }
        }

        public static int VerwijderenOrderlijn(Orderlijn orderlijn)
        {
            try
            {
                using (VerkoopbeheerEntities entities = new VerkoopbeheerEntities())
                {
                    entities.Entry(orderlijn).State = EntityState.Deleted;
                    return entities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                FileOperations.FoutLoggen(ex);
                return 0;
            }
        }
    }
}
