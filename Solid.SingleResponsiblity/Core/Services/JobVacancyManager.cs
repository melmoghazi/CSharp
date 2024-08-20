using Solid.SingleResponsiblity.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsiblity.Core.Services
{
    internal class JobVacancyManager
    {
        public int CreateNewVacancy(string jobTitle, string jobDescription)
        {
            return 0;
        }
        public int UpdateVacancy(int vacancyId, string jobTitle, string jobDescription)
        {
            return 0;
        }

        /*
         * Single Responsibility Principal (SRP)
        The class is responsible of one thing so it has a lot of properties and methods but they all related to one thing.
        The class should be height cohesive. متماسكة اى تخدم غرض واحد فقط
        The class should have only one reason to change.
        Example: Job Vacancy Manager class. The class has CRUD operations of job vacancy but not has items related to applicant and not sending emails.
        => So remove these commented methods to a new class JobApplicationManager
         */

        //public int AddApplicant(Applicant applicant, int vacancyId)
        //{
        //    return 0;
        //}
        //public void SendApplicantConfirmationEmail(Applicant applicant, int vacandyId)
        //{
        //    //implemtation...
        //}
        //public void RemoveApplication(Applicant applicant, int vacandyId)
        //{
        //    //implemtation...
        //}
        //public void SendApplicantRemovalEmail(Applicant applicant, int vacandyId)
        //{
        //    //implemtation...
        //}

        /*
         *  => So remove this commented method to a new class Logger
         */

        //public void LogMessage(string message)
        //{
        //    //implemtation...
        //}
    }
}
