using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    public enum PublicationType
    {
        Misc,
        Book,
        Magazine,
        Article
    }

    public abstract class Publication
    {
        private bool published = false;
        private DateTime datePublished;
        private int totalPages;

        public string Publisher { get; }
        public string Title { get; }
        public PublicationType Type { get; }
        public string CopyRightName { get; private set; }
        public int CopyRightDate { get; set; }
        public int pages
        {
            get
            {
                return totalPages;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("El numero de paginas no puede ser cero o negativo");
                }
                totalPages = value;
            }
        }

        public Publication(string title, string publisher, PublicationType type)
        {
            if (string.IsNullOrEmpty(publisher))
            {
                throw new ArgumentException("El editor es requerido");
            }
            Publisher = publisher;

            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("El Titulo es requerido");
            }
            Title = title;

            Type = type;
        }

        public string GetPublicationDate()
        {
            if (!published)
            {
                return "NPA";
            }
            else
            {
                return datePublished.ToString("d");
            }
        }

        public void Publish(DateTime datePublished)
        {
            published = true;
            this.datePublished = datePublished;
        }

        public void CopyRight(string copyRightName, int copyRightDate)
        {
            if (string.IsNullOrEmpty(copyRightName))
            {
                throw new ArgumentException("El nombre del copyright es requerido");
            }
            CopyRightName = copyRightName;

            int currentYear = DateTime.Now.Year;
            if (copyRightDate < currentYear - 10 || copyRightDate > currentYear + 2)
            {
                throw new ArgumentOutOfRangeException($"El año de copyright debe estar entre {currentYear - 10} y {currentYear + 1}");
            }
            CopyRightDate = copyRightDate;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}