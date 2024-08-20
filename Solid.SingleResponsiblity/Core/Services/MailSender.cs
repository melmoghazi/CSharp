using Solid.SingleResponsiblity.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsiblity.Core.Services
{
    internal class MailSender
    {
        public void SendApplicantConfirmationEmail(Applicant applicant, int vacandyId)
        {
            var smtp = new SmtpClient();
            Console.WriteLine($"Application confirmation mail sent to applicant `{applicant.FirstName} {applicant.LastName}`");
        }
        
        public void SendApplicantRemovalEmail(Applicant applicant, int vacandyId)
        {
            var smtp = new SmtpClient();
            Console.WriteLine($"Application removal mail sent to applicant `{applicant.FirstName} {applicant.LastName}`");
        }
    }
}
