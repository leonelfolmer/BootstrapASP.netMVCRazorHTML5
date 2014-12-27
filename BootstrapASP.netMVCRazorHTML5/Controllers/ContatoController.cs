using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using App.Models;


namespace App.Controllers
{
    public class ContatoController : Controller
    {
        //
        // GET: /Contato/
        [HttpGet]
        public ActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contato(ContatoModel model)
        {

            if (ModelState.IsValid)
            {

                WebMail.SmtpServer = "smtp.domain.com.br";
                WebMail.SmtpPort = 587;
                WebMail.EnableSsl = false;
                WebMail.UserName = "dev@domain.com";
                WebMail.From = "dev@domain.com";
                WebMail.Password = "pass";


                var fileAttachment = Request["fileAttachment"];
                var filesList = new string[] { fileAttachment };

                WebMail.Send(to: "dev@domain.com",
                             subject: "Contato",
                    //body: nome + cidade + empresa + telefone + email + comentarios
                             filesToAttach: filesList,
                             body: "<html>" +
                                    "<head>" +
                                        "<style type='text/css'>" +
                                            "table {" +
                                              "max-width: 100%;" +
                                              "background-color: transparent;" +
                                              "border-collapse: collapse;" +
                                              "border-spacing: 0;" +
                                            "}" +

                                            ".table {" +
                                              "width: 100%;" +
                                              "margin-bottom: 18px;" +
                                            "}" +

                                            ".table th," +
                                            ".table td {" +
                                              "padding: 8px;" +
                                              "line-height: 18px;" +
                                              "text-align: left;" +
                                              "vertical-align: top;" +
                                              "border-top: 1px solid #dddddd;" +
                                            "}" +

                                            ".table th {" +
                                              "font-weight: bold;" +
                                            "}" +

                                            ".table thead th {" +
                                              "vertical-align: bottom;" +
                                            "}" +

                                            ".table caption + thead tr:first-child th," +
                                            ".table caption + thead tr:first-child td," +
                                            ".table colgroup + thead tr:first-child th," +
                                            ".table colgroup + thead tr:first-child td," +
                                            ".table thead:first-child tr:first-child th," +
                                            ".table thead:first-child tr:first-child td {" +
                                             "border-top: 0;" +
                                            "}" +

                                            ".table tbody + tbody {" +
                                              "border-top: 2px solid #dddddd;" +
                                            "}" +

                                            ".table-condensed th," +
                                            ".table-condensed td {" +
                                              "padding: 4px 5px;" +
                                            "}" +

                                            ".table-bordered {" +
                                              "border: 1px solid #dddddd;" +
                                              "border-collapse: separate;" +
                                              "border-left: 0;" +
                                            "}" +

                                            ".table-bordered th," +
                                            ".table-bordered td {" +
                                              "border-left: 1px solid #dddddd;" +
                                            "}" +

                                            ".table-bordered caption + thead tr:first-child th," +
                                            ".table-bordered caption + tbody tr:first-child th," +
                                            ".table-bordered caption + tbody tr:first-child td," +
                                            ".table-bordered colgroup + thead tr:first-child th," +
                                            ".table-bordered colgroup + tbody tr:first-child th," +
                                            ".table-bordered colgroup + tbody tr:first-child td," +
                                            ".table-bordered thead:first-child tr:first-child th," +
                                            ".table-bordered tbody:first-child tr:first-child th," +
                                            ".table-bordered tbody:first-child tr:first-child td {" +
                                              "border-top: 0;" +
                                            "}" +

                                            ".table-striped tbody tr:nth-child(odd) td," +
                                            ".table-striped tbody tr:nth-child(odd) th {" +
                                              "background-color: #f9f9f9;" +
                                            "}" +

                                            ".table tbody tr:hover td," +
                                            ".table tbody tr:hover th {" +
                                              "background-color: #f5f5f5;" +
                                            "}" +
                                        "</style>" +
                                    "</head>" +

                                    "<body>" +
                                        "<table class='table table-bordered'>" +
                                            "<tr>" +
                                                "<th colspan='2' scope='col'>Formul&aacute;rio de contato</th>" +
                                            "</tr>" +

                                            "<tr>" +
                                                "<td>Nome:</td>" +
                                                "<td>" + model.nome + "</td>" +
                                            "</tr>" +

                                            "<tr>" +
                                                "<td>Cidade:</td>" +
                                                "<td>" + model.cidade + "</td>" +
                                            "</tr>" +

                                            "<tr>" +
                                                "<td>Empresa:</td>" +
                                                "<td>" + model.empresa + "</td>" +
                                            "</tr>" +

                                            "<tr>" +
                                                "<td>Telefone:</td>" +
                                                "<td>" + model.telefone + "</td>" +
                                            "</tr>" +

                                            "<tr>" +
                                                "<td>e-mail:</td>" +
                                                "<td>" + model.email + "</td>" +
                                            "</tr>" +

                                            "<tr>" +
                                                "<td>Comentários:</td>" +
                                                "<td>" + model.comentarios + "</td>" +
                                            "</tr>" +

                                        "</table>" +
                                    "</body>" +
                                "</html>"
                );

                return RedirectToAction("Principal", "Principal"); // Pode ser a página sucesso.

            }

            else
            {
                return View(); // Erro
            }

        }



          
        }


    }

