using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelProfesores
{
    public interface MedIMediator
    {
        void AddParticipant(MedIParticipant participant);
        void BroadcastMessage(string message, MedIParticipant sender);
    }
}
