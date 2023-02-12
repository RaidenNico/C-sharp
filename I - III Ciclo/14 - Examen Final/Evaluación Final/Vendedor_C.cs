using System;
using System.Collections.Generic;
using System.Linq;

namespace Evaluación_Final
{
    public class Vendedor_C
    {

        private string _codV;

        private string _Datv;

        private string _Dirv;

        private string _DNIv;

        private string _Sexv;

        public string CodV { get => _codV; set => _codV = value; }
        public string Datv { get => _Datv; set => _Datv = value; }
        public string Dirv { get => _Dirv; set => _Dirv = value; }
        public string DNIv { get => _DNIv; set => _DNIv = value; }
        public string Sexv { get => _Sexv; set => _Sexv = value; }

        public static List<Vendedor_C> ListarVendedor()
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from v in bd.Vendedor
                                    select new Vendedor_C
                                    {
                                        CodV = v.Codv,
                                        Datv = v.Datv,
                                        Dirv = v.Dirv,
                                        DNIv = v.Dniv,
                                        Sexv = v.Sexv,
                                    }).ToList();
                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void AgregarVendedor(Vendedor ve)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    bd.Vendedor.Add(ve);
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Vendedor ConsultarVendedor(Vendedor ve)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from v in bd.Vendedor where v.Codv == ve.Codv select v).First();
                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ModificarVendedor(Vendedor ve)
        {

            try
            {

                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from v in bd.Vendedor where v.Codv == ve.Codv select v);

                    foreach (Vendedor ven in consulta)
                    {
                        ven.Datv = ve.Datv;
                        ven.Dirv = ve.Dirv;
                        ven.Dniv = ve.Dniv;
                        ven.Sexv = ve.Sexv;
                    }
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void EliminarVendedor(Vendedor ve)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {

                    var consulta = (from v in bd.Vendedor where v.Codv == ve.Codv select v);

                    foreach (Vendedor v in consulta)
                    {
                        bd.Vendedor.Remove(v);
                    }
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Vendedor_C ObtenerCodigoByName(string name, bool busqueda = false)
        {
            try
            {

                if (busqueda)
                {
                    using (pablito_storeEntities bd = new pablito_storeEntities())
                    {
                        var consulta = (from v in bd.Vendedor
                                        where v.Codv == name
                                        select new Vendedor_C
                                        {
                                            Datv = v.Datv,
                                        }).First();
                        return consulta;
                    }
                }

                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from v in bd.Vendedor
                                    where v.Datv == name
                                    select new Vendedor_C
                                    {
                                        CodV = v.Codv
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
