using System;
using System.Collections.Generic;
using System.Linq;

namespace Evaluación_Final
{
    public class Cliente_c
    {

        private string _Codc;

        private string _Nomc;

        private string _Dirc;

        public string Codc { get => _Codc; set => _Codc = value; }
        public string Nomc { get => _Nomc; set => _Nomc = value; }
        public string Dirc { get => _Dirc; set => _Dirc = value; }

        public static List<Cliente_c> ListarCliente()
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from c in bd.Cliente
                                    orderby c.Nomc
                                    select new Cliente_c
                                    {
                                        Codc = c.Codc,
                                        Nomc = c.Nomc,
                                        Dirc = c.Dirc
                                    }).ToList();

                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void AgregarCliente(Cliente cl)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    bd.Cliente.Add(cl);
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Cliente ConsultarCliente(Cliente cl)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from c in bd.Cliente where c.Codc == cl.Codc select c).First();
                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ModificarCliente(Cliente cl)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from c in bd.Cliente where c.Codc == cl.Codc select c);

                    foreach (Cliente cli in consulta)
                    {
                        cli.Nomc = cl.Nomc;
                        cli.Dirc = cl.Dirc;
                    }
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void EliminarCliente(Cliente cl)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {

                    var consulta = (from c in bd.Cliente where c.Codc == cl.Codc select c);

                    foreach (Cliente c in consulta)
                    {
                        bd.Cliente.Remove(c);
                    }
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Cliente_c ObtenerCodigoByName(string name, bool buscar = false)
        {
            try
            {

                if (buscar)
                {
                    using (pablito_storeEntities bd = new pablito_storeEntities())
                    {
                        var consulta = (from c in bd.Cliente
                                        where c.Codc == name
                                        select new Cliente_c
                                        {
                                            Nomc = c.Nomc,
                                        }).First();
                        return consulta;
                    }
                }

                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from c in bd.Cliente
                                    where c.Nomc == name
                                    select new Cliente_c
                                    {
                                        Codc = c.Codc,
                                        Dirc = c.Dirc,
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
