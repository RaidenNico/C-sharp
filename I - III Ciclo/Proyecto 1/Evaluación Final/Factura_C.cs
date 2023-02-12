using System;
using System.Collections.Generic;
using System.Linq;

namespace Evaluación_Final
{
    public class Factura_C
    {
        private string _NumFac;

        private DateTime _FechaFac;

        private float _TotalFac;

        private float _IgvFac;

        private float _TotalPago;

        private string _Codc;

        private string _Codv;

        public string NumFac { get => _NumFac; set => _NumFac = value; }
        public DateTime FechaFac { get => _FechaFac; set => _FechaFac = value; }
        public float TotalFac { get => _TotalFac; set => _TotalFac = value; }
        public float IgvFac { get => _IgvFac; set => _IgvFac = value; }
        public float TotalPago { get => _TotalPago; set => _TotalPago = value; }
        public string Codc { get => _Codc; set => _Codc = value; }
        public string Codv { get => _Codv; set => _Codv = value; }

        public static List<Factura_C> ListarFacturas()
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from f in bd.Factura
                                    join
                                    c in bd.Cliente on f.Codc equals c.Codc
                                    join
                                    v in bd.Vendedor on f.Codv equals v.Codv
                                    select new Factura_C
                                    {
                                        NumFac = f.NumFac,
                                        FechaFac = (DateTime)f.FechaFac,
                                        TotalFac = (float)f.TotalFac,
                                        IgvFac = (float)f.IgvFac,
                                        TotalPago = (float)f.TotalPago,
                                        Codc = c.Nomc,
                                        Codv = v.Datv,
                                    }).ToList();
                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void AgregarFactura(Factura f)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    bd.Factura.Add(f);
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Factura ConsultarFactura(Factura fa)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from f in bd.Factura where f.NumFac == fa.NumFac select f).First();
                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ModificarFactura(Factura fa)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from f in bd.Factura where f.NumFac == fa.NumFac select f).ToList();

                    foreach (Factura fac in consulta)
                    {
                        fac.FechaFac = fa.FechaFac;
                        fac.TotalFac = fa.TotalFac;
                        fac.TotalPago = fa.TotalPago;
                        fac.IgvFac = fa.IgvFac;
                        fac.Codc = fa.Codc;
                        fac.Codv = fa.Codv;
                    }
                    bd.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void EliminarFactura(Factura fa)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from f in bd.Factura where f.NumFac == fa.NumFac select f).First();

                    bd.Factura.Remove(consulta);
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
