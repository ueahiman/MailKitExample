using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKitTest.MailLogic;
using MailKitTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MailKitTest.Controllers
{
    public class SendMailController : Controller
    {
        private readonly IMailSendLogic _mailSendLogic;

        public SendMailController(IMailSendLogic mailSendLogic)
        {
            _mailSendLogic = mailSendLogic;
        }

        // GET: SendMail
        public ActionResult Index()
        {
            return View(new SendMailViewModel());
        }
        [HttpPost]
        public ActionResult Index(SendMailViewModel mailViewModel)
        {
            _mailSendLogic.SendMailAsync(mailViewModel.SendTo, mailViewModel.SendFrom, mailViewModel.Subject, mailViewModel.Text);
            return View(mailViewModel);
        }

        // GET: SendMail/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SendMail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SendMail/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SendMail/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SendMail/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SendMail/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SendMail/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}