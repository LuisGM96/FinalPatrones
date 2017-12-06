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
        public void BroadcastMessage(string message, MedIParticipant sender)
        {
            Console.WriteLine("Alumno " + message + " ha terminado.");
        }
    }
}
