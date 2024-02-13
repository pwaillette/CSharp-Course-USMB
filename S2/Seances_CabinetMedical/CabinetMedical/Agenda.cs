using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical
{
    public class Agenda
    {
        private List<Consultation> lesConsultations;

        public Agenda(List<Consultation> lesConsultations)
        {
            LesConsultations = lesConsultations;
        }

        public Agenda() { }

        public List<Consultation> LesConsultations { get => lesConsultations; set => lesConsultations = value; }

        public override bool Equals(object? obj)
        {
            return obj is Agenda agenda &&
                   EqualityComparer<List<Consultation>>.Default.Equals(LesConsultations, agenda.LesConsultations);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(LesConsultations);
        }
    }
}
