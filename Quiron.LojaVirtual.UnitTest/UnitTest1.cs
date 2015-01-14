using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiron.LojaVirtual.Web.HtmlHelpers;
using Quiron.LojaVirtual.Web.Models;

namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestQuiron
    {
        [TestMethod]
        public void TestarSeAPaginacaoEstaSendoGeradaCorretamente()
        {
            //Arrange

            HtmlHelper html = null;

            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensPorPagina = 10,
                ItensTotal = 28
            };

            Func<int, string> paginaUrl = i => "Pagina" + i;

            // MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);

            ////Assert
            //Assert.AreEqual(
            //    @"<a class=""btn-default""href=""Pagina1"">1</a>"
            //    +@"<a class=""btn btn-default btn-primary selected""href=""Pagina2"">2</a>"
            //    +@"<a class=""btn-default""href=""Pagina3"">3</a>",resultado.ToString() 
            //    );

        }
    }
}
