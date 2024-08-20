using Solid.SingleResponsiblity.Core.Entities;

namespace Solid.SingleResponsiblity.Core.Services
{
    internal class JobApplicationManager
    {
        public int AddApplicant(Applicant applicant, int vacancyId)
        {
            return 0;
        }
        public void SendApplicantConfirmationEmail(Applicant applicant, int vacandyId)
        {
            MailSender mailSender = new  MailSender();
            mailSender.SendApplicantConfirmationEmail(applicant, vacandyId);
        }
        public void RemoveApplication(Applicant applicant, int vacandyId)
        {
            //implemtation...
        }
        public void SendApplicantRemovalEmail(Applicant applicant, int vacandyId)
        {
            MailSender mailSender = new MailSender();
            mailSender.SendApplicantRemovalEmail(applicant, vacandyId);
        }        
    }
}
