using ExamenFinalCalidadJCGM.DB;
using ExamenFinalCalidadJCGM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinalCalidadJCGM.Repositoria
{
    public class RepositarioCuenta : InterfaceCuenta
    {
        private DbContextExamen DbContextExamen;

        public RepositarioCuenta(DbContextExamen dbContextExamen)
        {
            this.DbContextExamen = dbContextExamen;
        }


        public void CraerCuenta(Cuenta cuenta)
        {
            DbContextExamen.Cuenta.Add(cuenta);
            DbContextExamen.SaveChanges();
        }


        public List<Cuenta> ListarCuenta()
        {
            // var cuenta = DbContextExamen.Cuenta;

            return DbContextExamen.Cuenta.ToList();
        }
    }

    public interface InterfaceCuenta
    {
        List<Cuenta> ListarCuenta();
        void CraerCuenta(Cuenta cuenta);
        

    }



}
