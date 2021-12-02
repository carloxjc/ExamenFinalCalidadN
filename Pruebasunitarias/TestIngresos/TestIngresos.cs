﻿using ExamenFinalCalidadJCGM.Controllers;
using ExamenFinalCalidadJCGM.Models;
using ExamenFinalCalidadJCGM.Repositoria;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebasunitarias.TestIngresos
{
    class TestIngresos
    {
        private Mock<InterfaceCuenta> cuentamoq;
        private Mock<InterfaceIngresos> ingresosmoq;

        [SetUp]
        public void SetUp()
        {
            cuentamoq = new Mock<InterfaceCuenta>();
            ingresosmoq = new Mock<InterfaceIngresos>();
        }

        [Test]
        public void TestIndexListaGastosIsOkCase01()
        {

            ingresosmoq.Setup(a => a.ListarIngresos()).Returns(new List<Ingresos>());

            var controller = new IngresosController(ingresosmoq.Object, null);

            var view = controller.Index() as ViewResult;

            Assert.IsInstanceOf<List<Ingresos>>(view.Model);

        }

        [Test]
        public void TestCreateGastosIsOkCase02()
        {
            var cuenta = new List<Cuenta>()
            {
                new Cuenta()
                {
                    Id = 1,
                    Nombre = "Caja Piura",
                    Categoria = "Credito",
                    SaldaInicisl = 150
                },
                new Cuenta()
                {
                    Id = 2,
                    Nombre = "Caja Sullana",
                    Categoria = "Credito",
                    SaldaInicisl = 400
                },
            };

            cuentamoq.Setup(a => a.ListarCuenta()).Returns(cuenta);

            var controller = new IngresosController(null, cuentamoq.Object);

            var view = controller.Create() as ViewResult;

            var c = controller.ViewBag.Cuenta;

            Assert.AreEqual(cuenta, c);
        }

        [Test]
        public void TestIndexListaGastosIsOkCase03()
        {

            ingresosmoq.Setup(a => a.ListarIngresos()).Returns(new List<Ingresos>());

            var controller = new IngresosController(ingresosmoq.Object, null);

            var view = controller.Index() as ViewResult;

            Assert.IsInstanceOf<List<Ingresos>>(view.Model);

        }

        [Test]
        public void TestCreateGastosIsOkCase04()
        {
            var cuenta = new List<Cuenta>()
            {
                new Cuenta()
                {
                    Id = 1,
                    Nombre = "Caja Piura",
                    Categoria = "Credito",
                    SaldaInicisl = 150
                },
                new Cuenta()
                {
                    Id = 2,
                    Nombre = "Caja Sullana",
                    Categoria = "Credito",
                    SaldaInicisl = 400
                },
            };

            cuentamoq.Setup(a => a.ListarCuenta()).Returns(cuenta);

            var controller = new IngresosController(null, cuentamoq.Object);

            var view = controller.Create() as ViewResult;

            var c = controller.ViewBag.Cuenta;

            Assert.AreEqual(cuenta, c);
        }
    }
}
