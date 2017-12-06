using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelProfesores
{
    public class MedConcreteParticipant2 : MedIParticipant
    {
        protected MedIMediator mediator;
        public MedConcreteParticipant2(MedIMediator mediator)
        {
            this.mediator = mediator;
        }
        public void SendMessage(string message)
        {
            mediator.BroadcastMessage(message, this);
        }
    }
}
