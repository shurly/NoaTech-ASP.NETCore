
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Noahtech.Migrations;
using Noahtech.Models;
using NoahTech.Models;
using Org.BouncyCastle.Crypto.Digests;

namespace Noahtech.Controllers
{
    public class FaleConoscoController : Controller
    {
        public readonly Context _context;

        public FaleConoscoController(Context context)  
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Enviar()
        {
            return View();

        }


        public IActionResult FaleConosco()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Noa Tech", "contato.noatech@gmail.com"));
            message.To.Add(new MailboxAddress("Shirlei", "passdomingos@gmail.com"));
            message.Subject = "Mensagem Enviada"; 
            message.Body = new TextPart("plain")
            {
                Text = "Olá, tudo bem?" +
                " Seu recado foi enviado com sucesso!" +
                " Obrigada por entrar em contato"
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("contato.noatech@gmail.com", "noatechpi");
                client.Send(message);
                client.Disconnect(true);


                return View();
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Enviar([Bind("ContatoId,Nome,Email,Mensagem")] FaleConosco faleconosco)
        {

            if (ModelState.IsValid)
            {
                _context.Add(faleconosco);
                await _context.SaveChangesAsync();
                return View();

            }
            
            else
            {
                return View();
            }

        }
    

    }
    }
