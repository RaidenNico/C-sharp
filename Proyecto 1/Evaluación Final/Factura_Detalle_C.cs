using System;
using System.Collections.Generic;
using System.Linq;

namespace Evaluación_Final
{
    public class Factura_Detalle_C
    {

        private string _NumFac;

        private string _Codp;

        private int _Cantidad;

        private float _PUnitario;

        private float _Importe;

        public string NumFac { get => _NumFac; set => _NumFac = value; }
        public string Codp { get => _Codp; set => _Codp = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public float PUnitario { get => _PUnitario; set => _PUnitario = value; }
        public float Importe { get => _Importe; set => _Importe = value; }

        public static List<Factura_Detalle_C> ListarFacturaDetalle()
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from dt in bd.DetalleFactura
                                    select new Factura_Detalle_C
                                    {
                                        NumFac = dt.NumFac,
                                        Codp = dt.Codp,
                                        Cantidad = (int)dt.Cantidad,
                                        PUnitario = (float)dt.PUnitario,
                                        Importe = (float)dt.Importe
                                    }).ToList();
                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void AgregarDetalleFactura(DetalleFactura dt)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    bd.DetalleFactura.Add(dt);
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DetalleFactura ConsultarDetalleFactura(DetalleFactura dta)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from dt in bd.DetalleFactura where dt.NumFac == dta.NumFac select dt).First();
                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ModificarDetalleFactura(DetalleFactura dta)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from dt in bd.DetalleFactura where dt.NumFac == dta.NumFac select dt);

                    foreach (DetalleFactura dtas in consulta)
                    {
                        dtas.Codp = dta.Codp;
                        dtas.Cantidad = dta.Cantidad;
                        dtas.PUnitario = dta.PUnitario;
                        dtas.Importe = dta.Importe;
                    }
                    bd.SaveChanges();
                }
            }
            catch (Exception) 
            { 
                throw;
            }
        }

        public static void EliminarDetalleFactura(DetalleFactura dta)
        {
            try
            {
                using (pablito_storeEntities bd = new pablito_storeEntities())
                {
                    var consulta = (from dt in bd.DetalleFactura where dt.NumFac == dta.NumFac select dta);

                    foreach (DetalleFactura dtas in consulta)
                    {
                        bd.DetalleFactura.Remove(dtas);
                    }
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
