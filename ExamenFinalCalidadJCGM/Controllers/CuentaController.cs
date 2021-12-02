using ExamenFinalCalidadJCGM.Models;
using ExamenFinalCalidadJCGM.Repositoria;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinalCalidadJCGM.Controllers
{
    public class CuentaController : Controller
    {
      

        private readonly InterfaceCuenta cuentaI;

        public CuentaController(InterfaceCuenta cuentaI)
        {
            this.cuentaI = cuentaI;
        }

        public IActionResult Index()
        {
            var CuentasList= cuentaI.ListarCuenta();
            return View(CuentasList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cuenta cuenta)
        {
            if (ModelState.IsValid)
            {
                cuentaI.CraerCuenta(cuenta);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
