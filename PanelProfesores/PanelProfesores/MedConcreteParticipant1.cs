using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelProfesores
{
    public class MedConcreteParticipant1 : MedIParticipant
    {
        protected MedIMediator mediator;
        public MedConcreteParticipant1(MedIMediator mediator)
        {
            this.mediator = mediator;
        }
        public string SendMessage(string message)
        {
            return mediator.BroadcastMessage(message, this);
        }
    }
}
