using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelProfesores
{
    public class MedConcreteMediator : MedIMediator
    {
        List<MedIParticipant> participants = new List<MedIParticipant>();
        public void AddParticipant(MedIParticipant participant)
        {
            participants.Add(participant);
        }
        public string BroadcastMessage(string message, MedIParticipant sender)
        {
            string mes ="Alumno " + message + " ha terminado.";
            return mes;
        }
    }
}
