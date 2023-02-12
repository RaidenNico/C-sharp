using System;
using System.Collections.Generic;
using System.Linq;

namespace Evaluación_Final
{
    public class Producto_C
    {

        private string _Codp;

        private string _Nomp;

        private float _Punp;

        private int _stockp;

        public string Codp { get => _Codp; set => _Codp = value; }
        public string Nomp { get => _Nomp; set => _Nomp = value; }
        public float Punp { get => _Punp; set => _Punp = value; }
        public int Stockp { get => _stockp; set => _stockp = value; }

        public static List<Producto_C> ListarProductos()
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from p in bd.Producto
                                    select new Producto_C
                                    {
                                        Codp = p.Codp,
                                        Nomp = p.Nomp,
                                        Punp = (float)p.Punp,
                                        Stockp = (int)p.Stockp
                                    }).ToList();
                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void AgregarProducto(Producto p)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    bd.Producto.Add(p);
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Producto ConsultarProducto(Producto pr)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from p in bd.Producto where p.Codp == pr.Codp select p).First();
                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ModificarProducto(Producto pr)
        {

            try
            {

                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from p in bd.Producto where p.Codp == pr.Codp select p);

                    foreach (Producto pra in consulta)
                    {
                        pra.Codp = pr.Codp;
                        pra.Nomp = pr.Nomp;
                        pra.Punp = pr.Punp;
                        pra.Stockp = pr.Stockp;
                    }
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void EliminarProducto(Producto pr)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {

                    var consulta = (from p in bd.Producto where p.Codp == pr.Codp select p);

                    foreach (Producto p in consulta)
                    {
                        bd.Producto.Remove(p);
                    }
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Producto_C ObtenerCodigoByName(string name)
        {
            try
            {

                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from p in bd.Producto
                                    where p.Nomp == name
                                    select new Producto_C
                                    {
                                        Codp = p.Codp,
                                        Punp = (float)p.Punp
                                    }).First();
                    return consulta;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
